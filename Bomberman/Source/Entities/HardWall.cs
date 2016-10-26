namespace Bomberman.Source.Entities
{
    class HardWall : Wall
    {
        public override string getTexture()
        {
            return "../../Resources/rock.png";
        }

        public override string getColor()
        {
            return "#424242";
        }
    }
}
