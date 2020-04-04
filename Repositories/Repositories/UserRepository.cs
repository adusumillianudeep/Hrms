using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UserRepository
    {
        private readonly HrmsEntities _dbContext;

        public UserRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public List<Users> GetUsers()
        {
            var users = _dbContext.Users.Select(u => new Model.Users
            {
                UserId = u.UserId,
                UserName = u.UserName,
                EmployeeId = u.EmployeeId.Value
            }).ToList();
            return users;
        }


        public Users SaveUser(Users user)
        {
            var userObj = _dbContext.Users.Where(u => u.UserId == user.UserId).FirstOrDefault();

            if (userObj == null)
            {
                userObj = new User();
                _dbContext.Users.Add(userObj);
                userObj.Password = user.Password;
            }

            userObj.UserName = user.UserName;
            userObj.EmployeeId = user.EmployeeId;

            _dbContext.SaveChanges();

            // clear all user roles 
            var userRoles = this._dbContext.UserRoles.Where(r => r.UserId == user.UserId);
            this._dbContext.UserRoles.RemoveRange(userRoles);

            // add new roles mapping 
            user.RoleIds.ForEach(r =>
            {
                var userRole = new UserRole();
                userRole.UserId = userObj.UserId;
                userRole.Roleid = r;
                this._dbContext.UserRoles.Add(userRole);
            });

            this._dbContext.SaveChanges();


            // clear all user regions 
            var userRegions = this._dbContext.UserRegions.Where(r => r.UserId == user.UserId);
            this._dbContext.UserRegions.RemoveRange(userRegions);

            user.UserId = userObj.UserId;

            return user;
        }
    }
}
