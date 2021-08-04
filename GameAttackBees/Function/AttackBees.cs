using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAttackBees.Bees;

namespace GameAttackBees.Function
{
    class AttackBees
    {
        public void Attack(List<Bees.Bees> Bees)
        {
            Random rand = new Random();
            foreach (Bees.QueenBee item in Bees.OfType<QueenBee>())
            {
                if (item.status == true)
                {
                    item.hp -= DamageRandom(rand);
                    item.status = item.SetStatus();
                    if(item.hp < 0)
                    {
                        item.hp = 0;
                    }
                }
            }

            foreach (Bees.WorkerBee item in Bees.OfType<WorkerBee>())
            {
                if (item.status == true)
                {
                    item.hp -= DamageRandom(rand);
                    item.status = item.SetStatus();
                    if (item.hp < 0)
                    {
                        item.hp = 0;
                    }
                }
            }

            foreach (Bees.MaleBee item in Bees.OfType<MaleBee>())
            {
                if (item.status == true)
                {
                    item.hp -= DamageRandom(rand);
                    item.status = item.SetStatus();
                    if (item.hp < 0)
                    {
                        item.hp = 0;
                    }
                }
            }
        }

        private int DamageRandom(Random rand)
        {
            int damage = rand.Next(0, 81);
            return damage;
        }
    }
}
