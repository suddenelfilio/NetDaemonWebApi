using NetDaemon.Common;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Extensions
{
    public static partial class EntityExtension
    {
        public static SceneEntities SceneEntities(this NetDaemonApp app) => new(app);
        public static LightEntities LightEntities(this NetDaemonApp app) => new(app);
        public static SwitchEntities SwitchEntities(this NetDaemonApp app) => new(app);
        public static MediaPlayerEntities MediaPlayerEntities(this NetDaemonApp app) => new(app);
        public static ScriptEntities ScriptEntities(this NetDaemonApp app) => new(app);
        public static CameraEntities CameraEntities(this NetDaemonApp app) => new(app);
        public static AutomationEntities AutomationEntities(this NetDaemonApp app) => new(app);
    }

    public partial class SceneEntities
    {
        private readonly NetDaemonApp _app;
        public SceneEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity VoordeurHeRelax => _app.Entity("scene.voordeur_he_relax");
        public IEntity BureelHeEnergize => _app.Entity("scene.bureel_he_energize");
        public IEntity HalOnderPlafondHeConcentrate => _app.Entity("scene.hal_onder_plafond_he_concentrate");
        public IEntity HalBovenWandHeDimmed => _app.Entity("scene.hal_boven_wand_he_dimmed");
        public IEntity HalOnderWandHeDimmed => _app.Entity("scene.hal_onder_wand_he_dimmed");
        public IEntity HalOnderPlafondHeEnergize => _app.Entity("scene.hal_onder_plafond_he_energize");
        public IEntity HalOnderPlafondHeRead => _app.Entity("scene.hal_onder_plafond_he_read");
        public IEntity HalBovenWandHeEnergize => _app.Entity("scene.hal_boven_wand_he_energize");
        public IEntity HalBovenWandHeBright => _app.Entity("scene.hal_boven_wand_he_bright");
        public IEntity LamellendakQuickClose2 => _app.Entity("scene.lamellendak_quick_close_2");
        public IEntity BureelHeNightlight => _app.Entity("scene.bureel_he_nightlight");
        public IEntity HalBovenWandHeRelax => _app.Entity("scene.hal_boven_wand_he_relax");
        public IEntity OnderLichtenUit => _app.Entity("scene.onder_lichten_uit");
        public IEntity HalOnderWandHeBright => _app.Entity("scene.hal_onder_wand_he_bright");
        public IEntity VoordeurHeEnergize => _app.Entity("scene.voordeur_he_energize");
        public IEntity HalOnderPlafondHeNightlight => _app.Entity("scene.hal_onder_plafond_he_nightlight");
        public IEntity KantoorMotionOff2 => _app.Entity("scene.kantoor_motion_off_2");
        public IEntity LamellendakQuickOpen => _app.Entity("scene.lamellendak_quick_open");
        public IEntity BureelHeDimmed => _app.Entity("scene.bureel_he_dimmed");
        public IEntity OnderLichtenUit2 => _app.Entity("scene.onder_lichten_uit_2");
        public IEntity BureelHeBright => _app.Entity("scene.bureel_he_bright");
        public IEntity HalOnderPlafondHeBright => _app.Entity("scene.hal_onder_plafond_he_bright");
        public IEntity KantoorMotionOn => _app.Entity("scene.kantoor_motion_on");
        public IEntity LamellendakQuickOpen2 => _app.Entity("scene.lamellendak_quick_open_2");
        public IEntity AllOpenAndSunny => _app.Entity("scene.all_open_and_sunny");
        public IEntity VoordeurHeBright => _app.Entity("scene.voordeur_he_bright");
        public IEntity VoordeurHeRead => _app.Entity("scene.voordeur_he_read");
        public IEntity BureelHeRead => _app.Entity("scene.bureel_he_read");
        public IEntity Lockdown => _app.Entity("scene.lockdown");
        public IEntity HalOnderWandHeConcentrate => _app.Entity("scene.hal_onder_wand_he_concentrate");
        public IEntity KantoorRingDing => _app.Entity("scene.kantoor_ring_ding");
        public IEntity LamellendakQuickClose => _app.Entity("scene.lamellendak_quick_close");
        public IEntity HalOnderWandHeNightlight => _app.Entity("scene.hal_onder_wand_he_nightlight");
        public IEntity HalBovenWandHeNightlight => _app.Entity("scene.hal_boven_wand_he_nightlight");
        public IEntity VoordeurHeDimmed => _app.Entity("scene.voordeur_he_dimmed");
        public IEntity LammellendakClosedScreens => _app.Entity("scene.lammellendak_closed_screens");
        public IEntity VoordeurHeNightlight => _app.Entity("scene.voordeur_he_nightlight");
        public IEntity HalOnderWandHeRelax => _app.Entity("scene.hal_onder_wand_he_relax");
        public IEntity VoordeurHeConcentrate => _app.Entity("scene.voordeur_he_concentrate");
        public IEntity HalOnderWandHeEnergize => _app.Entity("scene.hal_onder_wand_he_energize");
        public IEntity LammellendakClosedScreens2 => _app.Entity("scene.lammellendak_closed_screens_2");
        public IEntity HalOnderWandHeRead => _app.Entity("scene.hal_onder_wand_he_read");
        public IEntity KantoorMotionOn2 => _app.Entity("scene.kantoor_motion_on_2");
        public IEntity HalBovenWandHeConcentrate => _app.Entity("scene.hal_boven_wand_he_concentrate");
        public IEntity HalOnderPlafondHeRelax => _app.Entity("scene.hal_onder_plafond_he_relax");
        public IEntity KantoorMotionOff => _app.Entity("scene.kantoor_motion_off");
        public IEntity BureelHeConcentrate => _app.Entity("scene.bureel_he_concentrate");
        public IEntity KantoorRingDing2 => _app.Entity("scene.kantoor_ring_ding_2");
        public IEntity BureelHeRelax => _app.Entity("scene.bureel_he_relax");
        public IEntity HalOnderPlafondHeDimmed => _app.Entity("scene.hal_onder_plafond_he_dimmed");
        public IEntity HalBovenWandHeRead => _app.Entity("scene.hal_boven_wand_he_read");
    }

    public partial class LightEntities
    {
        private readonly NetDaemonApp _app;
        public LightEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity LampThuis13 => _app.Entity("light.lamp_thuis_13");
        public IEntity HueColorSpot9 => _app.Entity("light.hue_color_spot_9");
        public IEntity ColorTemperatureLight21 => _app.Entity("light.color_temperature_light_21");
        public IEntity Berging => _app.Entity("light.berging");
        public IEntity HueCentrisSpotWoningBinnenkant => _app.Entity("light.hue_centris_spot_woning_binnenkant");
        public IEntity HueColorSpot4 => _app.Entity("light.hue_color_spot_4");
        public IEntity HueLedPanelSharedDesks => _app.Entity("light.hue_led_panel_shared_desks");
        public IEntity ToiletBeneden => _app.Entity("light.toilet_beneden");
        public IEntity BijbouwLiving => _app.Entity("light.bijbouw_living");
        public IEntity LampThuis3 => _app.Entity("light.lamp_thuis_3");
        public IEntity ExtendedColorLight16 => _app.Entity("light.extended_color_light_16");
        public IEntity LampThuis2 => _app.Entity("light.lamp_thuis_2");
        public IEntity HueCentrisLed => _app.Entity("light.hue_centris_led");
        public IEntity HueAmbianceLamp5 => _app.Entity("light.hue_ambiance_lamp_5");
        public IEntity VerlichtingKeuken => _app.Entity("light.verlichting_keuken");
        public IEntity HueColorSpot5 => _app.Entity("light.hue_color_spot_5");
        public IEntity LampThuis12 => _app.Entity("light.lamp_thuis_1_2");
        public IEntity HueColorSpot10 => _app.Entity("light.hue_color_spot_10");
        public IEntity All => _app.Entity("light.all");
        public IEntity BijbouwRaam => _app.Entity("light.bijbouw_raam");
        public IEntity Kerst => _app.Entity("light.kerst");
        public IEntity LivingEetkamer => _app.Entity("light.living_eetkamer");
        public IEntity HueComputerLed => _app.Entity("light.hue_computer_led");
        public IEntity HueAmbianceLamp4 => _app.Entity("light.hue_ambiance_lamp_4");
        public IEntity LampThuis6 => _app.Entity("light.lamp_thuis_6");
        public IEntity LampThuis101 => _app.Entity("light.lamp_thuis_10_1");
        public IEntity LampThuis10 => _app.Entity("light.lamp_thuis_10");
        public IEntity Slaapkamer => _app.Entity("light.slaapkamer");
        public IEntity CustomGroupForLights => _app.Entity("light.custom_group_for_lights");
        public IEntity Bijbouw2 => _app.Entity("light.bijbouw_2");
        public IEntity LivingMuur => _app.Entity("light.living_muur");
        public IEntity Berging2 => _app.Entity("light.berging_2");
        public IEntity CustomGroupForGroup => _app.Entity("light.custom_group_for_group");
        public IEntity Bedroom => _app.Entity("light.bedroom");
        public IEntity HueColorSpot8 => _app.Entity("light.hue_color_spot_8");
        public IEntity ExtendedColorLight17 => _app.Entity("light.extended_color_light_17");
        public IEntity HueAmbianceLamp3 => _app.Entity("light.hue_ambiance_lamp_3");
        public IEntity LampThuis32 => _app.Entity("light.lamp_thuis_3_2");
        public IEntity HueColorSpot3 => _app.Entity("light.hue_color_spot_3");
        public IEntity HueCentrisSpot1 => _app.Entity("light.hue_centris_spot_1");
        public IEntity Bijbouw => _app.Entity("light.bijbouw");
        public IEntity HueLedStripNis => _app.Entity("light.hue_led_strip_nis");
        public IEntity ExtendedColorLight13 => _app.Entity("light.extended_color_light_13");
        public IEntity LampThuis14 => _app.Entity("light.lamp_thuis_14");
        public IEntity HueCentrisSpot3 => _app.Entity("light.hue_centris_spot_3");
        public IEntity Living => _app.Entity("light.living");
        public IEntity LampThuis8 => _app.Entity("light.lamp_thuis_8");
        public IEntity HueVoordeurSpotBoven => _app.Entity("light.hue_voordeur_spot_boven");
        public IEntity Entrance => _app.Entity("light.entrance");
        public IEntity HueColorSpot6 => _app.Entity("light.hue_color_spot_6");
        public IEntity HueColorSpot7 => _app.Entity("light.hue_color_spot_7");
        public IEntity HueCentrisSpotWoningBuitenkant => _app.Entity("light.hue_centris_spot_woning_buitenkant");
        public IEntity HcVerlichtingKeuken => _app.Entity("light.hc_verlichting_keuken");
        public IEntity HueNachthalWand => _app.Entity("light.hue_nachthal_wand");
        public IEntity LampThuis7 => _app.Entity("light.lamp_thuis_7");
        public IEntity HueGroupHalOnderPlafond => _app.Entity("light.hue_group_hal_onder_plafond");
        public IEntity HalBovenWand => _app.Entity("light.hal_boven_wand");
        public IEntity HcKeuken => _app.Entity("light.hc_keuken");
        public IEntity SlaapkamerMuur => _app.Entity("light.slaapkamer_muur");
        public IEntity LampThuis9 => _app.Entity("light.lamp_thuis_9");
        public IEntity Dakverlichting => _app.Entity("light.dakverlichting");
        public IEntity Wc => _app.Entity("light.wc");
        public IEntity HueCentrisSpotInkomBinnenkant => _app.Entity("light.hue_centris_spot_inkom_binnenkant");
        public IEntity HueColorSpot2 => _app.Entity("light.hue_color_spot_2");
        public IEntity LampThuis4 => _app.Entity("light.lamp_thuis_4");
        public IEntity LampThuis5 => _app.Entity("light.lamp_thuis_5");
        public IEntity HueCentrisSpot2 => _app.Entity("light.hue_centris_spot_2");
        public IEntity ExtendedColorLight18 => _app.Entity("light.extended_color_light_18");
        public IEntity ExtendedColorLight19 => _app.Entity("light.extended_color_light_19");
        public IEntity HueGroupHalOnder => _app.Entity("light.hue_group_hal_onder");
        public IEntity LampThuis11 => _app.Entity("light.lamp_thuis_11");
        public IEntity HueVoordeurSpotOnder => _app.Entity("light.hue_voordeur_spot_onder");
        public IEntity EntertainmentArea1 => _app.Entity("light.entertainment_area_1");
        public IEntity BuitenVoordeur => _app.Entity("light.buiten_voordeur");
        public IEntity NikoKelderVerlichting => _app.Entity("light.niko_kelder_verlichting");
        public IEntity ColorTemperatureLight20 => _app.Entity("light.color_temperature_light_20");
        public IEntity LivingTv => _app.Entity("light.living_tv");
        public IEntity LampThuis1 => _app.Entity("light.lamp_thuis_1");
        public IEntity LampThuis22 => _app.Entity("light.lamp_thuis_2_2");
        public IEntity CustomGroupForGroup2 => _app.Entity("light.custom_group_for_group2");
        public IEntity LampThuis => _app.Entity("light.lamp_thuis");
        public IEntity LampThuis15 => _app.Entity("light.lamp_thuis_15");
        public IEntity LivingMuur2 => _app.Entity("light.living_muur_2");
        public IEntity HueLedPanelFilipDesk => _app.Entity("light.hue_led_panel_filip_desk");
        public IEntity HueCentrisCeiling1 => _app.Entity("light.hue_centris_ceiling_1");
        public IEntity HalBoven => _app.Entity("light.hal_boven");
        public IEntity HalBovebPlafond => _app.Entity("light.hal_boveb_plafond");
        public IEntity HueGroupBureel => _app.Entity("light.hue_group_bureel");
        public IEntity HueGroupHalOnderWand => _app.Entity("light.hue_group_hal_onder_wand");
        public IEntity HueColorSpot1 => _app.Entity("light.hue_color_spot_1");
        public IEntity HalOnder => _app.Entity("light.hal_onder");
        public IEntity RangeExtender14 => _app.Entity("light.range_extender_14");
        public IEntity Cuisine => _app.Entity("light.cuisine");
        public IEntity HueGroupVoordeur => _app.Entity("light.hue_group_voordeur");
        public IEntity HueCentrisSpotInkomBuitenkant => _app.Entity("light.hue_centris_spot_inkom_buitenkant");
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonApp _app;
        public SwitchEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity StatusLightOnHalBoven => _app.Entity("switch.status_light_on_hal_boven");
        public IEntity RecordSmartOprit4k => _app.Entity("switch.record_smart_oprit_4k");
        public IEntity HdrModeTuinTerras => _app.Entity("switch.hdr_mode_tuin_terras");
        public IEntity RecordMotionTuinKantoor => _app.Entity("switch.record_motion_tuin_kantoor");
        public IEntity RecordAlwaysTuinKippenhok => _app.Entity("switch.record_always_tuin_kippenhok");
        public IEntity IrActiveHalBoven => _app.Entity("switch.ir_active_hal_boven");
        public IEntity IrActiveTuinTerras => _app.Entity("switch.ir_active_tuin_terras");
        public IEntity StatusLightOnTuinKippenhok => _app.Entity("switch.status_light_on_tuin_kippenhok");
        public IEntity StatusLightOnTuinTerras => _app.Entity("switch.status_light_on_tuin_terras");
        public IEntity NetdaemonHelloWorldApp => _app.Entity("switch.netdaemon_hello_world_app");
        public IEntity IrActiveKelder => _app.Entity("switch.ir_active_kelder");
        public IEntity HdrModeTuinPoortje => _app.Entity("switch.hdr_mode_tuin_poortje");
        public IEntity HdrModeTuinKantoor => _app.Entity("switch.hdr_mode_tuin_kantoor");
        public IEntity RecordAlwaysTuinTerras => _app.Entity("switch.record_always_tuin_terras");
        public IEntity StatusLightOnTuinKantoor => _app.Entity("switch.status_light_on_tuin_kantoor");
        public IEntity RecordMotionKelder => _app.Entity("switch.record_motion_kelder");
        public IEntity IrActiveTuinPoortje => _app.Entity("switch.ir_active_tuin_poortje");
        public IEntity RecordAlwaysOprit4k => _app.Entity("switch.record_always_oprit_4k");
        public IEntity NetdaemonLamellenDakApp => _app.Entity("switch.netdaemon_lamellen_dak_app");
        public IEntity RecordAlwaysTuinTuinhuis => _app.Entity("switch.record_always_tuin_tuinhuis");
        public IEntity HdrModeTuinKippenhok => _app.Entity("switch.hdr_mode_tuin_kippenhok");
        public IEntity RecordMotionTuinKippenhok => _app.Entity("switch.record_motion_tuin_kippenhok");
        public IEntity IrActiveOprit4k => _app.Entity("switch.ir_active_oprit_4k");
        public IEntity HighFpsOprit4k => _app.Entity("switch.high_fps_oprit_4k");
        public IEntity IrActiveTuinKippenhok => _app.Entity("switch.ir_active_tuin_kippenhok");
        public IEntity RecordMotionTuinTerras => _app.Entity("switch.record_motion_tuin_terras");
        public IEntity RecordAlwaysTuinKantoor => _app.Entity("switch.record_always_tuin_kantoor");
        public IEntity RecordMotionHalBoven => _app.Entity("switch.record_motion_hal_boven");
        public IEntity RecordAlwaysTuinPoortje => _app.Entity("switch.record_always_tuin_poortje");
        public IEntity StatusLightOnOprit4k => _app.Entity("switch.status_light_on_oprit_4k");
        public IEntity RecordMotionOprit4k => _app.Entity("switch.record_motion_oprit_4k");
        public IEntity StatusLightOnTuinTuinhuis => _app.Entity("switch.status_light_on_tuin_tuinhuis");
        public IEntity RecordAlwaysKelder => _app.Entity("switch.record_always_kelder");
        public IEntity RecordAlwaysHalBoven => _app.Entity("switch.record_always_hal_boven");
        public IEntity RecordMotionTuinTuinhuis => _app.Entity("switch.record_motion_tuin_tuinhuis");
        public IEntity StatusLightOnKelder => _app.Entity("switch.status_light_on_kelder");
        public IEntity IrActiveTuinTuinhuis => _app.Entity("switch.ir_active_tuin_tuinhuis");
        public IEntity StatusLightOnTuinPoortje => _app.Entity("switch.status_light_on_tuin_poortje");
        public IEntity RecordMotionTuinPoortje => _app.Entity("switch.record_motion_tuin_poortje");
        public IEntity HdrModeKelder => _app.Entity("switch.hdr_mode_kelder");
        public IEntity IrActiveTuinKantoor => _app.Entity("switch.ir_active_tuin_kantoor");
        public IEntity HdrModeTuinTuinhuis => _app.Entity("switch.hdr_mode_tuin_tuinhuis");
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonApp _app;
        public MediaPlayerEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IMediaPlayer TvKamer => _app.MediaPlayer("media_player.tv_kamer");
        public IMediaPlayer Move => _app.MediaPlayer("media_player.move");
        public IMediaPlayer Office => _app.MediaPlayer("media_player.office");
        public IMediaPlayer Keuken => _app.MediaPlayer("media_player.keuken");
        public IMediaPlayer Badkamer => _app.MediaPlayer("media_player.badkamer");
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonApp _app;
        public ScriptEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity StopSonosSpeakerBoven => _app.Entity("script.stop_sonos_speaker_boven");
        public IEntity StopSonosSpeakerOnder => _app.Entity("script.stop_sonos_speaker_onder");
        public IEntity StopSonosSpeaker => _app.Entity("script.stop_sonos_speaker");
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonApp _app;
        public CameraEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public ICamera Oprit4k => _app.Camera("camera.oprit_4k");
        public ICamera TuinTerras => _app.Camera("camera.tuin_terras");
        public ICamera TuinKantoor => _app.Camera("camera.tuin_kantoor");
        public ICamera HalBoven => _app.Camera("camera.hal_boven");
        public ICamera Kelder => _app.Camera("camera.kelder");
        public ICamera XiaomiCloudMapExtractor => _app.Camera("camera.xiaomi_cloud_map_extractor");
        public ICamera FrontDoor => _app.Camera("camera.front_door");
        public ICamera TuinTuinhuis => _app.Camera("camera.tuin_tuinhuis");
        public ICamera TuinPoortje => _app.Camera("camera.tuin_poortje");
        public ICamera TuinKippenhok => _app.Camera("camera.tuin_kippenhok");
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonApp _app;
        public AutomationEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity LockCarAfter30MinutesHome => _app.Entity("automation.lock_car_after_30_minutes_home");
        public IEntity NachthalWandAanSunset => _app.Entity("automation.nachthal_wand_aan_sunset");
        public IEntity Lammellendak => _app.Entity("automation.lammellendak");
        public IEntity HalBovenDeepscan => _app.Entity("automation.hal_boven_deepscan");
        public IEntity Dakverlichting30Minuten => _app.Entity("automation.dakverlichting_30_minuten");
    }
}