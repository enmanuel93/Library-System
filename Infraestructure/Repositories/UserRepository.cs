using Domain.Context;
using Domain.Interfaces;
using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class UserRepository : BaseRepository<Users>, IUser
    {

        public List<UserViewModel> ShowUsers(List<Users> users)
        {
            var _users = new List<UserViewModel>();

            foreach (var item in users)
            {
                _users.Add(new UserViewModel()
                {
                    ID = item.UserId,
                    Name = item.Name,
                    LastName = item.LastName,
                    UserName = item.UserName,
                    Rol = item.Rol
                });
            }

            return _users;
        }
    }
}
