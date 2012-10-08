using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion22.Models.Entities.Abstract;

namespace Lektion22.Models.Entities
{
    public class AppUser :IEntity
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmailAddress { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
    }
}