internal class CommandDelete : CommandUser
{
    private IdolDB idolDB;

    public CommandDelete(IdolDB idolDB)
    {
        this.idolDB = idolDB;
    }

    public override void Execute()
    {
        Console.WriteLine("Поиск айдола");
        List<Idol> idols = idolDB.Search(Console.ReadLine());
        for (int i = 0; i < idols.Count; i++)
        {
            Console.WriteLine($"{idols[i]}");
            Console.WriteLine("Кого удалить?");
            int.TryParse(Console.ReadLine(), out int delete);
            if (idols.Count > delete - 1)
            {
                idolDB.Delete(idols[i]);
                Console.WriteLine("Удален");
            }

            else
                Console.WriteLine("Такого нет");
        }

    }
}