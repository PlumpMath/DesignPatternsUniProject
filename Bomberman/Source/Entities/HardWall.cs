namespace Bomberman.Source.Entities
{
    class HardWall : Wall
    {
        public override string GetTexture()
        {
            return "HardWall";
        }

        public override string GetColor()
        {
            return "#424242";
        }

        public override bool isDestructable()
        {
            return false;
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
