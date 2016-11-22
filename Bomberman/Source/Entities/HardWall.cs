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
    }
}
