namespace Bomberman.Source.Entities
{
    public abstract class Entity
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public abstract string GetTexture();
        public abstract string GetColor();
    }
}
