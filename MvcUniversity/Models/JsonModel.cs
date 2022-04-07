using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUniversity.Models
{
    public class JsonModel
    {

        public class Options { 
            public string[] gender { get; set; }
            
            public string[] yearLevel { get; set; }
        }
    }
}
