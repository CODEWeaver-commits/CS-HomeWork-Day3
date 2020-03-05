using CityInterface;
using Moldova;
using Russia;

namespace Ukraine
{
    public class Kiev : ICity
    {
        private int CityPopulation;
        public string Name = "Киев";
        public int Population
        {
            set { CityPopulation = value; }
            get { return CityPopulation; }
        }
        public string ShowPopulation()
        {
            return $"Популяция: {Population} человек.";
        }
        public static string operator >(Kiev city1, Kishiniev city2)
        {
            if (city1.Population > city2.Population)
                return $"Популяция {city1.Name}a больше {city2.Name}a";
            else
                return $"Популяция {city2.Name}a больше {city1.Name}a";
        }
        public static string operator <(Kiev city1, Kishiniev city2)
        {
            if (city1.Population < city2.Population)
                return $"Популяция {city1.Name}a больше {city2.Name}a";
            else
                return $"Популяция {city2.Name}a больше {city1.Name}a";
        }
        public static string operator >(Kiev city1, Moscow city2)
        {
            if (city1.Population > city2.Population)
                return $"Популяция {city1.Name}a больше {city2.Name}ы";
            else
                return $"Популяция {city2.Name}a больше {city1.Name}ы";
        }
        public static string operator <(Kiev city1, Moscow city2)
        {
            if (city1.Population > city2.Population)
                return $"Популяция {city1.Name}a больше {city2.Name}ы";
            else
                return $"Популяция {city2.Name}a больше {city1.Name}ы";
        }
    }
}
