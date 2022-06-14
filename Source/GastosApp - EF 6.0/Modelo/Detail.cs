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
    [Table("Details")]
    public class Detail
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Name")]
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }

        [DisplayName("typeId")]        
        public int typeId { get; set; }

        [DisplayName("Daily")]
        public bool Daily { get; set; }

        [DisplayName("State")]
        public bool State { get; set; }

        [ForeignKey("typeId")]
        public virtual Type Type { get; set; }
        public virtual ICollection<Movement> Movements { get; set; }
    }
}
