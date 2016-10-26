using System;

namespace Bomberman.Source
{
    public abstract class AbstractGameEngine
    {
        [STAThread]
        public void Start()
        {
            BindControls();
            GameTimer.Instance.OnTick(MainLoop);
            GameTimer.Instance.Start();
            StartApp();

        }
        void MainLoop()
        {
            DrawScreen();
            AdvanceLogic();
        }
        protected abstract void StartApp();

        protected abstract void AdvanceLogic();

        protected abstract void DrawScreen();

        protected abstract void BindControls();
    }
}
