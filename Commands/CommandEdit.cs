internal class CommandEdit : CommandUser
{
    private IdolDB idolDB;

    public CommandEdit(IdolDB idolDB)
    {
        this.idolDB = idolDB;
    }
    public override void Execute()
    {
        Console.WriteLine("Поиск айдола");
        List<Idol> students = idolDB.Search(Console.ReadLine());
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"{students[i].Name}{students[i].SceneName}{students[i].Age}");
            Console.WriteLine("Кого отредактировать?");
            int.TryParse(Console.ReadLine(), out int edit);
            if ((students.Count > edit - 1))
            {
                Console.WriteLine("Укажите имя...");
                students[i].Name = Console.ReadLine();
                Console.WriteLine("Укажите сценическое имя...");
                students[i].SceneName = Console.ReadLine();
                Console.WriteLine("Укажите возраст...");
                students[i].Age = Console.ReadLine();
                if (idolDB.Update(students[i]))
                    Console.WriteLine("Айдол переименован!");
            }
            else
                Console.WriteLine("Такого нет");
        }
    }
}