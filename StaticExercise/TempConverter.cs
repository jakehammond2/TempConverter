using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double Ftemp)
        {

            double celcius = 0;

            celcius = (Ftemp - 32) / 1.8;

            return celcius;

        }


        public static double CelsiusToFahrenheit(double Ctemp)
        {

            double fahrenheit = 0;

            fahrenheit = (1.8 * Ctemp) + 32;

            return fahrenheit; 

        }
}
}

