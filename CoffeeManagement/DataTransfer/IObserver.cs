using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public interface IObserver
    {
        void OnNotify(string key);
    }
}