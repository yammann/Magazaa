namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    

    [Table("Employee")]
    public partial class Employee: IEntity
    {
        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        public string Adress { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? StartDate { get; set; }

        public string Phone { get; set; }

        public bool? EmployeeState { get; set; }

        public decimal? Salary { get; set; }

        [Column(TypeName = "image")]
        public byte[] Employeeİmage { get; set; }
    }
}
