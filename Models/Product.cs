using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSample.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Specs { get; set; }
        public string ImgPath { get; set; }
        public string Price { get; set; }
        public string OfferPrice { get; set; }
        public int Views { get; set; }
    }
}
