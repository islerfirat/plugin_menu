using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Menu.Models;
using PluginContracts;

namespace MVC_Menu.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult PluginMenuGet()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            Dictionary<string, IPlugin> _plugin = new Dictionary<string, IPlugin>();
            PluginLoader<IPlugin> loader = new PluginLoader<IPlugin>("../WFA_Menu/bin/Debug/Plugins");
            IEnumerable<IPlugin> plugins = loader.Plugins;
            foreach (var item in plugins)
            {
                _plugin.Add("menu", item);
            }
            IPlugin plugin = _plugin["menu"];
            dic["menu"] = plugin.MenuTitle;
            return Json(dic, JsonRequestBehavior.AllowGet);
        }

    }
}
