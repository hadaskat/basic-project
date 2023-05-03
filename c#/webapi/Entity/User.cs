using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class User
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Password { get; set; }
        public string Adress { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public bool Isprincipal { get; set; }


    }
}
