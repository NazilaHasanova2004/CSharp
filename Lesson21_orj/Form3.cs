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
    public partial class Form3 : Form
    {
        public PictureBox pictureBox;
        public static Form3 form3;
        public Form3()
        {
            InitializeComponent();
            form3 = this;
            pictureBox = pictureBox2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
