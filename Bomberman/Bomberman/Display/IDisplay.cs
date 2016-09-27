using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Bomberman.GameEngine.Display
{
    public interface IDisplay
    {

        void Display();

        void SetDimentions(int width, int lenght);

        void SetColor(string code);

        void DrawBackground();

        void DrawRectangle(Rectangle destination);

        void DrawImage(string image, Rectangle source, Rectangle destination);
    }
}
