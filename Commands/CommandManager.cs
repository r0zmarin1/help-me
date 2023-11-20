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
            Console.WriteLine(commands["test"].descr);
            commands[command].Item2.Execute();
        }
    }

    public void RegisterDescr(string descr, CommandUser commandUser)
    {
        commands.Add("test", ("описание команды", commandUser));
    }
 
    public void RegisterCommand(string command, CommandUser commandUser)
    {
        commands.Add(command, ("Добавление команды", commandUser));
    }

    public void ListCommands (string text)
    {
        foreach(var command in commands.Keys)
        {
            Console.WriteLine($"{command} - {commands["test"].descr}");
        }
    }
}
