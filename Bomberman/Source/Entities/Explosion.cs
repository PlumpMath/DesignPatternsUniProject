namespace Bomberman.Source.Entities
{
    public class Explosion : Entity
    {
        public override string getTexture()
        {
            return "../../Resources/explosion.png";
        }

        public override string getColor()
        {
            return "#000000";
        }
    }
}
