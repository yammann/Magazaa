using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUsersService
    {
        void Add(User user);
        void Delete(User user);
        List<User> GetAll();
        User GetUserByName(string userName);
        void Update(User user);
        User GetUser(int userId);
     
    }
}
