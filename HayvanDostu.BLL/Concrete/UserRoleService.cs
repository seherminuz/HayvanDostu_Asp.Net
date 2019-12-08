using HayvanDostu.BLL.Abstract;
using HayvanDostu.DAL.Concrete.EntityFramework.DAL;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Concrete
{
 
        public class UserRoleService : IUserRoleService
        {
            EFUserRoleDAL _userRoleDAL;

            public UserRoleService()
            {
                _userRoleDAL = new EFUserRoleDAL();
            }

            public bool Delete(UserRole model)
            {
                return _userRoleDAL.Delete(model) > 0;
            }

            public bool DeleteByID(int entityID)
            {
                UserRole role = Get(entityID);
                return Delete(role);
            }

            public UserRole Get(int entityID)
            {
                return _userRoleDAL.Get(a => a.ID == entityID);
            }

            public List<UserRole> GetAll()
            {
                return _userRoleDAL.GetAll().ToList();
            }

            public UserRole GetRoleByName(string name)
            {
                return _userRoleDAL.Get(a => a.RoleName == name);
            }

            public bool Insert(UserRole model)
            {
                return _userRoleDAL.Add(model) > 0;
            }

            public bool Update(UserRole model)
            {
                return _userRoleDAL.Update(model) > 0;
            }
        }
    
}
