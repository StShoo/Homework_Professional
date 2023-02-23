namespace TemperatureConverter
{
    public class TemperatureConvert
    {
        private double temperature;
        private char temperatureSign;

        public TemperatureConvert(double temperature, char temperatureSign)
        {
            this.temperature = temperature;
            this.temperatureSign = temperatureSign;
        }

        public void ConvertTemperature()
        {
            if (temperatureSign.Equals('C'))
            {
                Console.WriteLine($"{temperature} {temperatureSign} = {temperature * 1.8 + 32} F");
            }
            else if (temperatureSign.Equals('F'))
            {
                Console.WriteLine($"{temperature} {temperatureSign} = {(temperature - 32)/1.8} C");
            }
            else { Console.WriteLine("data is incorect"); }
        }
    }
}