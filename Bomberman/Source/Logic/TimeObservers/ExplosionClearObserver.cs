using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Entities;
using Bomberman.Source.Logic.Strategies;

namespace Bomberman.Source.Logic.TimeObservers
{
    public class ExplosionClearObserver : AbstractTimeObserver
    {
        private IBombExplosionStrategy _strategy;
        private Explosion _explosion;
        public ExplosionClearObserver(Explosion explosion, IBombExplosionStrategy strategy) : base(50)
        {
            _strategy = strategy;
            _explosion = explosion;
        }

        protected override void Execute()
        {
            _strategy.ClearExplosion(_explosion);
        }
    }
}
