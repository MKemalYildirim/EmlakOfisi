using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmlakOfisi.Entities
{
    public class GetPropModel : BaseEntity
    {
        public List<string> TypeList { get; set; }
        public List<string> CountryList { get; set; }
        public List<string> CountyList { get; set; }
        public List<string> CityList { get; set; }
        public int MaxPrice { get; set; }
        public int MinPrice { get; set; }
        public int MaxSize { get; set; }
        public int MinSize { get; set; }
        public int MaxRoomRage { get; set; }
        public int MinRoomRage { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public DateTime MaxDate { get; set; }
        public DateTime MinDate { get; set; }
    }
}