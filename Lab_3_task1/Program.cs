using System;
using System.Collections.Generic;

namespace Lab_3_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Ecosystem ecosystem = new Ecosystem
                {
                    Organisms = new List<LivingOrganism>
                    {
                        new Animal { Energy = 100, Age = 5, Size = 10, Species = "Lion" },
                        new Plant { Energy = 50, Age = 2, Size = 5, Species = "Oak" },
                        new Microorganism { Energy = 20, Age = 1, Size = 1, Species = "Bacteria" }
                    }
                };

                for (int i = 0; i < 100; i++)
                {
                    ecosystem.Simulate();
                }
            }
        }
    }
}