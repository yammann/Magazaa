namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IntOutStore")]
    public partial class IntOutStore:IEntity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int Quantiti { get; set; }

        public double ByPrice { get; set; }

        [StringLength(50)]
        public string SorceName { get; set; }

        public DateTime BusinessDate { get; set; }

        public string Note { get; set; }

        [StringLength(50)]
        public string Business { get; set; }
    }
}
