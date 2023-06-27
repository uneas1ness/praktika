using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace praktika
{
    public partial  class Persons
    {
       public string FirstName { get; set; }
        public   string gender { get; set; }
        public   string username { get; set; }
        public   string password { get; set; }
        [NotMapped]
        public GroupStyleSelector GroupStyleSelector { get; set; }
 
    }
}
