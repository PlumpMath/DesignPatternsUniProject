using System.Collections.Generic;
using Bomberman.Source.Entities.Factories;
using Bomberman.Source.Entities.States;

namespace Bomberman.Source.Entities
{
    public class Player : Entity
    {
        
        private BombFactory _bombFactory;
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
            return _bombs.Pop();
        }

        public void Push()
        {
            var bomb = _bombFactory.CreateBomb(BomCreationState.GetBombType());
            _bombs.Push(bomb);
        }
    }
}
