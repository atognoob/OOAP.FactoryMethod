using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Domain;

namespace lab1.Factory
{
    internal class MacbookPro14Factory : IStoreFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public MacbookPro14Factory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IStore GetMac()
        {
            MacbookPro14 mac = new MacbookPro14(_price)
            {
                Description = _description,
            };

            return (IStore)mac;
        }
    }
}
