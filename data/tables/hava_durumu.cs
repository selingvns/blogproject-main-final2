using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.tables
{
    public class hava_durumu
    {
        [Key]
        public int id {get;set;}
        public int derece {get;set;}
        public int nem_orani {get;set;}
        public string il {get;set;}
        
    }
}