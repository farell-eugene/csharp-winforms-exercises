using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace perpustakaanUMN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Book> daftarBuku = new List<Book>();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (daftarBuku.Count > 0)
            {
                for (int i = 0; i < daftarBuku.Count; i++)
                {
                    listBox1.Items.Add($"{i + 1}. " +
                        $"{daftarBuku[i].Title} - " +
                        $"{daftarBuku[i].Author} - " +
                        $"{daftarBuku[i].Type} - " +
                        $"{daftarBuku[i].Year}");
                }
            }
            else
            {
                MessageBox.Show("Buku Kosong!", "Informasi");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    Book buku = new Book();
                    buku.Title = inputJudul.Text; 
                    buku.Author = inputPenulis.Text;
                    buku.Type = radioButton1.Text;
                    buku.Year = inputTahun.Text; 

              
                    if (int.TryParse(inputJumlah.Text, out int jumlah))
                    {
                        buku.Qty = jumlah;
                        daftarBuku.Add(buku);
                        MessageBox.Show("Data berhasil masuk", "Informasi");
                    }
                    else
                    {
                        MessageBox.Show("Input jumlah tidak valid. Harap masukkan angka.", "Error");
                    }
                }
                else
                {
                    Book buku = new Book();
                    buku.Title = inputJudul.Text;
                    buku.Author = inputPenulis.Text;
                    buku.Type = radioButton2.Text;
                    buku.Year = inputTahun.Text;

           
                    buku.Qty = 0;

                    daftarBuku.Add(buku);
                    MessageBox.Show("Data berhasil masuk", "Informasi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            var bukuFiksi = daftarBuku.FindAll(b => b.Type == "Fiksi");
            if (bukuFiksi.Count > 0)
            {
                int nomor = 1;
                foreach (var buku in bukuFiksi)
                {
                    listBox1.Items.Add($"{nomor}. {buku.Title} - {buku.Author} - {buku.Year}");
                    nomor++;
                }
            }
            else
            {
                MessageBox.Show("Tidak ada buku fiksi", "Informasi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var bukuNonFiksi = daftarBuku.FindAll(b => b.Type == "Non-Fiksi");
            if (bukuNonFiksi.Count > 0)
            {
                int nomor = 1;
                foreach (var buku in bukuNonFiksi)
                {
                    listBox1.Items.Add($"{nomor}. {buku.Title} - {buku.Author} - {buku.Year}");
                    nomor++;
                }
            }
            else
            {
                MessageBox.Show("Tidak ada buku non-fiksi", "Informasi");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBox1.SelectedIndex;
                if (daftarBuku[index].borrowBooks())
                {
                    Student mahasiswa = new Student(inputNim.Text, inputNama.Text, comboBox1.SelectedItem.ToString());
                    mahasiswa.AddBorrow(mahasiswa);
                    MessageBox.Show("Data mahasiswa berhasil masuk!");
                }
                else
                {
                    MessageBox.Show("Buku tidak tersedia!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}


