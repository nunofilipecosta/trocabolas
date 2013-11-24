using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using TrocaBolas.Web.Models;
namespace TrocaBolas.Web.Controllers
{
    
    public class MainMenuSurfaceController : SurfaceController
    {
        /// <summary>
        /// Renders the Contact Form
        /// @Html.Action("RenderMainMenu","MainMenuSurface");
        /// </summary>
        /// <returns></returns>
        public ActionResult RenderMainMenu()
        {
            return PartialView("_MainMenu", new MainMenuViewModel());
        }
    }
}
