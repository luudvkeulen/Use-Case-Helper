using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper_V2
{
    public partial class MainForm : Form
    {
        int panelsize;
        PictureBox[] actors;
        Actor actor;

        public MainForm()
        {
            InitializeComponent();
            actors = new PictureBox[] { actor1, actor2, actor3 };
            actor = new Actor(actors);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            int cursorposx = Cursor.Position.X;
            if(cursorposx < (pnlUseCases.Width / 2))
            {
                if (radioActorAdd.Checked)
                {
                    actor.AddActor();
                }
                else if (radioActorRem.Checked)
                {
                    actor.RemoveActor();
                }
            }
            else
            {
                MessageBox.Show("UseCase");
            }

            if(radioLine.Checked)
            {
                MessageBox.Show("Line");
            }
        }

        private void actor1_Click(object sender, EventArgs e)
        {
            actor.SelectActor(1);
        }

        private void actor2_Click(object sender, EventArgs e)
        {
            actor.SelectActor(2);
        }

        private void actor3_Click(object sender, EventArgs e)
        {
            actor.SelectActor(3);
        }
    }
}
