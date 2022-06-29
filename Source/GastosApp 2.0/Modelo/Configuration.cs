using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Configurations")]
    public class Configuration
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Language")]
        [Column(TypeName = "varchar(30)")]
        public string Language { get; set; }
    }
}
