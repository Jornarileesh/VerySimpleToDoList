﻿using System;
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
            Console.WindowWidth = 70;
            Console.Title = "VERY SIMPLE TO DO LIST FOR GEEKS V 1.1.";

            Dictionary<int, string> todoList = new Dictionary<int, string>();
            Dictionary<int, string> checkedTask = new Dictionary<int, string>();

            Console.WriteLine("Witaj w programie VerySimpleToDoList.");
            Console.WriteLine("Aby dodać zadanie do listy użyj prefixu '+', np. +Kup mleko.");
            Console.WriteLine("Aby usunąć tekst z listy użyj prefixu '-', np. -Kup mleko.");
            Console.WriteLine("Aby wyczyścić listę wpisz tylko '!'.");

            do
            {

                string newText = Console.ReadLine();

                /* DO POPRAWY
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("\n");
                }
                */

                string prefix = newText.Trim().Substring(0, 1);
                int count = newText.Count();
                string newTask = newText.Trim().Substring(1, count - 1);

                Console.Clear();
                Console.WriteLine("//----- Do zrobienia: -----//");

                int RowsCount = todoList.Count();
                int Id = (RowsCount > 0) ? todoList.Keys.Max() : 0;

                if (prefix.Equals("+") || prefix.Equals("-") || prefix.Equals("!"))
                {

                    switch (prefix)
                    {
                        case "+":
                            todoList.Add(Id + 1, newTask);
                            break;
                        case "-":
                            todoList.Remove(Int32.Parse(newTask));
                            checkedTask.Add(Id, newTask);
                            break;
                        case "!":
                            todoList.Clear();
                            break;
                    }
                }
                else Console.WriteLine("Musisz dodać prefix '+' lub '-' przed zadaniem by je dodać lub usunąć. Wpisanie znaku '!' wyczyści listę.");

                foreach (KeyValuePair<int, string> item in todoList)
                {
                    Console.WriteLine("{0}. {1}", item.Key, item.Value);
                }

                Console.WriteLine("");
                Console.WriteLine("//----- Zrobione: -----//");

                foreach (KeyValuePair<int, string> item2 in checkedTask)
                {
                    Console.WriteLine("{0}. {1}", item2.Key, item2.Value);
                }

            } while (true);

// To Do
// 1. Aktualizacja numerów zadań po usunięciu zadania
// 2. Obsługa przyciśnięcia klawisza Enter
// 3. Poprawne wyświetlanie zrobionych zadań
}
}
}