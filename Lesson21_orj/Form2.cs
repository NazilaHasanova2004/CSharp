using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson21_orj
{
    public partial class Form2 : Form
    {
        public const string path = @"C:\Users\Azay\Desktop\Students";
        public string imagepath = "";
        DirectoryInfo dr = new DirectoryInfo(path);
        public Form2()
        {
            InitializeComponent();
           if(dr.GetFiles().Length > 0)
            {
                AllStudents();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var lastfile = dr.GetFiles().OrderByDescending(en=>en.Name).Select(f=>f.Name).FirstOrDefault();
           
            string gender = "";
            
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            if(pictureBox1.Image==null)
            {
                if (radioButton1.Checked)
                {
                    imagepath = @"C:\Users\Azay\Downloads\female.jpg";
                }
                else
                {
                    imagepath = @"C:\Users\Azay\Downloads\male.jpg";
                }
            }
            var p = Path.Combine(path, $"{textBox3.Text}.txt");
           Form1.Student st = new Form1.Student();
            var context = $"Name:{textBox1.Text}\r\nSurname:{textBox2.Text}\r\nId:{textBox3.Text}\r\nDate:{dateTimePicker1.Value.ToShortDateString()}\r\n"+
                $"Nationality:{textBox4.Text}\r\nImagePath-{imagepath}\r\nGender:{gender}\r\nAddress:{textBox5.Text}";
            File.WriteAllText(p,context);

            DialogResult dialogResult = MessageBox.Show("Do you want to close tab?\r\n",null,MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            if (dialogResult==DialogResult.Yes)
            {
                Close();
                AllStudents();
            }
            else
            {
                AllStudents();
            }

        }
        public void AllStudents()
        {
            Form1.form1.datagrid.Rows.Clear();
            var list = AddStudentsToList();

            foreach (var student in list)
            {
                var img = Image.FromFile(student.ImagePath);
                
                Form1.form1.datagrid.Rows.Add(student.Name, student.Surname,student.Id,student.Date,student.Nationality,img,student.Gender,student.Address);
            }
        }
       
        public List<Form1.Student> AddStudentsToList()
        {
            List<Form1.Student> list = new List<Form1.Student>();
            foreach (var file in dr.GetFiles())
            {
                var filelines = File.ReadAllLines(file.FullName);

              
                int n;
                if (int.TryParse(filelines.FirstOrDefault(line => line.StartsWith("Id:"))?.Split(':')[1].Trim(), out n))
                {
                    var st = new Form1.Student
                    {
                        Name = filelines.FirstOrDefault(line => line.StartsWith("Name:"))?.Split(':')[1].Trim(),
                        Surname = filelines.FirstOrDefault(line => line.StartsWith("Surname:"))?.Split(':')[1].Trim(),
                        Id = n,
                        Date = filelines.FirstOrDefault(line => line.StartsWith("Date:"))?.Split(':')[1].Trim(),
                        Nationality = filelines.FirstOrDefault(line => line.StartsWith("Nationality:"))?.Split(':')[1].Trim(),
                        ImagePath = filelines.FirstOrDefault(line => line.StartsWith("ImagePath-"))?.Split('-')[1].Trim(),
                        Gender = filelines.FirstOrDefault(line => line.StartsWith("Gender:"))?.Split(':')[1].Trim(),
                        Address = filelines.FirstOrDefault(line => line.StartsWith("Address:"))?.Split(':')[1].Trim(),

                    };

                    list.Add(st);
                }
                else
                {
                    // Log or handle invalid ID here
                    Console.WriteLine($"Invalid ID in file: {file.Name}");
                }
            }
            return list;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
               
                imagepath = op.FileName;
                pictureBox1.Image = Image.FromFile(imagepath);
                pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.Show();
           int i = Form1.form1.datagrid.CurrentCell.RowIndex;

            Read.read.tx.Text = $"Name is {Form1.form1.datagrid.Rows[i].Cells[0].Value.ToString()}"+".Surname is "+ Form1.form1.datagrid.Rows[i].Cells[1].Value.ToString()+
              ".Id is "+ Form1.form1.datagrid.Rows[i].Cells[2].Value.ToString()+",Date of birth is "+ Form1.form1.datagrid.Rows[i].Cells[3].Value.ToString()+
              ",Nationality is a "+ Form1.form1.datagrid.Rows[i].Cells[4].Value.ToString()+",Gender is "+ Form1.form1.datagrid.Rows[i].Cells[6].Value.ToString()+
              ".Address is "+ Form1.form1.datagrid.Rows[i].Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = Form1.form1.datagrid.CurrentCell.RowIndex;
            int c = Form1.form1.datagrid.CurrentCell.ColumnIndex;
            

            foreach (var file in dr.GetFiles())
            {
               string n = file.Name.Split('.')[0];
                if (Form1.form1.datagrid.Rows[r].Cells[2].Value.ToString() == n)
                {
                    string[] lines = File.ReadAllLines(path + $"\\{n}.txt");
                    switch (Form1.form1.datagrid.Columns[c].HeaderText)
                    {
                        case "Name":
                            lines[0] = $"Name:{textBox1.Text}";
                            break;
                        case "Surname":
                            lines[1]= $"Surname:{textBox2.Text}";
                            break;
                        case "Image":
                            OpenFileDialog ops = new OpenFileDialog();
                            if (ops.ShowDialog() == DialogResult.OK)
                            {

                                imagepath = ops.FileName;
                                pictureBox1.Image = Image.FromFile(imagepath);
                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                            lines[5] = $"ImagePath-{imagepath}";
                            break;
                        case "Gender":
                            string gender = "";
                            if (radioButton1.Checked)
                            {
                                gender = radioButton1.Text;
                            }
                            else if (radioButton2.Checked)
                            {
                                gender = radioButton2.Text;
                            }
                            lines[6] = $"Gender:{gender}";
                            break;
                        case "Address":
                            lines[7] = $"Address:{textBox5.Text}";
                            break;

                    }
                    File.WriteAllLines(path + $"\\{n}.txt", lines);
                }

            }
            AllStudents();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r = Form1.form1.datagrid.CurrentCell.RowIndex;
            var row = Form1.form1.datagrid.SelectedCells;
            foreach (var file in dr.GetFiles())
            {
                string n = file.Name.Split('.')[0];
                if (Form1.form1.datagrid.Rows[r].Cells[2].Value.ToString() == n)
                {
                    file.Delete();
                    foreach (DataGridViewRow dataGridViewRow in Form1.form1.datagrid.SelectedRows)
                    {
                        Form1.form1.datagrid.Rows.Remove(dataGridViewRow);
                    }
                    AllStudents();
                    break;
                }
            }


        }
    }
}
