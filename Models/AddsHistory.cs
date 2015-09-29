using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSample.Models
{
    public class AddsHistory
    {
        public int ID { get; set; }
        public string AgeGroup { get; set; }
        public string Gender { get; set; }
        public string Region { get; set; }     
        public int Views { get; set; }
    }
}
