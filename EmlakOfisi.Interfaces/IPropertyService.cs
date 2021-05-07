using EmlakOfisi.Entities;
using EmlakOfisi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Interfaces
{
    public interface IPropertyService : IGenericService<Property>
    {
        List<Property> Filter(GetPropModel entity,List<Property> All);
    }
}
