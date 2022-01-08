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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(240, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
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
            this.label2.Location = new System.Drawing.Point(41, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime";
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxUsername1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername1.Location = new System.Drawing.Point(44, 99);
            this.textBoxUsername1.MaxLength = 40;
            this.textBoxUsername1.Multiline = true;
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(200, 20);
            this.textBoxUsername1.TabIndex = 2;
            this.textBoxUsername1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(41, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lozinka";
            // 
            // textBoxPW
            // 
            this.textBoxPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPW.Location = new System.Drawing.Point(44, 150);
            this.textBoxPW.Multiline = true;
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '•';
            this.textBoxPW.Size = new System.Drawing.Size(200, 20);
            this.textBoxPW.TabIndex = 2;
            this.textBoxPW.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(41, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Potvrdi lozinku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirm.Location = new System.Drawing.Point(44, 199);
            this.textBoxConfirm.Multiline = true;
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.PasswordChar = '•';
            this.textBoxConfirm.Size = new System.Drawing.Size(200, 20);
            this.textBoxConfirm.TabIndex = 2;
            this.textBoxConfirm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.checkBoxShow.Location = new System.Drawing.Point(136, 225);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(108, 17);
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
            this.label5.Location = new System.Drawing.Point(432, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ime";
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNAME.Location = new System.Drawing.Point(435, 92);
            this.textBoxNAME.Multiline = true;
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(200, 20);
            this.textBoxNAME.TabIndex = 2;
            this.textBoxNAME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(432, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Prezime";
            // 
            // textBoxSURNAME
            // 
            this.textBoxSURNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxSURNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSURNAME.Location = new System.Drawing.Point(435, 150);
            this.textBoxSURNAME.Multiline = true;
            this.textBoxSURNAME.Name = "textBoxSURNAME";
            this.textBoxSURNAME.Size = new System.Drawing.Size(200, 20);
            this.textBoxSURNAME.TabIndex = 2;
            this.textBoxSURNAME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(432, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Grad";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCity.Location = new System.Drawing.Point(435, 199);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 20);
            this.textBoxCity.TabIndex = 2;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label8.Location = new System.Drawing.Point(432, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adresa";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdress.Location = new System.Drawing.Point(435, 248);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdress.TabIndex = 2;
            this.textBoxAdress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label9.Location = new System.Drawing.Point(432, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Broj telefona";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPN
            // 
            this.textBoxPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPN.Location = new System.Drawing.Point(435, 296);
            this.textBoxPN.Multiline = true;
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(200, 20);
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
            this.buttonReg.Location = new System.Drawing.Point(239, 322);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(220, 30);
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
            this.label10.Location = new System.Drawing.Point(274, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Već imaš nalog? Prijavi se.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 387);
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
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReg";
            this.Load += new System.EventHandler(this.FormReg_Load);
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
    }
}