
namespace UI_pokusaj.Forms
{
    partial class FormOnama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOnama));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSourceLjubimci1 = new System.Windows.Forms.BindingSource(this.components);
            this.vetSet11 = new UI_pokusaj.VetSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxISTORIJA = new System.Windows.Forms.ListBox();
            this.bindingSourcePregledi = new System.Windows.Forms.BindingSource(this.components);
            this.ljubimacTableAdapter1 = new UI_pokusaj.VetSet1TableAdapters.LjubimacTableAdapter();
            this.preglediTableAdapter = new UI_pokusaj.VetSet1TableAdapters.PreglediTableAdapter();
            this.listBoxTerapija = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLjubimci1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePregledi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Istorija pregleda:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.comboBox1.DataSource = this.bindingSourceLjubimci1;
            this.comboBox1.DisplayMember = "Ime";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "LjubimacID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bindingSourceLjubimci1
            // 
            this.bindingSourceLjubimci1.DataMember = "Ljubimac";
            this.bindingSourceLjubimci1.DataSource = this.vetSet11;
            // 
            // vetSet11
            // 
            this.vetSet11.DataSetName = "VetSet1";
            this.vetSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite životinju";
            // 
            // listBoxISTORIJA
            // 
            this.listBoxISTORIJA.BackColor = System.Drawing.Color.Aquamarine;
            this.listBoxISTORIJA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxISTORIJA.DataSource = this.bindingSourcePregledi;
            this.listBoxISTORIJA.DisplayMember = "Razlog";
            this.listBoxISTORIJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxISTORIJA.FormattingEnabled = true;
            this.listBoxISTORIJA.ItemHeight = 25;
            this.listBoxISTORIJA.Location = new System.Drawing.Point(13, 93);
            this.listBoxISTORIJA.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxISTORIJA.Name = "listBoxISTORIJA";
            this.listBoxISTORIJA.Size = new System.Drawing.Size(309, 375);
            this.listBoxISTORIJA.TabIndex = 4;
            this.listBoxISTORIJA.ValueMember = "Ljubimac";
            this.listBoxISTORIJA.SelectedIndexChanged += new System.EventHandler(this.listBoxISTORIJA_SelectedIndexChanged);
            // 
            // bindingSourcePregledi
            // 
            this.bindingSourcePregledi.DataMember = "Pregledi";
            this.bindingSourcePregledi.DataSource = this.vetSet11;
            // 
            // ljubimacTableAdapter1
            // 
            this.ljubimacTableAdapter1.ClearBeforeFill = true;
            // 
            // preglediTableAdapter
            // 
            this.preglediTableAdapter.ClearBeforeFill = true;
            // 
            // listBoxTerapija
            // 
            this.listBoxTerapija.BackColor = System.Drawing.Color.Aquamarine;
            this.listBoxTerapija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTerapija.DataSource = this.bindingSourcePregledi;
            this.listBoxTerapija.DisplayMember = "Primenjena terapija";
            this.listBoxTerapija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTerapija.FormattingEnabled = true;
            this.listBoxTerapija.ItemHeight = 25;
            this.listBoxTerapija.Location = new System.Drawing.Point(376, 93);
            this.listBoxTerapija.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTerapija.Name = "listBoxTerapija";
            this.listBoxTerapija.Size = new System.Drawing.Size(309, 350);
            this.listBoxTerapija.TabIndex = 6;
            this.listBoxTerapija.ValueMember = "Ljubimac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primenjena terapija:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormOnama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxTerapija);
            this.Controls.Add(this.listBoxISTORIJA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOnama";
            this.Text = "FormOnama";
            this.Load += new System.EventHandler(this.FormOnama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLjubimci1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePregledi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxISTORIJA;
        private VetSet1 vetSet11;
        private System.Windows.Forms.BindingSource bindingSourceLjubimci1;
        private VetSet1TableAdapters.LjubimacTableAdapter ljubimacTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSourcePregledi;
        private VetSet1TableAdapters.PreglediTableAdapter preglediTableAdapter;
        private System.Windows.Forms.ListBox listBoxTerapija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}