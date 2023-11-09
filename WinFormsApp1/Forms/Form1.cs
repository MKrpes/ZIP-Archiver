using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new ZipForm();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new AddToArchiveForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new ExtractArchive();
            newForm.Show();
        }
    }
}