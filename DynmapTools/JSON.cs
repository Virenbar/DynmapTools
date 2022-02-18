using Newtonsoft.Json;
using System.Collections.Generic;

namespace DynmapTools.JSON
{
    internal class URLs
    {
        [JsonProperty("configuration")]
        public string Configuration { get; set; }

        [JsonProperty("update")]
        public string Update { get; set; }

        [JsonProperty("sendmessage")]
        public string SendMessage { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("register")]
        public string Register { get; set; }

        [JsonProperty("tiles")]
        public string Tiles { get; set; }

        [JsonProperty("markers")]
        public string Markers { get; set; }
    }

    internal class Component
    {
        [JsonProperty("spawnlabel")]
        public string SpawnLabel { get; set; }

        [JsonProperty("spawnbedhidebydefault")]
        public bool SpawnBedHideByDefault { get; set; }

        [JsonProperty("spawnbedformat")]
        public string SpawnBedFormat { get; set; }

        [JsonProperty("showworldborder")]
        public bool ShowWorldBorder { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showlabel")]
        public bool ShowLabel { get; set; }

        [JsonProperty("offlineicon")]
        public string OfflineIcon { get; set; }

        [JsonProperty("showspawnbeds")]
        public bool ShowSpawnBeds { get; set; }

        [JsonProperty("showofflineplayers")]
        public bool ShowOfflinePlayers { get; set; }

        [JsonProperty("spawnbedicon")]
        public string SpawnBedIcon { get; set; }

        [JsonProperty("offlinehidebydefault")]
        public bool OfflineHideByDefault { get; set; }

        [JsonProperty("offlinelabel")]
        public string OfflineLabel { get; set; }

        [JsonProperty("enablesigns")]
        public bool EnableSigns { get; set; }

        [JsonProperty("default-sign-set")]
        public string DefaultSignSet { get; set; }

        [JsonProperty("spawnicon")]
        public string SpawnIcon { get; set; }

        [JsonProperty("offlineminzoom")]
        public int OfflineMinZoom { get; set; }

        [JsonProperty("spawnbedminzoom")]
        public int SpawnBedMinZoom { get; set; }

        [JsonProperty("showspawn")]
        public bool ShowSpawn { get; set; }

        [JsonProperty("spawnbedlabel")]
        public string SpawnBedLabel { get; set; }

        [JsonProperty("maxofflinetime")]
        public int MaxOfflineTime { get; set; }

        [JsonProperty("allowurlname")]
        public bool? AllowURLName { get; set; }

        [JsonProperty("focuschatballoons")]
        public bool? FocusChatBalloons { get; set; }

        [JsonProperty("showplayerfaces")]
        public bool? ShowPlayerFaces { get; set; }

        [JsonProperty("sendbutton")]
        public bool? SendButton { get; set; }

        [JsonProperty("messagettl")]
        public int? MessageTTL { get; set; }

        [JsonProperty("hidebydefault")]
        public bool? HideByDefault { get; set; }

        [JsonProperty("showplayerhealth")]
        public bool? ShowPlayerHealth { get; set; }

        [JsonProperty("showplayerbody")]
        public bool? ShowPlayerBody { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("smallplayerfaces")]
        public bool? SmallPlayerFaces { get; set; }

        [JsonProperty("layerprio")]
        public int? Layerprio { get; set; }

        [JsonProperty("showdigitalclock")]
        public bool? ShowDigitalClock { get; set; }

        [JsonProperty("showweather")]
        public bool? ShowWeather { get; set; }

        [JsonProperty("show-mcr")]
        public bool? ShowMCR { get; set; }

        [JsonProperty("hidey")]
        public bool? HideY { get; set; }
    }

    internal class Map
    {
        [JsonProperty("inclination")]
        public double Inclination { get; set; }

        [JsonProperty("nightandday")]
        public bool NightAndDay { get; set; }

        [JsonProperty("image-format")]
        public string ImageFormat { get; set; }

        [JsonProperty("shader")]
        public string Shader { get; set; }

        [JsonProperty("compassview")]
        public string CompassView { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("icon")]
        public object Icon { get; set; }

        [JsonProperty("scale")]
        public int Scale { get; set; }

