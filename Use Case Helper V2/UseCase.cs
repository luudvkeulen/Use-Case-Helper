using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper_V2
{
    public class UseCase : Drawing
    {
        string Name { get; set; }

        public UseCase(int X1, int Y1) : base(X1, Y1)
        {

        }
    }
}
