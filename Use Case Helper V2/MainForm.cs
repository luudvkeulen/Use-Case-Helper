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
        int amountofactors = 1;
        PictureBox[] actors;

        public MainForm()
        {
            InitializeComponent();
            panelsize = pnlUseCases.Width / 3;
            actors = new PictureBox[] { actor1, actor2, actor3 };
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if(Cursor.Position.X < panelsize)
            {
                if (radioActorAdd.Checked)
                {
                    amountofactors = Actor.AddActor(amountofactors, actors);
                }
                else if (radioActorRem.Checked)
                {
                    amountofactors = Actor.RemoveActor(amountofactors, actors);
                }
            }

            else if(radioLine.Checked)
            {
                MessageBox.Show("Line");
            }

            else if (radioUseCase.Checked && (Cursor.Position.X > (panelsize * 2) ) )
            {
                MessageBox.Show("UseCase");
            }
        }
    }
}
