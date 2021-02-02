using NetDaemon.Common.Reactive;

namespace daemonapp.apps
{
    public static class IRxEntityExtensions
    {
        public static void DimTo(this IRxEntityBase entity, int value)
        {
            entity.TurnOn(new {brightness = value});
        }
    }
}