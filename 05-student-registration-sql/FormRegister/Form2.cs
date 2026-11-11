using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegister
{
    public partial class Form2 : Form
    {
        private dbClient dbclient;

        public Form2()
        {
            InitializeComponent();
            dbclient = new dbClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students student = new Students(
                Convert.ToInt32(textBox1.Text),
                textBox2.Text,
                textBox3.Text);

            dbclient.addStudents(student);
            MessageBox.Show("Data berhasil ditambahkan!");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students student = new Students(
            Convert.ToInt32(textBox1.Text),
            textBox2.Text,
             textBox3.Text);

            dbclient.updateStudents(student);
            MessageBox.Show("Data berhasil diubah!");

            this.Close();
        }
    }
    }

