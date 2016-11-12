using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernDB
{

    //Entry data exchange between components
    interface IEntryData
    {
        List<Object> EntryData
        {
            get;
        }
    }

    //Info string  
    interface IStringData
    {
        void StringOut(string so);
    }
}
