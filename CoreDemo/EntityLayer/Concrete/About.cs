using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutDetaıls1 { get; set;}
        public string AboutDetaıls2 { get; set;}
        public string AboutImages1 { get; set;}
        public string AboutImages2 { get; set;}
        public string AboutImages3 { get; set;}
    }
}
