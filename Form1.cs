using System;
using System.IO;
using System.Diagnostics;
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
    public partial class FManager : Form
    {
        public FManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear Listbox again
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo crrDir in dirs)
            {
                listBox1.Items.Add(crrDir);
            }

            // show files

            FileInfo[] files = dir.GetFiles();
            foreach(FileInfo crrFile in files)
            {
                listBox1.Items.Add(crrFile);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Path.GetExtension(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString())) == "")
            {
                textBox1.Text = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());

                //clear Listbox again
                listBox1.Items.Clear();

                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo crrDir in dirs)
                {
                    listBox1.Items.Add(crrDir);
                }

                // show files

                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo crrFile in files)
                {
                    listBox1.Items.Add(crrFile);
                }
            } else
            {
                Process.Start(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString()));
            }
            
        }

        // button back - reload all back files
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '\\')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
            }
            else if (textBox1.Text[textBox1.Text.Length - 1] != '\\')
            {
                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
            }

            listBox1.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo crrDir in dirs)
            {
                listBox1.Items.Add(crrDir);
            }

            // show files

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo crrFile in files)
            {
                listBox1.Items.Add(crrFile);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


                /*
            
                foreach (var drive in DriveInfo.GetDrives())
                {

                    comboBox1.Items.Add("Имя диска: " + drive.Name + "Файловая система: " + drive.DriveFormat);
                    //comboBox1.Items.AddRange(new string[] { "Имя диска: " + drive.Name + "Файловая система: " + drive.DriveFormat + "Тип диска: " + drive.DriveType });
                    *//*Console.WriteLine("Объем доступного свободного места (в байтах): " + drive.AvailableFreeSpace);
                    Console.WriteLine("Готов ли диск: " + drive.IsReady);
                    Console.WriteLine("Корневой каталог диска: " + drive.RootDirectory);
                    Console.WriteLine("Общий объем свободного места, доступного на диске (в байтах): " + drive.TotalFreeSpace);
                    Console.WriteLine("Размер диска (в байтах): " + drive.TotalSize);
                    Console.WriteLine("Метка тома диска: " + drive.VolumeLabel);*//*

                }*/
            }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            DriveInfo[] di = DriveInfo.GetDrives();
            foreach (DriveInfo d in di)
                comboBox1.Items.Add(d.Name);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = comboBox1.SelectedItem.ToString();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo crrDir in dirs)
            {
                listBox1.Items.Add(crrDir);
            }

            // show files

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo crrFile in files)
            {
                listBox1.Items.Add(crrFile);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DriveInfo[] di = DriveInfo.GetDrives();
            foreach (DriveInfo d in di)
                comboBox1.Items.Add(d.Name);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form delete = new delete_files();
            delete.ShowDialog();
        }
    }
}
