using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string SoyAd { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public int CvId { get; set; }
    }
}
