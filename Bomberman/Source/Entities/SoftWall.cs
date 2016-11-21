namespace Bomberman.Source.Entities
{
    public class SoftWall : Wall
    {
        public override string getTexture()
        {
            return "SoftWall";
        }

        public override string getColor()
        {
            return "#2A1B0A";
        }
    }
}
