namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oneOrder")]
    public partial class oneOrder : IEntity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public double? Price { get; set; }

        public int Quantiti { get; set; }

        public double? discount { get; set; }

        public DateTime? Ddate { get; set; }

        public long? OrderId { get; set; }

        public double FinalPrice { get; set; }
    }
}
