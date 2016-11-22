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
        

        public MapScreen(Map map, IDisplay display, int width = 550, int lenght = 550) : base(display, width, lenght)
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
            for (int i = 0; i < _map.Lenght; i++)
            {
                for (int j = 0; j < _map.Width; j++)
                {
                    var node = _map.GetNode(i, j);
                    
                    var pos = new Rectangle(i * _nodeLenght, j * _nodeWhidth, _nodeWhidth, _nodeLenght);
                    DrawNode(node, pos);
                }
            }
            Display.Refresh();

        }

        private void DrawNode(Node node, Rectangle pos)
        {
            if (node.Entity == null)
            {
                Display.SetColor("#000000");
                Display.DrawRectangle(pos);
                //Display.DrawImage("../../Resources/floor.png", pos);
            }
            else
            {
                Display.SetColor(node.Entity.GetColor());
                Display.DrawRectangle(pos);
                Display.DrawImage(node.Entity.GetTexture(), pos);
            }


        }

       
    }
}
