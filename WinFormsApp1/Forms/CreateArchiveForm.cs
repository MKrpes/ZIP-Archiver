using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class ZipForm : Form
    {
        public ZipForm()
        {
            InitializeComponent();
        }
        WinFormsApp1.Forms.TextboxEntry entry = new TextboxEntry();

        private void button1_Click(object sender, EventArgs e) //TODO: pretvorit u zasebnu klasu
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string[] files = openFileDialog.FileNames;
                    entry.values = files;
                    string[] filenames = new string[files.Length];
                    for (int i = 0; i < files.Length; i++)
                    {
                        filenames[i] = Path.GetFileName(files[i]);
                        entry.textboxvalue = string.Join(", ", filenames);
                    }
                    textBox1.Text = entry.textboxvalue;
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
            ZipClass.zip(entry.values, textBox2.Text, textBox3.Text);
        }

    }
}
