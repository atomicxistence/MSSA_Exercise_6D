using System;
using System.Collections.Generic;

namespace AtomicFarm
{
    class Farm
    {
        List<Animal> barn;

        public Farm()
        {
            InitializeFarmAnimals();
        }
        public void Run()
        {
            Console.WriteLine("Welcome to the Atomic Farm!");
            Console.WriteLine("Generating tomorrow's animals today.");
        }

        private void InitializeFarmAnimals()
        {
            barn = new List<Animal>();

        }
    }
}