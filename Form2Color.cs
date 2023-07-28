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
    public partial class Form2Color : Form
    {
       
        public static int erreur = 3;
        SoundPlayer start = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\identify-the-color-of-the-leaf-.wav");
        SoundPlayer sound = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\source\repos\hacka\hacka\Resources\oh-no-113125.wav");
        SoundPlayer soundwin = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Downloads\wow-113128.wav");

        public Form2Color()
        {
            InitializeComponent();
        }

        private void nextb_Click(object sender, EventArgs e)
        {
           
        }

        private void greenb_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = true;
            blueb.Visible = false;
            redb.Visible = false;
            yellob.Visible = false;
            greenb.Visible = false;
            goodb.Visible = true;
            nextb.Visible = true;
            FormColor.erreur = 3;
            FormColor.score += 10;
            label8.Text = Convert.ToString(FormColor.score);
        }

        private void blueb_Click(object sender, EventArgs e)
        {
            sound.Play();
            erreur--;
            label2.Text = Convert.ToString(erreur);
            if (erreur == 0)
            {

                Loste l = new Loste();
                l.ShowDialog();
                this.Close();


            }
        }

        private void redb_Click(object sender, EventArgs e)
        {
            sound.Play();
            erreur--;
            label2.Text = Convert.ToString(erreur);
            if (erreur == 0)
            {

                Loste l = new Loste();
                l.ShowDialog();
                this.Close();


            }
        }

        private void yellob_Click(object sender, EventArgs e)
        {
            sound.Play();
            erreur--;
            label2.Text = Convert.ToString(erreur);
            if (erreur == 0)
            {
                
                Loste l = new Loste();
                l.ShowDialog();
                this.Close();


            }
        }

        private void Form2Color_Load(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(FormColor.score);
            start.PlaySync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            start.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormColor newForm = new FormColor();
            FormColor.score = 0;
            FormColor.erreur = 3;
            newForm.ShowDialog();
            this.Close();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();


            newForm.ShowDialog();
            this.Close();
        }
    }
}
