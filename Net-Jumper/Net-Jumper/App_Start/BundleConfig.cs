using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Net_Jumper.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            var googleFontCdn = "http://fonts.googleapis.com/css?family=Open+Sans:300,600,800";

            bundles.Add(new StyleBundle("~/admin/styles", googleFontCdn)
              .Include("~/content/styles/bootstrap.css")
              .Include("~/content/styles/site.css"));

            bundles.Add(new ScriptBundle("~/scripts")
              .Include("~/scripts/jquery-2.2.1.js")
              .Include("~/scripts/jquery.validate.unobtrusive.js")
              .Include("~/scripts/bootstrap.js")
              .Include("~/scripts/jquery.validate.js"));
        }

    }
}