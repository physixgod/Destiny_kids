using hacka.Resources;
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
    public partial class Form4 : Form

    {
        public static int score = 0;
        public static int erreur = 3;

        SoundPlayer sound = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\source\repos\hacka\hacka\Resources\oh-no-113125.wav");
        SoundPlayer soundwin = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Downloads\wow-113128.wav");
        public Form4()
        {
            InitializeComponent();


            
              Random rnd = new Random();
              valeur1.Text = rnd.Next(0, 10).ToString();
              char[] word = "+".ToCharArray();
              Random rn = new Random();
              cal.Text = word[rn.Next(0, word.Length)].ToString();




              valeur2.Text = rnd.Next(0 , Convert.ToInt32(valeur1.Text)).ToString();

              OpenFileDialog img1 = new OpenFileDialog();
              

            val1.Text = Convert.ToString(Convert.ToInt32(valeur1.Text)+Convert.ToInt32(valeur2.Text));
        }

        private void val2_Click(object sender, EventArgs e)
        {
            sound.Play();
            erreur--;
            labscor.Text = Convert.ToString(erreur);
            if (erreur == 0)
            {

                    Loste l = new Loste();
                    l.ShowDialog();
                    this.Close();

                
            }
        }

        private void val1_Click(object sender, EventArgs e)
        {
            
            soundwin.Play();
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            erreur = 3;
            score += 10;
            labscore.Text = Convert.ToString(score);
            val1.Enabled = false;val2.Enabled = false;
            val4.Enabled = false;
            val3.Enabled = false;
            next.Visible = true;
            go.Visible = true;

        }

        private void val3_Click(object sender, EventArgs e)
        {
            sound.Play();
            erreur--;
            labscor.Text = Convert.ToString(erreur);
            if (erreur == 0)
            {
                Loste l = new Loste();
                l.ShowDialog();
                this.Close();
            }
        }

        private void val4_Click(object sender, EventArgs e)
        {
            sound.Play();
            erreur--;
            labscor.Text = Convert.ToString(erreur);
            if (erreur == 0)
            {
                Loste l = new Loste();
                l.ShowDialog();
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            score = 0;
            erreur = 3;

            newForm.ShowDialog();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            labscore.Text = Convert.ToString(score);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();


            newForm.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {

            FormSoustraction newForm = new FormSoustraction();


            newForm.ShowDialog();
            this.Close();
        }

        private void cal_Click(object sender, EventArgs e)
        {

        }

        private void valeur2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labscor_Click(object sender, EventArgs e)
        {

        }

        private void labscore_Click(object sender, EventArgs e)
        {

        }

        private void valeur1_Click(object sender, EventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {

        }
    }
}
