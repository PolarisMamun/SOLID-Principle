using LSPDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo.Implementation
{
    public class Rectangle : Quadrilateral
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override int GetArea()
        {
            return Width * Height;
        }
    }
}
