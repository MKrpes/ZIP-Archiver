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
    public partial class AddToArchiveForm : Form
    {
        public AddToArchiveForm()
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

        private void button2_Click(object sender, EventArgs e) //TODO: zasebna klasa
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "ZIP Archive (.zip)|*.zip";
            DialogResult dialogResult = openFileDialog2.ShowDialog();
            if (DialogResult.OK == dialogResult)
            {
                try
                {
                    string file = openFileDialog2.FileName;
                    textBox2.Text = file;
                }
                catch (IOException)
                {
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZipClass.addTo(entry.values, textBox2.Text);
        }
    }
}
