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
    public partial class FormMedikamentiProdavnica : Form
    {
        public FormMedikamentiProdavnica()
        {
            InitializeComponent();
        }
        int FlagPorudzbina = 0;
        private void FormMedikamentiProdavnica_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetSet11.Porudzbine' table. You can move, or remove it, as needed.
            this.porudzbineTableAdapter.Fill(this.vetSet11.Porudzbine);
            // TODO: This line of code loads data into the 'vetSet11.Shop' table. You can move, or remove it, as needed.
            this.shopTableAdapter1.Fill(this.vetSet11.Shop);
     
            comboBoxCena.Hide();
        }

        private void buttonPoruci_Click(object sender, EventArgs e)
        {

            if (textBoxGrad.Text != "" && textBoxTrenutnaKolicina.Text != "" && textBoxCENA.Text != "" &&
                textBoxMejl.Text != "" && richTextBoxADRESA.Text != "")
            {
                var res = MessageBox.Show("Potvrdite porudzbinu!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    if (comboBoxProizvodi.Text != "")
                        MessageBox.Show($"Poručeno je:  {textBoxTrenutnaKolicina.Text} proizvoda:  {comboBoxProizvodi.Text} " +
                            $" Ukupna cena:  {textBoxCENA.Text}", "Zavrsena kupovina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //puni se baza 
                    var row = vetSet11.Porudzbine.NewPorudzbineRow();
                    row.Proizvodi = comboBoxProizvodi.SelectedIndex + 1;// zbog indeksa...0+1
                    //-----------------------------------------------??
                    row.Količina = textBoxTrenutnaKolicina.Text;
                    row.Ukupna_cena = Int32.Parse(textBoxCENA.Text);//?
                    row.Adresa = richTextBoxADRESA.Text;
                    //-----------------------------------------------
                    //nacin placaja radioBtn...
                    if (radioButtonOnline.Checked)
                        row.Način_plaćanja = "Pouzećem";
                    if (radioButtonPouzecem.Checked)
                        row.Način_plaćanja = "Online";
                    //-----------------------------------------
                    row.Email = textBoxMejl.Text;
                    row.Grad = textBoxGrad.Text;
                    //88888888888888888888888888888888888888888888888
                    vetSet11.Porudzbine.AddPorudzbineRow(row);
                    porudzbineTableAdapter.Update(vetSet11);
                    //flag za kupovinu i otkazivanje
                    FlagPorudzbina = 1;
                    
                }
            }
            else
            {
                MessageBox.Show("Popuni sva polja!");
            }
            

            /*  ovde flagPoruci=1, ako se klikne otkazi on proverava da li je fleg set na 1;
             *  ako jeste onda brise poslednju unetu porudzbinu. posto je opasno ovo, ograniciti da je porucivanje mogce
             *  ako su sva polja popunjena, otkazi resetuje fleg i fleg postaje=0 sve dok se ne poruci nesto...
                         
             */
        }

        private void buttonPovecajKolicinu(object sender, EventArgs e)
        {
            int a = 0;
            a = Int32.Parse(textBoxTrenutnaKolicina.Text);
            a++;
            textBoxTrenutnaKolicina.Text = a.ToString();
            textBoxCENA.Text = bindingSourceCena1.ToString();    //ovo se treba mnoziti sa cenom

        }

        private void btnSmanjiKolicinu_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = Int32.Parse(textBoxTrenutnaKolicina.Text);
            a--;
            if (a <= 0)
            {
                a = 0;
            }
            textBoxTrenutnaKolicina.Text = a.ToString();
            textBoxCENA.Text = a.ToString();
        }

        private void btnOtkaziKupovinu_Click(object sender, EventArgs e)
        {
            //ako je napravljena porudzbina fleg je =1, ovde na samom startu pitaj da li je ==1,
            //ako jeste brisi poslednju porudzbinu po id-u 
            if (FlagPorudzbina == 1) {
                FlagPorudzbina = 0; //resetuje fleg
                                    //brisi vrstu po id
                                    ////////////////////////////////////////////////////////
                                    //ovo ne brise nego postavlja sve na 0 u tabelu za tu porudzbiu...----------------KAKO OBRISATI RED 

               




                ////////////////////////////////////////////////////////
            }
            else
            {
                //nista
            }
        }

        private void textBoxCENA_TextChanged(object sender, EventArgs e)
        {
          
          //  textBoxCENA.Text = comboBoxCena.Text;
            int tmpcena = 0;
            int tmpkol = 1;
            tmpcena = Int32.Parse(comboBoxCena.Text);
            tmpkol = Int32.Parse(textBoxTrenutnaKolicina.Text);
            tmpcena = tmpcena * tmpkol;
            textBoxCENA.Text = tmpcena.ToString();
        }

        private void comboBoxProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourceCena1.Filter = string.Format("ShopID = {0}", comboBoxProizvodi.SelectedValue ?? 0);
            textBoxTrenutnaKolicina.Text = "1"; //reset nakon promene proizvoda |ovo ovako pise da bi radilo dugme +- posto ovaj text prebacuje u int...
            textBoxCENA.Text = comboBoxCena.Text;
            
        }

        private void comboBoxCena_SelectedIndexChanged(object sender, EventArgs e)
        {
           //postoji samo zbog preuzimanja cene||| VRV postoji bolje resenje...
        }
    }
}
