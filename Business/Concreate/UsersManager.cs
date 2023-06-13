using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class UsersManager : IUsersService
    {
        IUserDal _UserDal;

        public UsersManager(IUserDal userDal)
        {
            _UserDal = userDal;
        }

        public void Add(User user)
        {
           _UserDal.Add(user);
        }

        public void Delete(User user)
        {
            _UserDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _UserDal.GetAll();
        }

        public User GetUser(int userId)
        {
            return _UserDal.GetAll(x=>x.Id== userId).SingleOrDefault();
        }

        public User GetUserByName(string userName)
        {
           return _UserDal.GetAll(x => x.UserName == userName).SingleOrDefault() ;
        }

        public void Update(User user)
        {
           _UserDal.Update(user);
        }
    }
}
