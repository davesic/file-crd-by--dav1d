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

namespace davefiles.delete
{
    public partial class delete_folder : Form
    {
        public delete_folder()
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
            string path2 = path1+'\\'+name;

            if (!Directory.Exists(path2))
            {
                Form error = new delete_folder_fail();
                error.ShowDialog();
            }
            else
            {
                Directory.Delete(path2);
                Form good = new delete_folder_right();
                good.ShowDialog();
            }
        }
    }
}
