using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_pokusaj;

namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                new Form1().Show();
                this.Hide();
            }
        else
            {
                MessageBox.Show("Korisničko ime ili lozinka koju ste uneli nisu ispravni, pokušajte ponovo!");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
             }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new FormReg().Show();
            this.Hide(); 
        }
    }
}
