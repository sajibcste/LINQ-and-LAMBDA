using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLamda.Models
{
    public class EmployeeViewModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Enter your Name")]
        public string Name { get; set; }
        
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter your Gender")]
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> GradeId { get; set; }
        [Required(ErrorMessage = "Enter your Adress")]
        public string Address { get; set; }
        public string DepartmentName { get; set; }
    }
}