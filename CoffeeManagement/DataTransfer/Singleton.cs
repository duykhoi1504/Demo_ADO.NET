using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    internal class Singleton<T> where T : class, new()
    {
        private static T instant = null;
        public static T Instant=> instant;
    }
 
}
