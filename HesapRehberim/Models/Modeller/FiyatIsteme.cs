using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace HesapRehberim.Models.Modeller
{
    [Table("FiyatIsteme")]
    public class FiyatIsteme
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(5000), Required]
        public string metin { get; set; }
        public Dictionary<string, double> Sartlar { get; set; }
        public virtual List<Kisiler> Kisiler { get; set; }
        
    }
}