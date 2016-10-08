using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic
{
    public class Node
    {
        private Entity entity {get; set;}

        public Node()
        {
            entity = null;
        }

        public bool isEmpty()
        {
            return entity == null;
        }
    }
}
