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

namespace davefiles.Rename
{
    public partial class rename_files : Form
    {
        public rename_files()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path1 = textBox1.Text;
            string name = textBox2.Text;
            string path2 = path1 + '\\' + name;

            if(!File.Exists(path1))
            {
                Form error = new rename_files_error();
                error.ShowDialog();
            }
            else
            {
                File.Move(path1, name);
                Form good = new rename_file_good();
                good.ShowDialog();
            }
            

        }
    }
}
