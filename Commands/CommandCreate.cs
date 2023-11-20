internal class CommandCreate: CommandUser
{
    private IdolDB idolDB;

    public CommandCreate(IdolDB idolDB)
    {
        this.idolDB = idolDB;
    }
    public override void Execute()
    {
        Console.WriteLine("Добавление айдола...");
        Idol newIdol = idolDB.Create();
        Console.WriteLine("Укажите имя...");
        newIdol.Name = Console.ReadLine();
        Console.WriteLine("Укажите сценическое имя...");
        newIdol.SceneName = Console.ReadLine();
        Console.WriteLine("Укажите возраст...");
        newIdol.Age = Console.ReadLine();
        if (idolDB.Update(newIdol))
            Console.WriteLine("Айдол добавлен!");
        else
            Console.WriteLine("Ошибка");
    }
}