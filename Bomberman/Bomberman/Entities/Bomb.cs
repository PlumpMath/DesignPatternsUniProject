using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.GameEngine.Entities;

namespace Bomberman.GameEngine
{
    public abstract class Bomb : Entity
    {
        abstract public int getPower();
    }
}
