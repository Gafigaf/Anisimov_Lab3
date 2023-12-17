using System;

namespace Lab_3_task1
{
    public partial class Plant : LivingOrganism, IReproducible
    {
        public string Species { get; set; }

        public LivingOrganism Reproduce()
        {
            if (this.Energy > 30)
            {
                this.Energy -= 30;
                return new Plant { Energy = 10, Age = 0, Size = 1, Species = this.Species };
            }
            else
            {
                throw new Exception("Not enough energy for reproduction.");
            }
        }
    }
}