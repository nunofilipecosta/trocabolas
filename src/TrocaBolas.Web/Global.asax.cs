

namespace TrocaBolas.Web
{
    using System;
    
    using Umbraco.Web;

    public class Global : UmbracoApplication
    {
        protected override void OnApplicationStarting(object sender, EventArgs e)
        {
            //NinjectWebCommon.Start();

            base.OnApplicationStarting(sender, e);
            
        }

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);
        }
    }
}