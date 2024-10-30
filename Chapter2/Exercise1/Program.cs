using System.Numerics;

namespace Exercise1
{
    internal class Program
    {
        const int ITF = 12;
        static void Main(string[] args)
        {
            Console.Write("Enter your height in integer inches: ___\b\b\b");
            int inch = int.Parse(Console.ReadLine());
            int feet = inch/ITF;
            int inch2 = inch%ITF;
            Console.WriteLine($"Your height is {feet} feet and {inch2} inches");
        }
    }
}
