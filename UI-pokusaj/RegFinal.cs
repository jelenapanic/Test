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
                //vlasnik nekako nzm
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

        private void textBoxVlasnik1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
