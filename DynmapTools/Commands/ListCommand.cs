using Spectre.Console;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.Linq;

namespace DynmapTools.Commands
{
    internal class ListCommand : Command
    {
        public ListCommand() : base("list", "Show available worlds and maps")
        {
            var URL = new Argument<string>("url", "Dynmap URL");
            AddAlias("ls");
            AddArgument(URL);

            Handler = CommandHandler.Create<string>(HandleCommand);
        }

        private int HandleCommand(string URL)
        {
            //URL = "https://ebs.virenbar.ru/dynmap/";
            URL = "https://map.minecrafting.ru/";

            var D = new Dynmap(URL);
            D.RefreshConfig();
            /*
             * Scale - Number of pixels per block on max zoom (4 for lowres)
             * ExtraZoomOut - Number of additional z levels (0 by default)
             * 0 - ' ' - 4:1 = 4
             * 1 - 'z' - 2:1 = 2
             * 2 - 'zz' - 1:1 = 1
             * 3 - 'zzz' - 1:2 = 0.5
             * Min 'z' = ''
             *
             * Max 'z' = 'z'*(3+ExtraZoomOut) - 3 is default
             */

            var Worlds = D.Config.Worlds;
            var WNMax = Worlds.Max(W => W.Name.Length);
            var MNMax = Worlds.SelectMany(W => W.Maps).Max(M => M.Name.Length);

            var WTMax = Worlds.Max(W => W.Title.Length);
            var MTMax = Worlds.SelectMany(W => W.Maps).Max(M => M.Title.Length);

            var Root = new Tree("Available worlds");
            foreach (var W in Worlds)
            {
                var WNode = Root.AddNode($"[darkgreen]{W.Name} - {W.Title}[/]");
                foreach (var M in W.Maps)
                {
                    WNode.AddNode($"[green]{M.Name} - {M.Title}[/]");
                }
            }
            AnsiConsole.Write(Root);

            //Console.WriteLine("Available worlds:");
            //foreach (var W in Worlds)
            //{
            //    Console.WriteLine($"{W.Name} - {W.Title}");
            //    foreach (var M in W.Maps)
            //    {
            //        Console.ForegroundColor = ConsoleColor.DarkGreen;
            //        Console.WriteLine($"    {M.Name.PadRight(MNMax)} - {M.Title.PadRight(MTMax)} (Extra zoom: {W.ExtraZoomOut}, Scale: {M.Scale})");
            //        Console.ResetColor();
            //    }
            //}
            return 0;
        }
    }
}