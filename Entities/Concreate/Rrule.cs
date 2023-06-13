namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rrule")]
    public partial class Rrule : IEntity
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string RuleName { get; set; }
    }
}
