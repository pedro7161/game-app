using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace App
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Fire");
            comboBox1.Items.Add("Dark");
            comboBox1.Items.Add("Earth");
            comboBox1.Items.Add("Water");

        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    label10.Text = row.Cells["Id"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
                    textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    byte[] aray = (byte[])dataGridView1.Rows[e.RowIndex].Cells[9].Value;
                    Image img = byteArrayToImage(aray);


                    pictureBox1.Image = img;
                }
            }
            catch
            {

                MessageBox.Show("");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
                if (comboBox1.Text == "Fire")
                {
                    dataGridView1.DataSource = BLL.Monstros.fire(comboBox1.Text);
                }
                if (comboBox1.Text == "Earth")
                {
                    dataGridView1.DataSource = BLL.Monstros.earth(comboBox1.Text);
                   // this.dataGridView1.Sort(this.dataGridView1.Columns["Name"], ListSortDirection.Ascending);
                }
                if (comboBox1.Text == "Dark")
                {
                    dataGridView1.DataSource = BLL.Monstros.dark(comboBox1.Text);
                }
                if (comboBox1.Text == "Water")
                {
                    dataGridView1.DataSource = BLL.Monstros.water(comboBox1.Text);
                }
                if (comboBox1.Text == "")
                {
                    dataGridView1.DataSource = BLL.Monstros.Load();
                }
            }
           if (Check2.Checked==true)
            {
                if (comboBox1.Text == "Fire")
                {
                    dataGridView1.DataSource = BLL.Monstros.fire2(comboBox1.Text);
                }
                if (comboBox1.Text == "Earth")
                {
                    dataGridView1.DataSource = BLL.Monstros.earth2(comboBox1.Text);
                   
                }
                if (comboBox1.Text == "Dark")
                {
                    dataGridView1.DataSource = BLL.Monstros.dark2(comboBox1.Text);
                }
                if (comboBox1.Text == "Water")
                {
                    dataGridView1.DataSource = BLL.Monstros.water2(comboBox1.Text);
                }
                if (comboBox1.Text == "")
                {
                    dataGridView1.DataSource = BLL.Monstros.Load();
                }
                
            }
            else
            {

                if (comboBox1.Text == "Fire")
                {
                    dataGridView1.DataSource = BLL.Monstros.fire3(comboBox1.Text);
                }
                if (comboBox1.Text == "Earth")
                {
                    dataGridView1.DataSource = BLL.Monstros.earth3(comboBox1.Text);
                }
                if (comboBox1.Text == "Dark")
                {
                    dataGridView1.DataSource = BLL.Monstros.dark3(comboBox1.Text);
                }
                if (comboBox1.Text == "Water")
                {
                    dataGridView1.DataSource = BLL.Monstros.water3(comboBox1.Text);
                }
                if (comboBox1.Text == "")
                {
                    dataGridView1.DataSource = BLL.Monstros.Load();
                }
               


                   

                }


            

        }

        private void Check2_CheckedChanged(object sender, EventArgs e)
        {
          

            if (checkBox1.Checked==true)
            {
                checkBox1.Checked = true;
                Check2.Checked = false;

            }
        
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
      
          
            if (Check2.Checked == true)
            {
             
      
                checkBox1.Checked = false;
                Check2.Checked = true;
            }
         

        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL.Monstros.Inserir(textBox9.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox7.Text, textBox8.Text,textBox10.Text);
            MessageBox.Show("inserido");
           /* pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] buff = ms.GetBuffer();
            int vb = BLL.Imagem.insertImagem(buff, textBox2.Text);*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            open1.Multiselect = false;
            if (open1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap(open1.FileName);





            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] buff = ms.GetBuffer();
            int g = BLL.Imagem.insertImagem(buff, textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Monstros.earth(comboBox1.Text);
            // this.dataGridView1.Sort(this.dataGridView1.Columns["Name"], ListSortDirection.Ascending);

        }
    }
}