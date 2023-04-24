namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a value in degrees Farenheit to convert to Celsius");
            var fInput = double.Parse(Console.ReadLine());

            var celsius = TempConverter.FahrenheitToCelsius(fInput);
            Console.WriteLine(celsius);
            Console.WriteLine();

            Console.WriteLine("Enter a value in degrees Celsius to convert to Farenheit");
            var cInput = double.Parse(Console.ReadLine());

            var farenheit = TempConverter.CelsiusToFarenheit(cInput);
            Console.WriteLine(farenheit);

            //TempConverter.FahrenheitToCelsius(fInput);
            //Console.WriteLine($"{fInput}° Farenheit = {}° Celsius");
            //Console.WriteLine();

            //Console.WriteLine("Enter a value in Celsius to convert to Farenheit");
            //var cInput = double.Parse(Console.ReadLine());

            ////TempConverter.CelsiusToFarenheit(0);
            //Console.WriteLine($"{cInput}° Celsius = {TempConverter.CelsiusToFarenheit(cInput)}° Farenheit");
        }
    }
}
