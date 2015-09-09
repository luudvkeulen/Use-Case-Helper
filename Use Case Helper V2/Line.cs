using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper_V2
{
    class Line : Drawing
    {
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Line(int actorselected, int X1, int Y1) : base(X1, Y1)
        {
            X2 = 83;
            switch (actorselected)
            {
                case 1:
                    Y2 = 60;
                    break;
                case 2:
                    Y2 = 210;
                    break;
                case 3:
                    Y2 = 380;
                    break;
                default:
                    Y2 = 0;
                    break;
            }
        }
    }
}
