using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace lesson19.UserInterface
{
    public static class MenuHelper
    {
        //Добавляет функцию движения клавиш вверх и вниз
        public static void ExecuteMenu(List<MenuOption> options)
        {
            int index = 0;

            PrintMenu(options, index);
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                    }
                    PrintMenu(options, index);
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                    }
                    PrintMenu(options, index);
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options[index].Action();
                    index = 0;
                    PrintMenu(options, index);
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
        /// <summary>
        /// Вывод меню
        /// </summary>
        private static void PrintMenu(List<MenuOption> options, int index = 0)
        {
            Console.Clear();
            for (int i = 0; i < options.Count; i++)
            {
                MenuOption option = options[i];
                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(option.Title);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(option.Title);
                }
            }
        }
    }
}