        [JsonProperty("azimuth")]
        public double Azimuth { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lighting")]
        public string Lighting { get; set; }

        [JsonProperty("backgroundday")]
        public object BackgroundDay { get; set; }

        [JsonProperty("bigmap")]
        public bool BigMap { get; set; }

        [JsonProperty("maptoworld")]
        public List<double> Maptoworld { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("background")]
        public object Background { get; set; }

        [JsonProperty("mapzoomout")]
        public int MapZoomOut { get; set; }

        [JsonProperty("boostzoom")]
        public int BoostZoom { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("backgroundnight")]
        public object BackgroundNight { get; set; }

        [JsonProperty("perspective")]
        public string Perspective { get; set; }

        [JsonProperty("mapzoomin")]
        public int MapZooIn { get; set; }

        [JsonProperty("worldtomap")]
        public List<double> WorldToMap { get; set; }
    }

    internal class Center
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }
    }

    internal class World
    {
        [JsonProperty("sealevel")]
        public int Sealevel { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("maps")]
        public List<Map> Maps { get; set; }

        [JsonProperty("extrazoomout")]
        public int ExtraZoomOut { get; set; }

        [JsonProperty("center")]
        public Center Center { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("worldheight")]
        public int WorldHeight { get; set; }
    }

    internal class Config
    {
        [JsonProperty("updaterate")]
        public double UpdateRate { get; set; }

        [JsonProperty("chatlengthlimit")]
        public int ChatLengthLimit { get; set; }

        [JsonProperty("components")]
        public List<Component> Components { get; set; }

        [JsonProperty("worlds")]
        public List<World> Worlds { get; set; }

        [JsonProperty("confighash")]
        public int ConfigHash { get; set; }

        [JsonProperty("spammessage")]
        public string SpamMessage { get; set; }

        [JsonProperty("defaultmap")]
        public string DefaultMap { get; set; }

        [JsonProperty("msg-chatrequireslogin")]
        public string MsgChatRequiresLogin { get; set; }

        [JsonProperty("msg-hiddennameoin")]
        public string MsgHiddenNameJoin { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("grayplayerswhenhidden")]
        public bool GrayPlayersWhenHidden { get; set; }

        [JsonProperty("quitmessage")]
        public string QuitMessage { get; set; }

        [JsonProperty("defaultzoom")]
        public int DefaultZoom { get; set; }

        [JsonProperty("allowwebchat")]
        public bool AllowWebChat { get; set; }

        [JsonProperty("allowchat")]
        public bool AllowChat { get; set; }

        [JsonProperty("sidebaropened")]
        public string SideBarOpened { get; set; }

        [JsonProperty("webchat-interval")]
        public double WebChatInterval { get; set; }

        [JsonProperty("msg-chatnotallowed")]
        public string MsgChatNotAllowed { get; set; }

        [JsonProperty("loggedin")]
        public bool LoggedIn { get; set; }

        [JsonProperty("coreversion")]
        public string CoreVersion { get; set; }

        [JsonProperty("joinmessage")]
        public string JoinMessage { get; set; }

        [JsonProperty("webchat-requires-login")]
        public bool WebchatRequiresLogin { get; set; }

        [JsonProperty("showlayercontrol")]
        public string ShowLayerControl { get; set; }

        [JsonProperty("login-enabled")]
        public bool LoginEnabled { get; set; }

        [JsonProperty("maxcount")]
        public int MaxCount { get; set; }

        [JsonProperty("dynmapversion")]
        public string DynmapVersion { get; set; }

        [JsonProperty("msg-maptypes")]
        public string MsgMapTypes { get; set; }

        [JsonProperty("cyrillic")]
        public bool Cyrillic { get; set; }

        [JsonProperty("msg-hiddennamequit")]
        public string MsgHiddenNameQuit { get; set; }

        [JsonProperty("msg-players")]
        public string MsgPlayers { get; set; }

        [JsonProperty("webprefix")]
        public string WebPrefix { get; set; }

        [JsonProperty("showplayerfacesinmenu")]
        public bool ShowPLayerFacesInMenu { get; set; }

        [JsonProperty("defaultworld")]
        public string DefaultWorld { get; set; }
    }
}