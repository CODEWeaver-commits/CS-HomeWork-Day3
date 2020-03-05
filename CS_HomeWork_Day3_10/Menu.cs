using static System.Console;
namespace CS_HomeWork_Day3_10
{
    public static class Menu
    {
        private static Ukraine.Kiev kiev = new Ukraine.Kiev();
        private static Moldova.Kishiniev kishiniev = new Moldova.Kishiniev();
        private static Russia.Moscow moscow = new Russia.Moscow();
        public static void Initialize()
        {
            kiev.Population = 37289000;
            kishiniev.Population = 639100;
            moscow.Population = 12615882;
        }
        public static void Show()
        {
            ShowCityPopulation();

            WriteLine("\n===============================================\n");

            PopulationComparation();
        }
        private static void ShowCityPopulation()
        {
            WriteLine($"Киев \t| -- | {kiev.ShowPopulation()}");
            WriteLine($"Москва  | -- | {moscow.ShowPopulation()}");
            WriteLine($"Киненёв | -- | {kishiniev.ShowPopulation()}");
        }
        private static void PopulationComparation()
        {
            WriteLine($"{kiev > moscow},\n{kiev > kishiniev},\n{kishiniev > moscow},\n{kishiniev > kiev},\n{moscow > kiev},\n{moscow > kishiniev}");
        }
    }
}
