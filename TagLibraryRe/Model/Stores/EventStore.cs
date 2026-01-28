using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLibraryRe.Model.Stores
{
    
    internal class EventStore
    {
        private static EventStore _instance;
        private EventStore() {}

        public static EventStore Instance { 
            get { 
                if (_instance == null)
                {
                    _instance = new EventStore();
                }

                return _instance; 
            } 
        }
    }
}
