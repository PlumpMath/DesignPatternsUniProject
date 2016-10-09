using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic
{
    public class Node
    {
        private Entity entity {get; set;}

        public Node(Entity en)
        {
            entity = en;
        }

        public bool isEmpty()
        {
            return entity == null;
        }
    }
}
