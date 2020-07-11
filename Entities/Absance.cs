//--------------- Code de la classe Location ---------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities
{
    public class Absance
    {
        [Key]
        public string Num_Abs { get; set; }
        [ForeignKey("Module")]
        public string codeModule { get; set; }
        [ForeignKey("Etudient")]
        public string num_Etud { get; set; }
        public string dateabs { get; set; }

        public string absTP { get; set; }
        public string absCours { get; set; }



        public virtual Etudient Etudient { get; set; }
        public virtual Module Module { get; set; }
    }
}