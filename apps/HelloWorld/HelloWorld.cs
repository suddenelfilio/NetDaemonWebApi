using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Common.Reactive;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace HelloWorld
{
    /// <summary>
    ///     Hello world showcase
    /// </summary>


    public class HelloWorldApp : NetDaemonRxApp
    {
    

        IWebHost api;

        public override Task InitializeAsync()
        {
            api = WebHost.CreateDefaultBuilder()
                .ConfigureServices(svc =>
                {
                    svc.AddSingleton<INetDaemonRxApp>(this);
                })
                .UseStartup<daemonapp.apps.HelloWorld.StartUp>()
                .Build();
            api.RunAsync();

            Entity("binary_sensor.mypir").StateChanges
                .Where(e => e.New?.State == "on")
                .Subscribe(
                    e =>
                    {
                        Log("My Pir is doing something");
                        Entity("light.mylight").TurnOn();
                    }
                );
            Log("Hello World");

            StateChanges.Subscribe(e =>
            {
                Console.WriteLine(e);
            });

            return Task.CompletedTask;
        }

        public override ValueTask DisposeAsync()
        {

            api.Dispose();
            return base.DisposeAsync();
        }
       

    }
}
