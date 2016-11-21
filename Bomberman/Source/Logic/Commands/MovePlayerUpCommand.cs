using Bomberman.Source.Controls;

namespace Bomberman.Source.Logic.Commands
{
    public class MovePlayerUpCommand : ICommand
    {
        private Map _map;

        public MovePlayerUpCommand(Map map)
        {
            _map = map;
        }

        public void Execute()
        {
            _map.MovePlayer("up");
        }
    }
}
