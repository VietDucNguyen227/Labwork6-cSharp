using System;
using System.Collections.Generic;
using System.Text;

namespace Labwork6._1
{
    internal class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }
        public float Temperature { get; set; }
        private float _Temperature;
        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature > Temperature)
            {
                Console.WriteLine("Cooler: On");
            }
            else
            {
                Console.WriteLine("Cooler: Off");
            }
        }
    }
   
}
