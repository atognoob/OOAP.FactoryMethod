using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Domain;

namespace lab1.Domain
{
    internal class MacbookAir13 : IStore
    {
        private readonly string _name;
        private readonly decimal _price;

        public MacbookAir13(decimal price)
        {
            _name = "Macbook Air 13 inch";
            _price = price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice()
        {
            return _price;
        }
    }
}
