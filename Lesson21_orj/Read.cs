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
    public partial class Read : Form
    {
        public static Read read;
        public TextBox tx;
        public Read()
        {
            InitializeComponent();
            read = this;
            tx = textBox1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
