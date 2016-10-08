using System;
using System.Linq;
using Bomberman.Source.Logic;

namespace Bomberman.Source.Display
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
            Display.SetColor("#000000");
            Display.DrawBackground();
            

            Display.Refresh();

            _nodeLenght = lenght / map.Lenght;
            _nodeWhidth = width/map.Width;

        }

        public override void Draw()
        {

            
            Display.Clear();
            Display.Refresh();
        }
    }
}
