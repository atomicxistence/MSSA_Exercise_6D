using System;

namespace AtomicFarm
{
    class Chicken : Animal
    {
        public override void Speak()
        {
            Console.Write("The chicken says bok-bok");
        }

        public override void Feed()
        {
            Console.Write("The chicken eats feed.");
        }

        public override void Function()
        {
            Console.Write("The chicken makes delicious eggs and fingers");
        }

        public override void Race()
        {
            Console.Write("The chicken is much faster than it looks and leaves you winded.");
        }
    }
}