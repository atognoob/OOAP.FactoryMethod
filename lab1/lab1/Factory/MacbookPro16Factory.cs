using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Domain;

namespace lab1.Factory
{
    internal class MacbookPro16Factory : IStoreFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public MacbookPro16Factory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IStore GetMac()
        {
            MacbookPro16 mac = new MacbookPro16(_price)
            {
                Description = _description,
            };

            return (IStore)mac;
        }
    }
}
