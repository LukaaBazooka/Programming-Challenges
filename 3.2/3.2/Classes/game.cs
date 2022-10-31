using System;

public class game
{


    public static void Start()
    {
        character Player = new character();

        List<string> list = new List<string>();
        list.Add("John");
        list.Add("Enbiras");
        list.Add("Ardor");
        list.Add("Solan");
        var random = new Random();
        int index = random.Next(list.Count);

        Player.maxhp = 100;
        Console.WriteLine("Please enter your name");
        Player.characterName = Console.ReadLine();
        Player.IsPlayer = true;

        character Enemy = new character();
        Enemy.maxhp = 100;
        Enemy.characterName = list[index];
        Enemy.IsPlayer = false;

        Console.WriteLine($"The Player is called {Player.characterName}");
        Console.WriteLine($"{Player.characterName} has {Player.maxhp} health");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine($"The enemy is called {Enemy.characterName}");
        Console.WriteLine($"{Enemy.characterName} has {Enemy.maxhp} health");

        character.attack(Player, Enemy);

    }
}
