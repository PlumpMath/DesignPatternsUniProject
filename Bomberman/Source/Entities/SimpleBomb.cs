namespace Bomberman.Source.Entities
{
    class SimpleBomb : Bomb
    {
        const int Power = 1;
        public override int GetPower()
        {
            return Power;
        }
    }
}
