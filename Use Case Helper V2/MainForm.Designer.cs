namespace Use_Case_Helper_V2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUseCases = new System.Windows.Forms.Panel();
            this.actor2 = new System.Windows.Forms.PictureBox();
            this.actor3 = new System.Windows.Forms.PictureBox();
            this.actor1 = new System.Windows.Forms.PictureBox();
            this.grpElementen = new System.Windows.Forms.GroupBox();
            this.radioActorRem = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioActorAdd = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlUseCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor1)).BeginInit();
            this.grpElementen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUseCases
            // 
            this.pnlUseCases.BackColor = System.Drawing.Color.White;
            this.pnlUseCases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUseCases.Controls.Add(this.actor2);
            this.pnlUseCases.Controls.Add(this.actor3);
            this.pnlUseCases.Controls.Add(this.actor1);
            this.pnlUseCases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUseCases.Location = new System.Drawing.Point(9, 64);
            this.pnlUseCases.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUseCases.Name = "pnlUseCases";
            this.pnlUseCases.Size = new System.Drawing.Size(704, 433);
            this.pnlUseCases.TabIndex = 0;
            this.pnlUseCases.Click += new System.EventHandler(this.panel1_Click);
            // 
            // actor2
            // 
            this.actor2.BackColor = System.Drawing.Color.White;
            this.actor2.Enabled = false;
            this.actor2.Image = global::Use_Case_Helper_V2.Properties.Resources.actor;
            this.actor2.Location = new System.Drawing.Point(3, 155);
            this.actor2.Name = "actor2";
            this.actor2.Size = new System.Drawing.Size(81, 114);
            this.actor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.actor2.TabIndex = 2;
            this.actor2.TabStop = false;
            this.actor2.Visible = false;
            this.actor2.Click += new System.EventHandler(this.actor2_Click);
            // 
            // actor3
            // 
            this.actor3.BackColor = System.Drawing.Color.White;
            this.actor3.Enabled = false;
            this.actor3.Image = global::Use_Case_Helper_V2.Properties.Resources.actor;
            this.actor3.Location = new System.Drawing.Point(3, 314);
            this.actor3.Name = "actor3";
            this.actor3.Size = new System.Drawing.Size(81, 114);
            this.actor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.actor3.TabIndex = 1;
            this.actor3.TabStop = false;
            this.actor3.Visible = false;
            this.actor3.Click += new System.EventHandler(this.actor3_Click);
            // 
            // actor1
            // 
            this.actor1.BackColor = System.Drawing.Color.White;
            this.actor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actor1.Image = global::Use_Case_Helper_V2.Properties.Resources.actor;
            this.actor1.Location = new System.Drawing.Point(3, 3);
            this.actor1.Name = "actor1";
            this.actor1.Size = new System.Drawing.Size(81, 114);
            this.actor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.actor1.TabIndex = 0;
            this.actor1.TabStop = false;
            this.actor1.Click += new System.EventHandler(this.actor1_Click);
            // 
            // grpElementen
            // 
            this.grpElementen.Controls.Add(this.radioActorRem);
            this.grpElementen.Controls.Add(this.radioLine);
            this.grpElementen.Controls.Add(this.radioActorAdd);
            this.grpElementen.Location = new System.Drawing.Point(9, 10);
            this.grpElementen.Margin = new System.Windows.Forms.Padding(2);
            this.grpElementen.Name = "grpElementen";
            this.grpElementen.Padding = new System.Windows.Forms.Padding(2);
            this.grpElementen.Size = new System.Drawing.Size(174, 41);
            this.grpElementen.TabIndex = 1;
            this.grpElementen.TabStop = false;
            this.grpElementen.Text = "Elementen";
            // 
            // radioActorRem
            // 
            this.radioActorRem.AutoSize = true;
            this.radioActorRem.Location = new System.Drawing.Point(64, 17);
            this.radioActorRem.Margin = new System.Windows.Forms.Padding(2);
            this.radioActorRem.Name = "radioActorRem";
            this.radioActorRem.Size = new System.Drawing.Size(53, 17);
            this.radioActorRem.TabIndex = 5;
            this.radioActorRem.TabStop = true;
            this.radioActorRem.Text = "Actor-";
            this.radioActorRem.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Location = new System.Drawing.Point(121, 17);
            this.radioLine.Margin = new System.Windows.Forms.Padding(2);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(45, 17);
            this.radioLine.TabIndex = 4;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // radioActorAdd
            // 
            this.radioActorAdd.AutoSize = true;
            this.radioActorAdd.Location = new System.Drawing.Point(4, 17);
            this.radioActorAdd.Margin = new System.Windows.Forms.Padding(2);
            this.radioActorAdd.Name = "radioActorAdd";
            this.radioActorAdd.Size = new System.Drawing.Size(56, 17);
            this.radioActorAdd.TabIndex = 2;
            this.radioActorAdd.TabStop = true;
            this.radioActorAdd.Text = "Actor+";
            this.radioActorAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(656, 41);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 19);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(656, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 506);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpElementen);
            this.Controls.Add(this.pnlUseCases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Use Case Helper";
            this.pnlUseCases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor1)).EndInit();
            this.grpElementen.ResumeLayout(false);
            this.grpElementen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUseCases;
        private System.Windows.Forms.GroupBox grpElementen;
        private System.Windows.Forms.RadioButton radioActorAdd;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox actor2;
        private System.Windows.Forms.PictureBox actor3;
        private System.Windows.Forms.PictureBox actor1;
        private System.Windows.Forms.RadioButton radioActorRem;
    }
}

