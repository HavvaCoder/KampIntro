﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        public int Id { get; set; } //tc kimlik numarası gibi
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
