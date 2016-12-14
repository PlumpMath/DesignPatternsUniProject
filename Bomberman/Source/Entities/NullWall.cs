using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Entities
{
    public class NullWall:Wall
    {
        public override string GetTexture()
        {
            throw new NotImplementedException();
        }

        public override string GetColor()
        {
            throw new NotImplementedException();
        }

        public override bool isDestructable()
        {
            throw new NotImplementedException();
        }

        public override bool stopsExplosion()
        {
            throw new NotImplementedException();
        }

        public override bool isNull()
        {
            return true;
        }
    }
}
