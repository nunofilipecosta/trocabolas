

namespace TrocaBolas.Web
{
    using System;
    using DependencyInjection;
    using Umbraco.Web;

    public class Global : UmbracoApplication
    {
        protected override void OnApplicationStarting(object sender, EventArgs e)
        {
            base.OnApplicationStarting(sender, e);

            NinjectWebCommon.Start();
        }

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);
        }
    }
}