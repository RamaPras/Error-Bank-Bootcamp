using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfLogin.Models
{ [Table ("TB_T_Solution")]
   public class Solution
    {
        [Key]
        public int Id { get; set; }
        public string Solution_name { get; set; }
        public DateTimeOffset Completion_Date { get; set; }
        [ForeignKey("Employee")]
        public string NIK { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("Error_Message")]
        public int Error_Message_Id { get; set; }

    }
}
