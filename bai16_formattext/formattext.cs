using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_formattext
{
    public partial class formattext : Form
    {
        public formattext()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Green;
            txtnhapten.ForeColor = Color.Green;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Red;
            txtnhapten.ForeColor = Color.Red;
        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Text = txtnhapten.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Blue;
            txtnhapten.ForeColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Black;
            txtnhapten.ForeColor = Color.Black;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formattext_Load(object sender, EventArgs e)
        {
            radred.Checked = true;
            txtnhapten.Focus();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Bold);
            txtnhapten.Font = new Font(txtnhapten.Font.Name, txtnhapten.Font.Size, txtnhapten.Font.Style ^ FontStyle.Bold);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Italic);
            txtnhapten.Font = new Font(txtnhapten.Font.Name, txtnhapten.Font.Size, txtnhapten.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Underline);
            txtnhapten.Font = new Font(txtnhapten.Font.Name, txtnhapten.Font.Size, txtnhapten.Font.Style ^ FontStyle.Underline);
        }
    }
}
