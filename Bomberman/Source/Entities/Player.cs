using System.Collections.Generic;

namespace Bomberman.Source.Entities
{
    public class Player : Entity
    {
        private Stack<Bomb> _bombs = new Stack<Bomb>();
        public int X { get; set; }
        public int Y { get; set; }

        public Bomb Pop()
        {
            return _bombs.Pop();
        }

        public void Push(Bomb bomb)
        {
            _bombs.Push(bomb);
        }
    }
}
