using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hacka.Resources
{
    public partial class Loste : Form
    {
        public Loste()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();


            newForm.ShowDialog();
            this.Close();
        }

        private void Loste_Load(object sender, EventArgs e)
        {

        }
    }
}
