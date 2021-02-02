using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Reactive
{
    public class GeneratedAppBase : NetDaemonRxApp
    {
        public SensorEntities Sensor => new(this);
        public SceneEntities Scene => new(this);
        public LightEntities Light => new(this);
        public SwitchEntities Switch => new(this);
        public GroupEntities Group => new(this);
        public DeviceTrackerEntities DeviceTracker => new(this);
        public MediaPlayerEntities MediaPlayer => new(this);
        public BinarySensorEntities BinarySensor => new(this);
        public CoverEntities Cover => new(this);
        public InputBooleanEntities InputBoolean => new(this);
        public ScriptEntity Script => new(this, new string[]{""});
        public AlarmControlPanelEntities AlarmControlPanel => new(this);
        public CameraEntities Camera => new(this);
        public ImageProcessingEntities ImageProcessing => new(this);
        public WeatherEntities Weather => new(this);
        public AutomationEntities Automation => new(this);
        public ClimateEntities Climate => new(this);
        public PersonEntities Person => new(this);
        public VacuumEntities Vacuum => new(this);
        public ZoneEntities Zone => new(this);
        public SunEntities Sun => new(this);
        public LockEntities Lock => new(this);
    }

    public partial class SensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SensorEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class SceneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SceneEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "reload", serviceData);
        }

        public void Apply(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "apply", serviceData);
        }

        public void Create(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "create", serviceData);
        }
    }

    public partial class LightEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public LightEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class SwitchEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SwitchEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class GroupEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public GroupEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "reload", serviceData);
        }

        public void Set(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "set", serviceData);
        }

        public void Remove(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "remove", serviceData);
        }
    }

    public partial class DeviceTrackerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public DeviceTrackerEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void See(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("device_tracker", "see", serviceData);
        }
    }

    public partial class MediaPlayerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public MediaPlayerEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void VolumeUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_up", serviceData);
        }

        public void VolumeDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_down", serviceData);
        }

        public void MediaPlayPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play_pause", serviceData);
        }

        public void MediaPlay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play", serviceData);
        }

        public void MediaPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_pause", serviceData);
        }

        public void MediaStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_stop", serviceData);
        }

        public void MediaNextTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_next_track", serviceData);
        }

        public void MediaPreviousTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_previous_track", serviceData);
        }

        public void ClearPlaylist(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "clear_playlist", serviceData);
        }

        public void VolumeSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_set", serviceData);
        }

        public void VolumeMute(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_mute", serviceData);
        }

        public void MediaSeek(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_seek", serviceData);
        }

        public void SelectSource(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_source", serviceData);
        }

        public void SelectSoundMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_sound_mode", serviceData);
        }

        public void PlayMedia(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "play_media", serviceData);
        }

        public void ShuffleSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "shuffle_set", serviceData);
        }

        public void RepeatSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "repeat_set", serviceData);
        }
    }

    public partial class BinarySensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public BinarySensorEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class CoverEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public CoverEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void OpenCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "open_cover", serviceData);
        }

        public void CloseCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "close_cover", serviceData);
        }

        public void SetCoverPosition(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "set_cover_position", serviceData);
        }

        public void StopCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "stop_cover", serviceData);
        }

        public void OpenCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "open_cover_tilt", serviceData);
        }

        public void CloseCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "close_cover_tilt", serviceData);
        }

        public void StopCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "stop_cover_tilt", serviceData);
        }

        public void SetCoverTiltPosition(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "set_cover_tilt_position", serviceData);
        }

        public void ToggleCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "toggle_cover_tilt", serviceData);
        }
    }

    public partial class InputBooleanEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputBooleanEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_boolean", "reload", serviceData);
        }
    }

    public partial class ScriptEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ScriptEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void StopSonosSpeaker(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "stop_sonos_speaker", serviceData);
        }

        public void StopSonosSpeakerOnder(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "stop_sonos_speaker_onder", serviceData);
        }

        public void StopSonosSpeakerBoven(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "stop_sonos_speaker_boven", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "reload", serviceData);
        }
    }

    public partial class AlarmControlPanelEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public AlarmControlPanelEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void AlarmDisarm(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_disarm", serviceData);
        }

        public void AlarmArmHome(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_home", serviceData);
        }

        public void AlarmArmAway(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_away", serviceData);
        }

        public void AlarmArmNight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_night", serviceData);
        }

        public void AlarmArmCustomBypass(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_custom_bypass", serviceData);
        }

        public void AlarmTrigger(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_trigger", serviceData);
        }
    }

    public partial class CameraEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public CameraEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void EnableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "enable_motion_detection", serviceData);
        }

        public void DisableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "disable_motion_detection", serviceData);
        }

        public void Snapshot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "snapshot", serviceData);
        }

        public void PlayStream(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "play_stream", serviceData);
        }

        public void Record(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "record", serviceData);
        }
    }

    public partial class ImageProcessingEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ImageProcessingEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Scan(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("image_processing", "scan", serviceData);
        }
    }

    public partial class WeatherEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public WeatherEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class AutomationEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public AutomationEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Trigger(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("automation", "trigger", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("automation", "reload", serviceData);
        }
    }

    public partial class ClimateEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ClimateEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void SetHvacMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_hvac_mode", serviceData);
        }

        public void SetPresetMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_preset_mode", serviceData);
        }

        public void SetAuxHeat(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_aux_heat", serviceData);
        }

        public void SetTemperature(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_temperature", serviceData);
        }

        public void SetHumidity(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_humidity", serviceData);
        }

        public void SetFanMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_fan_mode", serviceData);
        }

        public void SetSwingMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_swing_mode", serviceData);
        }
    }

    public partial class PersonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public PersonEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("person", "reload", serviceData);
        }
    }

    public partial class VacuumEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public VacuumEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void StartPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "start_pause", serviceData);
        }

        public void Start(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "start", serviceData);
        }

        public void Pause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "pause", serviceData);
        }

        public void ReturnToBase(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "return_to_base", serviceData);
        }

        public void CleanSpot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "clean_spot", serviceData);
        }

        public void Locate(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "locate", serviceData);
        }

        public void Stop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "stop", serviceData);
        }

        public void SetFanSpeed(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "set_fan_speed", serviceData);
        }

        public void SendCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "send_command", serviceData);
        }
    }

    public partial class ZoneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ZoneEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zone", "reload", serviceData);
        }
    }

    public partial class SunEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SunEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class LockEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public LockEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Unlock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "unlock", serviceData);
        }

        public void Lock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "lock", serviceData);
        }

        public void Open(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "open", serviceData);
        }
    }

    public partial class SensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public SensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SensorEntity Room3Power => new(_app, new string[]{"sensor.room_3_power"});
        public SensorEntity UnifiDreamMachineKibSReceived => new(_app, new string[]{"sensor.unifi_dream_machine_kib_s_received"});
        public SensorEntity FebeSlaapkamerHeating => new(_app, new string[]{"sensor.febe_slaapkamer_heating"});
        public SensorEntity VisuasoftBvbaMaxChargeCurrent => new(_app, new string[]{"sensor.visuasoft_bvba_max_charge_current"});
        public SensorEntity VisuasoftBvbaRemainingChargeTime => new(_app, new string[]{"sensor.visuasoft_bvba_remaining_charge_time"});
        public SensorEntity MotionSensorHalBovenTemperature => new(_app, new string[]{"sensor.motion_sensor_hal_boven_temperature"});
        public SensorEntity VisuasoftBvbaRange => new(_app, new string[]{"sensor.visuasoft_bvba_range"});
        public SensorEntity FrontDoorBattery => new(_app, new string[]{"sensor.front_door_battery"});
        public SensorEntity Ipad2LastUpdateTrigger => new(_app, new string[]{"sensor.ipad_2_last_update_trigger"});
        public SensorEntity MotionSensorHalBovenLightLevel => new(_app, new string[]{"sensor.motion_sensor_hal_boven_light_level"});
        public SensorEntity VisuasoftBvbaClimatisationState => new(_app, new string[]{"sensor.visuasoft_bvba_climatisation_state"});
        public SensorEntity SolaredgeSolarPower => new(_app, new string[]{"sensor.solaredge_solar_power"});
        public SensorEntity FauneSlaapkamerLink => new(_app, new string[]{"sensor.faune_slaapkamer_link"});
        public SensorEntity UnifiDreamMachineBSent => new(_app, new string[]{"sensor.unifi_dream_machine_b_sent"});
        public SensorEntity RiscoThuisKantoorStatusEvents => new(_app, new string[]{"sensor.risco_thuis_kantoor_status_events"});
        public SensorEntity IpadBssid => new(_app, new string[]{"sensor.ipad_bssid"});
        public SensorEntity SolaredgePowerConsumption => new(_app, new string[]{"sensor.solaredge_power_consumption"});
        public SensorEntity LimburgNetPmd => new(_app, new string[]{"sensor.limburg_net_pmd"});
        public SensorEntity FauneSlaapkamerEarlyStart => new(_app, new string[]{"sensor.faune_slaapkamer_early_start"});
        public SensorEntity RiscoThuisKantoorAlarmEvents => new(_app, new string[]{"sensor.risco_thuis_kantoor_alarm_events"});
        public SensorEntity Ipad2ConnectionType => new(_app, new string[]{"sensor.ipad_2_connection_type"});
        public SensorEntity FrontDoorLastActivity => new(_app, new string[]{"sensor.front_door_last_activity"});
        public SensorEntity SolaredgeCurrentPower => new(_app, new string[]{"sensor.solaredge_current_power"});
        public SensorEntity SolaredgeInverters => new(_app, new string[]{"sensor.solaredge_inverters"});
        public SensorEntity Ipad2Activity => new(_app, new string[]{"sensor.ipad_2_activity"});
        public SensorEntity SolaredgeImportedPower => new(_app, new string[]{"sensor.solaredge_imported_power"});
        public SensorEntity Room3Temperature => new(_app, new string[]{"sensor.room_3_temperature"});
        public SensorEntity SolaredgeMeters => new(_app, new string[]{"sensor.solaredge_meters"});
        public SensorEntity VisuasoftBvbaSecondaryEngineType => new(_app, new string[]{"sensor.visuasoft_bvba_secondary_engine_type"});
        public SensorEntity Room3Link => new(_app, new string[]{"sensor.room_3_link"});
        public SensorEntity FauneSlaapkamerOpenWindow => new(_app, new string[]{"sensor.faune_slaapkamer_open_window"});
        public SensorEntity VisuasoftBvbaServiceInspectionTime => new(_app, new string[]{"sensor.visuasoft_bvba_service_inspection_time"});
        public SensorEntity FauneSlaapkamerHeating => new(_app, new string[]{"sensor.faune_slaapkamer_heating"});
        public SensorEntity VisuasoftBvbaSecondaryEngineRange => new(_app, new string[]{"sensor.visuasoft_bvba_secondary_engine_range"});
        public SensorEntity FilipNote20BatteryHealth => new(_app, new string[]{"sensor.filip_note_20_battery_health"});
        public SensorEntity SolaredgeEnergyThisYear => new(_app, new string[]{"sensor.solaredge_energy_this_year"});
        public SensorEntity Ipad2GeocodedLocation => new(_app, new string[]{"sensor.ipad_2_geocoded_location"});
        public SensorEntity MotionSensorBergingLightLevel => new(_app, new string[]{"sensor.motion_sensor_berging_light_level"});
        public SensorEntity SolaredgeSiteDetails => new(_app, new string[]{"sensor.solaredge_site_details"});
        public SensorEntity FrontDoorLastDing => new(_app, new string[]{"sensor.front_door_last_ding"});
        public SensorEntity MotionRecordingTuinTerras => new(_app, new string[]{"sensor.motion_recording_tuin_terras"});
        public SensorEntity Ipad2BatteryLevel => new(_app, new string[]{"sensor.ipad_2_battery_level"});
        public SensorEntity IpadGeocodedLocation => new(_app, new string[]{"sensor.ipad_geocoded_location"});
        public SensorEntity SolaredgeProductionPower => new(_app, new string[]{"sensor.solaredge_production_power"});
        public SensorEntity SolaredgeSensors => new(_app, new string[]{"sensor.solaredge_sensors"});
        public SensorEntity VisuasoftBvbaTankLevel => new(_app, new string[]{"sensor.visuasoft_bvba_tank_level"});
        public SensorEntity Lightlevel13BatteryLevel => new(_app, new string[]{"sensor.lightlevel_13_battery_level"});
        public SensorEntity MotionRecordingOprit4k => new(_app, new string[]{"sensor.motion_recording_oprit_4k"});
        public SensorEntity SolaredgeExportedPower => new(_app, new string[]{"sensor.solaredge_exported_power"});
        public SensorEntity SolaredgeGridPower => new(_app, new string[]{"sensor.solaredge_grid_power"});
        public SensorEntity UnifiDreamMachinePacketsSent => new(_app, new string[]{"sensor.unifi_dream_machine_packets_sent"});
        public SensorEntity UnifiDreamMachinePacketsSSent => new(_app, new string[]{"sensor.unifi_dream_machine_packets_s_sent"});
        public SensorEntity FebeSlaapkamerEarlyStart => new(_app, new string[]{"sensor.febe_slaapkamer_early_start"});
        public SensorEntity FrontDoorVolume => new(_app, new string[]{"sensor.front_door_volume"});
        public SensorEntity FauneSlaapkamerPower => new(_app, new string[]{"sensor.faune_slaapkamer_power"});
        public SensorEntity RiscoThuisKantoorTroubleEvents => new(_app, new string[]{"sensor.risco_thuis_kantoor_trouble_events"});
        public SensorEntity FebeSlaapkamerTemperature => new(_app, new string[]{"sensor.febe_slaapkamer_temperature"});
        public SensorEntity ThuisTadoBridgeStatus => new(_app, new string[]{"sensor.thuis_tado_bridge_status"});
        public SensorEntity SolaredgeStorageLevel => new(_app, new string[]{"sensor.solaredge_storage_level"});
        public SensorEntity Humidity3 => new(_app, new string[]{"sensor.humidity_3"});
        public SensorEntity Room3TadoMode => new(_app, new string[]{"sensor.room_3_tado_mode"});
        public SensorEntity HueMotionSensor1LightLevel => new(_app, new string[]{"sensor.hue_motion_sensor_1_light_level"});
        public SensorEntity FauneSlaapkamerTemperature => new(_app, new string[]{"sensor.faune_slaapkamer_temperature"});
        public SensorEntity Room3Heating => new(_app, new string[]{"sensor.room_3_heating"});
        public SensorEntity MotionRecordingTuinKantoor => new(_app, new string[]{"sensor.motion_recording_tuin_kantoor"});
        public SensorEntity Ipad2Ssid => new(_app, new string[]{"sensor.ipad_2_ssid"});
        public SensorEntity MotionRecordingTuinKippenhok => new(_app, new string[]{"sensor.motion_recording_tuin_kippenhok"});
        public SensorEntity FilipNote20BatteryState => new(_app, new string[]{"sensor.filip_note_20_battery_state"});
        public SensorEntity Temperature4 => new(_app, new string[]{"sensor.temperature_4"});
        public SensorEntity FebeSlaapkamerPower => new(_app, new string[]{"sensor.febe_slaapkamer_power"});
        public SensorEntity MotionRecordingHalBoven => new(_app, new string[]{"sensor.motion_recording_hal_boven"});
        public SensorEntity SolaredgeLifetimeEnergy => new(_app, new string[]{"sensor.solaredge_lifetime_energy"});
        public SensorEntity VisuasoftBvbaDoorsTrunkState => new(_app, new string[]{"sensor.visuasoft_bvba_doors_trunk_state"});
        public SensorEntity Room3Overlay => new(_app, new string[]{"sensor.room_3_overlay"});
        public SensorEntity LimburgNetPapier => new(_app, new string[]{"sensor.limburg_net_papier"});
        public SensorEntity IpadBatteryLevel => new(_app, new string[]{"sensor.ipad_battery_level"});
        public SensorEntity FilipNote20ChargerType => new(_app, new string[]{"sensor.filip_note_20_charger_type"});
        public SensorEntity IpadConnectionType => new(_app, new string[]{"sensor.ipad_connection_type"});
        public SensorEntity Room3Humidity => new(_app, new string[]{"sensor.room_3_humidity"});
        public SensorEntity VisuasoftBvbaOilChangeTime => new(_app, new string[]{"sensor.visuasoft_bvba_oil_change_time"});
        public SensorEntity SolaredgeEnergyThisMonth => new(_app, new string[]{"sensor.solaredge_energy_this_month"});
        public SensorEntity VisuasoftBvbaModel => new(_app, new string[]{"sensor.visuasoft_bvba_model"});
        public SensorEntity VisuasoftBvbaPlugState => new(_app, new string[]{"sensor.visuasoft_bvba_plug_state"});
        public SensorEntity SolaredgeConsumptionPower => new(_app, new string[]{"sensor.solaredge_consumption_power"});
        public SensorEntity MotionSensorBergingTemperature => new(_app, new string[]{"sensor.motion_sensor_berging_temperature"});
        public SensorEntity SolaredgeSelfconsumptionPower => new(_app, new string[]{"sensor.solaredge_selfconsumption_power"});
        public SensorEntity SnapshotBackup => new(_app, new string[]{"sensor.snapshot_backup"});
        public SensorEntity LimburgNetGft => new(_app, new string[]{"sensor.limburg_net_gft"});
        public SensorEntity HalBovenBatteryLevel => new(_app, new string[]{"sensor.hal_boven_battery_level"});
        public SensorEntity VisuasoftBvbaLastUpdate => new(_app, new string[]{"sensor.visuasoft_bvba_last_update"});
        public SensorEntity SolaredgeGateways => new(_app, new string[]{"sensor.solaredge_gateways"});
        public SensorEntity FauneSlaapkamerHumidity => new(_app, new string[]{"sensor.faune_slaapkamer_humidity"});
        public SensorEntity HueMotionSensor1Temperature => new(_app, new string[]{"sensor.hue_motion_sensor_1_temperature"});
        public SensorEntity IpadBatteryState => new(_app, new string[]{"sensor.ipad_battery_state"});
        public SensorEntity Ipad2Storage => new(_app, new string[]{"sensor.ipad_2_storage"});
        public SensorEntity LimburgNetRestafval => new(_app, new string[]{"sensor.limburg_net_restafval"});
        public SensorEntity Room3EarlyStart => new(_app, new string[]{"sensor.room_3_early_start"});
        public SensorEntity UnifiDreamMachineBReceived => new(_app, new string[]{"sensor.unifi_dream_machine_b_received"});
        public SensorEntity Lightlevel13 => new(_app, new string[]{"sensor.lightlevel_13"});
        public SensorEntity MotionRecordingTuinPoortje => new(_app, new string[]{"sensor.motion_recording_tuin_poortje"});
        public SensorEntity Hacs => new(_app, new string[]{"sensor.hacs"});
        public SensorEntity FrontDoorLastMotion => new(_app, new string[]{"sensor.front_door_last_motion"});
        public SensorEntity FilipNote20BatteryLevel => new(_app, new string[]{"sensor.filip_note_20_battery_level"});
        public SensorEntity SolaredgeEnergyToday => new(_app, new string[]{"sensor.solaredge_energy_today"});
        public SensorEntity VisuasoftBvbaPrimaryEngineRange => new(_app, new string[]{"sensor.visuasoft_bvba_primary_engine_range"});
        public SensorEntity HueDimmerSwitch1BatteryLevel => new(_app, new string[]{"sensor.hue_dimmer_switch_1_battery_level"});
        public SensorEntity IpadSsid => new(_app, new string[]{"sensor.ipad_ssid"});
        public SensorEntity UnifiDreamMachineKibSSent => new(_app, new string[]{"sensor.unifi_dream_machine_kib_s_sent"});
        public SensorEntity VisuasoftBvbaMileage => new(_app, new string[]{"sensor.visuasoft_bvba_mileage"});
        public SensorEntity RiscoThuisKantoorOtherEvents => new(_app, new string[]{"sensor.risco_thuis_kantoor_other_events"});
        public SensorEntity FebeSlaapkamerTadoMode => new(_app, new string[]{"sensor.febe_slaapkamer_tado_mode"});
        public SensorEntity KeukenVolume => new(_app, new string[]{"sensor.keuken_volume"});
        public SensorEntity Room3OpenWindow => new(_app, new string[]{"sensor.room_3_open_window"});
        public SensorEntity DimmerSwitchBatteryLevel => new(_app, new string[]{"sensor.dimmer_switch_battery_level"});
        public SensorEntity VisuasoftBvbaServiceInspectionDistance => new(_app, new string[]{"sensor.visuasoft_bvba_service_inspection_distance"});
        public SensorEntity FauneSlaapkamerOverlay => new(_app, new string[]{"sensor.faune_slaapkamer_overlay"});
        public SensorEntity VisuasoftBvbaStateOfCharge => new(_app, new string[]{"sensor.visuasoft_bvba_state_of_charge"});
        public SensorEntity SolaredgeBatteries => new(_app, new string[]{"sensor.solaredge_batteries"});
        public SensorEntity MotionRecordingTuinTuinhuis => new(_app, new string[]{"sensor.motion_recording_tuin_tuinhuis"});
        public SensorEntity Humidity5 => new(_app, new string[]{"sensor.humidity_5"});
        public SensorEntity FauneSlaapkamerTadoMode => new(_app, new string[]{"sensor.faune_slaapkamer_tado_mode"});
        public SensorEntity FebeSlaapkamerLink => new(_app, new string[]{"sensor.febe_slaapkamer_link"});
        public SensorEntity VisuasoftBvbaPrimaryEngineType => new(_app, new string[]{"sensor.visuasoft_bvba_primary_engine_type"});
        public SensorEntity Ipad2Bssid => new(_app, new string[]{"sensor.ipad_2_bssid"});
        public SensorEntity IpadStorage => new(_app, new string[]{"sensor.ipad_storage"});
        public SensorEntity Temperature2 => new(_app, new string[]{"sensor.temperature_2"});
        public SensorEntity UnifiDreamMachinePacketsSReceived => new(_app, new string[]{"sensor.unifi_dream_machine_packets_s_received"});
        public SensorEntity KantoorThermometerBatteryLevel => new(_app, new string[]{"sensor.kantoor_thermometer_battery_level"});
        public SensorEntity LimburgNetMorgen => new(_app, new string[]{"sensor.limburg_net_morgen"});
        public SensorEntity UnifiDreamMachinePacketsReceived => new(_app, new string[]{"sensor.unifi_dream_machine_packets_received"});
        public SensorEntity SolaredgeStoragePower => new(_app, new string[]{"sensor.solaredge_storage_power"});
        public SensorEntity VisuasoftBvbaChargingState => new(_app, new string[]{"sensor.visuasoft_bvba_charging_state"});
        public SensorEntity FebeSlaapkamerHumidity => new(_app, new string[]{"sensor.febe_slaapkamer_humidity"});
        public SensorEntity IpadLastUpdateTrigger => new(_app, new string[]{"sensor.ipad_last_update_trigger"});
        public SensorEntity MultiSensorBatteryLevel => new(_app, new string[]{"sensor.multi_sensor_battery_level"});
        public SensorEntity FebeSlaapkamerOpenWindow => new(_app, new string[]{"sensor.febe_slaapkamer_open_window"});
        public SensorEntity MotionRecordingKelder => new(_app, new string[]{"sensor.motion_recording_kelder"});
        public SensorEntity FebeSlaapkamerOverlay => new(_app, new string[]{"sensor.febe_slaapkamer_overlay"});
        public SensorEntity Openclose6BatteryLevel => new(_app, new string[]{"sensor.openclose_6_battery_level"});
        public SensorEntity VisuasoftBvbaOilChangeDistance => new(_app, new string[]{"sensor.visuasoft_bvba_oil_change_distance"});
        public SensorEntity VisuasoftBvbaOilLevel => new(_app, new string[]{"sensor.visuasoft_bvba_oil_level"});
        public SensorEntity Ipad2BatteryState => new(_app, new string[]{"sensor.ipad_2_battery_state"});
        public SensorEntity LimburgNetVandaag => new(_app, new string[]{"sensor.limburg_net_vandaag"});
    }

    public partial class SceneEntities
    {
        private readonly NetDaemonRxApp _app;
        public SceneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SceneEntity VoordeurHeRelax => new(_app, new string[]{"scene.voordeur_he_relax"});
        public SceneEntity BureelHeEnergize => new(_app, new string[]{"scene.bureel_he_energize"});
        public SceneEntity HalOnderPlafondHeConcentrate => new(_app, new string[]{"scene.hal_onder_plafond_he_concentrate"});
        public SceneEntity HalBovenWandHeDimmed => new(_app, new string[]{"scene.hal_boven_wand_he_dimmed"});
        public SceneEntity HalOnderWandHeDimmed => new(_app, new string[]{"scene.hal_onder_wand_he_dimmed"});
        public SceneEntity HalOnderPlafondHeEnergize => new(_app, new string[]{"scene.hal_onder_plafond_he_energize"});
        public SceneEntity HalOnderPlafondHeRead => new(_app, new string[]{"scene.hal_onder_plafond_he_read"});
        public SceneEntity HalBovenWandHeEnergize => new(_app, new string[]{"scene.hal_boven_wand_he_energize"});
        public SceneEntity HalBovenWandHeBright => new(_app, new string[]{"scene.hal_boven_wand_he_bright"});
        public SceneEntity LamellendakQuickClose2 => new(_app, new string[]{"scene.lamellendak_quick_close_2"});
        public SceneEntity BureelHeNightlight => new(_app, new string[]{"scene.bureel_he_nightlight"});
        public SceneEntity HalBovenWandHeRelax => new(_app, new string[]{"scene.hal_boven_wand_he_relax"});
        public SceneEntity OnderLichtenUit => new(_app, new string[]{"scene.onder_lichten_uit"});
        public SceneEntity HalOnderWandHeBright => new(_app, new string[]{"scene.hal_onder_wand_he_bright"});
        public SceneEntity VoordeurHeEnergize => new(_app, new string[]{"scene.voordeur_he_energize"});
        public SceneEntity HalOnderPlafondHeNightlight => new(_app, new string[]{"scene.hal_onder_plafond_he_nightlight"});
        public SceneEntity KantoorMotionOff2 => new(_app, new string[]{"scene.kantoor_motion_off_2"});
        public SceneEntity LamellendakQuickOpen => new(_app, new string[]{"scene.lamellendak_quick_open"});
        public SceneEntity BureelHeDimmed => new(_app, new string[]{"scene.bureel_he_dimmed"});
        public SceneEntity OnderLichtenUit2 => new(_app, new string[]{"scene.onder_lichten_uit_2"});
        public SceneEntity BureelHeBright => new(_app, new string[]{"scene.bureel_he_bright"});
        public SceneEntity HalOnderPlafondHeBright => new(_app, new string[]{"scene.hal_onder_plafond_he_bright"});
        public SceneEntity KantoorMotionOn => new(_app, new string[]{"scene.kantoor_motion_on"});
        public SceneEntity LamellendakQuickOpen2 => new(_app, new string[]{"scene.lamellendak_quick_open_2"});
        public SceneEntity AllOpenAndSunny => new(_app, new string[]{"scene.all_open_and_sunny"});
        public SceneEntity VoordeurHeBright => new(_app, new string[]{"scene.voordeur_he_bright"});
        public SceneEntity VoordeurHeRead => new(_app, new string[]{"scene.voordeur_he_read"});
        public SceneEntity BureelHeRead => new(_app, new string[]{"scene.bureel_he_read"});
        public SceneEntity Lockdown => new(_app, new string[]{"scene.lockdown"});
        public SceneEntity HalOnderWandHeConcentrate => new(_app, new string[]{"scene.hal_onder_wand_he_concentrate"});
        public SceneEntity KantoorRingDing => new(_app, new string[]{"scene.kantoor_ring_ding"});
        public SceneEntity LamellendakQuickClose => new(_app, new string[]{"scene.lamellendak_quick_close"});
        public SceneEntity HalOnderWandHeNightlight => new(_app, new string[]{"scene.hal_onder_wand_he_nightlight"});
        public SceneEntity HalBovenWandHeNightlight => new(_app, new string[]{"scene.hal_boven_wand_he_nightlight"});
        public SceneEntity VoordeurHeDimmed => new(_app, new string[]{"scene.voordeur_he_dimmed"});
        public SceneEntity LammellendakClosedScreens => new(_app, new string[]{"scene.lammellendak_closed_screens"});
        public SceneEntity VoordeurHeNightlight => new(_app, new string[]{"scene.voordeur_he_nightlight"});
        public SceneEntity HalOnderWandHeRelax => new(_app, new string[]{"scene.hal_onder_wand_he_relax"});
        public SceneEntity VoordeurHeConcentrate => new(_app, new string[]{"scene.voordeur_he_concentrate"});
        public SceneEntity HalOnderWandHeEnergize => new(_app, new string[]{"scene.hal_onder_wand_he_energize"});
        public SceneEntity LammellendakClosedScreens2 => new(_app, new string[]{"scene.lammellendak_closed_screens_2"});
        public SceneEntity HalOnderWandHeRead => new(_app, new string[]{"scene.hal_onder_wand_he_read"});
        public SceneEntity KantoorMotionOn2 => new(_app, new string[]{"scene.kantoor_motion_on_2"});
        public SceneEntity HalBovenWandHeConcentrate => new(_app, new string[]{"scene.hal_boven_wand_he_concentrate"});
        public SceneEntity HalOnderPlafondHeRelax => new(_app, new string[]{"scene.hal_onder_plafond_he_relax"});
        public SceneEntity KantoorMotionOff => new(_app, new string[]{"scene.kantoor_motion_off"});
        public SceneEntity BureelHeConcentrate => new(_app, new string[]{"scene.bureel_he_concentrate"});
        public SceneEntity KantoorRingDing2 => new(_app, new string[]{"scene.kantoor_ring_ding_2"});
        public SceneEntity BureelHeRelax => new(_app, new string[]{"scene.bureel_he_relax"});
        public SceneEntity HalOnderPlafondHeDimmed => new(_app, new string[]{"scene.hal_onder_plafond_he_dimmed"});
        public SceneEntity HalBovenWandHeRead => new(_app, new string[]{"scene.hal_boven_wand_he_read"});
    }

    public partial class LightEntities
    {
        private readonly NetDaemonRxApp _app;
        public LightEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LightEntity LampThuis13 => new(_app, new string[]{"light.lamp_thuis_13"});
        public LightEntity HueColorSpot9 => new(_app, new string[]{"light.hue_color_spot_9"});
        public LightEntity ColorTemperatureLight21 => new(_app, new string[]{"light.color_temperature_light_21"});
        public LightEntity Berging => new(_app, new string[]{"light.berging"});
        public LightEntity HueCentrisSpotWoningBinnenkant => new(_app, new string[]{"light.hue_centris_spot_woning_binnenkant"});
        public LightEntity HueColorSpot4 => new(_app, new string[]{"light.hue_color_spot_4"});
        public LightEntity HueLedPanelSharedDesks => new(_app, new string[]{"light.hue_led_panel_shared_desks"});
        public LightEntity ToiletBeneden => new(_app, new string[]{"light.toilet_beneden"});
        public LightEntity BijbouwLiving => new(_app, new string[]{"light.bijbouw_living"});
        public LightEntity LampThuis3 => new(_app, new string[]{"light.lamp_thuis_3"});
        public LightEntity ExtendedColorLight16 => new(_app, new string[]{"light.extended_color_light_16"});
        public LightEntity LampThuis2 => new(_app, new string[]{"light.lamp_thuis_2"});
        public LightEntity HueCentrisLed => new(_app, new string[]{"light.hue_centris_led"});
        public LightEntity HueAmbianceLamp5 => new(_app, new string[]{"light.hue_ambiance_lamp_5"});
        public LightEntity VerlichtingKeuken => new(_app, new string[]{"light.verlichting_keuken"});
        public LightEntity HueColorSpot5 => new(_app, new string[]{"light.hue_color_spot_5"});
        public LightEntity LampThuis12 => new(_app, new string[]{"light.lamp_thuis_1_2"});
        public LightEntity HueColorSpot10 => new(_app, new string[]{"light.hue_color_spot_10"});
        public LightEntity All => new(_app, new string[]{"light.all"});
        public LightEntity BijbouwRaam => new(_app, new string[]{"light.bijbouw_raam"});
        public LightEntity Kerst => new(_app, new string[]{"light.kerst"});
        public LightEntity LivingEetkamer => new(_app, new string[]{"light.living_eetkamer"});
        public LightEntity HueComputerLed => new(_app, new string[]{"light.hue_computer_led"});
        public LightEntity HueAmbianceLamp4 => new(_app, new string[]{"light.hue_ambiance_lamp_4"});
        public LightEntity LampThuis6 => new(_app, new string[]{"light.lamp_thuis_6"});
        public LightEntity LampThuis101 => new(_app, new string[]{"light.lamp_thuis_10_1"});
        public LightEntity LampThuis10 => new(_app, new string[]{"light.lamp_thuis_10"});
        public LightEntity Slaapkamer => new(_app, new string[]{"light.slaapkamer"});
        public LightEntity CustomGroupForLights => new(_app, new string[]{"light.custom_group_for_lights"});
        public LightEntity Bijbouw2 => new(_app, new string[]{"light.bijbouw_2"});
        public LightEntity LivingMuur => new(_app, new string[]{"light.living_muur"});
        public LightEntity Berging2 => new(_app, new string[]{"light.berging_2"});
        public LightEntity CustomGroupForGroup => new(_app, new string[]{"light.custom_group_for_group"});
        public LightEntity Bedroom => new(_app, new string[]{"light.bedroom"});
        public LightEntity HueColorSpot8 => new(_app, new string[]{"light.hue_color_spot_8"});
        public LightEntity ExtendedColorLight17 => new(_app, new string[]{"light.extended_color_light_17"});
        public LightEntity HueAmbianceLamp3 => new(_app, new string[]{"light.hue_ambiance_lamp_3"});
        public LightEntity LampThuis32 => new(_app, new string[]{"light.lamp_thuis_3_2"});
        public LightEntity HueColorSpot3 => new(_app, new string[]{"light.hue_color_spot_3"});
        public LightEntity HueCentrisSpot1 => new(_app, new string[]{"light.hue_centris_spot_1"});
        public LightEntity Bijbouw => new(_app, new string[]{"light.bijbouw"});
        public LightEntity HueLedStripNis => new(_app, new string[]{"light.hue_led_strip_nis"});
        public LightEntity ExtendedColorLight13 => new(_app, new string[]{"light.extended_color_light_13"});
        public LightEntity LampThuis14 => new(_app, new string[]{"light.lamp_thuis_14"});
        public LightEntity HueCentrisSpot3 => new(_app, new string[]{"light.hue_centris_spot_3"});
        public LightEntity Living => new(_app, new string[]{"light.living"});
        public LightEntity LampThuis8 => new(_app, new string[]{"light.lamp_thuis_8"});
        public LightEntity HueVoordeurSpotBoven => new(_app, new string[]{"light.hue_voordeur_spot_boven"});
        public LightEntity Entrance => new(_app, new string[]{"light.entrance"});
        public LightEntity HueColorSpot6 => new(_app, new string[]{"light.hue_color_spot_6"});
        public LightEntity HueColorSpot7 => new(_app, new string[]{"light.hue_color_spot_7"});
        public LightEntity HueCentrisSpotWoningBuitenkant => new(_app, new string[]{"light.hue_centris_spot_woning_buitenkant"});
        public LightEntity HcVerlichtingKeuken => new(_app, new string[]{"light.hc_verlichting_keuken"});
        public LightEntity HueNachthalWand => new(_app, new string[]{"light.hue_nachthal_wand"});
        public LightEntity LampThuis7 => new(_app, new string[]{"light.lamp_thuis_7"});
        public LightEntity HueGroupHalOnderPlafond => new(_app, new string[]{"light.hue_group_hal_onder_plafond"});
        public LightEntity HalBovenWand => new(_app, new string[]{"light.hal_boven_wand"});
        public LightEntity HcKeuken => new(_app, new string[]{"light.hc_keuken"});
        public LightEntity SlaapkamerMuur => new(_app, new string[]{"light.slaapkamer_muur"});
        public LightEntity LampThuis9 => new(_app, new string[]{"light.lamp_thuis_9"});
        public LightEntity Dakverlichting => new(_app, new string[]{"light.dakverlichting"});
        public LightEntity Wc => new(_app, new string[]{"light.wc"});
        public LightEntity HueCentrisSpotInkomBinnenkant => new(_app, new string[]{"light.hue_centris_spot_inkom_binnenkant"});
        public LightEntity HueColorSpot2 => new(_app, new string[]{"light.hue_color_spot_2"});
        public LightEntity LampThuis4 => new(_app, new string[]{"light.lamp_thuis_4"});
        public LightEntity LampThuis5 => new(_app, new string[]{"light.lamp_thuis_5"});
        public LightEntity HueCentrisSpot2 => new(_app, new string[]{"light.hue_centris_spot_2"});
        public LightEntity ExtendedColorLight18 => new(_app, new string[]{"light.extended_color_light_18"});
        public LightEntity ExtendedColorLight19 => new(_app, new string[]{"light.extended_color_light_19"});
        public LightEntity HueGroupHalOnder => new(_app, new string[]{"light.hue_group_hal_onder"});
        public LightEntity LampThuis11 => new(_app, new string[]{"light.lamp_thuis_11"});
        public LightEntity HueVoordeurSpotOnder => new(_app, new string[]{"light.hue_voordeur_spot_onder"});
        public LightEntity EntertainmentArea1 => new(_app, new string[]{"light.entertainment_area_1"});
        public LightEntity BuitenVoordeur => new(_app, new string[]{"light.buiten_voordeur"});
        public LightEntity NikoKelderVerlichting => new(_app, new string[]{"light.niko_kelder_verlichting"});
        public LightEntity ColorTemperatureLight20 => new(_app, new string[]{"light.color_temperature_light_20"});
        public LightEntity LivingTv => new(_app, new string[]{"light.living_tv"});
        public LightEntity LampThuis1 => new(_app, new string[]{"light.lamp_thuis_1"});
        public LightEntity LampThuis22 => new(_app, new string[]{"light.lamp_thuis_2_2"});
        public LightEntity CustomGroupForGroup2 => new(_app, new string[]{"light.custom_group_for_group2"});
        public LightEntity LampThuis => new(_app, new string[]{"light.lamp_thuis"});
        public LightEntity LampThuis15 => new(_app, new string[]{"light.lamp_thuis_15"});
        public LightEntity LivingMuur2 => new(_app, new string[]{"light.living_muur_2"});
        public LightEntity HueLedPanelFilipDesk => new(_app, new string[]{"light.hue_led_panel_filip_desk"});
        public LightEntity HueCentrisCeiling1 => new(_app, new string[]{"light.hue_centris_ceiling_1"});
        public LightEntity HalBoven => new(_app, new string[]{"light.hal_boven"});
        public LightEntity HalBovebPlafond => new(_app, new string[]{"light.hal_boveb_plafond"});
        public LightEntity HueGroupBureel => new(_app, new string[]{"light.hue_group_bureel"});
        public LightEntity HueGroupHalOnderWand => new(_app, new string[]{"light.hue_group_hal_onder_wand"});
        public LightEntity HueColorSpot1 => new(_app, new string[]{"light.hue_color_spot_1"});
        public LightEntity HalOnder => new(_app, new string[]{"light.hal_onder"});
        public LightEntity RangeExtender14 => new(_app, new string[]{"light.range_extender_14"});
        public LightEntity Cuisine => new(_app, new string[]{"light.cuisine"});
        public LightEntity HueGroupVoordeur => new(_app, new string[]{"light.hue_group_voordeur"});
        public LightEntity HueCentrisSpotInkomBuitenkant => new(_app, new string[]{"light.hue_centris_spot_inkom_buitenkant"});
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonRxApp _app;
        public SwitchEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SwitchEntity StatusLightOnHalBoven => new(_app, new string[]{"switch.status_light_on_hal_boven"});
        public SwitchEntity RecordSmartOprit4k => new(_app, new string[]{"switch.record_smart_oprit_4k"});
        public SwitchEntity HdrModeTuinTerras => new(_app, new string[]{"switch.hdr_mode_tuin_terras"});
        public SwitchEntity RecordMotionTuinKantoor => new(_app, new string[]{"switch.record_motion_tuin_kantoor"});
        public SwitchEntity RecordAlwaysTuinKippenhok => new(_app, new string[]{"switch.record_always_tuin_kippenhok"});
        public SwitchEntity IrActiveHalBoven => new(_app, new string[]{"switch.ir_active_hal_boven"});
        public SwitchEntity IrActiveTuinTerras => new(_app, new string[]{"switch.ir_active_tuin_terras"});
        public SwitchEntity StatusLightOnTuinKippenhok => new(_app, new string[]{"switch.status_light_on_tuin_kippenhok"});
        public SwitchEntity StatusLightOnTuinTerras => new(_app, new string[]{"switch.status_light_on_tuin_terras"});
        public SwitchEntity NetdaemonHelloWorldApp => new(_app, new string[]{"switch.netdaemon_hello_world_app"});
        public SwitchEntity IrActiveKelder => new(_app, new string[]{"switch.ir_active_kelder"});
        public SwitchEntity HdrModeTuinPoortje => new(_app, new string[]{"switch.hdr_mode_tuin_poortje"});
        public SwitchEntity HdrModeTuinKantoor => new(_app, new string[]{"switch.hdr_mode_tuin_kantoor"});
        public SwitchEntity RecordAlwaysTuinTerras => new(_app, new string[]{"switch.record_always_tuin_terras"});
        public SwitchEntity StatusLightOnTuinKantoor => new(_app, new string[]{"switch.status_light_on_tuin_kantoor"});
        public SwitchEntity RecordMotionKelder => new(_app, new string[]{"switch.record_motion_kelder"});
        public SwitchEntity IrActiveTuinPoortje => new(_app, new string[]{"switch.ir_active_tuin_poortje"});
        public SwitchEntity RecordAlwaysOprit4k => new(_app, new string[]{"switch.record_always_oprit_4k"});
        public SwitchEntity NetdaemonLamellenDakApp => new(_app, new string[]{"switch.netdaemon_lamellen_dak_app"});
        public SwitchEntity RecordAlwaysTuinTuinhuis => new(_app, new string[]{"switch.record_always_tuin_tuinhuis"});
        public SwitchEntity HdrModeTuinKippenhok => new(_app, new string[]{"switch.hdr_mode_tuin_kippenhok"});
        public SwitchEntity RecordMotionTuinKippenhok => new(_app, new string[]{"switch.record_motion_tuin_kippenhok"});
        public SwitchEntity IrActiveOprit4k => new(_app, new string[]{"switch.ir_active_oprit_4k"});
        public SwitchEntity HighFpsOprit4k => new(_app, new string[]{"switch.high_fps_oprit_4k"});
        public SwitchEntity IrActiveTuinKippenhok => new(_app, new string[]{"switch.ir_active_tuin_kippenhok"});
        public SwitchEntity RecordMotionTuinTerras => new(_app, new string[]{"switch.record_motion_tuin_terras"});
        public SwitchEntity RecordAlwaysTuinKantoor => new(_app, new string[]{"switch.record_always_tuin_kantoor"});
        public SwitchEntity RecordMotionHalBoven => new(_app, new string[]{"switch.record_motion_hal_boven"});
        public SwitchEntity RecordAlwaysTuinPoortje => new(_app, new string[]{"switch.record_always_tuin_poortje"});
        public SwitchEntity StatusLightOnOprit4k => new(_app, new string[]{"switch.status_light_on_oprit_4k"});
        public SwitchEntity RecordMotionOprit4k => new(_app, new string[]{"switch.record_motion_oprit_4k"});
        public SwitchEntity StatusLightOnTuinTuinhuis => new(_app, new string[]{"switch.status_light_on_tuin_tuinhuis"});
        public SwitchEntity RecordAlwaysKelder => new(_app, new string[]{"switch.record_always_kelder"});
        public SwitchEntity RecordAlwaysHalBoven => new(_app, new string[]{"switch.record_always_hal_boven"});
        public SwitchEntity RecordMotionTuinTuinhuis => new(_app, new string[]{"switch.record_motion_tuin_tuinhuis"});
        public SwitchEntity StatusLightOnKelder => new(_app, new string[]{"switch.status_light_on_kelder"});
        public SwitchEntity IrActiveTuinTuinhuis => new(_app, new string[]{"switch.ir_active_tuin_tuinhuis"});
        public SwitchEntity StatusLightOnTuinPoortje => new(_app, new string[]{"switch.status_light_on_tuin_poortje"});
        public SwitchEntity RecordMotionTuinPoortje => new(_app, new string[]{"switch.record_motion_tuin_poortje"});
        public SwitchEntity HdrModeKelder => new(_app, new string[]{"switch.hdr_mode_kelder"});
        public SwitchEntity IrActiveTuinKantoor => new(_app, new string[]{"switch.ir_active_tuin_kantoor"});
        public SwitchEntity HdrModeTuinTuinhuis => new(_app, new string[]{"switch.hdr_mode_tuin_tuinhuis"});
    }

    public partial class GroupEntities
    {
        private readonly NetDaemonRxApp _app;
        public GroupEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public GroupEntity SonosSpeakers => new(_app, new string[]{"group.sonos_speakers"});
        public GroupEntity SonosSpeakersBoven => new(_app, new string[]{"group.sonos_speakers_boven"});
        public GroupEntity SonosSpeakersOnder => new(_app, new string[]{"group.sonos_speakers_onder"});
        public GroupEntity LightsLiving => new(_app, new string[]{"group.lights_living"});
    }

    public partial class DeviceTrackerEntities
    {
        private readonly NetDaemonRxApp _app;
        public DeviceTrackerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public DeviceTrackerEntity Ipad => new(_app, new string[]{"device_tracker.ipad"});
        public DeviceTrackerEntity VisuasoftBvbaPosition => new(_app, new string[]{"device_tracker.visuasoft_bvba_position"});
        public DeviceTrackerEntity FilipNote20 => new(_app, new string[]{"device_tracker.filip_note_20"});
        public DeviceTrackerEntity Ipad2 => new(_app, new string[]{"device_tracker.ipad_2"});
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonRxApp _app;
        public MediaPlayerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public MediaPlayerEntity TvKamer => new(_app, new string[]{"media_player.tv_kamer"});
        public MediaPlayerEntity Move => new(_app, new string[]{"media_player.move"});
        public MediaPlayerEntity Office => new(_app, new string[]{"media_player.office"});
        public MediaPlayerEntity Keuken => new(_app, new string[]{"media_player.keuken"});
        public MediaPlayerEntity Badkamer => new(_app, new string[]{"media_player.badkamer"});
    }

    public partial class BinarySensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public BinarySensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public BinarySensorEntity Living => new(_app, new string[]{"binary_sensor.living"});
        public BinarySensorEntity MotionKelder => new(_app, new string[]{"binary_sensor.motion_kelder"});
        public BinarySensorEntity Su0695673088BatteryState => new(_app, new string[]{"binary_sensor.su0695673088_battery_state"});
        public BinarySensorEntity VisuasoftBvbaHood => new(_app, new string[]{"binary_sensor.visuasoft_bvba_hood"});
        public BinarySensorEntity VisuasoftBvbaSunRoof => new(_app, new string[]{"binary_sensor.visuasoft_bvba_sun_roof"});
        public BinarySensorEntity AquaraMotionSensor1 => new(_app, new string[]{"binary_sensor.aquara_motion_sensor_1"});
        public BinarySensorEntity Va3423011840BatteryState => new(_app, new string[]{"binary_sensor.va3423011840_battery_state"});
        public BinarySensorEntity Br1351622912ConnectionState => new(_app, new string[]{"binary_sensor.br1351622912_connection_state"});
        public BinarySensorEntity MotionSensorHalBovenMotion => new(_app, new string[]{"binary_sensor.motion_sensor_hal_boven_motion"});
        public BinarySensorEntity Voordeur => new(_app, new string[]{"binary_sensor.voordeur"});
        public BinarySensorEntity VisuasoftBvbaWindows => new(_app, new string[]{"binary_sensor.visuasoft_bvba_windows"});
        public BinarySensorEntity MotionHalBoven => new(_app, new string[]{"binary_sensor.motion_hal_boven"});
        public BinarySensorEntity VisuasoftBvbaTrunk => new(_app, new string[]{"binary_sensor.visuasoft_bvba_trunk"});
        public BinarySensorEntity MotionSensorBergingMotion => new(_app, new string[]{"binary_sensor.motion_sensor_berging_motion"});
        public BinarySensorEntity Achterdeur => new(_app, new string[]{"binary_sensor.achterdeur"});
        public BinarySensorEntity MotionTuinTuinhuis => new(_app, new string[]{"binary_sensor.motion_tuin_tuinhuis"});
        public BinarySensorEntity Inkom => new(_app, new string[]{"binary_sensor.inkom"});
        public BinarySensorEntity Va0436732928BatteryState => new(_app, new string[]{"binary_sensor.va0436732928_battery_state"});
        public BinarySensorEntity Va3423011840ConnectionState => new(_app, new string[]{"binary_sensor.va3423011840_connection_state"});
        public BinarySensorEntity VisuasoftBvbaDoors => new(_app, new string[]{"binary_sensor.visuasoft_bvba_doors"});
        public BinarySensorEntity VisuasoftBvbaParkingLight => new(_app, new string[]{"binary_sensor.visuasoft_bvba_parking_light"});
        public BinarySensorEntity KelderDeurOc => new(_app, new string[]{"binary_sensor.kelder_deur_oc"});
        public BinarySensorEntity Schuifraam1 => new(_app, new string[]{"binary_sensor.schuifraam_1"});
        public BinarySensorEntity MotionTuinPoortje => new(_app, new string[]{"binary_sensor.motion_tuin_poortje"});
        public BinarySensorEntity FrontDoorDing => new(_app, new string[]{"binary_sensor.front_door_ding"});
        public BinarySensorEntity MotionOprit4k => new(_app, new string[]{"binary_sensor.motion_oprit_4k"});
        public BinarySensorEntity Updater => new(_app, new string[]{"binary_sensor.updater"});
        public BinarySensorEntity SnapshotsStale => new(_app, new string[]{"binary_sensor.snapshots_stale"});
        public BinarySensorEntity Su0695673088ConnectionState => new(_app, new string[]{"binary_sensor.su0695673088_connection_state"});
        public BinarySensorEntity MotionTuinKippenhok => new(_app, new string[]{"binary_sensor.motion_tuin_kippenhok"});
        public BinarySensorEntity FrontDoorMotion => new(_app, new string[]{"binary_sensor.front_door_motion"});
        public BinarySensorEntity VisuasoftBvbaDoorsLock => new(_app, new string[]{"binary_sensor.visuasoft_bvba_doors_lock"});
        public BinarySensorEntity VisuasoftBvbaTrunkLock => new(_app, new string[]{"binary_sensor.visuasoft_bvba_trunk_lock"});
        public BinarySensorEntity MotionTuinTerras => new(_app, new string[]{"binary_sensor.motion_tuin_terras"});
        public BinarySensorEntity Schuifraam2 => new(_app, new string[]{"binary_sensor.schuifraam_2"});
        public BinarySensorEntity Ib2858223104ConnectionState => new(_app, new string[]{"binary_sensor.ib2858223104_connection_state"});
        public BinarySensorEntity FilipNote20IsCharging => new(_app, new string[]{"binary_sensor.filip_note_20_is_charging"});
        public BinarySensorEntity Va0436732928ConnectionState => new(_app, new string[]{"binary_sensor.va0436732928_connection_state"});
        public BinarySensorEntity Bureau => new(_app, new string[]{"binary_sensor.bureau"});
        public BinarySensorEntity MotionTuinKantoor => new(_app, new string[]{"binary_sensor.motion_tuin_kantoor"});
        public BinarySensorEntity HueMotionSensor1Motion => new(_app, new string[]{"binary_sensor.hue_motion_sensor_1_motion"});
    }

    public partial class CoverEntities
    {
        private readonly NetDaemonRxApp _app;
        public CoverEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CoverEntity ScreenRechts => new(_app, new string[]{"cover.screen_rechts"});
        public CoverEntity ScreenLinks => new(_app, new string[]{"cover.screen_links"});
        public CoverEntity ScreenVoor => new(_app, new string[]{"cover.screen_voor"});
        public CoverEntity Lamellen => new(_app, new string[]{"cover.lamellen"});
    }

    public partial class InputBooleanEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputBooleanEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputBooleanEntity LammellenDakAutomatisaties => new(_app, new string[]{"input_boolean.lammellen_dak_automatisaties"});
        public InputBooleanEntity DakverlichtingAutoOff => new(_app, new string[]{"input_boolean.dakverlichting_auto_off"});
        public InputBooleanEntity HalVerlichtingAutomatisaties => new(_app, new string[]{"input_boolean.hal_verlichting_automatisaties"});
        public InputBooleanEntity SendScreensNotificatuin => new(_app, new string[]{"input_boolean.send_screens_notificatuin"});
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonRxApp _app;
        public ScriptEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ScriptEntity StopSonosSpeakerBoven => new(_app, new string[]{"script.stop_sonos_speaker_boven"});
        public ScriptEntity StopSonosSpeakerOnder => new(_app, new string[]{"script.stop_sonos_speaker_onder"});
        public ScriptEntity StopSonosSpeaker => new(_app, new string[]{"script.stop_sonos_speaker"});
    }

    public partial class AlarmControlPanelEntities
    {
        private readonly NetDaemonRxApp _app;
        public AlarmControlPanelEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public AlarmControlPanelEntity RiscoAlarm => new(_app, new string[]{"alarm_control_panel.risco_alarm"});
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonRxApp _app;
        public CameraEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CameraEntity Oprit4k => new(_app, new string[]{"camera.oprit_4k"});
        public CameraEntity TuinTerras => new(_app, new string[]{"camera.tuin_terras"});
        public CameraEntity TuinKantoor => new(_app, new string[]{"camera.tuin_kantoor"});
        public CameraEntity HalBoven => new(_app, new string[]{"camera.hal_boven"});
        public CameraEntity Kelder => new(_app, new string[]{"camera.kelder"});
        public CameraEntity XiaomiCloudMapExtractor => new(_app, new string[]{"camera.xiaomi_cloud_map_extractor"});
        public CameraEntity FrontDoor => new(_app, new string[]{"camera.front_door"});
        public CameraEntity TuinTuinhuis => new(_app, new string[]{"camera.tuin_tuinhuis"});
        public CameraEntity TuinPoortje => new(_app, new string[]{"camera.tuin_poortje"});
        public CameraEntity TuinKippenhok => new(_app, new string[]{"camera.tuin_kippenhok"});
    }

    public partial class ImageProcessingEntities
    {
        private readonly NetDaemonRxApp _app;
        public ImageProcessingEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ImageProcessingEntity DeepstackObjectHalBoven => new(_app, new string[]{"image_processing.deepstack_object_hal_boven"});
    }

    public partial class WeatherEntities
    {
        private readonly NetDaemonRxApp _app;
        public WeatherEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public WeatherEntity Home => new(_app, new string[]{"weather.home"});
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonRxApp _app;
        public AutomationEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public AutomationEntity LockCarAfter30MinutesHome => new(_app, new string[]{"automation.lock_car_after_30_minutes_home"});
        public AutomationEntity NachthalWandAanSunset => new(_app, new string[]{"automation.nachthal_wand_aan_sunset"});
        public AutomationEntity Lammellendak => new(_app, new string[]{"automation.lammellendak"});
        public AutomationEntity HalBovenDeepscan => new(_app, new string[]{"automation.hal_boven_deepscan"});
        public AutomationEntity Dakverlichting30Minuten => new(_app, new string[]{"automation.dakverlichting_30_minuten"});
    }

    public partial class ClimateEntities
    {
        private readonly NetDaemonRxApp _app;
        public ClimateEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ClimateEntity FauneSlaapkamer => new(_app, new string[]{"climate.faune_slaapkamer"});
        public ClimateEntity FebeSlaapkamer => new(_app, new string[]{"climate.febe_slaapkamer"});
        public ClimateEntity Room3 => new(_app, new string[]{"climate.room_3"});
    }

    public partial class PersonEntities
    {
        private readonly NetDaemonRxApp _app;
        public PersonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public PersonEntity FilipStas => new(_app, new string[]{"person.filip_stas"});
    }

    public partial class VacuumEntities
    {
        private readonly NetDaemonRxApp _app;
        public VacuumEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public VacuumEntity RoborockS6 => new(_app, new string[]{"vacuum.roborock_s6"});
    }

    public partial class ZoneEntities
    {
        private readonly NetDaemonRxApp _app;
        public ZoneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ZoneEntity Home => new(_app, new string[]{"zone.home"});
    }

    public partial class SunEntities
    {
        private readonly NetDaemonRxApp _app;
        public SunEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SunEntity Sun => new(_app, new string[]{"sun.sun"});
    }

    public partial class LockEntities
    {
        private readonly NetDaemonRxApp _app;
        public LockEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LockEntity VisuasoftBvbaDoorLock => new(_app, new string[]{"lock.visuasoft_bvba_door_lock"});
    }
}