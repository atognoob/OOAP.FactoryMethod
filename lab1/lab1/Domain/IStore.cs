using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Domain
{
    internal interface IStore
    {
        string Name { get; }
        string Description { get; set; }
        decimal GetPrice();
    }
}
