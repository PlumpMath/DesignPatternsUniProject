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
            var type = BomCreationState.GetBombType();
            var bomb = _bombFactory.CreateBomb(type);
            _bombs.Push(bomb);
        }

        public override string getTexture()
        {
            return "../../Resources/p_1_down.png";
        }

        public override string getColor()
        {
            return "#000000";
        }
    }
}
