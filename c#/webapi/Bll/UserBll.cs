using AutoMapper;
using Dal;
using Dto;
using Entity;

namespace Bll
{
    internal class UserBll : IUserBll
    {

        IUserDal userDal;
        IMapper mapper;
        public UserBll(IUserDal userDal, IMapper mapper)
        {
            this.userDal = userDal;
            this.mapper = mapper;
        }
        public void delete(int id)
        {
            userDal.DeleteUser(id);
        }

        public List<UserDTO> getAll()
        {
            return mapper.Map<List<UserDTO>>(this.userDal.GetAllUsers());
        }

        public UserDTO getById(int id)
        {
            return mapper.Map<UserDTO>(this.userDal.GetUserById(id));
        }

        public List<UserDTO> post(UserDTO user)
        {
            return mapper.Map<List<UserDTO>>(userDal.AddUser(mapper.Map<User>(user)));
        }

        public void put(int id, UserDTO user)
        {
            userDal.UpdateUser(id, mapper.Map<User>(user));
        }
    }
}
