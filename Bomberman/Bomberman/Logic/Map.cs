namespace Bomberman.GameEngine.Logic
{
    public class Map
    {
        public int Lenght { get; }
        public int Width { get; }

        private Node[,] nodes;

        public Map(int lenght = 10, int width = 10) {
            Lenght = lenght;
            Width = width;
            nodes = new Node[width, lenght];
        }



    }
}
