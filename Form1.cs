using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();


            newForm.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer start = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Downloads\comic5-25269.wav");
           
                start.Play();

              
            

        }
    }
}
