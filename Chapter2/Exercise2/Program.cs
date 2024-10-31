namespace Exercise2
{
    internal class Program
    {
        const int ITF = 12;
        const double ITM = 0.0254;
        const double PTK = 2.2;
        static void Main(string[] args)
        {
            Console.Write("Enter your height, feet: ");
            int feet = int.Parse(Console.ReadLine());
            Console.Write("inches: ");
            int inch = int.Parse(Console.ReadLine());
            Console.Write("Enter your weight in pounds: ");
            int pounds = int.Parse(Console.ReadLine());
            int ich2 = feet * ITF + inch;
            double heightInMeters = ich2 * ITM;
            double weightInKilograms = pounds / PTK;
            double BMI = weightInKilograms / Math.Pow(heightInMeters, 2);
            Console.WriteLine($"Your BMI is {BMI}");
        }
    }
}
