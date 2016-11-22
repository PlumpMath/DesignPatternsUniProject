using System;
using System.CodeDom;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Bomberman.Source.Controls;
using Bomberman.Source.Display;
using Bomberman.Source.Entities.Factories;
using Bomberman.Source.Entities.States;
using Bomberman.Source.Logic;
using Bomberman.Source.Logic.Commands;
using Bomberman.Source.Logic.Strategies;
using Bomberman.Source.Logic.TimeObservers;

namespace Bomberman.Source
{
    class Game : AbstractGameEngine
    {
        private Map _map;
        public const int MaxFps = 60;
        public const int MaxTps = 60;
        private readonly TimeTracker _timeTracker = new TimeTracker();
        private Stopwatch _tpsTimer = Stopwatch.StartNew();

        private static int lastTick;
        private static int lastFrameRate;
        private static int frameRate;


        private IScreen _screen;

        private readonly Form _form;
        private readonly IDisplay _display;
        private readonly IController _controller;

        public Game(Form form)
        {
            _form = form;
            _controller = new FormController(form);
            _display = new FormDisplay(form, new TextureFactory());
            _map = new Map();
            _screen = new MapScreen(_map, _display);
            _map.GetPlayer().BombExplosionStrategy = new SimpleBombExplosionStrategy(_map, _timeTracker);
        }


        protected override void StartApp()
        {
            Application.EnableVisualStyles();
            Application.Run(_form);
        }

        protected override void DrawScreen()
        {
            var fps = GetFps();
            if (frameRate < MaxFps )
            {
                _screen.Draw();
                 DisplayFps(fps);
                frameRate++;
            }
           
        }

        protected override void AdvanceLogic()
        {
            _timeTracker.DoTick();
        }


        int GetFps()
        {
            if (System.Environment.TickCount - lastTick >= 1000)
            {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = System.Environment.TickCount;
            }
            return lastFrameRate;
        }


        void DisplayFps(int fps)
        {
            _display.SetColor("#4FFB09");
            _display.DrawText(fps.ToString(), new Rectangle(0, 0, 20, 1));
        }
        void DisplayTicks(int fps)
        {
            _display.SetColor("#4FFB09");
            _display.DrawText(fps.ToString(), new Rectangle(480, 0, 20, 1));
        }

        protected override void BindControls()
        {
            _controller.OnSpaceClick(new PlaceBombCommand(_map));
            _controller.OnWClick(new MovePlayerUpCommand(_map));
            _controller.OnSClick(new MovePlayerDownCommand(_map));
            _controller.OnAClick(new MovePlayerLeftCommand(_map));
            _controller.OnDClick(new MovePlayerRightCommand(_map));
            _controller.OnBClick(new ToggleBombTypeCommand(_map));
            _controller.OnIClick(new AddIgnitionPowerUpCommand(_map));
            _controller.OnPClick(new AddPowerPowerUpCommand(_map));
        }

    }
}
