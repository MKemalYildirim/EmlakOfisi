using EmlakOfisi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Mappings
{
   public class PropertyMap:BaseEntityMap<Property>
    {
        public PropertyMap()
        {
            HasRequired(t => t.Adress).WithRequiredDependent().WillCascadeOnDelete(false);

            ToTable("Property");
        }
    }
}
