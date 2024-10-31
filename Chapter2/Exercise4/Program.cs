using System.Xml.Serialization;

namespace Exercise4
{
    internal class Program
    {
        const int HID = 24;
        const int MIH = 60;
        const int SIM = 60;
        static void Main(string[] args)
        {
            Console.Write("Enter the number of seconds: ");
            long temp, sec = long.Parse(Console.ReadLine());
            int secunds = (int)(sec % SIM);
            temp = sec / SIM;
            int minutes = (int)(temp % MIH);
            temp /= MIH;
            int hours = (int)(temp % HID);
            temp /= HID;
            int days = (int)temp;
            Console.WriteLine($"{sec} seconds = {days} days, {hours} hours, {minutes} minutes, {secunds} seconds");
        }
    }
}
