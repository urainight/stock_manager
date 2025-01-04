using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_manager
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public DateTime date_added { get; set; } = DateTime.Now;
        public DateTime date_updated { get; set; } = DateTime.Now;
        public string unit { get; set; }
        public Product(int id, string name, int quantity, string unit)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.unit = unit;
        }
    }
}
