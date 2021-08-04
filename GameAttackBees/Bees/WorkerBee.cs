using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttackBees.Bees
{
    class WorkerBee : Bees
    {
        public bool SetStatus()
        {
            if (hp < 50)
            {
                return false;
            }
            return true;
        }
    }
}
