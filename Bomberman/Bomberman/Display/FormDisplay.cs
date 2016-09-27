using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bomberman.GameEngine.Display
{
    class FormDisplay : IDisplay
    {
        private readonly Bomberman _form;

        private Color color = Color.White;

        private PictureBox canvas;

        public FormDisplay(Bomberman form)
        {
            _form = form;
            _form.FormBorderStyle = FormBorderStyle.FixedSingle;
            _form.MaximizeBox = false;
            _form.MinimizeBox = false;
            var pb = new PictureBox
            {
                Dock = DockStyle.Fill
            };
            _form.Controls.Add(pb);
            canvas = pb;
        }


        public void Display()
        {
            canvas.Refresh();
        }

        public void SetDimentions(int width, int lenght)
        {
            _form.Size = new Size(width, lenght);
        }

        public void SetColor(string code)
        {
            color = ColorTranslator.FromHtml(code);
        }

        public void DrawBackground()
        {
            canvas.BackColor = color;
        }

        public void DrawRectangle(Rectangle destination)
        {
            throw new NotImplementedException();
        }

        public void DrawImage(string image, Rectangle source, Rectangle destination)
        {
            throw new NotImplementedException();
        }
    }
}
