using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help_me.Commands
{
    internal class CommandInvoker
    {
        public CommandManager CommandManager { get; set; }

        public void Run()
        {
            string command;
            do
            {
                Console.WriteLine("Введите команду");
                command = Console.ReadLine();
                CommandManager.Execute(command);
            }
            while (command != "exit");
            if (command == "help"):
                Console.WriteLine(List<comm>dd

        }
    }
}

