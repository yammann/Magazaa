using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class UserRuleManager : IUserRuleService
    {
        IUserRruleDal _usaerRule;
        public UserRuleManager(IUserRruleDal usaerRule) 
        { 
            _usaerRule = usaerRule;
        }
        public void Add(UserRrule userRrule)
        {
            _usaerRule.Add(userRrule);
        }

        public void Delete(UserRrule userRrule)
        {
            _usaerRule.Delete(userRrule);
        }

        public List<UserRrule> GetAll()
        {
            return _usaerRule.GetAll();
        }

        public UserRrule GetUser(int userId)
        {
            return _usaerRule.GetAll(x=> x.UserId == userId).SingleOrDefault();
        }

        public void Update(UserRrule userRrule)
        {
            _usaerRule.Update(userRrule);
        }
    }
}
