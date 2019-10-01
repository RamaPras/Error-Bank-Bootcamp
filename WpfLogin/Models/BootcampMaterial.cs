using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin.Models
{
    [Table("TB_M_Bootcamp_Material")]

    class BootcampMaterial
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public bool IsDeleted { get; set; }
                
    }
}
