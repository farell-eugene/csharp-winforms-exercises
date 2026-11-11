using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UTSVisualProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label6.Text = "";
            label8.Text = "";
            label10.Text = "";
            label12.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string nip = textBox2.Text;
            double upahBulanan;
            int jumlahAbsen;

            if (!double.TryParse(textBox3.Text, out upahBulanan) || !int.TryParse(textBox4.Text, out jumlahAbsen))
            {
                MessageBox.Show("Harap masukkan angka yang valid untuk upah dan jumlah absen.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int hariKerja = 22 - jumlahAbsen;
            double gajiKotor = upahBulanan;
            double pajak = 0;

            if (upahBulanan < 5000000)
            {
                pajak = gajiKotor * 0.02;
            }
            else
            {
                pajak =( gajiKotor * 0.03) + (gajiKotor * 0.05);
                
            }

            double gajiBersih = gajiKotor - pajak;

            label6.Text = pajak.ToString("C2");
            label8.Text = jumlahAbsen.ToString();
            label10.Text = gajiKotor.ToString("C2");
            label12.Text = gajiBersih.ToString("C2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label6.Text = "";
            label8.Text = "";
            label10.Text = "";
            label12.Text = "";
        }
    }
    
}