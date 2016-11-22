namespace Bomberman.Source.Entities
{
    class SimpleBomb : Bomb
    {
        const int Power = 2;
        const int IgnitionTime = 5;
        public override int GetPower()
        {
            return Power;
        }

        public override int GetIgnitionTime()
        {
            return IgnitionTime;
        }

        public override string GetTexture()
        {
            return "SimpleBomb";
        }

        public override string GetColor()
        {
            return "#000000";
        }
    }
}
