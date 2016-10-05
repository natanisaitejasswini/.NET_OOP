using System;

namespace ConsoleApplication
{
    public class Wizard : Human
    {
        int strength { get; set; }
        int intelligence { get; set; }
        int dexterity { get; set; }
        static int counter = 0;

        public Wizard(string person) : base("wizard")
        {
            name = person;
            strength = 30;
            intelligence = 25;
            dexterity = 175;
            health = 50;
            counter ++;
        }

        // Method called heal when invoked increases health by 10
        public void heal()
        {
            health += 10  *intelligence;
        }

        // Method Fireball
        public void fireball(object obj)
        {
            Random rand = new Random();
            if(obj.GetType() == typeof(Human))
            {
                var enemy = obj as Human;
                enemy.health -= rand.Next(20,50);
            }
        }
    }
}