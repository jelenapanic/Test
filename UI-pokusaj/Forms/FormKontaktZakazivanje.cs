using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_pokusaj.Forms
{
    public partial class FormKontaktZakazivanje : Form
    {
        public FormKontaktZakazivanje()
        {
            InitializeComponent();
        }
        int FlagZakazi = 0;
        private void FormKontaktZakazivanje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetSet11.Pregledi' table. You can move, or remove it, as needed.
            this.preglediTableAdapter.Fill(this.vetSet11.Pregledi);
            // TODO: This line of code loads data into the 'vetSet11.Veterinar' table. You can move, or remove it, as needed.
            this.veterinarTableAdapter1.Fill(this.vetSet11.Veterinar);
            // TODO: This line of code loads data into the 'vetSet11.Ljubimac' table. You can move, or remove it, as needed.
            this.ljubimacTableAdapter1.Fill(this.vetSet11.Ljubimac);
            // TODO: This line of code loads data into the 'vetSet11.Vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter1.Fill(this.vetSet11.Vlasnik);
     

        }



        private void textBoxUnosVrsteZivotinje_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImeZivotinje_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIzborVeterinara_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRazlogPregledaUnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZakazi_Click(object sender, EventArgs e)
        {
            
            if (textBoxRazlogPregledaUnos.Text != "" && textBoxVrsta.Text != "" && comboBoxImeZiv.Text != "" && comboBoxIzborVeterinara.Text != "" )
            {
                var row = vetSet11.Pregledi.NewPreglediRow();
                row.Ljubimac = comboBoxImeZiv.SelectedIndex;
                row.Veterinar = comboBoxIzborVeterinara.SelectedIndex;
                row.Razlog = textBoxRazlogPregledaUnos.Text;
                row.Datum_Pregleda = dateTimePicker1.Value;
                row.Vrsta_životinje = textBoxVrsta.Text;
                    vetSet11.Pregledi.AddPreglediRow(row);
                    preglediTableAdapter.Update(vetSet11);     ///---------problem sa upisom dodatog ljubimca u bazu...

                MessageBox.Show($"Zakazali ste pregled za ljubimca koji se zove {comboBoxImeZiv.Text} , kod veterinara sa imenom {comboBoxIzborVeterinara.Text}.", " ", MessageBoxButtons.OK);
                comboBoxImeZiv.ResetText();
                comboBoxIzborVeterinara.ResetText();
                textBoxRazlogPregledaUnos.Clear();
                textBoxVrsta.Clear();
                dateTimePicker1.ResetText();
                    FlagZakazi = 1;
            }
            else
            {
                MessageBox.Show("Popunite sva polja!");
            }


    



        }

        private void buttonOtkaziPregled_Click(object sender, EventArgs e)
        {
            //?Razmotriti ovo----da li da brise iz baze poslednju unetu stavku klikom na dugme zakazi?
            //defaultno da bude disable, a nakon klika na zakazi postaje enable....--^
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelImeZiv.Hide();
            labelVrstaZiv.Hide();
            labelRasaZiv.Hide();
            labelDatumRodj.Hide();
            labelPolZiv.Hide();
            textBoxImeZivotinje.Hide();
            textBoxUnosVrsteZivotinje.Hide();
            textBoxUnosrase.Hide();
            dateTimePickerrodj.Hide();
            radioButtonPolM.Hide();
            radioButtonPolZ.Hide();
            buttonDodajLjubimca.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajLjubimca_Click(object sender, EventArgs e)
        {
            if (textBoxImeZivotinje.Text != "" && textBoxUnosVrsteZivotinje.Text != "" && textBoxUnosrase.Text != "")
            {
                var row = vetSet11.Ljubimac.NewLjubimacRow();
                row.Ime = textBoxImeZivotinje.Text;
                row.Vrsta = textBoxUnosVrsteZivotinje.Text;
                row.Rasa = textBoxUnosrase.Text;
                if (radioButtonPolZ.Checked)
                    row.Pol = "Z";
                else row.Pol = "M";
                row.Rodjendan = dateTimePickerrodj.Value;
                //vet?????
                //vlasnik nekako nzm------------------------------------------problem
                vetSet11.Ljubimac.AddLjubimacRow(row);
                ljubimacTableAdapter1.Update(vetSet11);

                MessageBox.Show($"Dodat je {textBoxImeZivotinje.Text} kao Vaš novi ljubimac", "Možete zakazati pregled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxImeZivotinje.Clear();
                textBoxUnosVrsteZivotinje.Clear();
                textBoxUnosrase.Clear();
                dateTimePickerrodj.ResetText();
                radioButtonPolM.Checked = false;
                radioButtonPolZ.Checked = false;
            }
            else
                MessageBox.Show("Popuni sva polja!");
        }

        private void buttonDa_Click(object sender, EventArgs e)
        {
            labelImeZiv.Show();
            labelVrstaZiv.Show();
            labelRasaZiv.Show();
            labelDatumRodj.Show();
            labelPolZiv.Show();
            textBoxImeZivotinje.Show();
            textBoxUnosVrsteZivotinje.Show();
            textBoxUnosrase.Show();
            dateTimePickerrodj.Show();
            radioButtonPolM.Show();
            radioButtonPolZ.Show();
            buttonDodajLjubimca.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxImeZiv.SelectedIndex != -1)
            {
                textBoxVrsta.Text=comboBoxVrstaZiv.Text.Trim();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  textBoxVrsta.Text = comboBoxVrstaZiv.ValueMember;
            //  textBoxVrsta.Text = comboBoxVrstaZiv.Text;
            if (comboBoxVrstaZiv.SelectedItem != null)
                textBoxVrsta.Text = comboBoxVrstaZiv.Text;
        }
    }
}