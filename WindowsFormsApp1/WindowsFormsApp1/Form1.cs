using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int firstnumber = 0;
        int secondnumber = 0;
        float result = 0;
        string opretortype = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void acceptnumber(object sender, EventArgs e)
        {
            txtResult.Text += (sender as Button).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void acceptsecondnumber(object sender, EventArgs e)
        {
            opretortype = (sender as Button).Text;
            if (firstnumber == 0)
            {
                firstnumber = int.Parse(txtResult.Text);
                txtResult.Text = "";
            }
        }

        private void getresult(object sender, EventArgs e)
        {
            secondnumber= int.Parse(txtResult.Text);

            if (opretortype == "+")
            {
                result = firstnumber + secondnumber;

            }
            else if (opretortype == "x")
            {
                result = firstnumber * secondnumber;
            }
            else if (opretortype == "/")
            {
                result = firstnumber / secondnumber;
            }
            else if (opretortype == "-")
            {
                result = firstnumber - secondnumber;
            }
            txtResult.Text = result.ToString();

        }

        private void clearresult(object sender, EventArgs e)
        {
            txtResult.Text = "";
            firstnumber = 0;
            secondnumber = 0;
        }
    }
}
