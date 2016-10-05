using System;

namespace ConsoleApplication
{
    public class Samurai : Human
    {
        int strength { get; set; }
        int intelligence { get; set; }
        int dexterity { get; set; }
        static int counter = 0;

        public Samurai(string person) : base("samurai")
        {
            name = person;
            strength = 30;
            intelligence = 23;
            dexterity = 175;
            health = 200;
            counter ++;
        }

        // Ninja should have a steal method when invoked 
        public void death(object obj)
        {
            if (obj.GetType() == typeof(Human))
            {
                var enemy = obj as Human;
                if(enemy.health < 50){
                    enemy.health = 0;
                }
            }
            else
            {
                Console.WriteLine("Failed Attack");
            }
        }

        // get_away method when invoked decreases its health by 15
        public void meditate()
        {
            health = 200;
        }

        // how_many method
        public static int how_many()
        {
            return counter;
        }
    }
}