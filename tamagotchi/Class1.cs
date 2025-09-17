public class Tamagotchi
{
    private int Hunger;
    private int Boredom;
    private bool IsAlive;
    public string Name;
    private List<string> words = new List<string>() { "Hewwo" };

    public Tamagotchi()
    {
        IsAlive = true;
    }

    public void Hi()
    {
        int wordNum = Random.Shared.Next(words.Count);
        Console.WriteLine($"[{Name}] says: {words[wordNum]}");
        ReduceBoredom();
    }

    public void Feed()
    {
        Console.WriteLine($"[{Name}] ate and is now becoming less hungry");
        Hunger -= -2;
        if (Hunger < 0)
        {
            Hunger = 0;
        }
    }

    public void Tick()
    {

    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {Name} || Hunger: {Hunger} || Boredom: {Boredom} || Status: {isAlive} || Ord: {words.Count}");
    }

    private void ReduceBoredom()
    {

    }
}