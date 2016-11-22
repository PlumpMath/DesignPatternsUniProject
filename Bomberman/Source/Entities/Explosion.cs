namespace Bomberman.Source.Entities
{
    public class Explosion : Entity
    {
        public override string GetTexture()
        {
            return "Explosion";
        }

        public override string GetColor()
        {
            return "#000000";
        }

        public override bool isDestructable()
        {
            return true;
        }

        public override bool stopsExplosion()
        {
            return false;
        }
    }
}
