using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic.BombPowerUps
{
    public class DecreasedIgnitionBomb : AbstractBombPowerUp
    {
        public const string Name = "DecresedIgnotionTime";
        public DecreasedIgnitionBomb(Bomb bomb) : base(bomb)
        {
        }

        public override string GetTexture()
        {
            return Bomb.GetTexture();
        }

        public override string GetColor()
        {
            return Bomb.GetColor();
        }

        public override int GetPower()
        {
            return Bomb.GetPower();
        }

        public override int GetIgnitionTime()
        {
            if (Bomb.GetIgnitionTime() > 1)
            {
                return Bomb.GetIgnitionTime() - 1;
            }
            return Bomb.GetIgnitionTime();
        }
    }
}
