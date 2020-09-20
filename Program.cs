using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Publius Cornelius Tacitus", new DateTime(1944, 6, 6), Genders.Male);
            Person person2 = new Person("Demetra", new DateTime(1945, 9, 1), Genders.Female);
            Person person3 = new Person("Xenophon", new DateTime(1955, 12, 16), Genders.Male);
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
        }
    }
}
