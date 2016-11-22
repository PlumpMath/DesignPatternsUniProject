using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic.BombPowerUps
{
    public class PowerUpApplier
    {
        public static Bomb ApplyPowerUp(string powerup, Bomb bomb)
        {
            switch (powerup)
            {
                case IncreasedPowerBomb.Name:
                    return new IncreasedPowerBomb(bomb);

                case DecreasedIgnitionBomb.Name:
                    return new DecreasedIgnitionBomb(bomb);

                default:
                    return bomb;
            }
        }
    }
}
