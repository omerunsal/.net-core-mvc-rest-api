using Commander.Models;

namespace Commander.Data;

public class MockCommanderRepo : ICommanderRepo
{
    public IEnumerable<Command> GetAppCommands()
    {
        var commands = new List<Command>()
        {
            new Command
            {
                Id = 0, HowTo = "Test Wash", Line = "Test Line", Platform = "Test Platform"
            },
            new Command
            {
                Id = 1, HowTo = "Test Wash 1", Line = "Test Line 1", Platform = "Test Platform 1"
            },
            new Command
            {
                Id = 2, HowTo = "Test Wash 2", Line = "Test Line 2", Platform = "Test Platform 2"
            }
        };
        return commands;
    }

    public Command GetCommandById(int id)
    {
        return new Command
        {
            Id = 0,
            HowTo = "Test Wash",
            Line = "Test Line",
            Platform = "Test Platform"
        };
    }
}