using System;
using System.Threading.Tasks;
using daemonapp.apps;
using Netdaemon.Generated.Reactive;


namespace daemonapp.apps
{
    public class AutoOffApp : GeneratedAppBase
    {
        public override Task InitializeAsync()
        {
           // To follow the incoming events
           // StateChanges.Subscribe(e => Console.WriteLine(e.New));

            Light
                .HueComputerLed
                .TurnedOnBy(InputBoolean.LammellenDakAutomatisaties)
                .After(TimeSpan.FromSeconds(10))
                .DimTo(100)
                .After(TimeSpan.FromSeconds(10))
                .TurnOff()
                .Subscribe();
            
            // //Or shorter
            // Light
            //     .HueComputerLed
            //     .TurnedOnBy(InputBoolean.LammellenDakAutomatisaties)
            //     .DimToAfter(100,TimeSpan.FromSeconds(10))
            //     .TurnOffAfter(TimeSpan.FromSeconds(10))
            //     .Subscribe();

            return Task.CompletedTask;
        }
    }
}