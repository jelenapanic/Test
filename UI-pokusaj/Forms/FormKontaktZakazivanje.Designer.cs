namespace UI_pokusaj.Forms
{
    partial class FormKontaktZakazivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKontaktZakazivanje));
            this.labelVrstaZiv = new System.Windows.Forms.Label();
            this.labelVeterinar = new System.Windows.Forms.Label();
            this.textBoxRazlogPregledaUnos = new System.Windows.Forms.TextBox();
            this.labelRazlogPregleda = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDatum = new System.Windows.Forms.Label();
            this.buttonOtkaziPregled = new System.Windows.Forms.Button();
            this.buttonZakazi = new System.Windows.Forms.Button();
            this.textBoxImeZivotinje = new System.Windows.Forms.TextBox();
            this.labelImeZiv = new System.Windows.Forms.Label();
            this.comboBoxIzborVeterinara = new System.Windows.Forms.ComboBox();
            this.bindingSourceVet = new System.Windows.Forms.BindingSource(this.components);
            this.vetSet11 = new UI_pokusaj.VetSet1();
            this.textBoxUnosVrsteZivotinje = new System.Windows.Forms.TextBox();
            this.labelPolZiv = new System.Windows.Forms.Label();
            this.labelDatumRodj = new System.Windows.Forms.Label();
            this.labelRasaZiv = new System.Windows.Forms.Label();
            this.labelNoviLjubimac = new System.Windows.Forms.Label();
            this.buttonDa = new System.Windows.Forms.Button();
            this.buttonNe = new System.Windows.Forms.Button();
            this.textBoxUnosrase = new System.Windows.Forms.TextBox();
            this.radioButtonPolM = new System.Windows.Forms.RadioButton();
            this.radioButtonPolZ = new System.Windows.Forms.RadioButton();
            this.dateTimePickerrodj = new System.Windows.Forms.DateTimePicker();
            this.labelIzborVrste = new System.Windows.Forms.Label();
            this.labelIyborImena = new System.Windows.Forms.Label();
            this.comboBoxVrstaZiv = new System.Windows.Forms.ComboBox();
            this.bindingSourceLjubimac = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxImeZiv = new System.Windows.Forms.ComboBox();
            this.buttonDodajLjubimca = new System.Windows.Forms.Button();
            this.bindingSourceVlasnik1 = new System.Windows.Forms.BindingSource(this.components);
            this.vlasnikTableAdapter1 = new UI_pokusaj.VetSet1TableAdapters.VlasnikTableAdapter();
            this.ljubimacTableAdapter1 = new UI_pokusaj.VetSet1TableAdapters.LjubimacTableAdapter();
            this.veterinarTableAdapter1 = new UI_pokusaj.VetSet1TableAdapters.VeterinarTableAdapter();
            this.bindingSourcePregled = new System.Windows.Forms.BindingSource(this.components);
            this.preglediTableAdapter = new UI_pokusaj.VetSet1TableAdapters.PreglediTableAdapter();
            this.textBoxVrsta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLjubimac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVlasnik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVrstaZiv
            // 
            this.labelVrstaZiv.AutoSize = true;
            this.labelVrstaZiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrstaZiv.Location = new System.Drawing.Point(3, 245);
            this.labelVrstaZiv.Name = "labelVrstaZiv";
            this.labelVrstaZiv.Size = new System.Drawing.Size(126, 22);
            this.labelVrstaZiv.TabIndex = 3;
            this.labelVrstaZiv.Text = "Vrsta životinje:";
            this.labelVrstaZiv.Visible = false;
            // 
            // labelVeterinar
            // 
            this.labelVeterinar.AutoSize = true;
            this.labelVeterinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeterinar.Location = new System.Drawing.Point(496, 137);
            this.labelVeterinar.Name = "labelVeterinar";
            this.labelVeterinar.Size = new System.Drawing.Size(88, 22);
            this.labelVeterinar.TabIndex = 5;
            this.labelVeterinar.Text = "Veterinar:";
            // 
            // textBoxRazlogPregledaUnos
            // 
            this.textBoxRazlogPregledaUnos.Location = new System.Drawing.Point(673, 95);
            this.textBoxRazlogPregledaUnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRazlogPregledaUnos.Name = "textBoxRazlogPregledaUnos";
            this.textBoxRazlogPregledaUnos.Size = new System.Drawing.Size(243, 22);
            this.textBoxRazlogPregledaUnos.TabIndex = 6;
            this.textBoxRazlogPregledaUnos.TextChanged += new System.EventHandler(this.textBoxRazlogPregledaUnos_TextChanged);
            // 
            // labelRazlogPregleda
            // 
            this.labelRazlogPregleda.AutoSize = true;
            this.labelRazlogPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazlogPregleda.Location = new System.Drawing.Point(496, 95);
            this.labelRazlogPregleda.Name = "labelRazlogPregleda";
            this.labelRazlogPregleda.Size = new System.Drawing.Size(145, 22);
            this.labelRazlogPregleda.TabIndex = 7;
            this.labelRazlogPregleda.Text = "Razlog pregleda:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(673, 181);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 13, 23, 32, 52, 0);
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(496, 183);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(67, 22);
            this.labelDatum.TabIndex = 9;
            this.labelDatum.Text = "Datum:";
            // 
            // buttonOtkaziPregled
            // 
            this.buttonOtkaziPregled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOtkaziPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonOtkaziPregled.Location = new System.Drawing.Point(673, 224);
            this.buttonOtkaziPregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOtkaziPregled.Name = "buttonOtkaziPregled";
            this.buttonOtkaziPregled.Size = new System.Drawing.Size(119, 43);
            this.buttonOtkaziPregled.TabIndex = 10;
            this.buttonOtkaziPregled.Text = "Otkazi Pregled";
            this.buttonOtkaziPregled.UseVisualStyleBackColor = true;
            this.buttonOtkaziPregled.Click += new System.EventHandler(this.buttonOtkaziPregled_Click);
            // 
            // buttonZakazi
            // 
            this.buttonZakazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZakazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonZakazi.Location = new System.Drawing.Point(798, 224);
            this.buttonZakazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonZakazi.Name = "buttonZakazi";
            this.buttonZakazi.Size = new System.Drawing.Size(119, 43);
            this.buttonZakazi.TabIndex = 11;
            this.buttonZakazi.Text = "Zakazi pregled";
            this.buttonZakazi.UseVisualStyleBackColor = true;
            this.buttonZakazi.Click += new System.EventHandler(this.buttonZakazi_Click);
            // 
            // textBoxImeZivotinje
            // 
            this.textBoxImeZivotinje.Location = new System.Drawing.Point(141, 209);
            this.textBoxImeZivotinje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxImeZivotinje.Name = "textBoxImeZivotinje";
            this.textBoxImeZivotinje.Size = new System.Drawing.Size(240, 22);
            this.textBoxImeZivotinje.TabIndex = 14;
            this.textBoxImeZivotinje.Visible = false;
            this.textBoxImeZivotinje.TextChanged += new System.EventHandler(this.textBoxImeZivotinje_TextChanged);
            // 
            // labelImeZiv
            // 
            this.labelImeZiv.AutoSize = true;
            this.labelImeZiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeZiv.Location = new System.Drawing.Point(3, 207);
            this.labelImeZiv.Name = "labelImeZiv";
            this.labelImeZiv.Size = new System.Drawing.Size(112, 22);
            this.labelImeZiv.TabIndex = 15;
            this.labelImeZiv.Text = "Ime životinje:";
            this.labelImeZiv.Visible = false;
            // 
            // comboBoxIzborVeterinara
            // 
            this.comboBoxIzborVeterinara.DataSource = this.bindingSourceVet;
            this.comboBoxIzborVeterinara.DisplayMember = "Ime";
            this.comboBoxIzborVeterinara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIzborVeterinara.FormattingEnabled = true;
            this.comboBoxIzborVeterinara.Location = new System.Drawing.Point(675, 137);
            this.comboBoxIzborVeterinara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIzborVeterinara.Name = "comboBoxIzborVeterinara";
            this.comboBoxIzborVeterinara.Size = new System.Drawing.Size(241, 24);
            this.comboBoxIzborVeterinara.TabIndex = 16;
            this.comboBoxIzborVeterinara.ValueMember = "VeterinarID";
            this.comboBoxIzborVeterinara.SelectedIndexChanged += new System.EventHandler(this.comboBoxIzborVeterinara_SelectedIndexChanged);
            // 
            // bindingSourceVet
            // 
            this.bindingSourceVet.DataMember = "Veterinar";
            this.bindingSourceVet.DataSource = this.vetSet11;
            // 
            // vetSet11
            // 
            this.vetSet11.DataSetName = "VetSet1";
            this.vetSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxUnosVrsteZivotinje
            // 
            this.textBoxUnosVrsteZivotinje.Location = new System.Drawing.Point(141, 247);
            this.textBoxUnosVrsteZivotinje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUnosVrsteZivotinje.Name = "textBoxUnosVrsteZivotinje";
            this.textBoxUnosVrsteZivotinje.Size = new System.Drawing.Size(240, 22);
            this.textBoxUnosVrsteZivotinje.TabIndex = 17;
            this.textBoxUnosVrsteZivotinje.Visible = false;
            this.textBoxUnosVrsteZivotinje.TextChanged += new System.EventHandler(this.textBoxUnosVrsteZivotinje_TextChanged);
            // 
            // labelPolZiv
            // 
            this.labelPolZiv.AutoSize = true;
            this.labelPolZiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelPolZiv.Location = new System.Drawing.Point(3, 331);
            this.labelPolZiv.Name = "labelPolZiv";
            this.labelPolZiv.Size = new System.Drawing.Size(41, 22);
            this.labelPolZiv.TabIndex = 18;
            this.labelPolZiv.Text = "Pol:";
            this.labelPolZiv.Visible = false;
            // 
            // labelDatumRodj
            // 
            this.labelDatumRodj.AutoSize = true;
            this.labelDatumRodj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelDatumRodj.Location = new System.Drawing.Point(3, 370);
            this.labelDatumRodj.Name = "labelDatumRodj";
            this.labelDatumRodj.Size = new System.Drawing.Size(132, 22);
            this.labelDatumRodj.TabIndex = 19;
            this.labelDatumRodj.Text = "Datum rođenja:";
            this.labelDatumRodj.Visible = false;
            // 
            // labelRasaZiv
            // 
            this.labelRasaZiv.AutoSize = true;
            this.labelRasaZiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelRasaZiv.Location = new System.Drawing.Point(3, 286);
            this.labelRasaZiv.Name = "labelRasaZiv";
            this.labelRasaZiv.Size = new System.Drawing.Size(126, 22);
            this.labelRasaZiv.TabIndex = 21;
            this.labelRasaZiv.Text = "Rasa životinje:";
            this.labelRasaZiv.Visible = false;
            this.labelRasaZiv.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelNoviLjubimac
            // 
            this.labelNoviLjubimac.AutoSize = true;
            this.labelNoviLjubimac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelNoviLjubimac.Location = new System.Drawing.Point(103, 44);
            this.labelNoviLjubimac.Name = "labelNoviLjubimac";
            this.labelNoviLjubimac.Size = new System.Drawing.Size(126, 22);
            this.labelNoviLjubimac.TabIndex = 22;
            this.labelNoviLjubimac.Text = "Novi ljubimac?";
            // 
            // buttonDa
            // 
            this.buttonDa.Location = new System.Drawing.Point(124, 82);
            this.buttonDa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDa.Name = "buttonDa";
            this.buttonDa.Size = new System.Drawing.Size(75, 23);
            this.buttonDa.TabIndex = 23;
            this.buttonDa.Text = "Da";
            this.buttonDa.UseVisualStyleBackColor = true;
            this.buttonDa.Click += new System.EventHandler(this.buttonDa_Click);
            // 
            // buttonNe
            // 
            this.buttonNe.Location = new System.Drawing.Point(124, 111);
            this.buttonNe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNe.Name = "buttonNe";
            this.buttonNe.Size = new System.Drawing.Size(75, 23);
            this.buttonNe.TabIndex = 24;
            this.buttonNe.Text = " Ne";
            this.buttonNe.UseVisualStyleBackColor = true;
            this.buttonNe.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxUnosrase
            // 
            this.textBoxUnosrase.Location = new System.Drawing.Point(141, 288);
            this.textBoxUnosrase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUnosrase.Name = "textBoxUnosrase";
            this.textBoxUnosrase.Size = new System.Drawing.Size(240, 22);
            this.textBoxUnosrase.TabIndex = 25;
            this.textBoxUnosrase.Visible = false;
            // 
            // radioButtonPolM
            // 
            this.radioButtonPolM.AutoSize = true;
            this.radioButtonPolM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.radioButtonPolM.Location = new System.Drawing.Point(155, 329);
            this.radioButtonPolM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPolM.Name = "radioButtonPolM";
            this.radioButtonPolM.Size = new System.Drawing.Size(45, 26);
            this.radioButtonPolM.TabIndex = 26;
            this.radioButtonPolM.TabStop = true;
            this.radioButtonPolM.Text = "M";
            this.radioButtonPolM.UseVisualStyleBackColor = true;
            this.radioButtonPolM.Visible = false;
            // 
            // radioButtonPolZ
            // 
            this.radioButtonPolZ.AutoSize = true;
            this.radioButtonPolZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.radioButtonPolZ.Location = new System.Drawing.Point(205, 329);
            this.radioButtonPolZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPolZ.Name = "radioButtonPolZ";
            this.radioButtonPolZ.Size = new System.Drawing.Size(42, 26);
            this.radioButtonPolZ.TabIndex = 27;
            this.radioButtonPolZ.TabStop = true;
            this.radioButtonPolZ.Text = "Ž";
            this.radioButtonPolZ.UseVisualStyleBackColor = true;
            this.radioButtonPolZ.Visible = false;
            // 
            // dateTimePickerrodj
            // 
            this.dateTimePickerrodj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerrodj.Location = new System.Drawing.Point(141, 370);
            this.dateTimePickerrodj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerrodj.Name = "dateTimePickerrodj";
            this.dateTimePickerrodj.Size = new System.Drawing.Size(240, 22);
            this.dateTimePickerrodj.TabIndex = 28;
            this.dateTimePickerrodj.Visible = false;
            // 
            // labelIzborVrste
            // 
            this.labelIzborVrste.AutoSize = true;
            this.labelIzborVrste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelIzborVrste.Location = new System.Drawing.Point(496, 54);
            this.labelIzborVrste.Name = "labelIzborVrste";
            this.labelIzborVrste.Size = new System.Drawing.Size(126, 22);
            this.labelIzborVrste.TabIndex = 29;
            this.labelIzborVrste.Text = "Vrsta životinje:";
            // 
            // labelIyborImena
            // 
            this.labelIyborImena.AutoSize = true;
            this.labelIyborImena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelIyborImena.Location = new System.Drawing.Point(496, 13);
            this.labelIyborImena.Name = "labelIyborImena";
            this.labelIyborImena.Size = new System.Drawing.Size(112, 22);
            this.labelIyborImena.TabIndex = 30;
            this.labelIyborImena.Text = "Ime životinje:";
            // 
            // comboBoxVrstaZiv
            // 
            this.comboBoxVrstaZiv.DataSource = this.bindingSourceLjubimac;
            this.comboBoxVrstaZiv.DisplayMember = "Vrsta";
            this.comboBoxVrstaZiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVrstaZiv.FormattingEnabled = true;
            this.comboBoxVrstaZiv.Location = new System.Drawing.Point(468, 451);
            this.comboBoxVrstaZiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxVrstaZiv.Name = "comboBoxVrstaZiv";
            this.comboBoxVrstaZiv.Size = new System.Drawing.Size(244, 24);
            this.comboBoxVrstaZiv.TabIndex = 31;
            this.comboBoxVrstaZiv.ValueMember = "Vrsta";
            this.comboBoxVrstaZiv.Visible = false;
            this.comboBoxVrstaZiv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bindingSourceLjubimac
            // 
            this.bindingSourceLjubimac.DataMember = "Ljubimac";
            this.bindingSourceLjubimac.DataSource = this.vetSet11;
            // 
            // comboBoxImeZiv
            // 
            this.comboBoxImeZiv.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxImeZiv.DataSource = this.bindingSourceLjubimac;
            this.comboBoxImeZiv.DisplayMember = "Ime";
            this.comboBoxImeZiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImeZiv.FormattingEnabled = true;
            this.comboBoxImeZiv.Location = new System.Drawing.Point(673, 11);
            this.comboBoxImeZiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxImeZiv.Name = "comboBoxImeZiv";
            this.comboBoxImeZiv.Size = new System.Drawing.Size(243, 24);
            this.comboBoxImeZiv.TabIndex = 32;
            this.comboBoxImeZiv.ValueMember = "LjubimacID";
            this.comboBoxImeZiv.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonDodajLjubimca
            // 
            this.buttonDodajLjubimca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajLjubimca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonDodajLjubimca.Location = new System.Drawing.Point(141, 416);
            this.buttonDodajLjubimca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodajLjubimca.Name = "buttonDodajLjubimca";
            this.buttonDodajLjubimca.Size = new System.Drawing.Size(88, 33);
            this.buttonDodajLjubimca.TabIndex = 33;
            this.buttonDodajLjubimca.Text = "Dodaj ljubimca";
            this.buttonDodajLjubimca.UseVisualStyleBackColor = true;
            this.buttonDodajLjubimca.Visible = false;
            this.buttonDodajLjubimca.Click += new System.EventHandler(this.buttonDodajLjubimca_Click);
            // 
            // bindingSourceVlasnik1
            // 
            this.bindingSourceVlasnik1.DataMember = "Vlasnik";
            this.bindingSourceVlasnik1.DataSource = this.vetSet11;
            // 
            // vlasnikTableAdapter1
            // 
            this.vlasnikTableAdapter1.ClearBeforeFill = true;
            // 
            // ljubimacTableAdapter1
            // 
            this.ljubimacTableAdapter1.ClearBeforeFill = true;
            // 
            // veterinarTableAdapter1
            // 
            this.veterinarTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSourcePregled
            // 
            this.bindingSourcePregled.DataMember = "Pregledi";
            this.bindingSourcePregled.DataSource = this.vetSet11;
            // 
            // preglediTableAdapter
            // 
            this.preglediTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxVrsta
            // 
            this.textBoxVrsta.Location = new System.Drawing.Point(673, 56);
            this.textBoxVrsta.Name = "textBoxVrsta";
            this.textBoxVrsta.ReadOnly = true;
            this.textBoxVrsta.Size = new System.Drawing.Size(240, 22);
            this.textBoxVrsta.TabIndex = 34;
            this.textBoxVrsta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // FormKontaktZakazivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(945, 486);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxVrsta);
            this.Controls.Add(this.buttonDodajLjubimca);
            this.Controls.Add(this.comboBoxImeZiv);
            this.Controls.Add(this.comboBoxVrstaZiv);
            this.Controls.Add(this.labelIyborImena);
            this.Controls.Add(this.labelIzborVrste);
            this.Controls.Add(this.dateTimePickerrodj);
            this.Controls.Add(this.radioButtonPolZ);
            this.Controls.Add(this.radioButtonPolM);
            this.Controls.Add(this.textBoxUnosrase);
            this.Controls.Add(this.buttonNe);
            this.Controls.Add(this.buttonDa);
            this.Controls.Add(this.labelNoviLjubimac);
            this.Controls.Add(this.labelRasaZiv);
            this.Controls.Add(this.labelDatumRodj);
            this.Controls.Add(this.labelPolZiv);
            this.Controls.Add(this.textBoxUnosVrsteZivotinje);
            this.Controls.Add(this.comboBoxIzborVeterinara);
            this.Controls.Add(this.labelImeZiv);
            this.Controls.Add(this.textBoxImeZivotinje);
            this.Controls.Add(this.buttonZakazi);
            this.Controls.Add(this.buttonOtkaziPregled);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelRazlogPregleda);
            this.Controls.Add(this.textBoxRazlogPregledaUnos);
            this.Controls.Add(this.labelVeterinar);
            this.Controls.Add(this.labelVrstaZiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKontaktZakazivanje";
            this.Load += new System.EventHandler(this.FormKontaktZakazivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLjubimac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVlasnik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVrstaZiv;
        private System.Windows.Forms.Label labelVeterinar;
        private System.Windows.Forms.TextBox textBoxRazlogPregledaUnos;
        private System.Windows.Forms.Label labelRazlogPregleda;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Button buttonOtkaziPregled;
        private System.Windows.Forms.Button buttonZakazi;
        private System.Windows.Forms.TextBox textBoxImeZivotinje;
        private System.Windows.Forms.Label labelImeZiv;
        private System.Windows.Forms.ComboBox comboBoxIzborVeterinara;
        private System.Windows.Forms.TextBox textBoxUnosVrsteZivotinje;
        private System.Windows.Forms.Label labelPolZiv;
        private System.Windows.Forms.Label labelDatumRodj;
        private System.Windows.Forms.Label labelRasaZiv;
        private System.Windows.Forms.Label labelNoviLjubimac;
        private System.Windows.Forms.Button buttonDa;
        private System.Windows.Forms.Button buttonNe;
        private System.Windows.Forms.TextBox textBoxUnosrase;
        private System.Windows.Forms.RadioButton radioButtonPolM;
        private System.Windows.Forms.RadioButton radioButtonPolZ;
        private System.Windows.Forms.DateTimePicker dateTimePickerrodj;
        private System.Windows.Forms.Label labelIzborVrste;
        private System.Windows.Forms.Label labelIyborImena;
        private System.Windows.Forms.ComboBox comboBoxVrstaZiv;
        private System.Windows.Forms.ComboBox comboBoxImeZiv;
        private System.Windows.Forms.Button buttonDodajLjubimca;
        private VetSet1 vetSet11;
        private System.Windows.Forms.BindingSource bindingSourceVlasnik1;
        private VetSet1TableAdapters.VlasnikTableAdapter vlasnikTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSourceLjubimac;
        private VetSet1TableAdapters.LjubimacTableAdapter ljubimacTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSourceVet;
        private VetSet1TableAdapters.VeterinarTableAdapter veterinarTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSourcePregled;
        private VetSet1TableAdapters.PreglediTableAdapter preglediTableAdapter;
        private System.Windows.Forms.TextBox textBoxVrsta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        //       private UI_pokusaj.BazaDataSetTableAdapters.VeterinarTableAdapter veterinarTableAdapter;
    }
}