using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Logic;

namespace Bomberman.Source.Entities.Factories
{
    public class BombFactory : AbstractEntityFactory
    {
        public override Entity CreateNode(string nodeType)
        {
            return CreateBomb(nodeType);
        }

        public Bomb CreateBomb(string bombType)
        {
            switch (bombType)
            {
                case "simple":
                    return new SimpleBomb();
                default:
                    return null;
            }
        }
    }
}
