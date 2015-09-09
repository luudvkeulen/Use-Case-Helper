using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper_V2
{
    public class Actor
    {
        PictureBox[] Actors { get; set; }
        int amountofactors;
        public Actor(PictureBox[] actors)
        {
            Actors = actors;
            amountofactors = 1;
        }
        public void AddActor()
        {
            switch (amountofactors)
            {
                case 1:
                    Actors[1].Visible = true;
                    Actors[1].Enabled = true;
                    amountofactors++;
                    break;
                case 2:
                    Actors[2].Visible = true;
                    Actors[2].Enabled = true;
                    amountofactors++;
                    break;
            }
        }
        public void RemoveActor(bool all)
        {
            if (all)
            {
                Actors[1].Visible = false;
                Actors[1].Enabled = false;
                Actors[2].Visible = false;
                Actors[2].Enabled = false;
                SelectActor(1);
                amountofactors = 1;
            }
            else
            {
                switch (amountofactors)
                {
                    case 2:
                        Actors[1].Visible = false;
                        Actors[1].Enabled = false;
                        amountofactors--;
                        SelectActor(1);
                        break;
                    case 3:
                        Actors[2].Visible = false;
                        Actors[2].Enabled = false;
                        amountofactors--;
                        SelectActor(1);
                        break;
                }
            }
        }

        public void SelectActor(int i)
        {
            string actor = "actor";
            foreach(PictureBox picture in Actors)
            {
                if (picture.Name == actor + i.ToString())
                {
                    picture.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    picture.BorderStyle = BorderStyle.None;
                }
            }
        }

        public void SelectNoActor()
        {
            foreach(PictureBox picture in Actors)
            {
                picture.BorderStyle = BorderStyle.None;
            }
        }
    }
}
