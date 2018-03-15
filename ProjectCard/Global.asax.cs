using ProjectCard.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjectCard
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            //insted of Web.Config!!!
            /*
              <contexts>
                  <context type="CardProject.DAL.Systems, CardProject">
                    <databaseInitializer type="CardProject.DAL.SystemInitializer, CardProject" />
                  </context>
                </contexts>

            <connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectCard.mdf;Initial Catalog=ProjectCard;Integrated Security=True"
      providerName="System.Data.SqlClient" />
  </connectionStrings>
             */

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Systems>());


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
