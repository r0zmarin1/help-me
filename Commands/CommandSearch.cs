internal class CommandSearch : CommandUser
{
    private IdolDB idolDB;

    public CommandSearch(IdolDB idolDB)
    {
        this.idolDB = idolDB;
    }

    public override void Execute()
    {
        Console.WriteLine("Поиск");
        List<Idol> idols = idolDB.Search(Console.ReadLine());
        for (int i = 0; i < idols.Count; i++)
        {
            Console.WriteLine($"{idols[i].Name} {idols[i].SceneName} {idols[i].Age}");
        }
    }
}