using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime date { get; set; }

        public virtual ICollection<Product> Products { get;set; }
    }
}
