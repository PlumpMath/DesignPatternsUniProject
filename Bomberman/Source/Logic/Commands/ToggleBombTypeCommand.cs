using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman.Source.Controls;
using Bomberman.Source.Entities.States;

namespace Bomberman.Source.Logic.Commands
{
    public class ToggleBombTypeCommand : ICommand
    {
        private Map _map;

        public ToggleBombTypeCommand(Map map)
        {
            _map = map;
        }

        public void Execute()
        {
            if (_map.GetPlayer().BomCreationState.GetType() == typeof(StrongBombCreationState))
            {
                _map.GetPlayer().BomCreationState = new SimpleBombCreationState();
            }
            else
            {
                _map.GetPlayer().BomCreationState = new StrongBombCreationState();
            }
        }
    }
}
