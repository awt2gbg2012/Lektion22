using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lektion22.Models.Entities;
using Lektion22.Models.Repositories.Abstract;

namespace Lektion22.Models.Repositories
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        AppUser GetUserNameByEmail(string email);
        void RegisterUser(AppUser user);
        void DeleteUserByUserName(string username);
    }

    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        public AppUserRepository() : base() { }

        public AppUser GetUserNameByEmail(string email)
        {
            return FindAll(u => u.UserEmailAddress == email).FirstOrDefault();
        }
        public void RegisterUser(AppUser user)
        {
            _dbSet.Add(user);
            _context.SaveChanges();
        }
        public void DeleteUserByUserName(string username)
        {
            var user = FindAll(u => u.UserName == username).FirstOrDefault();
            _dbSet.Remove(user);
            _context.SaveChanges();
        }
    }
}