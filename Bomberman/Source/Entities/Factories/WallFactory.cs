using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Entities.Factories
{
    class WallFactory : AbstractEntityFactory
    {
        public override Entity GetNode(string nodeType)
        {
            return GetWall(nodeType);
        }

        public Wall GetWall(string wallType)
        {
            switch (wallType)
            {
                case "hard":
                    return new HardWall();
                case "soft":
                    return new SoftWall();
                default:
                    return null;
            }
        }
    }
}
