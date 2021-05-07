using EmlakOfisi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmlakOfisi.Models
{
    public class ViewModel
    {
        public User User { get; set; }
        public Property Property { get; set; }
        public List<Property> PropertyList { get; set; }
        public Adress Adress { get; set; }
    }
}