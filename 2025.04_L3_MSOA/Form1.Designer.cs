namespace _2025._04_L3_MSOA
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEchipa = new System.Windows.Forms.ComboBox();
            this.btnEchipa = new System.Windows.Forms.Button();
            this.flpEchipa = new System.Windows.Forms.FlowLayoutPanel();
            this.btnJucator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.dtNastere = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // cmbEchipa
            // 
            this.cmbEchipa.FormattingEnabled = true;
            this.cmbEchipa.Location = new System.Drawing.Point(110, 26);
            this.cmbEchipa.Name = "cmbEchipa";
            this.cmbEchipa.Size = new System.Drawing.Size(121, 24);
            this.cmbEchipa.TabIndex = 1;
            this.cmbEchipa.SelectedIndexChanged += new System.EventHandler(this.cmbEchipa_SelectedIndexChanged);
            // 
            // btnEchipa
            // 
            this.btnEchipa.Location = new System.Drawing.Point(260, 26);
            this.btnEchipa.Name = "btnEchipa";
            this.btnEchipa.Size = new System.Drawing.Size(147, 23);
            this.btnEchipa.TabIndex = 2;
            this.btnEchipa.Text = "Echipa noua";
            this.btnEchipa.UseVisualStyleBackColor = true;
            // 
            // flpEchipa
            // 
            this.flpEchipa.Location = new System.Drawing.Point(58, 79);
            this.flpEchipa.Name = "flpEchipa";
            this.flpEchipa.Size = new System.Drawing.Size(311, 304);
            this.flpEchipa.TabIndex = 3;
            // 
            // btnJucator
            // 
            this.btnJucator.Location = new System.Drawing.Point(170, 403);
            this.btnJucator.Name = "btnJucator";
            this.btnJucator.Size = new System.Drawing.Size(132, 23);
            this.btnJucator.TabIndex = 4;
            this.btnJucator.Text = "Jucator nou";
            this.btnJucator.UseVisualStyleBackColor = true;
            this.btnJucator.Click += new System.EventHandler(this.btnJucator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNastere);
            this.groupBox1.Controls.Add(this.txtVarsta);
            this.groupBox1.Controls.Add(this.txtCNP);
            this.groupBox1.Controls.Add(this.txtPost);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(455, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii jucator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Post:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "CNP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data nașterii:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vârsta:";
            // 
            // txtNume
            // 
            this.txtNume.Enabled = false;
            this.txtNume.Location = new System.Drawing.Point(103, 34);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(151, 22);
            this.txtNume.TabIndex = 5;
            // 
            // txtPost
            // 
            this.txtPost.Enabled = false;
            this.txtPost.Location = new System.Drawing.Point(103, 62);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(151, 22);
            this.txtPost.TabIndex = 6;
            // 
            // txtCNP
            // 
            this.txtCNP.Enabled = false;
            this.txtCNP.Location = new System.Drawing.Point(103, 90);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(151, 22);
            this.txtCNP.TabIndex = 7;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Enabled = false;
            this.txtVarsta.Location = new System.Drawing.Point(103, 154);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(151, 22);
            this.txtVarsta.TabIndex = 8;
            // 
            // dtNastere
            // 
            this.dtNastere.Enabled = false;
            this.dtNastere.Location = new System.Drawing.Point(103, 119);
            this.dtNastere.Name = "dtNastere";
            this.dtNastere.Size = new System.Drawing.Size(151, 22);
            this.dtNastere.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnJucator);
            this.Controls.Add(this.flpEchipa);
            this.Controls.Add(this.btnEchipa);
            this.Controls.Add(this.cmbEchipa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEchipa;
        private System.Windows.Forms.Button btnEchipa;
        private System.Windows.Forms.FlowLayoutPanel flpEchipa;
        private System.Windows.Forms.Button btnJucator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.DateTimePicker dtNastere;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtPost;
    }
}

