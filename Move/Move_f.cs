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

namespace davefiles.Move
{
    public partial class Move_f : Form
    {
        public Move_f()
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
            string path2 = textBox2.Text;

            // If there is no file path1 - create
            if (!File.Exists(path1))
            {
                using (FileStream fs = File.Create(path1)) {}
            }
            // If path2 already has such a file - delete
            if (File.Exists(path2))
            {
                File.Delete(path2);
            }

            // Move file
            File.Move(path1, path2);
            Form move_good = new move_files_right();
            move_good.ShowDialog();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
