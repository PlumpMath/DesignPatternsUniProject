using System.Windows.Forms;

namespace Bomberman.Source.Display
{
    public interface IDisplay
    {

        void Refresh();

        void SetDimentions(int width, int lenght);

        void SetColor(string code);

        void DrawBackground();

        void DrawRectangle(Rectangle destination);

        void DrawImage(string image, Rectangle source, Rectangle destination);

        void DrawText(string text, Rectangle rectangle);

        void Clear();
    }
}
