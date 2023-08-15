using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Deneyim
    {
        //[Key]
        //public int Id { get; set; }
        //public string FirmaAdi { get; set; }
        //public string Pozisyon { get; set; }
        //public DateTime Baslama { get; set; }
        //public DateTime Bitis { get; set; }
        //public string IsTanimi { get; set; }
        //[ForeignKey("CvTablosu")]
        //public CvTablosu CvTablosuId { get; set; }
       
            [Key]
            public int Id { get; set; }
            public string FirmaAdi { get; set; }
            public string Pozisyon { get; set; }
            public DateTime Baslama { get; set; }
            public DateTime Bitis { get; set; }
            public string IsTanimi { get; set; }

            // CvTablosuId özelliğini [ForeignKey] niteliği ile belirtin
            [ForeignKey("CvTablosu")]
            public int CvTablosuId { get; set; }
            public CvTablosu CvTablosu { get; set; }
        

    }
}
