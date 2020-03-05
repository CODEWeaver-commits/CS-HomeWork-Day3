using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInterface
{
    interface ICity
    {
        int Population { get; set; }
        string ShowPopulation();
    }
}
