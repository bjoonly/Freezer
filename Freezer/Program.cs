using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freezer
{
  

    class Program
    {
        static void Main(string[] args)
        {
            Freezer[] freezers = new Freezer[] { new Freezer ("Delfa","DF-120","White",122,55,138,-15),
                                                 new Freezer("ATLANT","M 7606-100-N"),
                                                 new Freezer(),
                                                 new Freezer("Gorenje","FN6191CX","Silver",185,60,243,-20),
                                                 new Freezer("Zanussi","ZFC51400WA")
                                                };
        
  
         foreach(var freezer in freezers)
                Console.WriteLine(freezer);
        
         freezers[1].SetSuperFreezeMode();
            freezers[1].SetSuperFreezeMode();
            Console.WriteLine("\n\n"+freezers[3]);
            freezers[3].SetTemperatureToDefault();
            Console.WriteLine(freezers[3]);
            Fruit fruit = new Fruit("Apple", 5);
            Console.WriteLine("\n\n"+fruit);

            freezers[0].ShowTemperatures();
            freezers[0].FreezeFruit( fruit);
            Console.WriteLine("\n\n"+fruit);
        }
    }
}
