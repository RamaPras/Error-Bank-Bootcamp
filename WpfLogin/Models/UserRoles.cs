using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin.Models
{
    [Table ("TB_User_Roles")]
    class UserRoles
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey ("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
        [ForeignKey ("Roles")]
        public int Roles_Id { get; set; }
        public Roles Roles { get; set; }
    }
}
