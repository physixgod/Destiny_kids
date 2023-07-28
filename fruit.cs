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
    public partial class fruit : Form
    {
        SoundPlayer soundA = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\A.wav");
        SoundPlayer soundB = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\B.wav");
        SoundPlayer soundC = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\C.wav");
        SoundPlayer soundD = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\D.wav");
        SoundPlayer soundE = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\E.wav");
        SoundPlayer soundF = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\F.wav");
        SoundPlayer soundG = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\G.wav");
        SoundPlayer soundH = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\H .wav");
        SoundPlayer soundI = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\I .wav");
        SoundPlayer soundJ = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\J .wav");
        SoundPlayer soundK = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\K .wav");
        SoundPlayer soundL = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\L .wav");
        SoundPlayer soundM = new SoundPlayer(soundLocation: @"C:\Users\TOSHIBA\Desktop\Nouveau dossier\son\2\M .wav");

        public fruit()
        {
            InitializeComponent();
        }

        private void fruit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundA.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            soundB.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            soundC.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            soundD.Play();
        }

     

        private void button5_Click_1(object sender, EventArgs e)
        {
            soundE.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            soundH.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            soundI.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            soundL.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            soundG.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            soundM.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            soundK.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            soundF.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            soundJ.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Abcchallage newForm = new Abcchallage();
            
            newForm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();


            newForm.ShowDialog();
            this.Close();
        }
    }
}
