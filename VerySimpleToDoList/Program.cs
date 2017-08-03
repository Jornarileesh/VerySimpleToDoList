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
            Dictionary<int, string> todoList = new Dictionary<int, string>();

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

                int Id = todoList.Count();

                // poniżej poprawić
                if (Id > 0)
                {
                    int maxId = todoList.Keys.Max();
                    Console.WriteLine(maxId);
                }
                else
                {
                    Console.WriteLine("brak");
                }
                // -----

                if (b.Equals("+") || b.Equals("-") || b.Equals("!"))
                {
                    switch (b)
                    {
                        case "+":
                            todoList.Add(maxId + 1, c);
                            break;
                        case "-":
                            todoList.Remove(Int32.Parse(c));
                            break;
                        case "!":
                            todoList.Clear();
                            break;
                    }
                }
                else Console.WriteLine("Musisz dodać prefix ze znakiem plus lub minus do słowa by je dodać lub usunąć. Wpisanie wykrzyknika wyczyści listę.");

                foreach (KeyValuePair<int, string> item in todoList)
                {
                    Console.WriteLine("{0}. {1}", item.Key, item.Value);
                }

            } while (true);

// To Do
// 1. ustawić rozmiar okienka
// 2. Zapisywać nr zadania
// 3. Wyświetlać nr zadania
// 4. Usuwać wg numeru
}
}
}
