using System;

namespace AtomicFarm
{
    class Goat : Animal
    {
        public override void Feed()
        {
            Console.Write("The goat will eat anything.");
        }

        public override void Speak()
        {
            Console.Write("The goat says blee");
        }

        public override void Race()
        {
            Console.Write("The goat is not as fast as you but finds a shortcut by climbing over the barn.");
        }
    }
}