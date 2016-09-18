using System;

namespace DES_ninor15.Task7
{
    public class Task7
    {
        SingleLinkedList<Person> people = new SingleLinkedList<Person>();

        public void OrderDrink(string name, string drink)
        {
            people.Add(new Person("none", "Bartender"));
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person());
            }
            people.Add(new Person(drink, name));
            Console.WriteLine(people.ToString());
        }
    }
}