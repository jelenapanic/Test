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
    public partial class FormOnama : Form
    {
        public FormOnama()
        {
            InitializeComponent();
        }

        private void FormOnama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetSet11.Vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.Fill(this.vetSet11.Vlasnik);
            // TODO: This line of code loads data into the 'vetSet11.Pregledi' table. You can move, or remove it, as needed.
            this.preglediTableAdapter.Fill(this.vetSet11.Pregledi);
            // TODO: This line of code loads data into the 'vetSet11.Ljubimac' table. You can move, or remove it, as needed.
            this.ljubimacTableAdapter1.Fill(this.vetSet11.Ljubimac);
           

            comboBox1_SelectedIndexChanged(comboBox1, null);
            
            comboBox2_SelectedIndexChanged(comboBox2, null);
            listBoxISTORIJA.Hide();
            listBoxTerapija.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourcePregledi.Filter = string.Format("Ljubimac = {0}", comboBox1.SelectedValue ?? 0);
            // bindingSourceLjubimci1.Filter
            listBoxISTORIJA.Show();
            listBoxTerapija.Show();
        }

        private void listBoxISTORIJA_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourceLjubimci1.Filter = string.Format("Vlasnik = {0}", comboBox2.SelectedValue ?? 0);
        }

        private void listBoxTerapija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 