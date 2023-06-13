namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product : IEntity
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? Quantiti { get; set; }

        public decimal? Price { get; set; }

        [Column(TypeName = "image")]
        public byte[] Covir { get; set; }
    }
}
