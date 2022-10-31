using System;

public class character
{

    public string characterName;
    public int maxhp;
    public bool IsPlayer;

    public static void attack(character Player, character Enemy)
    {
        Console.WriteLine("A fight begins!");

        while (Player.maxhp > 0 && Enemy.maxhp > 0)
        {
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.Spacebar:
                    Random rnd = new Random();
                    int damage = rnd.Next(1, 1);

                    Enemy.maxhp -= damage;

                    if (Enemy.maxhp < 0)
                    {
                        Enemy.maxhp = 0;
                        Console.WriteLine($"The opponent has hit 0 health! you win lol");

                    }
                    else if (Enemy.maxhp > 0)
                    {
                        Console.WriteLine($"You did {damage} damage, {Enemy.characterName} is now on {Enemy.maxhp} health");

                    }
                    break;
            }
        }
        if (Enemy.maxhp <= 0)
        {
            Console.WriteLine($"The opponent has hit 0 health! you win lol");

            Console.WriteLine("ded");
        }


    }

}