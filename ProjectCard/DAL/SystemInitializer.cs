using ProjectCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCard.DAL
{
    public class SystemInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Systems>
    {
        protected override void Seed(Systems context)
        {
          
        }
    }
}