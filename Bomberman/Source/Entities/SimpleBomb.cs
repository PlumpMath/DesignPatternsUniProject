namespace Bomberman.Source.Entities
{
    class SimpleBomb : Bomb
    {
        const int Power = 1;
        public override int GetPower()
        {
            return Power;
        }

        public override string getTexture()
        {
            return "SimpleBomb";
        }

        public override string getColor()
        {
            return "#000000";
        }
    }
}
