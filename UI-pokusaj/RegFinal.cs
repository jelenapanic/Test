using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_pokusaj
{
    public partial class RegFinal : Form
    {
        
        public RegFinal()
        {
            InitializeComponent();
        }
        
        private void buttonPetInfo_Click(object sender, EventArgs e)
        {
            if(textBoxPetName.Text != "" || textBoxRasa.Text != "" || textBoxVrsta.Text != "")
            {
                var row = vetSet11.Ljubimac.NewLjubimacRow();
                row.Ime = textBoxPetName.Text;
                row.Vrsta = textBoxVrsta.Text;
                row.Rasa = textBoxRasa.Text;
                if (rBZ.Checked)
                    row.Pol = "Z";
                else row.Pol = "M";
                row.Rodjendan = dateTimePicker1.Value;
                //vet?????
                //vlasnik nekako nzm-------------------------RESIO

                //-----------------------test
                int incIDvlasnik = vetSet11.Vlasnik.Max(x => x.VlasnikID);
                row.Vlasnik = incIDvlasnik+1; ////----------napravi: Izvuci MAX ID i dodaj 1 zatim upisi na neku lok pa odatle u row.Vlasnik
                //------------------------test

                vetSet11.Ljubimac.AddLjubimacRow(row);
                ljubimacTableAdapter1.Update(vetSet11);

                MessageBox.Show($"Dodat je {textBoxPetName.Text} kao Vaš ljubimac", "", MessageBoxButtons.OK);
                textBoxPetName.Clear();
                textBoxVrsta.Clear();
                textBoxRasa.Clear();
                dateTimePicker1.ResetText();
                rBM.Checked = false;
                rBZ.Checked = false;
           
                MessageBox.Show("Uspešno ste kreirali Vaš korisnički nalog i prijavili vaseg ljubimca!");
                new Form1().Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormReg().Show();
            this.Hide();
        }

        private void RegFinal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetSet11.Vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.Fill(this.vetSet11.Vlasnik);
            comboBoxVlasnikID.Hide();
        }

        private void comboBoxVlasnikID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // UPISUJE ID NAJNOVIJEG KORISNIKA
        }
    }
}
