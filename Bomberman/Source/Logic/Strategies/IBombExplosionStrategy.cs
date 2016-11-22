using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic.Strategies
{
    public interface IBombExplosionStrategy
    {
        void Explode(Bomb bomb);
        void Ignite(Bomb bomb);
        void ClearExplosion(Explosion explosion);
    }
}
