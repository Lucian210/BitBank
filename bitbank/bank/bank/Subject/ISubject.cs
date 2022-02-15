using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.Subject
{
    public interface ISubject
    {
        void RegisterObserve(IObserver observer);
        void UnregisterObserve(IObserver observer);
        void NotifyObserver(String c);
    }
}
