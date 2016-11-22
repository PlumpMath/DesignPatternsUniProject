using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bomberman.Source.Entities;
using Bomberman.Source.Logic.TimeObservers;

namespace Bomberman.Source.Logic.Strategies
{
    class SimpleBombExplosionStrategy : IBombExplosionStrategy
    {
        private readonly Map _map;
        private readonly TimeTracker _timeTracker;

        public SimpleBombExplosionStrategy(Map map, TimeTracker timeTracker)
        {
            _map = map;
            _timeTracker = timeTracker;
        }

        public void Explode(Bomb bomb)
        {
            GenerateExplosions(bomb.GetPower(), bomb.PosX, bomb.PosY);
        }

        public void Ignite(Bomb bomb)
        {
            _timeTracker.Subscibe(new BombIgnitionObserver(bomb, this));
        }

        public void ClearExplosion(Explosion explosion)
        {
            var node = _map.GetNode(explosion.PosX, explosion.PosY);
            if (node.Entity == explosion)
            {
                node.Entity = null;
            }
        }

        private void CreateExplosion(int x, int y)
        {
            var explosion = new Explosion() {PosX = x, PosY = y};
            _map.GetNode(x, y).Entity = explosion;
            _timeTracker.Subscibe(new ExplosionClearObserver(explosion, this));
        }

        private void GenerateExplosions(int size, int x, int y)
        {
            int tmp = 1;
            CreateExplosion(x, y);

            //up
            for (int i = 1; i <= size; i++)
            {
                tmp = i;
                var node = _map.GetNode(x, y + i);

                if (node != null && (node.IsEmpty() || node.Entity.isDestructable()))
                {
                    if (!node.IsEmpty() && node.Entity.stopsExplosion())
                    {
                        tmp = size+1;
                    }
                    CreateExplosion(x, y + i);
                    i = tmp;
                }
                else
                {
                    break;
                }

            }

            //down
            for (int i = 1; i <= size; i++)
            {
                tmp = i;
                var node = _map.GetNode(x, y - i);
                if (node != null && (node.IsEmpty() || node.Entity.isDestructable()))
                {
                    if (!node.IsEmpty() && node.Entity.stopsExplosion())
                    {
                        tmp = size+1;
                    }
                    CreateExplosion(x, y - i);
                    i = tmp;
                }
                else
                {
                    break;
                }

            }

            //left
            for (int i = 1; i <= size; i++)
            {
                tmp = i;
                var node = _map.GetNode(x-i, y);
                if (node != null && (node.IsEmpty() || node.Entity.isDestructable()))
                {
                    if (!node.IsEmpty() && node.Entity.stopsExplosion())
                    {
                        tmp = size + 1;
                    }
                    CreateExplosion(x-i, y);
                    i = tmp;
                }
                else
                {
                    break;
                }

            }

            //right
            for (int i = 1; i <= size; i++)
            {
                tmp = i;
                var node = _map.GetNode(x + i, y);
                if (node != null && (node.IsEmpty() || node.Entity.isDestructable()))
                {
                    if (!node.IsEmpty() && node.Entity.stopsExplosion())
                    {
                        tmp = size+1;
                    }
                    CreateExplosion(x + i, y);
                    i = tmp;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
