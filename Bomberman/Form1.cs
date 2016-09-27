using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman
{
    public partial class Bomberman : Form
    {
        public Bomberman()
        {
            InitializeComponent();
        }

        public void DrawIt(Graphics graphics)
        {
            
            var nodeSize = 30;
            var screenSize = 20;
            for (int i = 0; i< screenSize; i++)
            {
                graphics.DrawRectangle(Pens.Red, i*nodeSize, 0, nodeSize, nodeSize);
                graphics.DrawRectangle(Pens.Red, 0, i*nodeSize, nodeSize, nodeSize);
            }
        }

       
    }
}
