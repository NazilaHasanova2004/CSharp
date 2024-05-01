using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson21_orj
{

    public partial class Form1 : Form
    {
        public static Form1 form1;
        public DataGridView datagrid;
        public Form1()
        {
            InitializeComponent();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Surname", "Surname");
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Nationality", "Nationality");
            dataGridView1.Columns.Add(imageColumn);
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("Address", "Address");
            form1 = this;
            datagrid = form1.dataGridView1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
        }
        public class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Id { get; set; }
            public string Date { get; set; }
            public string Nationality { get; set; }
            public string ImagePath { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Bitmap image = (Bitmap)dataGridView1.CurrentCell.Value;
            Form3.form3.pictureBox.Image = image;
            Form3.form3.pictureBox.SizeMode=PictureBoxSizeMode.StretchImage;
        }
    }
}
