using LSPDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo.Implementation
{
    public class Square : Quadrilateral
    {
        public int Size { get; set; }
        public override int GetArea()
        {
            return Size * Size;
        }
    }
}
