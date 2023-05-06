using System;

namespace Person
{
    internal class Program
    {
        static void Main()
        {
            Person person = new Person("John", 25);
            Person person2 = new Person("Jason", 31);
            // You can add as many people as you want

            Console.WriteLine(Person.Count);
        }
    }
}