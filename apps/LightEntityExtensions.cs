using Netdaemon.Generated.Reactive;

namespace daemonapp.apps
{
    public static class LightEntityExtensions
    {
        public static void DimTo(this LightEntity entity, int value)
        {
            entity.TurnOn(new {brightness = value});
        }
    }
}