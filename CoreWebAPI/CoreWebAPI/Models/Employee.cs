using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string  Ename { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Emp_ID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Department { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }
    }
}
