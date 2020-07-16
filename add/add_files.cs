using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davefiles.add
{
    public partial class add_files : Form
    {
        public add_files()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            string name = textBox2.Text;

            if (!File.Exists(Path.Combine(path, name)))
            {
                Close();
                // If file found, delete it    
                File.Create(Path.Combine(path, name));
                Form good_create = new add_files_right();
                good_create.ShowDialog();
            }
            else
            {
                Form error_add = new add_fail();
                error_add.ShowDialog();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
