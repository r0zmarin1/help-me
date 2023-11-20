using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CommandManager
{
    Dictionary<string,(string descr, CommandUser)> commands = new();

    public void Execute(string? command)
    {
        if (commands.ContainsKey(command))
        {
            Console.WriteLine(commands[command].descr);
            commands[command].Item2.Execute();
        }
    }
 
    public void RegisterCommand(string command, string descr, CommandUser commandUser)
    {
        commands.Add(command, (descr, commandUser));
    }

    public void ListCommands ()
    {
        foreach(var command in commands.Keys)
        {
            Console.WriteLine($"{command} - {commands[command].descr}");
        }
    }
}
