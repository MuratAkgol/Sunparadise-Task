using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Egitim
    {
        public int Id { get; set; }
        public string Lise { get; set; }
        public string? Universite { get; set; }
        public string? Bolum { get; set; }
        [ForeignKey("CvTablosu")]
        public int CvTablosuId { get; set; }
        public CvTablosu CvTablosu { get; set; }
    }
}
