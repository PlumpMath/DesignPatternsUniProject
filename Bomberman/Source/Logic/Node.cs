using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic
{
    public class Node
    {
        public Entity Entity { get; }

        public Node(Entity en)
        {
            Entity = en;
        }

        public bool IsEmpty()
        {
            return Entity == null;
        }
    }
}
