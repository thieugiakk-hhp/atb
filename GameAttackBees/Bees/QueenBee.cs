using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttackBees.Bees
{
    class QueenBee : Bees
    {
        public bool SetStatus()
        {
            if (hp < 70)
            {
                return false;
            }
            return true;
        }
    }
}
