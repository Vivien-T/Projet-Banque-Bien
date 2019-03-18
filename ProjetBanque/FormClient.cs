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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            MessageBox.Show("Bienvenue cher client voici les informations que vous avez rentrées, est-ce juste ? :" +
                " {0} {1} {2} {3} {4} {5} {6} {7} ", client.getId, "Mon espace",MessageBoxButtons.YesNo);
        }
    }
}
