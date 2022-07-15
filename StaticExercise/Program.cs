using StaticExercise;


Console.WriteLine("Welcome to the temperature converter!\n");


Console.WriteLine("Please enter in the degrees in fahrenheit that you would like to convert to celsius!");


Console.WriteLine(TempConverter.FahrenheitToCelsius(Convert.ToDouble(Console.ReadLine())));

Console.WriteLine("\n");


Console.WriteLine("Please enter in the degrees in celsius that you would like to convert to celsius!");


Console.WriteLine(TempConverter.CelsiusToFahrenheit(Convert.ToDouble(Console.ReadLine())));

