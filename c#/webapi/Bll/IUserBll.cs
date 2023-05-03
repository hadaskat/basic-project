using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bll
{
    internal interface IUserBll
    {
        
            public List<UserDTO> post(UserDTO user);
            public List<UserDTO> getAll();
            public UserDTO getById(int id);
            public void put(int id, UserDTO user);
            public void delete(int id);
        
    }
}
