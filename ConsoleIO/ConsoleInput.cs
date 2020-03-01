

namespace ConsoleIO
{
    public static class ConsoleInput
    {
        public static void Input(byte Number)
        {
            if (IsValidNumber(Number))
            {

            }
        }
        public static bool IsValidNumber(byte Number)
        {
            if (Number > 100 | Number < 0)
            {
                ConsoleOutput.ErrorMessage = "Не правильное число!" + "\nПовторите попытку."
                                            + "\nДля продолжения нажмите любую клавишу...";
                return false;
            }
            else return true;
        }
    }
}
