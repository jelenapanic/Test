
namespace UI_pokusaj
{
    partial class RegFinal
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
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVrsta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rBZ = new System.Windows.Forms.RadioButton();
            this.rBM = new System.Windows.Forms.RadioButton();
            this.buttonPetInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.vetSet11 = new UI_pokusaj.VetSet1();
            this.ljubimacTableAdapter1 = new UI_pokusaj.VetSet1TableAdapters.LjubimacTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "O LJUBIMCU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxPetName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPetName.Location = new System.Drawing.Point(49, 103);
            this.textBoxPetName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPetName.MaxLength = 25;
            this.textBoxPetName.Multiline = true;
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(200, 25);
            this.textBoxPetName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(45, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vrsta";
            // 
            // textBoxVrsta
            // 
            this.textBoxVrsta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxVrsta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVrsta.Location = new System.Drawing.Point(49, 150);
            this.textBoxVrsta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVrsta.MaxLength = 25;
            this.textBoxVrsta.Multiline = true;
            this.textBoxVrsta.Name = "textBoxVrsta";
            this.textBoxVrsta.Size = new System.Drawing.Size(200, 25);
            this.textBoxVrsta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(45, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rasa";
            // 
            // textBoxRasa
            // 
            this.textBoxRasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxRasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRasa.Location = new System.Drawing.Point(49, 199);
            this.textBoxRasa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRasa.MaxLength = 25;
            this.textBoxRasa.Multiline = true;
            this.textBoxRasa.Name = "textBoxRasa";
            this.textBoxRasa.Size = new System.Drawing.Size(200, 25);
            this.textBoxRasa.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label5.Location = new System.Drawing.Point(47, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pol";
            // 
            // rBZ
            // 
            this.rBZ.AutoSize = true;
            this.rBZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.rBZ.Location = new System.Drawing.Point(103, 247);
            this.rBZ.Margin = new System.Windows.Forms.Padding(4);
            this.rBZ.Name = "rBZ";
            this.rBZ.Size = new System.Drawing.Size(39, 21);
            this.rBZ.TabIndex = 3;
            this.rBZ.TabStop = true;
            this.rBZ.Text = "Ž";
            this.rBZ.UseVisualStyleBackColor = true;
            // 
            // rBM
            // 
            this.rBM.AutoSize = true;
            this.rBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.rBM.Location = new System.Drawing.Point(49, 247);
            this.rBM.Margin = new System.Windows.Forms.Padding(4);
            this.rBM.Name = "rBM";
            this.rBM.Size = new System.Drawing.Size(41, 21);
            this.rBM.TabIndex = 3;
            this.rBM.TabStop = true;
            this.rBM.Text = "M";
            this.rBM.UseVisualStyleBackColor = true;
            // 
            // buttonPetInfo
            // 
            this.buttonPetInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.buttonPetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPetInfo.ForeColor = System.Drawing.Color.White;
            this.buttonPetInfo.Location = new System.Drawing.Point(49, 339);
            this.buttonPetInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPetInfo.Name = "buttonPetInfo";
            this.buttonPetInfo.Size = new System.Drawing.Size(200, 43);
            this.buttonPetInfo.TabIndex = 4;
            this.buttonPetInfo.Text = "REGISTRUJ SE";
            this.buttonPetInfo.UseVisualStyleBackColor = false;
            this.buttonPetInfo.Click += new System.EventHandler(this.buttonPetInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(116, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nazad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 298);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // vetSet11
            // 
            this.vetSet11.DataSetName = "VetSet1";
            this.vetSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ljubimacTableAdapter1
            // 
            this.ljubimacTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(47, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Datum rođenja";
            // 
            // RegFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 453);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonPetInfo);
            this.Controls.Add(this.rBM);
            this.Controls.Add(this.rBZ);
            this.Controls.Add(this.textBoxRasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegFinal";
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVrsta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBZ;
        private System.Windows.Forms.RadioButton rBM;
        private System.Windows.Forms.Button buttonPetInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private VetSet1 vetSet11;
        private VetSet1TableAdapters.LjubimacTableAdapter ljubimacTableAdapter1;
        private System.Windows.Forms.Label label7;
    }
}