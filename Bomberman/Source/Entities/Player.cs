using System.Collections.Generic;
using System.Drawing;
using Bomberman.Source.Entities.Factories;
using Bomberman.Source.Entities.States;
using Bomberman.Source.Logic.BombPowerUps;
using Bomberman.Source.Logic.Strategies;

namespace Bomberman.Source.Entities
{
    public class Player : Entity
    {
        private List<string> _powerUps = new List<string>();
        private BombFactory _bombFactory;
        public IBombExplosionStrategy BombExplosionStrategy { get; set; }
        private Stack<Bomb> _bombs = new Stack<Bomb>();

        public IBombCreationState BomCreationState { get; set;}

        public Player(BombFactory bombFactory)
        {
            _bombFactory = bombFactory;
            BomCreationState = new SimpleBombCreationState();
        }

        public Bomb Pop()
        {
            if (_bombs.Count <= 0)
            {
                return null;
            }
            var bomb = _bombs.Pop();
            BombExplosionStrategy.Ignite(bomb);
            return bomb;
        }

        public void Push()
        {
            var type = BomCreationState.GetBombType();
            var bomb = _bombFactory.CreateBomb(type);
            _bombs.Push(ApplyPowerUps(bomb));
        }

        public override string GetTexture()
        {
            return "Player";
        }

        public override string GetColor()
        {
            return "#000000";
        }

        public void AddPowerUp(string name)
        {
            _powerUps.Add(name);
        }

        private Bomb ApplyPowerUps(Bomb target)
        {
            var result = target;
            foreach (var powerUp in _powerUps)
            {
                result = PowerUpApplier.ApplyPowerUp(powerUp, result);
            }
            return result;
        }
    }
}
