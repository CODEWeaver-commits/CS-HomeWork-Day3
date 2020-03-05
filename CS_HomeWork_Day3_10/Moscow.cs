using CityInterface;
using Ukraine;
using Moldova;

namespace Russia
{
    public class Moscow : ICity
    {
        private int CityPopulation;
        public string Name = "Москв";
        public int Population
        {
            set { CityPopulation = value; }
            get { return CityPopulation; }
        }
        public string ShowPopulation()
        {
            return $"Популяция: {Population} человек.";
        }
        public static string operator >(Moscow city1, Kiev city2)
        {
            if (city1.Population > city2.Population)
                return $"Популяция {city1.Name}ы больше {city2.Name}a";
            else
                return $"Популяция {city2.Name}а больше {city1.Name}ы";
        }
        public static string operator <(Moscow city1, Kiev city2)
        {
            if (city1.Population < city2.Population)
                return $"Популяция {city1.Name}ы больше {city2.Name}a";
            else
                return $"Популяция {city2.Name}а больше {city1.Name}ы";
        }
        public static string operator >(Moscow city1, Kishiniev city2)
        {
            if (city1.Population > city2.Population)
                return $"Популяция {city1.Name}ы больше {city2.Name}a";
            else
                return $"Популяция {city2.Name}а больше {city1.Name}ы";
        }
        public static string operator <(Moscow city1, Kishiniev city2)
        {
            if (city1.Population < city2.Population)
                return $"Популяция {city1.Name}ы больше {city2.Name}a";
            else
                return $"Популяция {city2.Name}а больше {city1.Name}ы";
        }
    }
}
