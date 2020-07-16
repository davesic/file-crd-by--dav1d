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
    public partial class move_folder : Form
    {
        public move_folder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path1 = @textBox1.Text;
            string path2 = @textBox2.Text;

            try
            {
                Directory.Move(path1, path2);
                Form good = new folder_good_move();
                good.ShowDialog();
            }
            catch (Exception es)
            {

                Console.WriteLine(es.Message);
            }
        }
    }
}
