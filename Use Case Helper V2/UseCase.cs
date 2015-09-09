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
        TextBox Textbox { get; set; }
        string Name { get; set; }
        string Text { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public UseCase(MainForm form,int textboxes, int X1, int Y1) : base(X1, Y1)
        {
            X2 = 120;
            Y2 = 50;
            AddTextBox(form, textboxes);
        }

        private void AddTextBox(MainForm form, int textboxes)
        {
            TextBox tb = new TextBox();
            this.Name = tb.Name = ("txtnr" + textboxes.ToString());
            tb.Location = new Point(X1 + 20, Y1 + 85);
            tb.Visible = true;
            tb.BorderStyle = BorderStyle.None;
            tb.TextAlign = HorizontalAlignment.Center;
            form.Controls.Add(tb);
            tb.BringToFront();
            this.Textbox = tb;
        }
    }
}
