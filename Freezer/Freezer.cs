using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freezer
{
    partial class Freezer
    {
        public void ShowTemperatures()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}");
            Console.WriteLine($"Current temperature:{ Temperature}\nDefault temperature: {DefaultTemperature}\nTemperature with super freeze: {SuperFreezeTemperature}.");
        }
        public void SetTemperatureToDefault()
        {
            Console.WriteLine($"Temperature has been changed from {Temperature} to default({DefaultTemperature}).");
            Temperature = DefaultTemperature;
        }
        public void SetSuperFreezeMode()
        {
            if (IsSuperFreezeOn)
            {
                Console.WriteLine($"Super freeze off, temperature has been changed to default({DefaultTemperature}).");
                IsSuperFreezeOn = false;
                Temperature = DefaultTemperature;
            }
            else
            {
                Console.WriteLine($"Super freeze on, temperature has been changed to {SuperFreezeTemperature}.");
                IsSuperFreezeOn = true;
                Temperature = SuperFreezeTemperature;
            }
        }
        public void FreezeFruit(Fruit fruit)
        {
            Console.WriteLine($"{fruit.Name} has been chilled to temperature {Temperature}.");
            fruit.Temperature = Temperature;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}\nModel: {Model}\nColor: {Color}\nHeight: {Height}\nWidth: {Width}\nVolume: {Volume}\nTemperature: {Temperature}\n";
        }
        

    }

}
