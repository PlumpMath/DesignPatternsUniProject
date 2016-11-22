using Bomberman.Source.Controls;

namespace Bomberman.Source.Logic.Commands
{
    public class MovePlayerRightCommand : ICommand
    {
        private Map _map;

        public MovePlayerRightCommand(Map map)
        {
            _map = map;
        }

        public void Execute()
        {
            _map.MovePlayer("right");
        }
    }
}
