#nullable enable

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(SearchApiGroupCommand.Create());
        return command;
    }
}