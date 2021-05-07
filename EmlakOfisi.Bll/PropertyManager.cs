using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using EmlakOfisi.Entities.Models;
using EmlakOfisi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Bll
{
    public class PropertyManager : GenericManager<Property>, IPropertyService
    {
        IGenericRepository<Property> genericRepository;


        public PropertyManager(IGenericRepository<Property> genericRepository) : base(genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        public List<Property> Filter(GetPropModel PropModel, List<Property> PropList)
        {

            if (PropModel.CountryList != null)
            {
                var NewList = new List<Property>();
                PropModel.CountryList.ForEach(country => NewList.AddRange(PropList.FindAll(x => x.Adress.Country == country)));
                PropList = NewList;

            }
            if (PropModel.TypeList != null)
            {
                var NewList = new List<Property>();
                PropModel.TypeList.ForEach(type => NewList.AddRange(PropList.FindAll(x => x.Type == type)));
                PropList = NewList;

            }
            if (PropModel.CityList != null)
            {
                var NewList = new List<Property>();
                PropModel.CityList.ForEach(city => NewList.AddRange(PropList.FindAll(x => x.Adress.City == city)));
                PropList = NewList;

            }
            if (PropModel.CountyList != null)
            {
                var NewList = new List<Property>();
                PropModel.CountyList.ForEach(county => NewList.AddRange(PropList.FindAll(x => x.Adress.County == county)));
                PropList = NewList;

            }
            if (PropModel.MaxAge != 0 || PropModel.MinAge != 0)
            {
                var NewList = new List<Property>();
                NewList.AddRange(PropList.FindAll(x => x.HomeAge <= PropModel.MaxAge && x.HomeAge >= PropModel.MinAge));
                PropList = NewList;
            }
            if (PropModel.MaxDate != default(DateTime) || PropModel.MinDate != default(DateTime))
            {
                var NewList = new List<Property>();
                NewList.AddRange(PropList.FindAll(x => x.Date < PropModel.MaxDate && x.Date < PropModel.MinDate));
                PropList = NewList;
            }
            if (PropModel.MaxPrice != 0 || PropModel.MinPrice != 0)
            {
                var NewList = new List<Property>();
                NewList.AddRange(PropList.FindAll(x => x.Price < PropModel.MaxPrice && x.Price < PropModel.MinPrice));
                PropList = NewList;
            }
            if (PropModel.MaxRoomRage != 0 || PropModel.MinRoomRage != 0)
            {
                var NewList = new List<Property>();
                NewList.AddRange(PropList.FindAll(x => x.RoomRage < PropModel.MaxRoomRage && x.RoomRage < PropModel.MinRoomRage));
                PropList = NewList;
            }
            if (PropModel.MaxSize != 0 || PropModel.MinSize != 0)
            {
                var NewList = new List<Property>();
                NewList.AddRange(PropList.FindAll(x => x.HomeSize < PropModel.MaxSize && x.HomeSize > PropModel.MinSize));
                PropList = NewList;
            }


            return PropList;
        }
    }
}
