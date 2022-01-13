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
    public partial class FormZdravlje : Form
    {
        public FormZdravlje()
        {
            InitializeComponent();
        }

        private void FormZdravlje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetSet11.Veterinar' table. You can move, or remove it, as needed.
            this.veterinarTableAdapter.Fill(this.vetSet11.Veterinar);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
