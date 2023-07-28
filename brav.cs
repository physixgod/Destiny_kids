using hacka.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hacka
{
    public partial class brav : Form
    {
        public brav()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Loste newForm = new Loste();
           
            newForm.ShowDialog();
            this.Close();
        }
    }
}
