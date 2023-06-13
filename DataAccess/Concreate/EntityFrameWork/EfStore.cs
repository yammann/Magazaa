using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DataAccess.Concreate.EntityFrameWork
{

    public class EfStore : EfEntityRepositoryBase<Store, StoreContext>, IStoreDal
    {

    }
}
