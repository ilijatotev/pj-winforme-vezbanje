namespace trudim_se
{
    partial class Form1
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
            this.labIme = new System.Windows.Forms.Label();
            this.labPrez = new System.Windows.Forms.Label();
            this.labInd = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrez = new System.Windows.Forms.TextBox();
            this.numInd = new System.Windows.Forms.NumericUpDown();
            this.boxNivoStud = new System.Windows.Forms.GroupBox();
            this.radOsn = new System.Windows.Forms.RadioButton();
            this.radMas = new System.Windows.Forms.RadioButton();
            this.radDok = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numInd)).BeginInit();
            this.boxNivoStud.SuspendLayout();
            this.SuspendLayout();
            // 
            // labIme
            // 
            this.labIme.AutoSize = true;
            this.labIme.Location = new System.Drawing.Point(23, 27);
            this.labIme.Name = "labIme";
            this.labIme.Size = new System.Drawing.Size(27, 13);
            this.labIme.TabIndex = 0;
            this.labIme.Text = "Ime:";
            // 
            // labPrez
            // 
            this.labPrez.AutoSize = true;
            this.labPrez.Location = new System.Drawing.Point(23, 57);
            this.labPrez.Name = "labPrez";
            this.labPrez.Size = new System.Drawing.Size(47, 13);
            this.labPrez.TabIndex = 1;
            this.labPrez.Text = "Prezime:";
            // 
            // labInd
            // 
            this.labInd.AutoSize = true;
            this.labInd.Location = new System.Drawing.Point(23, 83);
            this.labInd.Name = "labInd";
            this.labInd.Size = new System.Drawing.Size(68, 13);
            this.labInd.TabIndex = 2;
            this.labInd.Text = "Broj indeksa:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(124, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrez
            // 
            this.txtPrez.Location = new System.Drawing.Point(124, 54);
            this.txtPrez.Name = "txtPrez";
            this.txtPrez.Size = new System.Drawing.Size(100, 20);
            this.txtPrez.TabIndex = 4;
            // 
            // numInd
            // 
            this.numInd.Location = new System.Drawing.Point(124, 83);
            this.numInd.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numInd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInd.Name = "numInd";
            this.numInd.Size = new System.Drawing.Size(100, 20);
            this.numInd.TabIndex = 5;
            this.numInd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // boxNivoStud
            // 
            this.boxNivoStud.Controls.Add(this.radDok);
            this.boxNivoStud.Controls.Add(this.radMas);
            this.boxNivoStud.Controls.Add(this.radOsn);
            this.boxNivoStud.Location = new System.Drawing.Point(15, 113);
            this.boxNivoStud.Name = "boxNivoStud";
            this.boxNivoStud.Size = new System.Drawing.Size(229, 46);
            this.boxNivoStud.TabIndex = 6;
            this.boxNivoStud.TabStop = false;
            this.boxNivoStud.Text = "Godina studija:";
            this.boxNivoStud.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radOsn
            // 
            this.radOsn.AutoSize = true;
            this.radOsn.Location = new System.Drawing.Point(11, 19);
            this.radOsn.Name = "radOsn";
            this.radOsn.Size = new System.Drawing.Size(68, 17);
            this.radOsn.TabIndex = 0;
            this.radOsn.TabStop = true;
            this.radOsn.Text = "Osnovne";
            this.radOsn.UseVisualStyleBackColor = true;
            this.radOsn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radMas
            // 
            this.radMas.AutoSize = true;
            this.radMas.Location = new System.Drawing.Point(85, 19);
            this.radMas.Name = "radMas";
            this.radMas.Size = new System.Drawing.Size(57, 17);
            this.radMas.TabIndex = 7;
            this.radMas.TabStop = true;
            this.radMas.Text = "Master";
            this.radMas.UseVisualStyleBackColor = true;
            // 
            // radDok
            // 
            this.radDok.AutoSize = true;
            this.radDok.Location = new System.Drawing.Point(148, 19);
            this.radDok.Name = "radDok";
            this.radDok.Size = new System.Drawing.Size(74, 17);
            this.radDok.TabIndex = 7;
            this.radDok.TabStop = true;
            this.radDok.Text = "Doktorske";
            this.radDok.UseVisualStyleBackColor = true;
            this.radDok.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.boxNivoStud);
            this.Controls.Add(this.numInd);
            this.Controls.Add(this.txtPrez);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.labInd);
            this.Controls.Add(this.labPrez);
            this.Controls.Add(this.labIme);
            this.Name = "Form1";
            this.Text = "ime forms aplikacije";
            ((System.ComponentModel.ISupportInitialize)(this.numInd)).EndInit();
            this.boxNivoStud.ResumeLayout(false);
            this.boxNivoStud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labIme;
        private System.Windows.Forms.Label labPrez;
        private System.Windows.Forms.Label labInd;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrez;
        private System.Windows.Forms.NumericUpDown numInd;
        private System.Windows.Forms.GroupBox boxNivoStud;
        private System.Windows.Forms.RadioButton radDok;
        private System.Windows.Forms.RadioButton radMas;
        private System.Windows.Forms.RadioButton radOsn;
    }
}

