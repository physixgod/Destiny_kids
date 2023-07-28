using hacka.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hacka
{
    public partial class FormColor : Form
    {
        public static int score = 0;
        public static int erreur = 3;
        SoundPlayer start = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\identify-the-color-of-the-sun.wav");
        SoundPlayer sound = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\source\repos\hacka\hacka\Resources\oh-no-113125.wav");
        SoundPlayer soundwin = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Downloads\wow-113128.wav");

        public FormColor()
        {
            InitializeComponent();
           
            
        }

        private void FormColor_Load(object sender, EventArgs e)
        {
            start.PlaySync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = true;
            blueb.Visible = false;
            redb.Visible = false;
            yellob.Visible = false;
            greenb.Visible = false;
            goodb.Visible = true;
            nextb.Visible = true;
            erreur = 3;
            score += 10;
            labscore.Text = Convert.ToString(score);
            won.Visible = true;
        }

        private void redb_Click(object sender, EventArgs e)
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

        private void greenb_Click(object sender, EventArgs e)
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

        private void blueb_Click(object sender, EventArgs e)
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

        private void nextb_Click(object sender, EventArgs e)
        {
          Form2Color Form = new Form2Color();


            Form.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            start.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormColor newForm = new FormColor();
            score = 0;
            erreur = 3;
            newForm.ShowDialog();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();


            newForm.ShowDialog();
            this.Close();
        }
    }
}
