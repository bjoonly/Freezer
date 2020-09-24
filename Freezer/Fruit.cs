using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freezer
{
    class Fruit
    {
       public string Name { get; set; }
       public int Temperature { get; set; }
       public Fruit(string name,int temperature)
        {
            Name = name;
            Temperature = temperature;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nTemperature: {Temperature}";
        }
    }
}
