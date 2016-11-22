using System;
using System.Collections.Generic;
using System.Linq;
using Bomberman.Source.Entities;
using Bomberman.Source.Logic.Strategies;

namespace Bomberman.Source.Logic.TimeObservers
{
    public class BombIgnitionObserver : AbstractTimeObserver
    {
        private Bomb _bomb;
        private IBombExplosionStrategy _strategy;
        public BombIgnitionObserver(Bomb bomb, IBombExplosionStrategy strategy) : base(bomb.GetIgnitionTime()*50)
        {
            _bomb = bomb;
            _strategy = strategy;
        }
        protected override void Execute()
        {
            _strategy.Explode(_bomb);
        }
    }
}
