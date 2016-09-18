using System;

namespace DES_ninor15.Task7
{
    public class Order
    {
        static Random rnd = new Random();

        private static string[] DRINKS =
        {
            "Lemon Gloom",
            "Cognac Smooch",
            "Unholy Horror",
            "Pear Mud",
            "Basil Tea",
            "Winter Teaser",
            "Sweet Nectar",
            "Banana Rum",
            "Rushed Freedom",
            "Orange Lotus"
        };

        public string Drink;

        public Order()
        {
            Drink = DRINKS[rnd.Next(DRINKS.Length)];
        }

        public Order(string drink)
        {
            Drink = drink;
        }

        public override string ToString()
        {
            return Drink;
        }
    }
}