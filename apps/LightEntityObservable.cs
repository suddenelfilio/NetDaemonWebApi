using System;
using NetDaemon.Common;
using Netdaemon.Generated.Reactive;

namespace daemonapp.apps
{
    public class LightEntityObservable:IObservable<(EntityState Old, EntityState New)>
    {
        public IObservable<(EntityState Old, EntityState New)> Source { get; set; }
        public LightEntity Entity { get; private set; }

        public LightEntityObservable(IObservable<(EntityState Old, EntityState New)> source, LightEntity entity)
        {
            Source = source;
            Entity = entity;
        }

        public IDisposable Subscribe(IObserver<(EntityState Old, EntityState New)> observer)
        {
            return Source.Subscribe(observer);
        }
    }
}