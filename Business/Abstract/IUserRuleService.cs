using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserRuleService
    {
        void Add(UserRrule userRrule);
        void Delete(UserRrule userRrule);
        List<UserRrule> GetAll();
        void Update(UserRrule userRrule);
        UserRrule GetUser(int userId);
    }
}
