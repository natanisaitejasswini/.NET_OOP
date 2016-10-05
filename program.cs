using System;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human created = new Human("Teju");
            Console.WriteLine($"Human name is {created.name}");
            Console.WriteLine($"Human health is {created.health}");

            Wizard wizzy_created = new Wizard("Wizard");
            wizzy_created.heal();
            Console.WriteLine($"Wizard Health is {wizzy_created.health}");
            wizzy_created.fireball(created);
            Console.WriteLine($"Enemy Health after attack is {created.health}");

            Samurai sam_created1 = new Samurai("sam");
            Samurai sam_created2 = new Samurai("tom");
            sam_created1.meditate();
            Console.WriteLine($"Samurai1 Health is {sam_created1.health}");
            Console.WriteLine($"Samurais created upto now are {Samurai.how_many()}");

            Ninja ninja_created = new Ninja("ninja");
            ninja_created.get_away();
            Console.WriteLine($"Ninja Health is {ninja_created.health}");
        }
    }
}
