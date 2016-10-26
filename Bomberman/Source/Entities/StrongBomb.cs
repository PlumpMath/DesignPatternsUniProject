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

        public override string getTexture()
        {
            return "../../Resources/bombBonus.png";
        }

        public override string getColor()
        {
            return "#000000";
        }
    }
}
