using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    public class Products
    {
        
        [Key]


        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Manufacturer { get; set; }
        public bool Availability { get; set; }
        public int Price { get; set; }


    }



}

