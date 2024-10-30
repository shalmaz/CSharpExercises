namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            ShowTime(hours, minutes);
        }
        static void ShowTime(int hours, int minutes)
        {
            Console.WriteLine($"Time: {hours}:{minutes}");
        }
    }
}
