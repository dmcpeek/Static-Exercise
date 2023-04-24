namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double farenheitTemp = 32;
            var celsius = TempConverter.FahrenheitToCelsius(32); // Expect 0° returned
            Console.WriteLine($"{farenheitTemp}° Farenheit = {celsius}° Celsius");

            double celsiusTemp = 0;
            var farenheit = TempConverter.CelsiusToFarenheit(0); // Expect 32° returned
            Console.WriteLine($"{celsiusTemp}° Celsius = {farenheit}° Farenheit");
        }
    }
}
