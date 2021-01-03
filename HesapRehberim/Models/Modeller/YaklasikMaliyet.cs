using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapRehberim.Models.Modeller
{
    [Table("YaklasikMaliyet")]
    public class YaklasikMaliyet
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100), Required]
        public string konu{ get; set; }
        [StringLength(1000), Required]
        public string metin { get; set; }
        [Required]
        public virtual IsTanimi IsTanimi { get; set; }
        public virtual List<Malzeme> Malzemeler { get; set; }
    }

}