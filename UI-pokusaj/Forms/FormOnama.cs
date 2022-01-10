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
            // TODO: This line of code loads data into the 'vetSet11.Pregledi' table. You can move, or remove it, as needed.
            this.preglediTableAdapter.Fill(this.vetSet11.Pregledi);
            // TODO: This line of code loads data into the 'vetSet11.Ljubimac' table. You can move, or remove it, as needed.
            this.ljubimacTableAdapter1.Fill(this.vetSet11.Ljubimac);
           

            comboBox1_SelectedIndexChanged(comboBox1, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourcePregledi.Filter = string.Format("Ljubimac = {0}", comboBox1.SelectedValue ?? 0);
                
        }

        private void listBoxISTORIJA_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           // razmotri mogucnost da ovo bude personalizovano| ulogovani korisnik moze videti istoriju samo za svoje zovotinje!!!!!!!!!!!
        }

      
    }
}
 