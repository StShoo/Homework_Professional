using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_6_task_1
{
    internal class TemperatureConverter
    {
        protected double temperature;
        protected char signOfTemperature;

        protected TemperatureConverter(double temperature, char signOfTemperature) 
        {
            this.temperature = temperature;
            this.signOfTemperature = signOfTemperature;
        }

        public void ConvertTemperature()
        {
            if(signOfTemperature.Equals('C')) 
            {
                Console.WriteLine($"{temperature} {signOfTemperature} = {temperature * 1.8 + 32} F");
            } else if (signOfTemperature.Equals('F'))
            {
                Console.WriteLine($"{temperature} {signOfTemperature} = {(temperature - 32)/1.8} C");
            } else 
            { Console.WriteLine("Input is not correct"); }
        } 
    }
}
