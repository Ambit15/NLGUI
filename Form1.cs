using System.Windows.Forms;

namespace NLGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult = folderBrowserDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                string pathshp = folderBrowserDialog1.SelectedPath;
                textBox1.Text = pathshp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}