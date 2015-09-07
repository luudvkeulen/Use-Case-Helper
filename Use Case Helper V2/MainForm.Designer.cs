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
            this.grpElementen = new System.Windows.Forms.GroupBox();
            this.radioUseCase = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioActor = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpElementen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUseCases
            // 
            this.pnlUseCases.BackColor = System.Drawing.Color.White;
            this.pnlUseCases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUseCases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUseCases.Location = new System.Drawing.Point(12, 79);
            this.pnlUseCases.Name = "pnlUseCases";
            this.pnlUseCases.Size = new System.Drawing.Size(938, 532);
            this.pnlUseCases.TabIndex = 0;
            this.pnlUseCases.Click += new System.EventHandler(this.panel1_Click);
            // 
            // grpElementen
            // 
            this.grpElementen.Controls.Add(this.radioUseCase);
            this.grpElementen.Controls.Add(this.radioLine);
            this.grpElementen.Controls.Add(this.radioActor);
            this.grpElementen.Location = new System.Drawing.Point(12, 12);
            this.grpElementen.Name = "grpElementen";
            this.grpElementen.Size = new System.Drawing.Size(228, 51);
            this.grpElementen.TabIndex = 1;
            this.grpElementen.TabStop = false;
            this.grpElementen.Text = "Elementen";
            // 
            // radioUseCase
            // 
            this.radioUseCase.AutoSize = true;
            this.radioUseCase.Location = new System.Drawing.Point(131, 21);
            this.radioUseCase.Name = "radioUseCase";
            this.radioUseCase.Size = new System.Drawing.Size(90, 21);
            this.radioUseCase.TabIndex = 3;
            this.radioUseCase.TabStop = true;
            this.radioUseCase.Text = "Use Case";
            this.radioUseCase.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Location = new System.Drawing.Point(74, 21);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(56, 21);
            this.radioLine.TabIndex = 4;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // radioActor
            // 
            this.radioActor.AutoSize = true;
            this.radioActor.Location = new System.Drawing.Point(6, 21);
            this.radioActor.Name = "radioActor";
            this.radioActor.Size = new System.Drawing.Size(62, 21);
            this.radioActor.TabIndex = 2;
            this.radioActor.TabStop = true;
            this.radioActor.Text = "Actor";
            this.radioActor.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(875, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(875, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 623);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpElementen);
            this.Controls.Add(this.pnlUseCases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Use Case Helper";
            this.grpElementen.ResumeLayout(false);
            this.grpElementen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUseCases;
        private System.Windows.Forms.GroupBox grpElementen;
        private System.Windows.Forms.RadioButton radioActor;
        private System.Windows.Forms.RadioButton radioUseCase;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}

