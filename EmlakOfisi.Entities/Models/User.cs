using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Models
{

    public class User : BaseEntity
    {

        public virtual  Adress Adress { get; set; }
        public virtual List<Property> Properties { get; set; }
        [DisplayName("Firma İsmi")]
        [Required]
        public string CompanyName { get; set; }
        [DisplayName("Kullanıcı Adı")]
        [Required]

        public string UserName { get; set; }
        [DisplayName("Şifre")]
        [Required]

        public string Password { get; set; }
    }
}
