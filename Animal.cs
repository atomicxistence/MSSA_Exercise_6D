using System;

namespace AtomicFarm
{
    abstract class Animal
    {
        public virtual void Speak()
        {
            Console.Write("This animal has nothing to say.");
        }

        public virtual void Feed()
        {
            Console.Write("This animal doesn't eat anything");
        }

        public virtual void Function()
        {
            Console.Write("This animal has no function.");
        }

        public virtual void Race()
        {
            Console.Write("This animal doesn't move.");
        }
    }
}