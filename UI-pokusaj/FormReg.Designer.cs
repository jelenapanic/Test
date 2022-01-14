namespace UI_pokusaj
{
    partial class FormReg
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSURNAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPN = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.vetSet11 = new UI_pokusaj.VetSet1();
            this.vlasnikTableAdapter1 = new UI_pokusaj.VetSet1TableAdapters.VlasnikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(320, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOBRODOŠLI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime";
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxUsername1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername1.Location = new System.Drawing.Point(59, 122);
            this.textBoxUsername1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername1.MaxLength = 40;
            this.textBoxUsername1.Multiline = true;
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(267, 25);
            this.textBoxUsername1.TabIndex = 2;
            this.textBoxUsername1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(55, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lozinka";
            // 
            // textBoxPW
            // 
            this.textBoxPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPW.Location = new System.Drawing.Point(59, 185);
            this.textBoxPW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPW.Multiline = true;
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '•';
            this.textBoxPW.Size = new System.Drawing.Size(267, 25);
            this.textBoxPW.TabIndex = 2;
            this.textBoxPW.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(55, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Potvrdi lozinku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirm.Location = new System.Drawing.Point(59, 245);
            this.textBoxConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxConfirm.Multiline = true;
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.PasswordChar = '•';
            this.textBoxConfirm.Size = new System.Drawing.Size(267, 25);
            this.textBoxConfirm.TabIndex = 2;
            this.textBoxConfirm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.checkBoxShow.Location = new System.Drawing.Point(181, 277);
            this.checkBoxShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(135, 21);
            this.checkBoxShow.TabIndex = 3;
            this.checkBoxShow.Text = "Prikaži lozinku";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label5.Location = new System.Drawing.Point(576, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ime";
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNAME.Location = new System.Drawing.Point(580, 113);
            this.textBoxNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNAME.Multiline = true;
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(267, 25);
            this.textBoxNAME.TabIndex = 2;
            this.textBoxNAME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(576, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Prezime";
            // 
            // textBoxSURNAME
            // 
            this.textBoxSURNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxSURNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSURNAME.Location = new System.Drawing.Point(580, 185);
            this.textBoxSURNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSURNAME.Multiline = true;
            this.textBoxSURNAME.Name = "textBoxSURNAME";
            this.textBoxSURNAME.Size = new System.Drawing.Size(267, 25);
            this.textBoxSURNAME.TabIndex = 2;
            this.textBoxSURNAME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(576, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Grad";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCity.Location = new System.Drawing.Point(580, 245);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(267, 25);
            this.textBoxCity.TabIndex = 2;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label8.Location = new System.Drawing.Point(576, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adresa";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdress.Location = new System.Drawing.Point(580, 305);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(267, 25);
            this.textBoxAdress.TabIndex = 2;
            this.textBoxAdress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label9.Location = new System.Drawing.Point(576, 345);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Broj telefona";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPN
            // 
            this.textBoxPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPN.Location = new System.Drawing.Point(580, 364);
            this.textBoxPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPN.Multiline = true;
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(267, 25);
            this.textBoxPN.TabIndex = 2;
            this.textBoxPN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPN_KeyPress);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(133)))));
            this.buttonReg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReg.Location = new System.Drawing.Point(319, 396);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(293, 37);
            this.buttonReg.TabIndex = 4;
            this.buttonReg.Text = "DALJE...";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label10.Location = new System.Drawing.Point(365, 437);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Već imaš nalog? Prijavi se.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // vetSet11
            // 
            this.vetSet11.DataSetName = "VetSet1";
            this.vetSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vlasnikTableAdapter1
            // 
            this.vlasnikTableAdapter1.ClearBeforeFill = true;
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 476);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.textBoxPN);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSURNAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUsername1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReg";
            this.Load += new System.EventHandler(this.FormReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSURNAME;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPN;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label label10;
        private VetSet1 vetSet11;
        private VetSet1TableAdapters.VlasnikTableAdapter vlasnikTableAdapter1;
    }
}