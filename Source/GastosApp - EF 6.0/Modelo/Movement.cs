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
    [Table("Movements")]
    public class Movement
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("detailId")]
        public int detailId { get; set; }

        [DisplayName("Amount")]
        public Double Amount { get; set; }

        [DisplayName("Month")]
        [Column(TypeName = "varchar(10)")]
        public string Month { get; set; }

        [DisplayName("Year")]
        public int Year { get; set; }

        [ForeignKey("detailId")]
        public virtual Detail Detail { get; set; }
    }
}
