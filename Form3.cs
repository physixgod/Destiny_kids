using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hacka
{
    public partial class Form3 : Form
    {
        public Form3()

        {

            InitializeComponent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();


            newForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormColor FR = new FormColor();
            FR.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {fruit FR = new fruit();
            FR.ShowDialog();
            
        }
    }
}
