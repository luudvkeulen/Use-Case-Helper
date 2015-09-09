using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Use_Case_Helper_V2
{
    public class UseCase : Drawing
    {
        public TextBox Textbox { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public string Samenvatting { get; set; }
        public string Actoren { get; set; }
        public string Aannamen { get; set; }
        public string Beschrijving { get; set; }
        public string Uitzonderingen { get; set; }
        public string Resultaat { get; set; }

        public UseCase(MainForm form, Panel pnl, int textboxes, int X1, int Y1) : base(X1, Y1)
        {
            X2 = 120;
            Y2 = 50;
            AddTextBox(form, textboxes, pnl);
        }

        private void AddTextBox(MainForm form, int textboxes, Panel pnl)
        {
            TextBox tb = new TextBox();
            this.Name = tb.Name = ("txtnr" + textboxes.ToString());
            tb.Location = new Point(X1 + 10, Y1 + 15);
            tb.Visible = true;
            tb.BorderStyle = BorderStyle.None;
            tb.TextAlign = HorizontalAlignment.Center;
            form.Controls.Add(tb);
            tb.Parent = pnl;
            //tb.BringToFront();
            this.Textbox = tb;
        }
    }
}
