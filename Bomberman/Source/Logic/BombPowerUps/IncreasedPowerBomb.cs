using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic.BombPowerUps
{
    public class IncreasedPowerBomb : AbstractBombPowerUp
    {
        public const string Name = "IncreasedPower";
        public IncreasedPowerBomb(Bomb bomb) : base(bomb)
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
            return Bomb.GetPower() + 1;
        }

        public override int GetIgnitionTime()
        {
            return Bomb.GetIgnitionTime();
        }
    }
}
