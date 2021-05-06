using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Models
{

    public class Property : BaseEntity
    {
        public string AgentId { get; set; }
        public Agent Agent { get; set; }

        public virtual Adress Adress { get; set; }

        public int Type { get; set; }
        public int Price { get; set; }
        public int RoomRage { get; set; }
        public int BedroomRange { get; set; }
        public int BathroomRange { get; set; }
        public int HomeAge { get; set; }
        public int HomeSize { get; set; }
        public bool State { get; set; }
    }
}
