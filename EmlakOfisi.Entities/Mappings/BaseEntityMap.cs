using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Entities.Mappings
{
    public abstract class BaseEntityMap<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        protected BaseEntityMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasMaxLength(128).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
