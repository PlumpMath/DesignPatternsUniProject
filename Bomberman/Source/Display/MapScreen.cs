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
                Display.SetColor("#ffffff");
                Display.DrawRectangle(pos);
                Display.DrawImage("../../Resources/floor.png", pos);
            }
            else if (node.Entity.GetType() == typeof(SoftWall))
            {
                Display.SetColor("#2A1B0A");
                Display.DrawRectangle(pos);
                Display.DrawImage("../../Resources/rock.png", pos);
            }
            else if (node.Entity.GetType() == typeof(HardWall))
            {
                Display.SetColor("#424242");
                Display.DrawRectangle(pos);
            }
            else if (node.Entity.GetType() == typeof(Player))
            {
                Display.SetColor("#000000");
                Display.DrawRectangle(pos);
                Display.DrawImage("../../Resources/p_1_down.png", pos);
            }

            
        }

       
    }
}
