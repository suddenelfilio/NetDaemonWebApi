using System;
using System.Reactive;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using Netdaemon.Generated.Reactive;
using daemonapp.apps;

namespace daemonapp.apps
{
    public static class LightObservableExtensions
    {
        public static LightEntityObservable TurnedOn(this LightEntity entity)
        {
            var source = entity.StateChanges.Where(e => e.New?.State == "on");
            return new(source, entity);
        }

        public static LightEntityObservable TurnedOnBy(this LightEntity entity, RxEntity trigger)
        {
            var source = trigger.StateChanges.Where(e => e.New?.State == "on");
            source = source.Do(_ => entity.DimTo(255));
            return new(source, entity);
        }

        public static LightEntityObservable After(this LightEntityObservable source, TimeSpan delay)
        {
            source.Source = source.Source.Throttle(delay);
            return source;
        }

        public static LightEntityObservable DimTo(this LightEntityObservable source, int dimValue)
        {
            source.Source = source.Source
                .Do(_ => source.Entity.DimTo(dimValue));

            return source;
        }

        public static LightEntityObservable DimToAfter(this LightEntityObservable source, int dimValue,
            TimeSpan delay)
        {
            source.Source = source.Source
                .Throttle(delay)
                .Do(_ => source.Entity.DimTo(dimValue));

            return source;
        }

        public static LightEntityObservable TurnOffAfter(this LightEntityObservable source, TimeSpan delay)
        {
            source.Source = source.Source
                .Throttle(delay)
                .Do(_ => source.Entity.TurnOff());

            return source;
        }

        public static LightEntityObservable TurnOff(this LightEntityObservable source)
        {
            source.Source = source.Source
                .Do(_ => source.Entity.TurnOff());

            return source;
        }
    }
}