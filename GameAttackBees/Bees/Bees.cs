using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttackBees.Bees
{
    class Bees
    {
        public int hp { get; set; }
        public bool status { get; set; }
        public string name { get; set; }

        public void Create(string name)
        {
            hp = 100;
            status = true;
            this.name = name;
        }
    }
}
