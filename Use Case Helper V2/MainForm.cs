using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Use_Case_Helper_V2
{
    public partial class MainForm : Form
    {
        int actorselected = 1;
        int textboxes = 0;
        PictureBox[] actors;
        Actor actor;
        List<Drawing> drawings = new List<Drawing>();

        public MainForm()
        {
            InitializeComponent();
            actors = new PictureBox[] { actor1, actor2, actor3 };
            actor = new Actor(actors);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point cursorpos = pnlUseCases.PointToClient(Cursor.Position);

            if (cursorpos.X < (pnlUseCases.Width / 2))
            {
                if (radioActorAdd.Checked)
                {
                    actor.AddActor();
                }
                else if (radioActorRem.Checked)
                {
                    actor.RemoveActor(false);
                    actorselected = 1;
                }
                return;
            }

            bool existing = false;
            UseCase usecase = null;
            foreach (Drawing drawing in drawings)
            {
                if (drawing is UseCase)
                {
                    usecase = (UseCase)drawing;
                    bool inx = (cursorpos.X > usecase.X1 && cursorpos.X < (usecase.X1 + 120));
                    bool iny = (cursorpos.Y > usecase.Y1 && cursorpos.Y < (usecase.Y1 + 50));
                    if (inx && iny)
                    {
                        existing = true;
                        break;
                    }
                }
            }

            if (radioLine.Checked)
            {
                if (existing)
                {
                    drawings.Add(new Line(actorselected, usecase.X1, usecase.Y1 + 25));
                    pnlUseCases.Refresh();
                }
            }

            else if (radioUseCase.Checked)
            {
                if (!existing)
                {
                    textboxes++;
                    drawings.Add(new UseCase(this, pnlUseCases, textboxes, (pnlUseCases.PointToClient(Cursor.Position).X) - 60, (pnlUseCases.PointToClient(Cursor.Position).Y) - 25));
                    pnlUseCases.Refresh();
                }
            }
            
            else if (radioInfo.Checked)
            {
                if (existing)
                {
                    UseCaseInfo UseCaseForm = new UseCaseInfo(usecase);
                    UseCaseForm.Show();
                }
            }
        }

        #region actor event handlers
        private void actor1_Click(object sender, EventArgs e)
        {
            actor.SelectActor(1);
            actorselected = 1;
        }

        private void actor2_Click(object sender, EventArgs e)
        {
            actor.SelectActor(2);
            actorselected = 2;
        }

        private void actor3_Click(object sender, EventArgs e)
        {
            actor.SelectActor(3);
            actorselected = 3;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Source: http://stackoverflow.com/questions/5124434/how-to-get-the-screenshot-of-the-form
            using(SaveFileDialog saveScreenshot = new SaveFileDialog())
            {
                saveScreenshot.AddExtension = true;
                saveScreenshot.DefaultExt = "png";
                saveScreenshot.Title = "Save Use Case";
                saveScreenshot.Filter = "Image(*.png)|*.*";
                if (saveScreenshot.ShowDialog() == DialogResult.OK)
                {
                    actor.SelectNoActor(); //Actors deselecteren voor een mooi plaatje
                    Rectangle bounds = pnlUseCases.Bounds;
                    Bitmap bmp = new Bitmap(pnlUseCases.Width, pnlUseCases.Height);
                    pnlUseCases.DrawToBitmap(bmp, new Rectangle(pnlUseCases.Location.X, pnlUseCases.Location.Y, bmp.Width, bmp.Height));
                    bmp.Save(saveScreenshot.FileName);
                    actor.SelectActor(1);
                }
            }
            
        }

        private void pnlUseCases_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Drawing drawing in drawings)
            {
                if(drawing is UseCase)
                {
                    UseCase usecase = (UseCase)drawing;
                    g.DrawEllipse(Pens.Black, usecase.X1, usecase.Y1, usecase.X2, usecase.Y2);
                }
                else if(drawing is Line)
                {
                    Line line = (Line)drawing;
                    g.DrawLine(Pens.Black, line.X2, line.Y2, line.X1, line.Y1);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            drawings.Clear();
            pnlUseCases.Refresh();
            actor.RemoveActor(true);
            actorselected = 1;
            for(int i = 1; i <= textboxes; i++)
            {
                string textboxname = "txtnr" + i.ToString();
                Control txt = Controls[textboxname];
                Controls.Remove(txt);
            }
        }
    }
}
