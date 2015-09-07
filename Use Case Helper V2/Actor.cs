using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper_V2
{
    public static class Actor
    {
        public static int AddActor(int amount, PictureBox[] actors)
        {
            switch (amount)
            {
                case 1:
                    actors[1].Visible = true;
                    return 2;
                case 2:
                    actors[2].Visible = true;
                    return 3;
                default:
                    return amount;
            }
        }
        public static int RemoveActor(int amount, PictureBox[] actors)
        {
            switch (amount)
            {
                case 2:
                    actors[1].Visible = false;
                    return 1;
                case 3:
                    actors[2].Visible = false;
                    return 2;
                default:
                    return amount;
            }
        }
    }
}
