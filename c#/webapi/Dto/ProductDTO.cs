using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public string Desc { get; set; }
        public DateTime date { get; set; }
    }
}
