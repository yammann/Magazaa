namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRrule")]
    public partial class UserRrule : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RuleId { get; set; }
    }
}
