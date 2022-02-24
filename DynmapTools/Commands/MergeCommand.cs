using DynmapTools.Models;
using Spectre.Console;
using System;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;

namespace DynmapTools.Commands
{
    internal class MergeCommand : Command
    {
        public MergeCommand() : base("merge", "Merge dynmap to image")
        {
            AddAlias("m");
            AddArgument(new Argument<string>("url", "Dynmap URL"));
            AddArgument(new Argument<string>("world", "World"));
            AddArgument(new Argument<string>("map", "Map"));
            AddArgument(new Argument<string>("center", "Center of image [x,y,z]"));
            AddArgument(new Argument<string>("range", "Range of image in tiles [all]|[vert,horz]|[top,left,bottom,right]"));
            AddArgument(new Argument<int>("zoom", () => 0, "Zoom"));
            AddOption(new Option<string>(new[] { "--output", "-o" }, "Output path"));

            Handler = CommandHandler.Create<string, string, string, string, string, int, string>(HandleCommand);
        }

        private static int HandleCommand(string URL, string world, string map, string center, string range, int zoom, string output)
        {
            try
            {
                //URL = "https://ebs.virenbar.ru/dynmap/";
                URL = "https://map.minecrafting.ru/";
                var D = new Dynmap(URL);
                D.RefreshConfig();
                if (!D.Worlds.ContainsKey(world)) { throw new ArgumentException($"Invalid world name: {world}", nameof(world)); }
                if (!D.Maps.ContainsKey((world, map))) { throw new ArgumentException($"Invalid map name: {map}", nameof(map)); }

                var World = D.Worlds[world];
                var Map = D.Maps[(world, map)];

                var R = Models.Range.Parse(range);

                var T = D.WTM(Map, (-64, 64, -64));

                var Dir = Path.Combine("Tiles", world, map);
                if (Directory.Exists(Dir)) { Directory.CreateDirectory(Dir); }

                AnsiConsole.Markup($"[green]{URL} {world} {range} {map} {zoom}[/]");
                return 0;
            }
            catch (ArgumentException E)
            {
                AnsiConsole.MarkupLine($"[red]{E.Message.EscapeMarkup()}[/]");
                //AnsiConsole.WriteException(E, ExceptionFormats.ShortenPaths);
                return 1;
            }
        }
    }
}