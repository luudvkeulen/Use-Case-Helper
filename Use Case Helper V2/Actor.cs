using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper_V2
{
    class Actor : Drawing
    {
        public int Position { get; set; }

        public Actor(int position)
        {
            Position = position;
            if(Position == 1)
            {
                
            }
        }
    }
}
