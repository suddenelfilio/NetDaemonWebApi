using Microsoft.AspNetCore.Mvc;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using System.Threading.Tasks;

namespace daemonapp.apps.HelloWorld
{
    [ApiController]
    [Route("helloworld")]
    public class Controller
    {
        public Controller(INetDaemonRxApp app) => App = app;

        public INetDaemonRxApp App { get; }

        [HttpGet("off")]
        public Task<IActionResult> Get()
        {
            App.Entity("light.hue_computer_led").TurnOff();
            return Task.FromResult((IActionResult)new OkResult());
        }
    }
}
