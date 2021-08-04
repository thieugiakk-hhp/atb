using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAttackBees.Bees;

namespace GameAttackBees.Function
{
    class CreateBees
    {
        public void Create(List<Bees.Bees> Bees, int amount)
        {
            Bees.Bees qB;
            Bees.Bees wB;
            Bees.Bees mB;

            int q = 1, w = 1, m = 1;

            Random rand = new Random();

            while (Bees.Count <= amount)
            {
                int n = rand.Next(3, 6);

                if (n % 3 == 0 && q <= (amount + 1) / 3)
                {
                    qB = new Bees.QueenBee();
                    qB.Create("Q");
                    Bees.Add(qB);
                    q++;
                }

                if (n % 3 == 1 && w <= (amount + 1) / 3)
                {
                    wB = new Bees.WorkerBee();
                    wB.Create("W");
                    Bees.Add(wB);
                    w++;
                }

                if (n % 3 == 2 && m <= (amount + 1) / 3)
                {
                    mB = new Bees.MaleBee();
                    mB.Create("M");
                    Bees.Add(mB);
                    m++;
                }
            }
        }
    }
}
