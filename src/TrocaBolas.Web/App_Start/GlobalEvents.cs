using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Events;
using Umbraco.Core.Models;
using Umbraco.Core.Publishing;
using Umbraco.Core.Services;

namespace TrocaBolas.Web.App_Start
{
    using System.Web.Optimization;

    /// <summary>
    /// Umbraco Register Events on Application Startup
    /// 
    /// Documentation
    /// http://our.umbraco.org/documentation/Reference/Events/application-startup
    /// http://our.umbraco.org/documentation/reference/events-v6/
    /// </summary>
    public class GlobalEvents : ApplicationEventHandler
    {

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
