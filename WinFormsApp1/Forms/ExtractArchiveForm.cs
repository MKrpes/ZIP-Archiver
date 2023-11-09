using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class ExtractArchive : Form
    {
        public ExtractArchive()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //TODO: zasebna klasa
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "ZIP Archive (.zip)|*.zip";
            DialogResult dialogResult = openFileDialog2.ShowDialog();
            if (DialogResult.OK == dialogResult)
            {
                try
                {
                    string file = openFileDialog2.FileName;
                    textBox1.Text = file;
                }
                catch (IOException)
                {
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string foldername = folderBrowserDialog.SelectedPath;
                    textBox2.Text = foldername;
                }
                catch (IOException)
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZipClass.ExtractTo(textBox1.Text, textBox2.Text);
        }
    }
}
