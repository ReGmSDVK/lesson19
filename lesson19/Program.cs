using lesson19.UserInterface;

namespace lesson19
{
    //Запуск программы всегда начинается в классе Program
    class Program
    {
        //Запуск программы начинается с вызова метода Main
        static void Main(string[] args)
        {
            // Вызываем меню
            MenuHelper.ExecuteMenu(MainMenu.options);
        }
    }
}