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
    public partial class FormSoustraction : Form
    {
        SoundPlayer sound = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\source\repos\hacka\hacka\Resources\oh-no-113125.wav");
        SoundPlayer soundwin = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Downloads\wow-113128.wav");

        public FormSoustraction()
        {
            InitializeComponent();
            Random rndd = new Random();
            valeur1.Text = rndd.Next(0, 10).ToString();
            char[] word = "-".ToCharArray();
            Random rn = new Random();
            cal.Text = word[rn.Next(0, word.Length)].ToString();




            valeur2.Text = rndd.Next(0, Convert.ToInt32(valeur1.Text)).ToString();

            OpenFileDialog img1 = new OpenFileDialog();


            val1.Text = Convert.ToString(Convert.ToInt32(valeur1.Text) - Convert.ToInt32(valeur2.Text));
            
        }

        private void val1_Click(object sender, EventArgs e)
        {
            soundwin.Play();
            pictureBox1.Visible = false;
            yah.Visible = true;
            Form4.erreur = 3;
            Form4.score += 10;
            labscore.Text = Convert.ToString(Form4.score);
            val1.Enabled = false; val2.Enabled = false;
            val4.Enabled = false;
            val3.Enabled = false;
            next.Visible = true;
            go.Visible = true;
        }

        private void next_Click(object sender, EventArgs e)
        {

            Form4 newForm = new Form4();


            newForm.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormSoustraction_Load(object sender, EventArgs e)
        {
            labscore.Text = Form4.score.ToString();
        }

        private void val2_Click(object sender, EventArgs e)
        {
            sound.Play();
            Form4.erreur--;
            labscor.Text = Convert.ToString(Form4.erreur);
            if (Form4.erreur == 0)
            {

                Loste l = new Loste();
                l.ShowDialog();
                this.Close();


            }
        }

        private void val3_Click(object sender, EventArgs e)
        {
            sound.Play();
            Form4.erreur--;
            labscor.Text = Convert.ToString(Form4.erreur);
            if (Form4.erreur == 0)
            {

                Loste l = new Loste();
                l.ShowDialog();
                this.Close();


            }
        }

        private void val4_Click(object sender, EventArgs e)
        {
            sound.Play();
            Form4.erreur--;
            labscor.Text = Convert.ToString(Form4.erreur);
            if (Form4.erreur == 0)
            {

                Loste l = new Loste();
                l.ShowDialog();
                this.Close();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            Form4.score = 0;
            Form4.erreur = 3;
            newForm.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            
            newForm.ShowDialog();
            this.Close();
        }
    }
}
