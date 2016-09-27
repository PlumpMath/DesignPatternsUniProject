namespace Bomberman.Source.Entities
{
    class SimpleBomb : Bomb
    {
        const int power = 1;
        public override int getPower()
        {
            return power;
        }
    }
}
