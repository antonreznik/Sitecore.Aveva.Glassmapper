using Aveva.Models;
using Aveva.Models.GlassMapperModels;
using Aveva.Services;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Aveva.Web.Controllers
{
    public class HomeController : GlassController
    {
        public ActionResult GetHeader()
        {
            //Models.HeaderModel model = ViewModelsMapper.MapHeader(Sitecore.Context.Item);
            var service = new SitecoreContext();
            var model = service.GetCurrentItem<Models.GlassMapperModels.HeaderModel>();

            return View(model);
        }

        public ActionResult GetFooter()
        {
            //FooterModel model = ViewModelsMapper.MapFooter(Sitecore.Context.Item);
        
            //var service = new SitecoreContext();
            var model = this.GetContextItem<Models.GlassMapperModels.FooterModel>();
            return View(model);
        }

        public ActionResult GetData()
        {
            var service = new SitecoreContext();
            var model = service.GetCurrentItem<DataTest>();
            return View(model);
        }
    }
}