using System;

namespace AtomicFarm
{
    static class Write
    {
        public static void EmptySpace(int fillAmount)
        {
            for( var i = 0; i < fillAmount; i++)
            {
                Console.Write(" ");
            }
        }
    }
}