using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freezer
{
    partial class Freezer
    {
        private int volume;
        private double height;
        private double width;
        public bool IsSuperFreezeOn { get; private set; }
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value < 60)
                    volume = 60;
                else if (value > 572)
                    volume = 572;
                else
                    volume = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 84.5)
                    height = 84.5;
                else if (value > 195)
                    height = 195;
                else
                    height = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 48)
                    width = 48;
                else if (value > 165)
                    width = 165;
                else
                    width = value;
            }
        }
        public int Temperature { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public static int DefaultTemperature { get; private set; }
       public static int SuperFreezeTemperature { get; private set; }
        public static int Count { get; private set; }

        static Freezer()
        {
            DefaultTemperature = -18;
            SuperFreezeTemperature = -32;
            Count = 0;
        }

        public Freezer()
        {
            Color = "No color";
            Brand = "No brand";
            Model = "No model";
            height = 0;
            width = 0;
            volume = 0;
            Temperature = 0;
            IsSuperFreezeOn = false;
            Count++;
        }

        public Freezer(string brand, string model, string color, double height, double width, int volume, int temperature)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Height = height;
            Width = width;
            Volume = volume;
            Temperature = temperature;
            IsSuperFreezeOn = false;
            Count++;
        }

        public Freezer(string brand, string model) : this(brand, model, "Silver", 100, 60, 90, DefaultTemperature) { }

        

    
    }

}
