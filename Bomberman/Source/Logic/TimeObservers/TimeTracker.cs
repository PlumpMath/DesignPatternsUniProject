using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Logic.TimeObservers
{
    public class TimeTracker
    {
        private List<AbstractTimeObserver> _observers = new List<AbstractTimeObserver>();
        private List<AbstractTimeObserver> _observersBuffer = new List<AbstractTimeObserver>();

        public void Subscibe(AbstractTimeObserver observer)
        {
            _observersBuffer.Add(observer);
        }

        public void DoTick()
        {
            var notActive = new List<AbstractTimeObserver>();
            foreach (var observer in _observers)
            {
                if (!observer.Tick())
                {
                    notActive.Add(observer);
                }
            }
            notActive.ForEach(o => _observers.Remove(o));
            notActive.Clear();
            _observersBuffer.ForEach( o => _observers.Add(o));
            _observersBuffer.Clear();
        }
    }
}
