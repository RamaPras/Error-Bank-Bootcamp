using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin.Models
{
    [Table ("TB_M_User")]
    public class User 
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("Employee")]
        public string NIK { get; set; }
        public Employee Employee { get; set; } 

    }
}
