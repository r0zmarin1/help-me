using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help_me.Commands
{
    internal class CommandInvoker
    {
        public CommandManager commandManager;

        public CommandInvoker(CommandManager commandManager)
        {
            this.commandManager = commandManager;
        }

        public void Run()
        {
            string command;
            do
            {
                Console.WriteLine("Введите команду");
                command = Console.ReadLine();
                if (command == "help")
                    commandManager.ListCommands();
                else
                    commandManager.Execute(command);
            }
            while (command != "exit");
            

        }
    }
}

