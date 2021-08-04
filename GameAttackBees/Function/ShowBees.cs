using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAttackBees.Bees;

namespace GameAttackBees.Function
{
    class ShowBees
    {
        public void Output(List<Bees.Bees> Bees, int amount)
        {
            int nor = 0;
            foreach (Bees.Bees item in Bees)
            {
                Console.Write("\t" + item.name + item.hp);
                nor++;
                if (nor % ((amount + 1) / 10) == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
