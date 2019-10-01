using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin.Models
{   [Table ("TB_M_Error_Message")]
    class ErrorMessage
    {
        [Key]
        public int Id { get; set; }
        public string Error_Message { get; set; }
        public string Error_Meanging { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("BootcampMaterial")]
        public int BootcampMaterial_id { get; set; }
        public BootcampMaterial BootcampMaterial { get; set; }
    }
}
