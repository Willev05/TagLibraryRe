using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLibraryRe.ViewModel;

namespace TagLibraryRe.Model.EventArgs
{
    internal class VMEventArgs
    {
        public readonly BaseViewModel VM;

        public VMEventArgs(BaseViewModel vm)
        {
            VM = vm;
        }
    }
}
