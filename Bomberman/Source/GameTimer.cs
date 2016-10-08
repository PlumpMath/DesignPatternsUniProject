using System;
using System.Windows.Forms;

namespace Bomberman.Source
{
    public class GameTimer
    {
        private static GameTimer _instance;
        private Timer _timer;

        public static GameTimer Instance => _instance ?? (_instance = new GameTimer());


        private GameTimer()
        {
            _timer = new Timer {Interval = 10};
        }

        public void OnTick(Action action)
        {
            _timer.Tick += delegate { action(); };
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }


    }
}
