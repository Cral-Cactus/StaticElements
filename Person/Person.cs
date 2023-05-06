using System;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        private static int count;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int Count
        {
            get { return count; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            count++;
        }
    }
}