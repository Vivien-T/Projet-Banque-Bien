using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBanque
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }   

        public void Bouton1_Click(object sender, EventArgs e)
        {
            int id = 1;
            string nom = textBox1.Text;
            string prenom = textBox2.Text;
            DateTime dateNaissance = dateTimePicker1.Value;
            string adresse = textBox3.Text;
            int codePostal = Convert.ToInt32(textBox4.Text.Trim());
            string ville = textBox5.Text;
            string telephone = textBox6.Text;
            string mail = textBox7.Text;

            FormClient formClient = new FormClient(id, nom, prenom, dateNaissance, adresse, codePostal, ville, telephone, mail);
            if (formClient.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
