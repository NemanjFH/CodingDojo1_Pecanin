using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1
{
    class StackElement
    {
        public Person ValueOfElement { get; set; }
        public StackElement Successor { get; set; }
    }
}
