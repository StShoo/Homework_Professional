using TemperatureConverter;

namespace Homework_P_6_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConvert tempConverter = new TemperatureConvert(20.77, 'F');
            tempConverter.ConvertTemperature();
        }
    }
}