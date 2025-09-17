Console.WriteLine("Say hello to your very own Tamagotchi!");

Tamagotchi tami = new Tamagotchi();

Console.WriteLine("Please choose a name for your Tamagotchi.");
tami.Name = Console.ReadLine();

Console.WriteLine($"{tami.Name} is a wonderful name!");
Console.ReadLine();


while (tami.GetAlive() == true)
{
    Console.Clear();
    tami.PrintStats();
    Console.WriteLine("Please choose what you would like to do.");
    Console.WriteLine($"1. Feed {tami.name}");
    Console.WriteLine($"2. Talk to {tami.name}");
    Console.WriteLine($"3. Teach {tami.name} a new word");
    Console.WriteLine($"4. Do nothing");

    string action = Console.ReadLine();
    if (action == "1")
    {
        tami.Feed();
    }
    if (action == "2")
    {
        tami.Hi();
    }
    if (action == "3")
    {
        Console.WriteLine("What word would you like to teach your Tamagotchi?");
        string word = Console.ReadLine();
        tami.Teach(word);
    }
    else
    {
        Console.WriteLine("Doing nothing...");
    }
    tami.Tick();
    Console.WriteLine("Press ENTER to continue.");
    Console.ReadLine();
}

Console.WriteLine($"OH NO! {tami.name} is dead!");
Console.WriteLine("Press ENTER to quit.");
Console.ReadLine();