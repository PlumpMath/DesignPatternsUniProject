using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Logic.TimeObservers
{
   public abstract class AbstractTimeObserver
   {
        private int _totalTicks;
        private int currentTicks = 0;
        protected AbstractTimeObserver(int totalTicks)
        {
            _totalTicks = totalTicks;
        }

       public bool Tick()
       {
           currentTicks++;
           if (currentTicks >= _totalTicks)
           {
                Execute();
               return false;
           }
           return true;
            
       }

       protected abstract void Execute();

   }
}
