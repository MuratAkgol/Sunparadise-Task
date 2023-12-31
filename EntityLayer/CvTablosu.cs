﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CvTablosu
    {
        public int Id { get; set; }
        public string IsimSoyisim { get; set; }
        public ICollection<Deneyim>? Deneyimler { get; set; }
        public ICollection<Egitim>? Egitimler { get; set; }

        public CvTablosu()
        {
            Deneyimler = new List<Deneyim>();
            Egitimler = new List<Egitim>();
        }
    }
}
