using System;

namespace Lab_3_task1
{
    public class Microorganism : LivingOrganism, IReproducible
    {
        public string Species { get; set; }

        public LivingOrganism Reproduce()
        {
            if (this.Energy > 10)
            {
                this.Energy -= 10;
                return new Microorganism { Energy = 5, Age = 0, Size = 1, Species = this.Species };
            }
            else
            {
                throw new Exception("Not enough energy for reproduction.");
            }
        }
    }
}