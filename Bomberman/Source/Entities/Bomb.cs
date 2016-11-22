namespace Bomberman.Source.Entities
{
    public abstract class Bomb : Entity
    {
        public abstract int GetPower();
        public abstract int GetIgnitionTime();
    }
}
