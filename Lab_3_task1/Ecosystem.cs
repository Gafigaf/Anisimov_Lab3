using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3_task1
{
    public class Ecosystem
    {
        public List<LivingOrganism> Organisms { get; set; }

        public void Simulate()
        {
            foreach (var organism in Organisms)
            {
                organism.Age += 1;
                
                organism.Energy -= 1;
                
                if (organism is IPredator predator)
                {
                    var prey = Organisms.FirstOrDefault(o => o is not IPredator);
                    if (prey != null)
                    {
                        try
                        {
                            predator.Hunt(prey);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                
                if (organism is IReproducible reproducible && organism.Energy > 50)
                {
                    try
                    {
                        var offspring = reproducible.Reproduce();
                        Organisms.Add(offspring);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                
                if (organism.Energy <= 0)
                {
                    Organisms.Remove(organism);
                }
            }
        }
    }
}