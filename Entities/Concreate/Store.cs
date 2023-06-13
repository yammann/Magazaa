namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store:IEntity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [StringLength(50)]
        public string productName { get; set; }

        public int ProductQuantiti { get; set; }

        [Column(TypeName = "image")]
        public byte[] Covir { get; set; }
    }
}
