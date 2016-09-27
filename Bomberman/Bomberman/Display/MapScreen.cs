using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.GameEngine.Logic;

namespace Bomberman.GameEngine.Display
{
    class MapScreen : AbstractScreen
    {
        private Map _map;

        private int _nodeWhidth;
        private int _nodeLenght;

        public MapScreen(Map map, IDisplay display, int width = 600, int lenght = 600) : base(display, width, lenght)
        {
            this._map = map;
            Display.SetDimentions(width, lenght);
            _nodeLenght = lenght / map.Lenght;
            _nodeWhidth = width/map.Width;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
