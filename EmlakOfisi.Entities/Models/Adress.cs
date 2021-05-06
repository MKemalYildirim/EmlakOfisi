using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Models
{
    public class Adress : BaseEntity
    {


        [DisplayName("Ülke")]
        public string Country { get; set; }
        [DisplayName("İl")]
        public string City { get; set; }
        [DisplayName("İlçe")]
        public string County { get; set; }
        [DisplayName("Tam Adres")]
        public string FullArdress { get; set; }

    }

}
