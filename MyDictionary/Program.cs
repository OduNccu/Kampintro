using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> user = new MyDictionary<int, string>();
            user.Add(1, "Hamza");
            user.Add(3, "Serhat");
            user.Add(4, "Melisa");

            Console.WriteLine("Number: " + user.Key[0] + "\n" + "Name: " + user.Value[0]);

        }
    }
}