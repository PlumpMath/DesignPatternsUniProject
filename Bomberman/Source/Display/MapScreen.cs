using System;
using System.Linq;
using Bomberman.Source.Entities;
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
            
            Display.SetColor("#40A76B");
            for (int i = 0; i < _map.Lenght; i++)
            {
                for (int j = 0; j < _map.Width; j++)
                {
                    var node = _map.getNode(i, j);
                    DrawNode(node);
                    Rectangle rectangle = new Rectangle(i* _nodeLenght/2, j*_nodeWhidth/2, _nodeWhidth, _nodeLenght);
                    Display.DrawRectangle(rectangle);
                }
            }
            //Display.DrawBackground();
            Display.Refresh();

        }

        void DrawNode(Node node)
        {
            if (node.Entity == null)
            {
                Display.SetColor("#0101DF");
            }
            else if (node.Entity.GetType() == typeof(SoftWall))
            {
                Display.SetColor("#2A1B0A");                    
            }
            else if (node.Entity.GetType() == typeof(HardWall))
            {
                Display.SetColor("#424242");
            }

            
        }
    }
}
