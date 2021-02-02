using System;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;

namespace daemonapp.apps
{
    public class RxEntityObservable:IObservable<(EntityState Old, EntityState New)>
    {
        public IObservable<(EntityState Old, EntityState New)> Source { get; set; }
        public IRxEntityBase Entity { get; private set; }

        public RxEntityObservable(IObservable<(EntityState Old, EntityState New)> source, IRxEntityBase entity)
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