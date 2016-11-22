using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Controls;
using Bomberman.Source.Logic.BombPowerUps;

namespace Bomberman.Source.Logic.Commands
{
    class AddIgnitionPowerUpCommand : ICommand
    {
        private Map _map;

        public AddIgnitionPowerUpCommand(Map map)
        {
            _map = map;
        }

        public void Execute()
        {
            _map.GetPlayer().AddPowerUp(DecreasedIgnitionBomb.Name);
        }
    }
}
