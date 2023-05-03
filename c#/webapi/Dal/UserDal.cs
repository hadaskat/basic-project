using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class UserDal : IUserDal
    {
        public Delivery delivery;
        public UserDal(Delivery Delivery)
        {
            this.delivery = Delivery;
        }
         
        public  List<User>  AddUser(User user)
        {
            delivery.Users.Add(user);
            delivery.SaveChanges();
            return GetAllUsers();
        }

        public void DeleteUser(int userId)
        {
            var user = delivery.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                delivery.Users.Remove(user);
                delivery.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            return delivery.Users.ToList();
        }


        public User GetUserById(int userId)
        {
            return delivery.Users.FirstOrDefault(p => p.Id == userId);
        }


        public void UpdateUser(int Id,User user)
        {
            delivery.Users.Update(user);
            delivery.SaveChanges();
        }

       
    }

}
    

