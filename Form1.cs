using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 转换工具集
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToIP_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            Regex regex = new Regex("^-?\\d+$");
            if(!regex.IsMatch(textBox1.Text)){
                MessageBox.Show("输入格式错误！",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            try
            {
                UInt32 n = UInt32.Parse(textBox1.Text);
                byte a = (byte)((n & 0xFF000000) >> 24);
                byte b = (byte)((n & 0x00FF0000) >> 16);
                byte c = (byte)((n & 0x0000FF00) >> 8);
                byte d = (byte)(n & 0x000000FF);
                txtResult.Text = String.Format("{0}.{1}.{2}.{3}", d, c, b, a);
            }
            catch (Exception)
            {
                Int32 n = Int32.Parse(textBox1.Text);
                byte a = (byte)((n & 0xFF000000) >> 24);
                byte b = (byte)((n & 0x00FF0000) >> 16);
                byte c = (byte)((n & 0x0000FF00) >> 8);
                byte d = (byte)(n & 0x000000FF);
                txtResult.Text = String.Format("{0}.{1}.{2}.{3}", d, c, b, a);
            }
        }

        private void btnToVersion_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            Regex regex = new Regex("^\\d+$");
            if (!regex.IsMatch(textBox1.Text))
            {
                MessageBox.Show("输入格式错误！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            UInt32 n = UInt32.Parse(textBox1.Text);
            byte a = (byte)((n & 0xFF000000) >> 24);
            byte b = (byte)((n & 0x00FF0000) >> 16);
            byte c = (byte)((n & 0x0000FF00) >> 8);
            byte d = (byte)(n & 0x000000FF);
            txtResult.Text = String.Format("{0}.{1}.{2}.{3}", a, b, c, d);
        }

        private void btnToTime_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            Regex regex = new Regex("^\\d+$");
            if (!regex.IsMatch(textBox1.Text))
            {
                MessageBox.Show("输入格式错误！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            UInt32 n = UInt32.Parse(textBox1.Text);
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddSeconds(n);
            txtResult.Text = time.ToString();
        }

        private void btnToUTCTime_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            Regex regex = new Regex("^\\d+$");
            if (!regex.IsMatch(textBox1.Text))
            {
                MessageBox.Show("输入格式错误！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            UInt32 n = UInt32.Parse(textBox1.Text);
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = new System.DateTime(1970, 1, 1);
            time = startTime.AddSeconds(n);
            txtResult.Text = time.ToString();
        }

        private void btnUTCToInt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            DateTime dt = DateTime.Parse(textBox1.Text);
            TimeSpan ts1970 = new TimeSpan(DateTime.Parse("1970/1/1 00:00:00").Ticks);
            TimeSpan ts = new TimeSpan(dt.Ticks);
            txtResult.Text = ts.Subtract(ts1970).Duration().TotalSeconds.ToString();
        }

        private void btnLocalTimeToInt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            DateTime dt = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Parse(textBox1.Text));
            TimeSpan ts1970 = new TimeSpan(DateTime.Parse("1970/1/1 00:00:00").Ticks);
            TimeSpan ts = new TimeSpan(dt.Ticks);
            txtResult.Text = ts.Subtract(ts1970).Duration().TotalSeconds.ToString();
        }
    }
}
