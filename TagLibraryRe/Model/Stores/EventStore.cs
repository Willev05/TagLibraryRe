using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLibraryRe.Model.EventArgs;
using TagLibraryRe.ViewModel;

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

        public event EventHandler<VMEventArgs> ChangeMainVM;
        public void InvokeChangeMainVM(BaseViewModel vm)
        {
            ChangeMainVM?.Invoke(null, new VMEventArgs(vm));
        }
    }
}
