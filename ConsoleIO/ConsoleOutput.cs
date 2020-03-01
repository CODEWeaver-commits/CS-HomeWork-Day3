using static System.Console;

namespace ConsoleIO
{
    public static class ConsoleOutput
    {
        public static string ErrorMessage { get; set; }
        
        public static void WriteMessage()
        {
            WriteLine(ErrorMessage);
            ReadKey();
        }
        public static void WriteInfo(string FirstName, string LastName, string Patonymic, string Group, byte Age)
        {
            WriteLine($"Имя: {FirstName}");
            WriteLine($"Фамилия: {LastName}");
            WriteLine($"Отчество: {Patonymic}");
            WriteLine($"Группа: {Group}");
            WriteLine($"Возраст: {Age}");
        }
    }
}
