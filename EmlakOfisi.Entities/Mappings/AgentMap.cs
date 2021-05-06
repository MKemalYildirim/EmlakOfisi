using EmlakOfisi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Mappings
{
    public class AgentMap : BaseEntityMap<Agent>
    {
        public AgentMap()
        {
            HasRequired(t => t.User).WithMany(T => T.Agents) .HasForeignKey(t => t.UserId).WillCascadeOnDelete(false);
            HasRequired(t => t.Adress).WithRequiredDependent().WillCascadeOnDelete(false);

            Property(t => t.UserName).IsOptional().HasMaxLength(25);
            Property(t => t.Password).IsOptional().HasMaxLength(25);
            Property(t => t.CompanyName).IsOptional().HasMaxLength(75);





            ToTable("Agent");
        }
    }
}
