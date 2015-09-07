using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper_V2
{
    class Line : Drawing
    {
        int X2 { get; set; }
        int Y2 { get; set; }
        public Line(int X1, int Y1, int X2, int Y2) : base(X1, Y1)
        {
            this.X2 = X2;
            this.Y2 = Y2;
        }
    }
}
