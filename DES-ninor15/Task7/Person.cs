using System;

namespace DES_ninor15.Task7
{
    public class Person
    {
        static Random rnd = new Random();

        private static string[] NAMES =
        {
            "Milo",
            "Brigida",
            "Darin",
            "Kelley",
            "Tanna",
            "Jaunita",
            "Elly",
            "Tanner",
            "Anastacia",
            "Chaya",
            "Jordan",
            "Kory",
            "Adrien",
            "Marion",
            "Vicenta",
            "Geri",
            "King",
            "Jenifer",
            "Erinn",
            "Mayme"
        };
        public Order Drink;
        public string Name;

        public Person()
        {
            Name = NAMES[rnd.Next(NAMES.Length)];
            Drink = new Order();
        }

        public Person(String drink, string name)
        {
            Drink = new Order(drink);
            Name = name;
        }

        public override string ToString()
        {
            return Name + " - " + Drink;
        }


    }
}