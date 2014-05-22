using System;
using System.Windows.Forms;

namespace superconverter
{
    public partial class SuperConvertWindow : Form
    {
        public SuperConvertWindow()
        {
            InitializeComponent();
        }

        private void btnToIP_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            if (!textBox1.Text.IsIp())
            {
                MessageBox.Show("输入格式错误！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            txtResult.Text = txtResult.Text.ToIp();
        }

        private void btnToVersion_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            if (!textBox1.Text.IsVersion())
            {
                MessageBox.Show("输入格式错误！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            txtResult.Text = txtResult.Text.ToVersion();
        }

        private void btnToTime_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            if (!textBox1.Text.IsTime())
            {
                MessageBox.Show("输入格式错误！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            txtResult.Text = txtResult.Text.ToTime();
        }

        private void btnToUTCTime_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            if (!textBox1.Text.IsUTCTime())
            {
                MessageBox.Show("输入格式错误！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            txtResult.Text = txtResult.Text.ToUTCTime();
        }

        private void btnUTCToInt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            txtResult.Text = txtResult.Text.UTCToInt();
        }

        private void btnLocalTimeToInt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            txtResult.Text = txtResult.Text.LocalTimeToInt();
        }
    }
}
