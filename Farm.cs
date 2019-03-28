using System;
using System.Collections.Generic;

namespace AtomicFarm
{
    class Farm
    {
        private List<Animal> barn;
        private Coord origin;
        private string[] graphic = new string[]
            {
                "  ▟███▙                                                              ",
                " ▟█████▙                                                             ",
                "▟███████▙                                                            ",
                " ███████  ▟████████████████████████████████████████████████████████▙ ",
                " ███████ ▟██████████████████████████████████████████████████████████▙",
                " ███████  ██████████████████████████████████████████████████████████ ",
                " ███████  ██████████████████████████████████████████████████████████ ",
                " ███████  ██████████████████████████████████████████████████████████ ",
                " ███████  ██████████████████████████████████████████████████████████ ",
                " ███████  ██████████████████████████████████████████████████████████ ",
                " ███████  ██████████████████████████████████████████████████████████ ",
                " ███████  ██████████████████████████████████████████████████████████ ",
            };

        public Farm()
        {
            SetWindowOrigin();
            InitializeFarmAnimals();
        }
        public void Run()
        {
            InitializeGraphics();
            Console.ReadKey(true);

            OneClassOneMethod();
            FourClassesOneMethod();
            FourClassesFourMethods();

            Console.ResetColor();
        }

        private void SetWindowOrigin()
        {
            var horizontalOrigin = (Console.WindowWidth / 2) - (graphic[0].Length / 2);
            var verticalOrigin = (Console.WindowHeight / 2) - (graphic.Length / 2);

            origin = new Coord(horizontalOrigin, verticalOrigin);
        }

        private void InitializeFarmAnimals()
        {
            barn = new List<Animal>
            {
                new Cow(),
                new Horse(),
                new Chicken(),
                new Goat(),
            };
        }

        private void InitializeGraphics()
        {
            PrintBarnGraphic();
            PrintTitle();
            PrintPrompt("Press ENTER to continue");
        }

        private void PrintTitle()
        {
            var title = "Welcome to the Atomic Farm!";
            var subTitle = "Generating tomorrow's animals today.";
            var offsetX = 16;
            var offsetY = 5;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(origin.X + offsetX + 4, origin.Y + offsetY);
            Console.Write(title);
            Console.SetCursorPosition(origin.X + offsetX, origin.Y + offsetY + 1);
            Console.Write(subTitle);
        }

        private void PrintBarnGraphic()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            for (var i = 0; i < graphic.Length; i++)
            {
                Console.SetCursorPosition(origin.X, origin.Y + i);
                Console.Write(graphic[i]);
            }
        }

        private void PrintPrompt(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(origin.X + 20, origin.Y + 9);
            Console.Write(prompt);
        }

        private void ResetBeforePrintingLine()
        {
            var underGraphic = origin.Y + graphic.Length + 1;

            Console.ResetColor();
            Console.SetCursorPosition(0, underGraphic);
            Write.EmptySpace(Console.WindowWidth);

            Console.SetCursorPosition(origin.X + 2, underGraphic);
        }

        private void OneClassOneMethod()
        {
            ResetBeforePrintingLine();
            new Cow().Speak();
            Console.ReadKey(true);
        }

        private void FourClassesOneMethod()
        {
            foreach (var animal in barn)
            {
                ResetBeforePrintingLine();
                animal.Race();
                Console.ReadKey(true);
            }
        }

        private void FourClassesFourMethods()
        {
            foreach (var animal in barn)
            {
                ResetBeforePrintingLine();
                animal.Speak();
                Console.ReadKey(true);
            }
            foreach (var animal in barn)
            {
                ResetBeforePrintingLine();
                animal.Feed();
                Console.ReadKey(true);
            }
            foreach (var animal in barn)
            {
                ResetBeforePrintingLine();
                animal.Race();
                Console.ReadKey(true);
            }
            foreach (var animal in barn)
            {
                ResetBeforePrintingLine();
                animal.Function();
                Console.ReadKey(true);
            }
        }
    }
}