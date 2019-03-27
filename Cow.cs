using System;

namespace AtomicFarm
{
    class Cow : Animal
    {
        public override void Speak()
        {
            Console.Write("The cow says moo.");
        }

        public override void Feed()
        {
            Console.Write("The cow is hungry and wants some hay.");
        }

        public override void Function()
        {
            Console.Write("The cow makes milk and is made of beef.");
        }
    }
}