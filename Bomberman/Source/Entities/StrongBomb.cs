using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Entities
{
    class StrongBomb : Bomb
    {
        const int power = 3;
        public override int GetPower()
        {
            return power;
        }
    }
}
