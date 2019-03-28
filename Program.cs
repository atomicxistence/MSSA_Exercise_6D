using System;

namespace AtomicFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            new Farm().Run();
        }
    }
}
