using LSPDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo.Implementation
{
    public class CalculateQuadrilateral
    {
        public int CalculateQuadrilateralArea(Quadrilateral quadrilateral)
        {
            return quadrilateral.GetArea();
        }
    }
}
