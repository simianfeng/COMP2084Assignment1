namespace COMP2084Assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int PositionID { get; set; }

        public int DepartmentID { get; set; }

        public int Age { get; set; }

        public virtual Department Department { get; set; }

        public virtual Position Position { get; set; }
    }
}
