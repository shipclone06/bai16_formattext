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

namespace bai16_formattext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formattextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formattext formatText = new formattext();
            formatText.MdiParent = this;
            formatText.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ten = "Nguyễn Anh Khoa";
            lblinfo.Text= "Họ Và Tên: " + ten+ Environment.NewLine;
            lblinfo.Text += "Ngày Thực Hành" + System. DateTime.Now;
            

        }
    }
}
