using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2._43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        double result;
        string op;
        Random rnd = new Random();

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {

        }
        void ChangeColor()
        {
            this.txtResult.BackColor = Color.Green;
        }

        private void CbxAutoNext_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbxAutoNext.Checked)
            {
                this.timer1.Enabled = true;
            }
            else this.timer1.Enabled = false;
        }

        private void BtnFast_Click(object sender, EventArgs e)
        {
            if(this.timer1.Interval > 1000)
                this.timer1.Interval -= 1000;
        }

        private void BtnSlow_Click(object sender, EventArgs e)
        {
            this.timer1.Interval += 1000;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BtnNext_Click(sender, e);
        }

        private void CbxAutoShow_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = result.ToString();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            double t = double.Parse(this.txtResult.Text);
            if (Math.Abs(result - t) < 1e-3)
            {
                ChangeColor();
                this.lblPoint.Text = (int.Parse(this.lblPoint.Text) + 1).ToString();
            }
        }

        private void TxtResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.BtnConfirm_Click(sender, e);//触发button事件
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            this.txtResult.BackColor = Color.White;
            if (this.rbtnType1.Checked || this.rbtnType2.Checked)
            {
                if (this.rbtnType1.Checked)
                {
                    a = rnd.Next(9) + 1;
                    b = rnd.Next(9) + 1;
                }
                else
                {
                    a = rnd.Next(19) + 1;
                    b = rnd.Next(19) + 1;
                }
                int c = rnd.Next(2);
                switch (c)
                {
                    case 0: op = "+"; result = a + b; break;
                    case 1: op = "-"; result = a - b; break;
                }

            }
            else
            {
                a = rnd.Next(19) + 1;
                b = rnd.Next(19) + 1;
                int c = rnd.Next(2);
                switch (c)
                {
                    case 0: op = "*"; result = a * b; break;
                    case 1: op = "/"; result = a / (b*1.0); break;
                }
            }
            this.lblA.Text = a.ToString();
            this.lblB.Text = b.ToString();
            this.lblOp.Text = op;
            if (this.cbxAutoShow.Checked)
            {
                this.txtResult.Text = result.ToString();
                this.txtResult.BackColor = Color.Green;
            }
        }
    }
}
