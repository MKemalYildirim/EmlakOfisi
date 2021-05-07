using EmlakOfisi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Mappings
{
    public class UserMap : BaseEntityMap<User>
    {
        public UserMap()
        {
            HasRequired(t => t.Adress).WithRequiredDependent().WillCascadeOnDelete(false);

            Property(t => t.UserName).IsOptional().HasMaxLength(25);
            Property(t => t.Password).IsOptional().HasMaxLength(25);
            Property(t => t.CompanyName).IsRequired().HasMaxLength(75);

            ToTable("User");
        }
    }
}
