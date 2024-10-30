namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a Celsius value: ");
            int cel = int.Parse(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(cel);
            Console.WriteLine($"{cel} degrees Celsius is {fahrenheit} degrees Fahrenheit");
        }
        static double CelsiusToFahrenheit(int cel)
        {
            double fahrenheit = 1.8 * cel + 32.0;
            return fahrenheit;
        }
    }
}
