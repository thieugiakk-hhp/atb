using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttackBees.Bees
{
    class MaleBee : Bees
    {
        public bool SetStatus()
        {
            if (hp < 20)
            {
                return false;
            }
            return true;
        }
    }
}
