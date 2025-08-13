using System;
namespace StaticExercise
{
    class program
    {
        static void Main(string[] args)
        {

            var celcius = TempConvertor.FahrenheitToCelsius(68); // 20
            Console.WriteLine($"Celcius = {celcius}.");
            var fahrenheit = TempConvertor.CelsiusToFahrenheit(20); // 68
            Console.WriteLine($"Fahrenheit = {fahrenheit}.");
        }

       
        

    }

}