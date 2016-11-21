using System;
using System.Drawing;
using System.Windows.Forms;
using Bomberman.Source.Entities.Factories;
using Rectangle = Bomberman.Source.Display.Rectangle;

namespace Bomberman.Source.Display
{
    class FormDisplay : IDisplay
    {
        private readonly Form _form;

        private Bitmap _image;

        private Color _color = Color.White;

        private PictureBox canvas;

        private TextureFactory _textureFacoFactory;

        public FormDisplay(Form form, TextureFactory textureFacoFactory)
        {
            _form = form;
            _form.FormBorderStyle = FormBorderStyle.FixedSingle;
            _form.MaximizeBox = false;
            _form.MinimizeBox = false;
            _textureFacoFactory = textureFacoFactory;
            var pb = new PictureBox
            {
                Dock = DockStyle.Fill
            };
            _form.Controls.Add(pb);
            canvas = pb;
            _image = new Bitmap(_form.ClientSize.Width, _form.ClientSize.Height);
            canvas.Image = _image;
        }


        public void Refresh()
        {
            canvas.Refresh();
        }

        public void SetDimentions(int width, int lenght)
        {
            _form.ClientSize = new Size(width, lenght);
            _image = new Bitmap(_form.ClientSize.Width, _form.ClientSize.Width);

        }

        public void SetColor(string code)
        {
            _color = ColorTranslator.FromHtml(code);
        }

        public void DrawBackground()
        {
            canvas.BackColor = _color;
        }

        public void DrawRectangle(Rectangle destination)
        {
            using (var g = Graphics.FromImage(_image))
            {
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(destination.X, destination.Y, destination.Width, destination.Lenght);
                g.FillRectangle(new SolidBrush(_color), rectangle);
                g.DrawRectangle(new Pen(_color), rectangle );
                canvas.Invalidate();
            }
            //throw new NotImplementedException();
        }

        public void DrawImage(string image, Rectangle destination)
        {
            using (var g = Graphics.FromImage(_image))
            { 

                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(destination.X, destination.Y, destination.Width, destination.Lenght);
                g.DrawImage(_textureFacoFactory.getTexture(image), rectangle);
                canvas.Invalidate();
            }
        }

        public void DrawText(string text, Rectangle rectangle)
        {
            using (var g = Graphics.FromImage(_image))
            {
                var font = new Font("Courier", rectangle.Width);
                var brush = new SolidBrush(_color);
                var drawFormat = new StringFormat();
                g.DrawString(text, font, brush, rectangle.X, rectangle.Y, drawFormat);
                canvas.Invalidate();

            }
        }

        public void Clear()
        {
            _image.Dispose();
            _image = new Bitmap(_form.Width, _form.Height);
            canvas.Image = _image;
        }
    }
}
