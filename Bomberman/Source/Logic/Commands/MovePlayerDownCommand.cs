using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Controls;

namespace Bomberman.Source.Logic.Commands
{
    public class MovePlayerDownCommand : ICommand
    {
        private Map _map;

        public MovePlayerDownCommand(Map map)
        {
            _map = map;
        }

        public void Execute()
        {
            _map.MovePlayer("down");
        }
    }
}
