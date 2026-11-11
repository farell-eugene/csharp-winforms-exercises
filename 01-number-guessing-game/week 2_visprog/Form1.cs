using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_2_visprog
{
    public partial class Form1 : Form
    {
        private int angkaRahasia;
        private int percobaan = 0;
        private const int MAX_PERCOBAAN = 10;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            label1.Text = "Applikasi Tebak Angka";
            button1.Text = "Mulai!";
            groupBox1.Text = "Tebak Angka 1-100";
            label2.Text = "Tebak:";
            button2.Text = "Proses";
            label3.Text = "";
            label4.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label1.Visible = false;
            button1.Visible = false;
            angkaRahasia = random.Next(1, 101);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            percobaan++;
            int tebakAngka = Convert.ToInt32(textBox1.Text);
            if (percobaan <= MAX_PERCOBAAN)
            {
                if (tebakAngka == angkaRahasia)
                {
                    label3.Text = $"Selamat, Anda benar! Anda menebak dalam {percobaan} kali percobaan.";
                    button2.Enabled = false;
                }
                else if (angkaRahasia > tebakAngka)
                {
                    label3.Text = $"Angka terlalu kecil! Silahkan Coba lagi! Sisa percobaan: " + (MAX_PERCOBAAN - percobaan);
                }
                else
                {
                    label3.Text = $"Angka terlalu besar, Silahkan Coba lagi! Sisa percobaan: " + (MAX_PERCOBAAN - percobaan);
                }
            
            if (tebakAngka % 2 == 0)
            {
                label4.Text = "Bilangan tersebut adalah bilangan 'Genap'";
            }
            else
            {
                label4.Text = "Bilangan tersebut adalah bilangan 'Ganjil'";
            }
        }
            else
            {
                label3.Text = $"Masa percobaan anda telah lebih dari {percobaan}, maka permainan di hentikan.";
            }
        }
    }
}
