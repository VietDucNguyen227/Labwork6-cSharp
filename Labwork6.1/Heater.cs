using System;
using System.Collections.Generic;
using System.Text;

namespace Labwork6._1
{
    internal class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }
        public float Temperature { get; set; }
        private float _Temperature;
        public void OnTemperatureChanged(float newTemperature)
        {
            if(newTemperature < Temperature)
            {
                Console.WriteLine("Heater: On");
            }
            else
            {
                Console.WriteLine("Heater: Off");
            }
        }
    }
}
