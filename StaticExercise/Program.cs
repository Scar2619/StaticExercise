using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(60);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(25);

            Console.WriteLine($"After conversion: Celsius is {celsius} and "
                + $"Fahrenheit is {fahrenheit}.");

        }
    }
}

