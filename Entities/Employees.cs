using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace Entities
{
    public partial class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        public int? DepartmentID { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        [StringLength(50)]
        public string EmployeeSurname { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public string DepartmentName { get; set; }

        public override string ToString()
        {       
            return String.Format("{0} {1} {2} {3} {4} {5} {6}", EmployeeID, DepartmentID, EmployeeName, EmployeeSurname, Address, Email, DepartmentName);      
    }
    } 
}


   
