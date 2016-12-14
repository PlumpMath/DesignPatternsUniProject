namespace Bomberman.Source.Entities
{
    public class SoftWall : Wall
    {
        public override string GetTexture()
        {
            return "SoftWall";
        }

        public override string GetColor()
        {
            return "#2A1B0A";
        }

        public override bool isDestructable()
        {
            return true;
        }

        public override bool stopsExplosion()
        {
            return true;
        }

        public override bool isNull()
        {
            return false;
        }
    }
}
