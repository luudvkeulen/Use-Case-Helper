using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper_V2
{
    public abstract class Drawing
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }

        public Drawing(int X1, int Y1)
        {
            this.X1 = X1;
            this.Y1 = Y1;
        }
    }
}
