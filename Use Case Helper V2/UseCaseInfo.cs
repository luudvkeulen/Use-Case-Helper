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
    public partial class UseCaseInfo : Form
    {
        UseCase UC { get; set; }
        public UseCaseInfo(UseCase uc)
        {
            InitializeComponent();
            UC = uc;
            tbNaam.Text = uc.Textbox.Text;
            tbBeschrijving.Text = uc.Beschrijving;
            tbActors.Text = uc.Actoren;
            tbAannamen.Text = uc.Aannamen;
            tbSamenv.Text = uc.Samenvatting;
            tbResultaat.Text = uc.Resultaat;
            tbUitzondering.Text = uc.Uitzonderingen;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            UC.Beschrijving = tbBeschrijving.Text;
            UC.Actoren = tbActors.Text;
            UC.Aannamen = tbAannamen.Text;
            UC.Samenvatting = tbSamenv.Text;
            UC.Resultaat = tbResultaat.Text;
            UC.Uitzonderingen = tbUitzondering.Text;
            Close();
        }
    }
}
