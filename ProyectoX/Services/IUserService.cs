using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoX.Domain;

namespace ProyectoX.Services
{
    public interface IUserService
    {
        void Agregar(User user);
    }

    public class UserService : IUserService
    {
        private static List<User> Users;

        public UserService()
        {
            Users = new List<User>();
        }

        public void Agregar(User user)
        {
            Users.Add(user);
        }
    }
}
