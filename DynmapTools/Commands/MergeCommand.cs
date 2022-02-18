using Spectre.Console;
using System;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;

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
            //AddArgument(new Argument<string>("center", "Center of image [x,y,z]"));
            //AddArgument(new Argument<string>("size", "Center of image [h,v]"));
            AddArgument(new Argument<int>("zoom", () => 0, "Zoom"));
            AddOption(new Option<string>(new[] { "--output", "-o" }, "Output path"));

            Handler = CommandHandler.Create<string, string, string, int, string>(HandleCommand);
        }

        private static int HandleCommand(string URL, string world, string map, int zoom, string output)
        {
            try
            {
                //URL = "https://ebs.virenbar.ru/dynmap/";
                URL = "https://map.minecrafting.ru/";
                var D = new Dynmap(URL);
                D.RefreshConfig();
                if (!D.Worlds.ContainsKey(world)) { throw new ArgumentException($"Invalid world name: {world}", nameof(world)); }
                if (!D.Maps.ContainsKey((world, map))) { throw new ArgumentException($"Invalid map name: {map}", nameof(map)); }

                //Console.WriteLine("Hello World!");
                //Console.WriteLine($"{URL} {world} {map} {zoom}");
                AnsiConsole.Markup($"[green]{URL} {world} {map} {zoom}[/]");
                return 0;
            }
            catch (ArgumentException E)
            {
                AnsiConsole.MarkupLine($"[red]{E.Message}[/]");
                return 0;
            }
        }
    }
}