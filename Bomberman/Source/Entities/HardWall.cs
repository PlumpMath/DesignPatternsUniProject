namespace Bomberman.Source.Entities
{
    class HardWall : Wall
    {
        public override string getTexture()
        {
            return "HardWall";
        }

        public override string getColor()
        {
            return "#424242";
        }
    }
}
