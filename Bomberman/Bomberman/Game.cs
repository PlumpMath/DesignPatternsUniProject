using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bomberman.GameEngine.Controls;
using Bomberman.GameEngine.Display;

namespace Bomberman.GameEngine
{
    class Game
    {
        [STAThread]
        public void Start()
        {
            var form = new Bomberman();
            var display = new FormDisplay(form);
            var controller = new FormController(form);
            display.SetDimentions(600, 600);
            display.SetColor("#000000");
            display.DrawBackground();

            
            var random = new Random();
            const string chars = "ABCDEF0123456789";
            

            controller.OnSpaceClick(delegate
            {
                var code = "#" + new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

                display.SetColor(code);
                display.DrawBackground();
                display.Display();
            });

            Application.EnableVisualStyles();
            Application.Run(form);


        }
    }
}
