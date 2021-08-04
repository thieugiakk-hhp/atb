using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAttackBees.Bees;

namespace GameAttackBees.Function
{
    class PrintInfomation
    {

        public void Print(List<Bees.Bees> Bees)
        {
            int alive = NumberOfBeesAlive(Bees);
            int dead = 100 - NumberOfBeesAlive(Bees);
            Console.WriteLine("Alive: " + alive + " - Dead: " + dead);

            Infomation(Bees);
        }

        private void Infomation(List<Bees.Bees> Bees)
        {
            int qBAlive = NumberOfQBAlive(Bees);
            int wBAlive = NumberOfWBAlive(Bees);
            int mBAlive = NumberOfMBAlive(Bees);

            int q = 1, w = 1, m = 1;

            Console.WriteLine("\n______________\n");
            Console.WriteLine("Queen Bee: " + qBAlive + " Alive");
            Console.WriteLine("______________");
            foreach (Bees.QueenBee item in Bees.OfType<QueenBee>())
            {
                Console.Write(q + ". HP: " + item.hp + " - Status: " + SetStatus(item) + "\t");
                q++;
                if ((q - 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n______________\n");
            Console.WriteLine("Worker Bee: " + wBAlive + " Alive");
            Console.WriteLine("______________");
            foreach (Bees.WorkerBee item in Bees.OfType<WorkerBee>())
            {
                Console.Write(w + ". HP: " + item.hp + " - Status: " + SetStatus(item) + "\t");
                w++;
                if ((w - 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n______________\n");
            Console.WriteLine("Male Bee: " + mBAlive + " Alive");
            Console.WriteLine("______________");
            foreach (Bees.MaleBee item in Bees.OfType<MaleBee>())
            {
                Console.Write(m + ". HP: " + item.hp + " - Status: " + SetStatus(item) + "\t");
                m++;
                if ((m - 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        private String SetStatus(Bees.Bees bees)
        {
            if (bees.status == true)
            {
                return "Alive";
            }
            return "Dead";
        }

        private int NumberOfBeesAlive(List<Bees.Bees> Bees)
        {
            int count = 0;
            foreach (Bees.Bees item in Bees)
            {
                if (item.status == true)
                {
                    count++;
                }
            }
            return count;
        }

        private int NumberOfQBAlive(List<Bees.Bees> Bees)
        {
            int count = 0;
            foreach (Bees.QueenBee item in Bees.OfType<QueenBee>())
            {
                if (item.status == true)
                {
                    count++;
                }
            }
            return count;
        }

        private int NumberOfWBAlive(List<Bees.Bees> Bees)
        {
            int count = 0;
            foreach (Bees.WorkerBee item in Bees.OfType<WorkerBee>())
            {
                if (item.status == true)
                {
                    count++;
                }
            }
            return count;
        }

        private int NumberOfMBAlive(List<Bees.Bees> Bees)
        {
            int count = 0;
            foreach (Bees.MaleBee item in Bees.OfType<MaleBee>())
            {
                if (item.status == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
