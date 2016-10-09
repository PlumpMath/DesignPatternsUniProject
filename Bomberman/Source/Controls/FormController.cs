using System;
using System.Windows.Forms;

namespace Bomberman.Source.Controls
{
    class FormController : IController
    {
        private Action OnSpacePress;
        private Action OnWPress;
        private Action OnSPress;
        private Action OnAPress;
        private Action OnDPress;

        private Form _form;

        public FormController(Form form)
        {
            _form = form;
            _form.KeyPress += OnKeyPress;
        }

        void OnKeyPress(object sender, KeyPressEventArgs e)
        {
           
            switch (e.KeyChar)
            {
                case ' ':
                    OnSpacePress();
                    e.Handled = true;
                    break;
                case 'w':
                    OnWPress();
                    e.Handled = true;
                    break;
                case 's':
                    OnSPress();
                    e.Handled = true;
                    break;
                case 'a':
                    OnAPress();
                    e.Handled = true;
                    break;
                case 'd':
                    OnDPress();
                    e.Handled = true;
                    break;
            }
            
        }

        public void OnWClick(Action action)
        {
            OnWPress = action;
        }

        public void OnDClick(Action action)
        {
             OnDPress = action;
        }

        public void OnAClick(Action action)
        {
            OnAPress = action;
        }

        public void OnBClick(Action action)
        {
            OnSpacePress = action;
        }

        public void OnSClick(Action action)
        {
            OnSPress = action;
        }

        public void OnSpaceClick(Action action)
        {
            OnSpacePress = action;
        }
    }
}
