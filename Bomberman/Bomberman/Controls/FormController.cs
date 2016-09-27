using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman.GameEngine.Controls
{
    class FormController : IController
    {
        private Action OnSpacePress;

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
            }
            
        }

        public void OnWClick(Action action)
        {
            action();
        }

        public void OnDClick(Action action)
        {
            action();
        }

        public void OnAClick(Action action)
        {
            action();
        }

        public void OnBClick(Action action)
        {
            action();
        }

        public void OnSClick(Action action)
        {
            action();
        }

        public void OnSpaceClick(Action action)
        {
            OnSpacePress = action;
        }
    }
}
