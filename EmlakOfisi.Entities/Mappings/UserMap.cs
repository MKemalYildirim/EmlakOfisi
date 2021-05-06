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
            Property(t => t.Name).IsRequired().HasMaxLength(25);
            Property(t => t.Password).IsRequired().HasMaxLength(25);

            ToTable("User");
        }

    }
}
