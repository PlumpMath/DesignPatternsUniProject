using System;

namespace Bomberman.Source.Controls
{
    interface IController
    {
        void OnWClick(ICommand command);
        void OnDClick(ICommand command);
        void OnAClick(ICommand command);
        void OnBClick(ICommand command);
        void OnSClick(ICommand command);
        void OnSpaceClick(ICommand command);
        void OnIClick(ICommand command);
        void OnPClick(ICommand command);


    }
}
