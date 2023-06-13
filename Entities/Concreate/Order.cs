namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long orderId { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        public DateTime? OrderDate { get; set; }

        public double OrderPrice { get; set; }
    }
}
