using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Logic;

namespace Bomberman.Source.Entities.Factories
{
    class BombFactory : AbstractEntityFactory
    {
        public override Entity GetNode(string nodeType)
        {
            return GetBomb(nodeType);
        }

        public Bomb GetBomb(string bombType)
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
