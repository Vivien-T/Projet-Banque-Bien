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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }   

        private void Bouton1_Click(object sender, EventArgs e)
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
            Client client = new Client(id, nom, prenom, dateNaissance, adresse, codePostal, ville, telephone, mail);

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            dateTimePicker1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();

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

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}
