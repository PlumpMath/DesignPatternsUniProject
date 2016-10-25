using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Entities.States
{
    public class StrongBombCreationState : IBombCreationState
    {
        public string GetBombType()
        {
            return "strong";
        }
    }
}
