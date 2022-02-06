using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_pokusaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]        //vezano za okvir i mousedown copypaste
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,int wParam,int lParam);

        //--------------------------
        int btnFlag = 0;
        int ZakaziFlag = 0;

    //---------------------------------za prikazivanje child formi na panel forme Form1
    public void loadform(object Form)
        {
            if (this.panelForma.Controls.Count > 0)
                this.panelForma.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelForma.Controls.Add(f);
            this.panelForma.Tag = f;
            f.Show();

        }
    //-----------------------------------------------------------
        private void buttonZdravlje_Click(object sender, EventArgs e)
        {
            
            if (btnFlag == 1 || ZakaziFlag ==1)
            {
                var res = MessageBox.Show("Da li ste sigurni? Vaši izbori neće biti zabeleženi!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
       //             MessageBox.Show($"Kliknuto je yes Flag={btnFlag}"); //provera /obrisati u konacnoj fazi
                    loadform(new Forms.FormZdravlje());
                    labelBar1.Text = "Zdravlje";
                    btnFlag = 0;//reset flagova
                    ZakaziFlag = 0;
                        buttonZdravlje.Enabled = false;
                    buttonMedikament.Enabled = true;
                    buttonZakazi.Enabled = true;
                    buttonZivotinje.Enabled = true;
                }
            }
            else
            {
                loadform(new Forms.FormZdravlje());
                labelBar1.Text = "Zdravlje";
                    buttonZdravlje.Enabled = false;
                buttonMedikament.Enabled = true;
                buttonZakazi.Enabled = true;
                buttonZivotinje.Enabled = true;
            }        
        }
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void buttonMedikament_Click(object sender, EventArgs e)
        {
            if (ZakaziFlag == 1) 
            {
                var res = MessageBox.Show("Da li ste sigurni? Vaši izbori neće biti zabeleženi!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    loadform(new Forms.FormMedikamentiProdavnica());
                    labelBar1.Text = "VetShop";
                    btnFlag = 1; //lokalni flag---sluzi da zaustavi reset stranice prilikom ponovnog klika na dugme za otvaranje shopa
                    ZakaziFlag = 0;
                        buttonMedikament.Enabled = false;
                    buttonZakazi.Enabled = true;
                    buttonZivotinje.Enabled = true;
                    buttonZdravlje.Enabled = true;
                }
            } 
            else 
            {
                loadform(new Forms.FormMedikamentiProdavnica());
                labelBar1.Text = "VetShop";
                ZakaziFlag = 0;
                btnFlag = 1;
                    buttonMedikament.Enabled = false;
                buttonZakazi.Enabled = true;
                buttonZivotinje.Enabled = true;
                buttonZdravlje.Enabled = true;
                /*otvori normalno i resi fleg*/
            }      
        }
        private void buttonZakazi_Click(object sender, EventArgs e)
        {
            if (btnFlag == 1)
            {
                var res = MessageBox.Show("Da li ste sigurni? Vaši izbori neće biti zabeleženi!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    loadform(new Forms.FormKontaktZakazivanje());
                    labelBar1.Text = "Zakazivanje";
                    btnFlag = 0;//reset flaga
                    ZakaziFlag = 1;
                    buttonZakazi.Enabled = false;
                    buttonMedikament.Enabled = true;
                    buttonZivotinje.Enabled = true;
                    buttonZdravlje.Enabled = true;

                }
            }
            else
            {
                loadform(new Forms.FormKontaktZakazivanje());
                labelBar1.Text = "Zakazivanje";
                ZakaziFlag = 1;
                btnFlag = 0;
                buttonZakazi.Enabled = false;
                buttonMedikament.Enabled = true;
                buttonZivotinje.Enabled = true;
                buttonZdravlje.Enabled = true;
            }
        }

        private void buttonZivotinje_Click(object sender, EventArgs e)
        {
            //--------------------------------------test
     
            //--------------------------------------test

            if (btnFlag == 1 || ZakaziFlag==1)
            {
                var res = MessageBox.Show("Da li ste sigurni? Vaši izbori neće biti zabeleženi!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    loadform(new Forms.FormOnama());
                    labelBar1.Text = "Istorija vaseg ljubimca";
                    btnFlag = 0;//reset flaga
                    ZakaziFlag = 0;
                    buttonMedikament.Enabled = true;
                    buttonZakazi.Enabled = true;
                    buttonZivotinje.Enabled = false;
                    buttonZdravlje.Enabled = true;
                }
            }
            else
            {
                loadform(new Forms.FormOnama());
                labelBar1.Text = "Istorija vaseg ljubimca";
                buttonZivotinje.Enabled = false;
                buttonZdravlje.Enabled = true;
                buttonMedikament.Enabled = true;
                buttonZakazi.Enabled = true;
            }
        }
        //------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Da li ste sigurni?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;    
            }
        }

    }
}
