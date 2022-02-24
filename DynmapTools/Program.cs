using DynmapTools.Commands;
using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using System.Diagnostics;

namespace DynmapTools
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Verbose = new Option<bool>(new[] { "--verbose", "-v" }, "Show full log");
            var RootCommand = new RootCommand() { new ListCommand(), new MergeCommand() };
            RootCommand.AddGlobalOption(Verbose);
            RootCommand.Description = "Render dynmap";

            var CBL = new CommandLineBuilder(RootCommand)
                .AddMiddleware((context, next) =>
                {
                    var V = context.ParseResult.GetValueForOption(Verbose);
                    if (V) { Trace.Listeners.Add(new TextWriterTraceListener(Console.Out)); }
                    Debug.WriteLine("Verbose output enabled");
                    return next(context);
                })
                .UseParseErrorReporting()
                .UseExceptionHandler()
                .UseHelp()
                .Build();
#if DEBUG
            CBL.Invoke("ls t");
            //CBL.Invoke("m t world flat [0,0] [2,2,2]");
#else
            CBL.Invoke(args);
#endif
        }
    }
}