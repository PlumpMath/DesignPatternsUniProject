using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Logic;
using Microsoft.SqlServer.Server;

namespace Bomberman.Source.Entities.Factories
{
    public abstract class AbstractEntityFactory
    {
        public abstract Entity GetNode(string nodeType);

        public static AbstractEntityFactory CreateEntityFactory(string factoryType)
        {
            switch (factoryType)
            {
                case "bomb":
                    return new BombFactory();
                case "wall":
                    return new WallFactory();
                default:
                    return null;
            }
        }

    }
}
