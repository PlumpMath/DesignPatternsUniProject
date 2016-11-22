using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Controls;
using Bomberman.Source.Logic.BombPowerUps;

namespace Bomberman.Source.Logic.Commands
{
    public class AddPowerPowerUpCommand : ICommand
    {
        private Map _map;

        public AddPowerPowerUpCommand(Map map)
        {
            _map = map;
        }

        public void Execute()
        {
            _map.GetPlayer().AddPowerUp(IncreasedPowerBomb.Name);
        }
    }
}
