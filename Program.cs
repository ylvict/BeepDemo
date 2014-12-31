using System;
using System.Runtime.InteropServices;
namespace Beep
{
    class BeepDemo
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);
        static void Main(string[] args)
        {
            Random random = new Random();
            while (true)
            {
                Beep(random.Next(10000), 100);
            }
        }
    }
}