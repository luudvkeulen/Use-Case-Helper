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
        private List<Actor> actoren = new List<Actor>();
        int panelsize;

        public MainForm()
        {
            InitializeComponent();
            panelsize = pnlUseCases.Width / 3;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if(radioActor.Checked && (MousePosition.X < panelsize))
            {
                if(actoren.Count < 3)
                {
                    actoren.Add(new Actor(actoren.Count + 1));
                }
            }

            else if(radioLine.Checked)
            {
                MessageBox.Show("Line");
            }

            else if (radioUseCase.Checked && (MousePosition.X > (panelsize * 2) ) )
            {
                MessageBox.Show("UseCase");
            }
        }
    }
}
