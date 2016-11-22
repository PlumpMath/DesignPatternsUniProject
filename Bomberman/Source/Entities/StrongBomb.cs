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
        const int IgnitionTime = 3;
        public override int GetPower()
        {
            return power;
        }

        public override int GetIgnitionTime()
        {
            return IgnitionTime;
        }

        public override string GetTexture()
        {
            return "StrongBomb";
        }

        public override string GetColor()
        {
            return "#000000";
        }

        public override bool isDestructable()
        {
            return false;
        }

        public override bool stopsExplosion()
        {
            return false;
        }
    }
}
