using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.GameEngine.Controls
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
