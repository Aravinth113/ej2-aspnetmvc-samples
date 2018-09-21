using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult ProgressButton()
        {
            List<object> spinSettings = new List<object>();
            spinSettings.Add(new {
                position= "Right"
            });
            spinSettings.Add(new {
                position= "Top"
            });
            spinSettings.Add(new {
                position= "Bottom"
            });
            spinSettings.Add(new {
                position= "Center"
            });
            ViewBag.spinSettings = spinSettings;
            List<object> animationSettings = new List<object>();
            animationSettings.Add(new {
                effect= "SlideLeft"
            });
            animationSettings.Add(new {
                effect= "SlideRight"
            });
            animationSettings.Add(new {
                effect= "ZoomIn"
            });
            animationSettings.Add(new {
                effect= "ZoomOut"
            });
            ViewBag.animationSettings = animationSettings;
            return View();
        }
    }

}