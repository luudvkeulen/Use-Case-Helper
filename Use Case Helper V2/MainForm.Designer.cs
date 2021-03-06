﻿namespace Use_Case_Helper_V2
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
            this.radioInfo = new System.Windows.Forms.RadioButton();
            this.radioUseCase = new System.Windows.Forms.RadioButton();
            this.radioActorRem = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioActorAdd = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.actortext1 = new System.Windows.Forms.TextBox();
            this.actortext2 = new System.Windows.Forms.TextBox();
            this.actortext3 = new System.Windows.Forms.TextBox();
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
            this.pnlUseCases.Controls.Add(this.actortext3);
            this.pnlUseCases.Controls.Add(this.actortext2);
            this.pnlUseCases.Controls.Add(this.actortext1);
            this.pnlUseCases.Controls.Add(this.actor2);
            this.pnlUseCases.Controls.Add(this.actor3);
            this.pnlUseCases.Controls.Add(this.actor1);
            this.pnlUseCases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUseCases.Location = new System.Drawing.Point(12, 79);
            this.pnlUseCases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUseCases.Name = "pnlUseCases";
            this.pnlUseCases.Size = new System.Drawing.Size(938, 532);
            this.pnlUseCases.TabIndex = 0;
            this.pnlUseCases.Click += new System.EventHandler(this.panel1_Click);
            this.pnlUseCases.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUseCases_Paint);
            // 
            // actor2
            // 
            this.actor2.BackColor = System.Drawing.Color.White;
            this.actor2.Enabled = false;
            this.actor2.Image = global::Use_Case_Helper_V2.Properties.Resources.actor;
            this.actor2.Location = new System.Drawing.Point(4, 180);
            this.actor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actor2.Name = "actor2";
            this.actor2.Size = new System.Drawing.Size(108, 140);
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
            this.actor3.Location = new System.Drawing.Point(4, 356);
            this.actor3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actor3.Name = "actor3";
            this.actor3.Size = new System.Drawing.Size(108, 140);
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
            this.actor1.Location = new System.Drawing.Point(4, 4);
            this.actor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actor1.Name = "actor1";
            this.actor1.Size = new System.Drawing.Size(107, 140);
            this.actor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.actor1.TabIndex = 0;
            this.actor1.TabStop = false;
            this.actor1.Click += new System.EventHandler(this.actor1_Click);
            // 
            // grpElementen
            // 
            this.grpElementen.Controls.Add(this.radioInfo);
            this.grpElementen.Controls.Add(this.radioUseCase);
            this.grpElementen.Controls.Add(this.radioActorRem);
            this.grpElementen.Controls.Add(this.radioLine);
            this.grpElementen.Controls.Add(this.radioActorAdd);
            this.grpElementen.Location = new System.Drawing.Point(12, 12);
            this.grpElementen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpElementen.Name = "grpElementen";
            this.grpElementen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpElementen.Size = new System.Drawing.Size(416, 50);
            this.grpElementen.TabIndex = 1;
            this.grpElementen.TabStop = false;
            this.grpElementen.Text = "Elementen";
            // 
            // radioInfo
            // 
            this.radioInfo.AutoSize = true;
            this.radioInfo.Location = new System.Drawing.Point(315, 21);
            this.radioInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioInfo.Name = "radioInfo";
            this.radioInfo.Size = new System.Drawing.Size(72, 21);
            this.radioInfo.TabIndex = 7;
            this.radioInfo.TabStop = true;
            this.radioInfo.Text = "Details";
            this.radioInfo.UseVisualStyleBackColor = true;
            // 
            // radioUseCase
            // 
            this.radioUseCase.AutoSize = true;
            this.radioUseCase.Location = new System.Drawing.Point(223, 21);
            this.radioUseCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioUseCase.Name = "radioUseCase";
            this.radioUseCase.Size = new System.Drawing.Size(86, 21);
            this.radioUseCase.TabIndex = 6;
            this.radioUseCase.TabStop = true;
            this.radioUseCase.Text = "UseCase";
            this.radioUseCase.UseVisualStyleBackColor = true;
            // 
            // radioActorRem
            // 
            this.radioActorRem.AutoSize = true;
            this.radioActorRem.Location = new System.Drawing.Point(85, 21);
            this.radioActorRem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioActorRem.Name = "radioActorRem";
            this.radioActorRem.Size = new System.Drawing.Size(67, 21);
            this.radioActorRem.TabIndex = 5;
            this.radioActorRem.TabStop = true;
            this.radioActorRem.Text = "Actor-";
            this.radioActorRem.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Location = new System.Drawing.Point(161, 21);
            this.radioLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(56, 21);
            this.radioLine.TabIndex = 4;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // radioActorAdd
            // 
            this.radioActorAdd.AutoSize = true;
            this.radioActorAdd.Location = new System.Drawing.Point(5, 21);
            this.radioActorAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioActorAdd.Name = "radioActorAdd";
            this.radioActorAdd.Size = new System.Drawing.Size(70, 21);
            this.radioActorAdd.TabIndex = 2;
            this.radioActorAdd.TabStop = true;
            this.radioActorAdd.Text = "Actor+";
            this.radioActorAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(875, 50);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(875, 21);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // actortext1
            // 
            this.actortext1.Location = new System.Drawing.Point(4, 151);
            this.actortext1.Name = "actortext1";
            this.actortext1.Size = new System.Drawing.Size(107, 22);
            this.actortext1.TabIndex = 3;
            this.actortext1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // actortext2
            // 
            this.actortext2.Enabled = false;
            this.actortext2.Location = new System.Drawing.Point(3, 327);
            this.actortext2.Name = "actortext2";
            this.actortext2.Size = new System.Drawing.Size(107, 22);
            this.actortext2.TabIndex = 5;
            this.actortext2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.actortext2.Visible = false;
            // 
            // actortext3
            // 
            this.actortext3.Enabled = false;
            this.actortext3.Location = new System.Drawing.Point(4, 503);
            this.actortext3.Name = "actortext3";
            this.actortext3.Size = new System.Drawing.Size(107, 22);
            this.actortext3.TabIndex = 6;
            this.actortext3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.actortext3.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 623);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpElementen);
            this.Controls.Add(this.pnlUseCases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Use Case Helper";
            this.pnlUseCases.ResumeLayout(false);
            this.pnlUseCases.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioUseCase;
        private System.Windows.Forms.RadioButton radioInfo;
        private System.Windows.Forms.TextBox actortext3;
        private System.Windows.Forms.TextBox actortext2;
        private System.Windows.Forms.TextBox actortext1;
    }
}

