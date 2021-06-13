using System;
using Part4.demo;

namespace Part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Nam";
            person.address = "Ha Noi";
            person.email = "nam@gmail.com";
            person.phoneNumber = 0989550185;
            Console.WriteLine(person.ToString());
        }
    }
}