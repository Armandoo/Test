﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honeymoonshop.Models
{
    public class Product
    {
        
        public int id { get; set; }
        public int artikelnummer { get; set; }
        public int prijs { get; set; }
        public Merk merk { get; set; }
        public Category categorie { get; set; }
        public virtual List<Kleurproduct> kleuren { get; set; }
        public virtual List<Kenmerkproduct> kenmerken { get; set; }
        public List<ProductImage> afbeeldingen { get; set; }
        public string omschrijving { get; set; }

    }
}
