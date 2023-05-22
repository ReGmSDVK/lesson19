using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson19.Lessons;
using Microsoft.VisualBasic;

namespace lesson19.UserInterface;
public class MainMenu
{
    //Отображение меню
    public static List<MenuOption> options = new List<MenuOption>()
        {
            new MenuOption()
            {
                Title = "Задача 1",
                Action = LessonOne,
            },
            new MenuOption()
            {
                 Title = "Задача 2",
                 Action = LessonTwo,
            },
            new MenuOption()
            {
                 Title = "Задача 3",
                 Action = LessonThree,
            },
            new MenuOption()
            {
                Title = "Выход",
                Action = OnExit,
            },
        };

    //ссылки на классы с задачами
    public static void LessonOne()
    {
        string[] deadends = { "0201", "0101", "0102", "1212", "2002" };
        string target = "0202";
        //использует алгоритм BFS для нахождения минимального количества оборотов, необходимых для открытия замка
        int minTurns = Lesson1.OpenLock1(deadends, target);
        Console.Clear();
        Console.WriteLine("Минимальное количество оборотов: " + minTurns);

        ConsoleKeyInfo keyInfo;
        do
        {
            Console.WriteLine("Для того чтобы вернутся в меню нажмите Esc");
            keyInfo = Console.ReadKey(true);
        } while (keyInfo.Key != ConsoleKey.Escape);
    }

    //ссылки на классы с задачами
    public static void LessonTwo()
    {
        string[] deadends = { "8888" };
        string target = "0009";
        //использует алгоритм BFS для нахождения минимального количества оборотов, необходимых для открытия замка
        int minTurns = Lesson1.OpenLock1(deadends, target);
        Console.Clear();
        Console.WriteLine("Минимальное количество оборотов: " + minTurns);

        ConsoleKeyInfo keyInfo;
        do
        {
            Console.WriteLine("Для того чтобы вернутся в меню нажмите Esc");
            keyInfo = Console.ReadKey(true);
        } while (keyInfo.Key != ConsoleKey.Escape);
    }

    //ссылки на классы с задачами
    public static void LessonThree()
    {
        string[] deadends = { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" };
        string target = "8888";
        //использует алгоритм BFS для нахождения минимального количества оборотов, необходимых для открытия замка
        int minTurns = Lesson1.OpenLock1(deadends, target);
        Console.Clear();
        Console.WriteLine("Минимальное количество оборотов: " + minTurns);

        ConsoleKeyInfo keyInfo;
        do
        {
            Console.WriteLine("Для того чтобы вернутся в меню нажмите Esc");
            keyInfo = Console.ReadKey(true);
        } while (keyInfo.Key != ConsoleKey.Escape);
    }



    /// <summary>
    /// Выход
    /// </summary>
    public static void OnExit()
    {
        Environment.Exit(0);
    }

}
