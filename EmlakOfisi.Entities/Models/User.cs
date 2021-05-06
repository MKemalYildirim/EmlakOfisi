using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Models
{

    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public virtual List<Agent> Agents{ get; set; }
    }
}
