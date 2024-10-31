namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a latitude in degrees, minutes, and seconds: ");
            Console.Write("First, enter the degrees: ");
            int degrees = int.Parse(Console.ReadLine());
            Console.Write("Next, enter the minutes of arc: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Finally, enter the seconds of arc: ");
            int seconds = int.Parse(Console.ReadLine());
            double sum = (seconds/60d + minutes)/60 + degrees;
            Console.WriteLine($"{degrees} degrees, {minutes} minutes, {seconds} seconds = {sum} degrees");
        }
    }
}
