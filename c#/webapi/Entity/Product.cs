using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public string Desc { get; set; }
        public DateTime date { get; set; }
        //public virtual Order Orders { get; set; }    
    }
}
