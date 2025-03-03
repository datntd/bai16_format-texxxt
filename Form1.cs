using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_format_texxxt
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText formatText = new FormatText();
            formatText.MdiParent = this;
            formatText.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string ten = "nguyen thanh dat:";
            lblInfo.Text = "Họ và tên thí sinh:" + ten + Environment.NewLine;
            lblInfo.Text += "ngày viết:" + System.DateTime.Now;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox = new AboutBox1();
            AboutBox.MdiParent = this;
            AboutBox.Show();
        }
    }
}
