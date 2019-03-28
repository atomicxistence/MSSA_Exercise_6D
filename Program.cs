using System;

namespace AtomicFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            new Farm().Run();
        }
    }
}