using System;

namespace Bomberman.Source.Controls
{
    interface IController
    {
        void OnWClick(Action action);
        void OnDClick(Action action);
        void OnAClick(Action action);
        void OnBClick(Action action);
        void OnSClick(Action action);
        void OnSpaceClick(Action action);


    }
}
