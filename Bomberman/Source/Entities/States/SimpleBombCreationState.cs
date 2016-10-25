using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Entities.States
{
    public class SimpleBombCreationState : IBombCreationState
    {
        public string GetBombType()
        {
            return "simple";
        }
    }
}
