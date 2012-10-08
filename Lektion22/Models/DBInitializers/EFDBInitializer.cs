using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lektion22.Models.Contexts;
using Lektion22.Models.Entities;

namespace Lektion22.Models.DBInitializers
{
    public class EFDBInitializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            
        }
    }
}