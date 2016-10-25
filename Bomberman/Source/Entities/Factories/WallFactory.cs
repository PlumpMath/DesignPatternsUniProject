using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Entities.Factories
{
    public class WallFactory : AbstractEntityFactory
    {
        public override Entity CreateNode(string nodeType)
        {
            return CreateWall(nodeType);
        }

        public Wall CreateWall(string wallType)
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
