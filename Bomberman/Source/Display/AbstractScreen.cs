namespace Bomberman.Source.Display
{
    public abstract class AbstractScreen : IScreen
    {
        protected IDisplay Display;
        public int Lenght { get; set; }
        public int Whidth { get; set; }

        protected AbstractScreen(IDisplay display, int width = 40, int lenght = 40)
        {
            Display = display;
            Lenght = lenght;
            Whidth = width;
        }

        public abstract void Draw();
    }
}
