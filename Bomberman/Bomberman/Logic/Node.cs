using Bomberman.GameEngine.Entities;

namespace Bomberman.GameEngine.Logic
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
