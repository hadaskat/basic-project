using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public interface IUserDal
    {
       public List<User> GetAllUsers();
       public List<User> AddUser(User user);
       public void UpdateUser(int Id, User user);
       public void DeleteUser(int Id);
       public User GetUserById(int Id);
    }
}
