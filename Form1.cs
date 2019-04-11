using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                this.textBox1.Text = filePath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = this.textBox1.Text;
            if (!File.Exists(filePath))
            {
                return;
            }
            using (FileStream stream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int)stream.Length);
                AutoDetector dector = new AutoDetector();
                Encoding encoder = null;
                string encode = dector.DetectEncoding(buffer, ref encoder);
                MessageBox.Show(encode);
            }
        }
    }
}
