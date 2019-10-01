using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin.Models
{
    [Table ("TB_M_Employee")]
   public  class Employee
    {
        [Key]
        public string NIK { get; set; }
        public string First_name { get; set; }
        public string Last_name{ get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Personal_Email { get; set; }

       
    }
}
