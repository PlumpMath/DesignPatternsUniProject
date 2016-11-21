﻿using System;
using System.CodeDom;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Bomberman.Source.Controls;
using Bomberman.Source.Display;
using Bomberman.Source.Entities.States;
using Bomberman.Source.Logic;
using Bomberman.Source.Logic.Commands;

namespace Bomberman.Source
{
    class Game : AbstractGameEngine
    {
        private Map _map;
        public const int MaxFps = 60;
        public const int MaxTps = 60;
        private Stopwatch _fpsTimer = Stopwatch.StartNew();
        private Stopwatch _tpsTimer = Stopwatch.StartNew();
        private int _fpsCounter = 0;
        private int _tpsCounter = 0;


        private IScreen _screen;

        private readonly Form _form;
        private readonly IDisplay _display;
        private readonly IController _controller;

        public Game(Form form)
        {
            _form = form;
            _controller = new FormController(form);
            _display = new FormDisplay(form);
            _map = new Map();
            _screen = new MapScreen(_map, _display);
        }


        protected override void StartApp()
        {
            Application.EnableVisualStyles();
            Application.Run(_form);
        }

        protected override void DrawScreen()
        {
            var fps = GetFps();
            if (_fpsCounter < MaxFps)
            {
                _screen.Draw();
                DisplayFps(_fpsCounter);
                _fpsCounter++;
            }
           
        }

        protected override void AdvanceLogic()
        {

        }


        int GetFps()
        {
            var time = _fpsTimer.ElapsedMilliseconds + 1;
            int fps = (int) (1000 * (_fpsCounter / time));
            if (time > 1000)
            {
                _fpsCounter = 0;
                _fpsTimer.Reset();
                _fpsTimer.Start();
                
            }
            return fps;
        }

        void DisplayFps(int fps)
        {
            _display.SetColor("#4FFB09");
            _display.DrawText(fps.ToString(), new Rectangle(0, 0, 20, 1));
        }

        protected override void BindControls()
        {
            _controller.OnSpaceClick(new PlaceBombCommand(_map));
            _controller.OnWClick(new MovePlayerUpCommand(_map));
            _controller.OnSClick(new MovePlayerDownCommand(_map));
            _controller.OnAClick(new MovePlayerLeftCommand(_map));
            _controller.OnDClick(new MovePlayerRightCommand(_map));
            _controller.OnBClick(new ToggleBombTypeCommand(_map));
        }

    }
}
