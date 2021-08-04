using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAttackBees.Bees;
using GameAttackBees.Function;

namespace GameAttackBees
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("\n0.End Battle\t\t1. Create\t\t2. Attacks\t\t3. Print Infomation");
        }

        static void Main(string[] args)
        {
            List<Bees.Bees> Bees = new List<Bees.Bees>();
            ShowBees showBees = new ShowBees();

            int amount = 89;

            int choose;
            do
            {
                Menu();
                Console.Write("Please Choose Number: ");
                choose = int.Parse(Console.ReadLine());
                Console.WriteLine("Request: Confirmed");
                Console.WriteLine();

                switch (choose)
                {
                    case 1:
                        CreateBees createBees = new CreateBees();
                        createBees.Create(Bees, amount);

                        Console.WriteLine("Status: Created");
                        showBees.Output(Bees, amount);
                        break;
                    case 2:
                        Function.AttackBees attackBees = new AttackBees();
                        attackBees.Attack(Bees);

                        Console.WriteLine("Status: Attacked");
                        showBees.Output(Bees, amount);
                        break;
                    case 3:
                        Console.WriteLine("\nInfomation: ");
                        PrintInfomation printInfomation = new PrintInfomation();
                        printInfomation.Print(Bees);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (choose != 0);
        }
    }
}
