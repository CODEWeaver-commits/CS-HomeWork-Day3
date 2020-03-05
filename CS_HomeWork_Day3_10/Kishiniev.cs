using CityInterface;
using Ukraine;
using Russia;

namespace Moldova
{
    public class Kishiniev : ICity
    {
        private int CityPopulation;
        public string Name = "Кишенёв";
        public int Population
        {
            set { CityPopulation = value; }
            get { return CityPopulation; }
        }
        public string ShowPopulation()
        {
            return $"Популяция: {Population} человек.";
        }
        public static string operator >(Kishiniev city1, Kiev city2)
        {
            if (city1.Population > city2.Population)
                return $"Популяция {city1.Name}a больше {city2.Name}a";
            else
                return $"Популяция {city2.Name}a больше {city1.Name}a";
        }
        public static string operator <(Kishiniev city1, Kiev city2)
        {
            if (city1.Population < city2.Population)
                return $"Популяция {city1.Name}a больше {city2.Name}a";
            else
                return $"Популяция {city2.Name}a больше {city1.Name}a";
        }
        public static string operator >(Kishiniev city1, Moscow city2)
        {
            if (city1.Population > city2.Population)
                return $"Популяция {city1.Name}a больше {city2.Name}ы";
            else
                return $"Популяция {city2.Name}ы больше {city1.Name}а";
        }
        public static string operator <(Kishiniev city1, Moscow city2)
        {
            if (city1.Population < city2.Population)
                return $"Популяция {city1.Name}a больше {city2.Name}ы";        
            else
                return $"Популяция {city2.Name}ы больше {city1.Name}а";
        }
    }
}
