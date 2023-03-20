using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    public class Employee <Tgen>
    {
        
        public List<Tgen> Things { get; set; }
    }
}
