using CommandLine;
using GitCli.Commands;

Parser.Default.ParseArguments<Clone, Push, Commit>(args)
    .WithParsed<ICommand>(command => command.Execute())
    .WithNotParsed(errors => Console.WriteLine(errors));