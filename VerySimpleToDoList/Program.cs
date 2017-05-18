using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySimpleToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todolist = new List<string>() { };
            Console.WriteLine("Witaj w programie VerySimpleToDoList.");
            Console.WriteLine("Aby dodać tekst do listy użyj prefixu ze znakiem plus, np. +Kup mleko.");
            Console.WriteLine("Aby usunąć tekst z listy użyj prefixu ze znakiem minus, np. -Kup mleko.");
            Console.WriteLine("Aby wyczyścić listę wpisz poprostu wykrzyknik.");

            do
            {
                string a = Console.ReadLine();
                string b = a.Trim().Substring(0, 1);
                int count = a.Count();
                string c = a.Trim().Substring(1, count - 1);

                Console.Clear();
                Console.WriteLine("//----- Twoja TODO lista -----//");

                if (b.Equals("+") || b.Equals("-") || b.Equals("!"))
                {
                    switch (b)
                    {
                        case "+":
                            todolist.Add(c);
                            break;
                        case "-":
                            todolist.Remove(c);
                            break;
                        case "!":
                            todolist.Clear();
                            break;
                    }
                }
                else Console.WriteLine("Musisz dodać prefix ze znakiem plus, minus do słowa by je dodać lub usunąć. Wpisanie wykrzyknika wyczyści liste.");

                todolist.ForEach(Console.WriteLine);

            } while (true);
        }
    }
}
