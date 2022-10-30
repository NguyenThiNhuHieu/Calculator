using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btCong_Click(object sender, EventArgs e)
        {
            if(txtSoA.Text != String.Empty && txtSoB.Text != String.Empty)
            {
                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);
                Calculation c = new Calculation(a, b);
                int kq = c.Execute("+");
                txtKetQua.Text = c.ToString();
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text != String.Empty && txtSoB.Text != String.Empty)
            {
                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);
                Calculation c = new Calculation(a, b);
                int kq = c.Execute("-");
                txtKetQua.Text = c.ToString();
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text != String.Empty && txtSoB.Text != String.Empty)
            {
                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);
                Calculation c = new Calculation(a, b);
                int kq = c.Execute("*");
                txtKetQua.Text = c.ToString();
            }
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text != String.Empty && txtSoB.Text != String.Empty)
            {
                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);
                Calculation c = new Calculation(a, b);
                int kq = c.Execute("/");
                txtKetQua.Text = c.ToString();
            }
        }

        private void btSoSanh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            
        }
    }
}
