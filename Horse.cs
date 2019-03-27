using System;

namespace AtomicFarm
{
    class Horse : Animal
    {
        public override void Speak()
        {
            Console.Write("The horse says neigh");
        }

        public override void Feed()
        {
            Console.Write("The horse eats oats and stuff");
        }

        public override void Function()
        {
            Console.Write("The horse provides transportation and glue");
        }

        public override void Race()
        {
            Console.Write("The horse is really fast and wins. I'm not sure why you're even trying to race it.");
        }
    }
}