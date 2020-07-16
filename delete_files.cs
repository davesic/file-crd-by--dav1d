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

namespace davefiles
{
    public partial class delete_files : Form
    {
        public delete_files()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form delete_1 = new delete_files();
            delete_1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Default folder    
            string rootFolder = textBox1.Text;
            //Filename
            string authorsFile = textBox2.Text;
            if (File.Exists(Path.Combine(rootFolder, authorsFile)))
            {
                Close();
                // If file found, delete it    
                File.Delete(Path.Combine(rootFolder, authorsFile));
                Form good_delete = new delete_files_right();
                good_delete.ShowDialog();
            }
            else
            {
                Form error_delete = new delete_fail();
                error_delete.ShowDialog();
            }
        }
    }
}
