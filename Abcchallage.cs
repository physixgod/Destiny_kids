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
    public partial class Abcchallage : Form
    {
        public Abcchallage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer soundL = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\L .wav");
            soundL.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            brav br = new brav();
            br.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();


            newForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
