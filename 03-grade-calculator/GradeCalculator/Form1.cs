using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
        }
        List<Course> courses = new List<Course>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                int semester = Convert.ToInt32(textBox2.Text);
                if ((textBox1.Text != "") && (textBox2.Text != ""))
                {
                    groupBox2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Input the Field!", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (courses.Any(c => c.CourseName == textBox1.Text))
                {
                    MessageBox.Show("You cannot input data twice!", "Information");
                }
                else
                {
                    Course course = new Course(
                        textBox3.Text,
                        Convert.ToInt32(textBox4.Text),
                        Convert.ToInt32(textBox5.Text),
                        Convert.ToInt32(textBox6.Text),
                        Convert.ToInt32(textBox7.Text)
                    );
                    courses.Add(course);
                    MessageBox.Show("Data Berhasil Masuk!", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                if (courses.Count > 0)
                {
                    dataGridView1.DataSource = courses;
                    chart1.Series.Clear();
                    chart1.Palette = ChartColorPalette.EarthTones;
                    chart1.Titles.Add($"Grade semester {textBox2.Text}");
                    for (int i = 0; i < courses.Count; i++)
                    {
                        Series series = chart1.Series.Add(courses[i].CourseName);
                        series.Points.Add(courses[i].Total);
                    }
                }
                else
                {
                    MessageBox.Show("Data Empty!", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
