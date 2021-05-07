using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Models
{

    public class Property : BaseEntity
    {
        public string AgentId { get; set; }
        public User Agent { get; set; }

        public virtual Adress Adress { get; set; }
        [DisplayName("Tipi")]
        public string Type { get; set; }
        [DisplayName("Açıklama")]
        public string Desc { get; set; }
        [DisplayName("Tarih")]
        public DateTime Date { get; set; }
        [DisplayName("Ücret")]
        public int Price { get; set; }
        [DisplayName("Oda Sayısı")]
        public int RoomRage { get; set; }
        [DisplayName("Yatak Odası")]
        public int BedroomRange { get; set; }
        [DisplayName("Banyo")]
        public int BathroomRange { get; set; }
        [DisplayName("Bina Yaşı")]
        public int HomeAge { get; set; }
        [DisplayName("Bina Büyüklüğü")]
        public int HomeSize { get; set; }
        [DisplayName("Durumu")]
        public bool State { get; set; } = true;


    }
}
