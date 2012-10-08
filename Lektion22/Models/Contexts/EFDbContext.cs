using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion22.Models.Entities;
using System.Data.Entity;

namespace Lektion22.Models.Contexts
{
    public class EFDbContext : DbContext
    {
        public DbSet<AppUser> Products { get; set; }
    }
}