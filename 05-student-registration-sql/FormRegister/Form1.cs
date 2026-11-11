using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FormRegister
{
    public partial class Form1 : Form
    {
        private dbClient dbclient;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            dbclient = new dbClient();
            dataGridView1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                DataTable studentsData = dbclient.getAllStudents();

                dataGridView1.DataSource = studentsData;
                dataGridView1.Visible = true;

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 vregister = new Form2();
            vregister.MdiParent = this;
            vregister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    var cellValue = row.Cells["nimStudent"].Value;

                    if (cellValue != null)
                    {
                        string nim = cellValue.ToString();

                        DialogResult result = MessageBox.Show(
                            $"Yakin ingin menghapus data dengan NIM {nim}?",
                            "Konfirmasi Hapus",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            dbclient.deleteStudents(nim);
                            MessageBox.Show("Data berhasil dihapus!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable studentTable = dbclient.getAllStudents();
                var sortedName = from DataRow row in studentTable.Rows
                                 orderby row["nameStudent"].ToString()
                                 select row;
                dataGridView1.Visible = true;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = sortedName.CopyToDataTable();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable studentTable = dbclient.getAllStudents();
                var sortedMin = from DataRow row in studentTable.Rows
                                orderby row["nimStudent"]
                                select row;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = sortedMin.CopyToDataTable();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }
    }
}    

