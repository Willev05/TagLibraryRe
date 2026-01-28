using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLibraryRe.Model.Stores
{
    internal class StateStore
    {
        private static StateStore _instance;
        private StateStore() { }

        public static StateStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StateStore();
                }

                return _instance;
            }
        }

        private bool _isLibraryLoaded = false;
        public bool IsLibraryLoaded { get { return _isLibraryLoaded; } set { _isLibraryLoaded = value; } }
    }
}
