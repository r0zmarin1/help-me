using help_me.Commands;
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        CommandManager commandManager = new CommandManager();
        CommandInvoker commandInvoker = new CommandInvoker(commandManager);
        IdolDB idolDB = new IdolDB();
        commandManager.RegisterCommand("Create", "Добавление", new CommandCreate(idolDB));
        commandManager.RegisterCommand("Search", "Поиск", new CommandSearch(idolDB));
        commandManager.RegisterCommand("Delete", "Удаление", new CommandDelete(idolDB));
        commandManager.RegisterCommand("Edit", "Редактирование", new CommandEdit(idolDB));

        commandInvoker.Run();
    }

}