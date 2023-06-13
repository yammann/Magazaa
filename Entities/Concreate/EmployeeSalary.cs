namespace Entities.Concreate
{
    using Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeSalary")]
    public partial class EmployeeSalary : IEntity
    {
        public int id { get; set; }

        public int EmployeeId { get; set; }

        public decimal Payment { get; set; }

        public decimal discount { get; set; }

        public DateTime SalaryDate { get; set; }

        public string Note { get; set; }

        public decimal Salary { get; set; }
    }
}
