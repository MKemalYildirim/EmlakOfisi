using EmlakOfisi.Bll;
using EmlakOfisi.Dal.Concrete.EntityFramework.Repository;
using EmlakOfisi.Entities;
using EmlakOfisi.Entities.Models;
using EmlakOfisi.Interfaces;
using EmlakOfisi.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakOfisi.Controllers
{
    [Authorize(Roles = "Agent")]
    public class HomeController : Controller
    {
        ViewModel vm = new ViewModel();
        IGenericService<User> GUserService = new GenericManager<User>(new EfGenericRepository<User>());
        IPropertyService PropertyService = new PropertyManager(new EfGenericRepository<Property>());
        IGenericService<Adress> GAdressService = new GenericManager<Adress>(new EfGenericRepository<Adress>());
        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            vm.User = GUserService.GettAll(x => x.Id == id).FirstOrDefault();
            vm.PropertyList = TempData["PropList"]!=null? TempData["PropList"] as List<Property>: PropertyService.GettAll(x => x.AgentId == id);

            return View(vm);
        }

        [HttpPost]
        public ActionResult EditProp(Property Property)
        {
            vm.Property = PropertyService.GettAll(x => x.Id == Property.Id).FirstOrDefault();
            return PartialView("_PropPartial", vm);
        }
        [HttpGet]
        public ActionResult DeleteProp(Property Property)
        {
            PropertyService.Remove(x => x.Id == Property.Id);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult AddOrUpdate(Property Property)
        {
            Property.Date = Property.Date == default(DateTime) ? DateTime.Now : Property.Date;
            Property.AgentId = User.Identity.GetUserId();
            Property.Id = Property.Id == null ? Guid.NewGuid().ToString() : Property.Id;
            Property.Adress.Id = Property.Adress.Id == null ? Property.Id : Property.Adress.Id;
            PropertyService.Update(Property);
            GAdressService.Update(Property.Adress);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult GetProp(GetPropModel PropModel)
        {
        

            var UserId = User.Identity.GetUserId();
            List<Property> PropList = PropertyService.GettAll(x => x.AgentId == UserId);
            PropList = PropertyService.Filter(PropModel, PropList);

            vm.User = GUserService.GettAll(x => x.Id == UserId).FirstOrDefault();
            TempData["PropList"] = PropList;

            return RedirectToAction("Index");
        }

    }
}