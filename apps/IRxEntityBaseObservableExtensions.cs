using System;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

namespace daemonapp.apps
{
    public static class IRxEntityBaseObservableExtensions
    {
        public static RxEntityObservable TurnedOn(this IRxEntityBase entity)
        {
            var source = entity.StateChanges.Where(e => e.New?.State == "on");
            return new(source, entity);
        }

        public static RxEntityObservable TurnedOnBy(this IRxEntityBase entity, IRxEntityBase trigger)
        {
            var source = trigger.StateChanges.Where(e => e.New?.State == "on");
            source = source.Do(_ => entity.DimTo(255));
            return new(source, entity);
        }

        public static RxEntityObservable After(this RxEntityObservable source, TimeSpan delay)
        {
            source.Source = source.Source.Throttle(delay);
            return source;
        }

        public static RxEntityObservable DimTo(this RxEntityObservable source, int dimValue)
        {
            source.Source = source.Source
                .Do(_ => source.Entity.DimTo(dimValue));

            return source;
        }

        public static RxEntityObservable DimToAfter(this RxEntityObservable source, int dimValue,
            TimeSpan delay)
        {
            source.Source = source.Source
                .Throttle(delay)
                .Do(_ => source.Entity.DimTo(dimValue));

            return source;
        }

        public static RxEntityObservable TurnOffAfter(this RxEntityObservable source, TimeSpan delay)
        {
            source.Source = source.Source
                .Throttle(delay)
                .Do(_ => source.Entity.TurnOff());

            return source;
        }

        public static RxEntityObservable TurnOff(this RxEntityObservable source)
        {
            source.Source = source.Source
                .Do(_ => source.Entity.TurnOff());

            return source;
        }
    }
}