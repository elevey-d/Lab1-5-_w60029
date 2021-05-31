using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a, b, c;
        char action;
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "0" && !tbMain.Text.Contains(",") && tbMain.Text.IndexOf("0") == 0)
            {
                return;
            }
            tbMain.Text += (sender as Button).Text;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            action = (sender as Button).Text[0];
            a = tbMain.Text;
            tbMain.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            b = tbMain.Text;
            double temp;
            switch (action)
            {
                case '+':
                    temp = (Convert.ToDouble(a) + Convert.ToDouble(b));
                    c = (Math.Round(temp, 6)).ToString();
                    break;
                case '-':
                    temp = (Convert.ToDouble(a) - Convert.ToDouble(b));
                    c = (Math.Round(temp, 6)).ToString();
                    break;
                case '*':
                    temp = (Convert.ToDouble(a) * Convert.ToDouble(b));
                    c = (Math.Round(temp, 6)).ToString();
                    break;
                case '/':
                    temp = (Convert.ToDouble(a) / Convert.ToDouble(b));
                    c = (Math.Round(temp, 6)).ToString();
                    break;
            }
            tbMain.Text = c;
            a = "";
            b = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMain.Text = "";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (tbMain.Text.Length < 1)
                return;
            if (tbMain.Text.IndexOf(",") > 0 && (sender as Button).Text == ",")
            {
                return;
            }
            tbMain.Text += ",";
        }
    }
}
