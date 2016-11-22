using System;
using System.Windows.Forms;

namespace Bomberman.Source.Controls
{
    class FormController : IController
    {
        private ICommand OnSpacePress;
        private ICommand OnWPress;
        private ICommand OnSPress;
        private ICommand OnAPress;
        private ICommand OnDPress;
        private ICommand OnBPress;
        private ICommand OnIPress;
        private ICommand OnPPress;

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
                    OnSpacePress.Execute();
                    e.Handled = true;
                    break;
                case 'w':
                    OnWPress.Execute();
                    e.Handled = true;
                    break;
                case 's':
                    OnSPress.Execute();
                    e.Handled = true;
                    break;
                case 'a':
                    OnAPress.Execute();
                    e.Handled = true;
                    break;
                case 'd':
                    OnDPress.Execute();
                    e.Handled = true;
                    break;
                case 'b':
                    OnBPress.Execute();
                    e.Handled = true;
                    break;
                case 'p':
                    OnPPress.Execute();
                    e.Handled = true;
                    break;
                case 'i':
                    OnIPress.Execute();
                    e.Handled = true;
                    break;
            }
            
        }

        public void OnWClick(ICommand command)
        {
            OnWPress = command;
        }

        public void OnDClick(ICommand command)
        {
             OnDPress = command;
        }

        public void OnAClick(ICommand command)
        {
            OnAPress = command;
        }

        public void OnBClick(ICommand command)
        {
            OnBPress = command;
        }

        public void OnSClick(ICommand command)
        {
            OnSPress = command;
        }

        public void OnSpaceClick(ICommand command)
        {
            OnSpacePress = command;
        }

        public void OnIClick(ICommand command)
        {
            OnIPress = command;
        }

        public void OnPClick(ICommand command)
        {
            OnPPress = command;
        }
    }
}
