using System.Collections.Specialized;
using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic.BombPowerUps
{
    public abstract class AbstractBombPowerUp : Bomb
    {
        
        protected Bomb Bomb;
        protected AbstractBombPowerUp(Bomb bomb)
        {
            Bomb = bomb;
        }
    }
}
