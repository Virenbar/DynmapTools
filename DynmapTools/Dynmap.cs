using DynmapTools.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace DynmapTools
{
    internal class Dynmap
    {
        private readonly string URL;
        private URLs URLs;

        public Dynmap(string url)
        {
            URL = url.TrimEnd('/');
            Debug.WriteLine($"Dynmap URL: {URL}");
        }

        public Config Config { get; private set; }

        public void RefreshConfig()
        {
            using var WC = new WebClient();
            var URLFile = $"{URL}/standalone/config.js";
            Debug.WriteLine($"Fetching: {URLFile}");
            var urls = WC.DownloadString(URLFile);
            var Match = Regex.Match(urls, "url : (.+)};", RegexOptions.Singleline);
            URLs = JsonConvert.DeserializeObject<URLs>(Match.Groups[1].Value);

            var ConfigFile = $"{URL}/{ApplyTimestamp(URLs.Configuration)}";
            Debug.WriteLine($"Fetching: {ConfigFile}");
            var config = WC.DownloadString(ConfigFile);
            Config = JsonConvert.DeserializeObject<Config>(config);

            //var W = Config.Worlds.Select(w => w.Name);
            Worlds = Config.Worlds.ToDictionary(W => W.Name, W => W);
            Maps = Config.Worlds.SelectMany(W => W.Maps.Select(M => (W, M))).ToDictionary(X => (X.W.Name, X.M.Name), X => X.M);
        }

        public Dictionary<string, World> Worlds { get; private set; }
        public Dictionary<(string world, string map), Map> Maps { get; private set; }

        public string Tiles(string world) => URLs?.Tiles.Replace("{world}", world);

        private static string ApplyTimestamp(string str) => str.Replace("{timestamp}", DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString());

        //private static string ApplyWorld(string str, string world) => str.Replace("{world}", world);
    }
}