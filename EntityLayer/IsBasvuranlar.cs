using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class IsBasvuranlar
    {
        public List<IsIlanı> IsIlani { get; set; }
        public List<Basvuru> BasvuruTablosu { get; set; }
        public List<CvTablosu> CvTablosu { get; set; }
        public List<Deneyim> Deneyimler { get; set; }
        public List<Egitim> Egitimler { get; set; }
        public List<User> Aday { get; set; }
    }
}
