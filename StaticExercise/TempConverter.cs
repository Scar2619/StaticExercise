using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double temp)
		{
			double f = temp;
			return (f - 32) * 5 / 9;
		}

		public static double CelsiusToFahrenheit(double temp)
        {
			double c = temp;
			return c * 9 / 5 + 32;
        }

	}
}

