using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class mapa : Form
    {
        public mapa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Initial City";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
        //*****************************************
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            //************************************************
            textBox2.Text = "Guardman";
            textBox3.Text = "Elite Guardman";
            textBox4.Text = "Slime";
            textBox5.Text = "Bat";
            textBox6.Text = "Hornet";
            textBox7.Text = "Large Snake";
            textBox8.Text = "Spider";
            textBox9.Text = "Warrior";
            textBox10.Text = "Lich";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Evil Castle";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
//***************************************************************************
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        //**********************************************************

            textBox2.Text = "Spectral Draco Knight";
            textBox3.Text = "Hollow Draco Knight";
            textBox4.Text = "Gabranth, The Fift";
         
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Allied Castle";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
//****************************************************
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "The Blue Lagoon";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
//*****************************************************************
            textBox2.Visible = true;
            //*******************************************************
            textBox2.Text = "Leviathan";
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Earth Tower";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            //**********************************************************
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            //*********************************************************

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.Text= "Pyramid";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
//*********************************************************************
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ghost Town";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
//**************************************************
          

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Florest Tower";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            //************************************************************
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;

            //************************************************************
            textBox2.Text = "Blue Plant";
            textBox3.Text = "Red Plant";
            textBox4.Text = "Treant";
            textBox5.Text = "DragonFly";
            textBox6.Text = "Beatle";
            textBox7.Text = "Black Widow";
            textBox8.Text = "Spider";
            textBox9.Text = "Green Elemental";
        }
    }
}
