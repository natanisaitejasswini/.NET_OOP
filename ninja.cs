using System;

namespace ConsoleApplication
{
    public class Ninja : Human
    {
        int strength { get; set; }
        int intelligence { get; set; }
        int dexterity { get; set; }

        public Ninja(string person) : base("ninja")
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 175;
            health = 100;
        }

        // Ninja should have a steal method when invoked 
        public void steal(object obj)
        {
            if (obj.GetType() == typeof(Human))
            {
                var enemy = obj as Human;
                enemy.health -= 10;
                health += 10;
            }
            else
            {
                Console.WriteLine("Failed Attack");
            }
        }

        // get_away method when invoked decreases its health by 15
        public void get_away()
        {
            health -= 15;
        }
    }
}