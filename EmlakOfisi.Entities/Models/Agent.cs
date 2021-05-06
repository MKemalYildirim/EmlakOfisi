using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Models
{

    public class Agent : BaseEntity
    {

        public string UserId { get; set; }
        public virtual User User{ get; set; }
        public virtual  Adress Adress { get; set; }
        public virtual List<Property> Properties { get; set; }

        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
