using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Bomberman.GameEngine;

namespace Bomberman
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
  
        static void Main()
        {
            var game = new Game();
            game.Start();
        }
    }
}
