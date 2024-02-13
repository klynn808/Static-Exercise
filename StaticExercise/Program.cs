namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConvertFahrenheitToCelsius();
            ConvertCelsiusToFahrenheit();
        }

        public static void ConvertFahrenheitToCelsius()
        {
            Console.WriteLine("Temperature to be converted to celsius: ");
            var userInput = Console.ReadLine();

            if (double.TryParse(userInput, out double fahrenheit))
            {
                var cels = TempConverter.FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"Your Fahrenheit temperature, {fahrenheit} to celsius conversion is {cels:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid temperature in Farhenheit.");
                ConvertFahrenheitToCelsius(); 
            }
        }

        public static void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine("Temperature to be converted to fahrenheit: ");
            var userInput2 = Console.ReadLine();

            if (double.TryParse(userInput2, out double celsius))
            {
                var fahr = TempConverter.CelsiusToFahrenheit(celsius);
                Console.WriteLine($"Your celsius temperature, {celsius} converted to fahrenheit: {fahr:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid temperature in Celsius.");
                ConvertCelsiusToFahrenheit(); 
            }
        }
    }
}
