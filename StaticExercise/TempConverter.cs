using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double farenheit) 
        {
            return ((farenheit - 32.0) * 0.5556);
        }

        public static double CelsiusToFarenheit(double celsius)
        {
            return ((celsius * 1.8) + 32.0);
        }
    }
}
