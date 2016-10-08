namespace Bomberman.Source.Logic
{
    public class Map
    {
        public int Lenght { get; }
        public int Width { get; }

        private Node[,] nodes;

        public Map(int width = 10, int lenght = 10) {
            Lenght = lenght;
            Width = width;
            nodes = new Node[width, lenght];
        }



    }
}
