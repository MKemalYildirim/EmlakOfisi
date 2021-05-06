using EmlakOfisi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Mappings
{
   public class AdressMap:BaseEntityMap<Adress>
    {
        public AdressMap()
        {
            Property(t => t.City).IsOptional().HasMaxLength(50);
            Property(t => t.Country).IsOptional().HasMaxLength(50);
            Property(t => t.County).IsOptional().HasMaxLength(50);
            Property(t => t.FullArdress).IsOptional();


            ToTable("Adress");
        }
    }
}
