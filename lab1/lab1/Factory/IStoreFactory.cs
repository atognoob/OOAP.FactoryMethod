using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Domain;

namespace lab1.Factory
{
    internal abstract class IStoreFactory
    {
        public abstract IStore GetMac();
        
    }
}
