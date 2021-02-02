using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NetDaemon.Common.Reactive;

namespace daemonapp.apps
{
    public class AutoOffApp : NetDaemonRxApp
    {
        public string? EntityToControl { get; set; }
        public string? TriggerEntity { get; set; }
        public bool? AlsoDim { get; set; }
        public int? DimDelay { get; set; }
        public int? DimValue { get; set; }
        public double TurnOffAfter { get; set; }

        public override Task InitializeAsync()
        {
            if (EntityToControl == null) return Task.CompletedTask;

            Logger.LogInformation("========== AUTO OFF APP ===============");
            Logger.LogInformation($"Entity {EntityToControl} will ");

            var entity = Entity(EntityToControl);
            RxEntityObservable observable;
            if (string.IsNullOrEmpty(TriggerEntity))
            {
                Logger.LogInformation("  run this app when turned on");
                observable = entity.TurnedOn();
            }
            else
            {
                Logger.LogInformation($"  run this app when turned on by {TriggerEntity}");
                observable = entity.TurnedOnBy(Entity(TriggerEntity));
            }

            if (AlsoDim.HasValue
                && AlsoDim.Value
                && DimDelay.HasValue
                && DimValue.HasValue)
            {
                Logger.LogInformation($"  it will dim to {DimValue} after {DimDelay} seconds");
                observable = observable.DimToAfter(DimValue.Value, TimeSpan.FromSeconds(DimDelay.Value));
            }

            Logger.LogInformation($"  it will turn off after {TurnOffAfter} seconds");
            observable
                .TurnOffAfter(TimeSpan.FromSeconds(TurnOffAfter))
                .Subscribe();

            return Task.CompletedTask;
        }
    }
}