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
            if(textBoxPetName.Text == "" || textBoxRasa.Text == "" || textBoxVrsta.Text == "")
            {
                MessageBox.Show("Molimo Vas, popunite sve podatke o vašem ljubimcu!"); 
            }
            else
            {
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
    }
}
