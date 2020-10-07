using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringsSample
{
    public partial class Form1 : Form
    {
        List<string> items = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            string str = "";
            string rev = "";
            string a = txtOne.Text;
            int namelength = a.Length;
            lblLeng.Text =(namelength).ToString();
            if (namelength>=10)
            {
                lblLeng.BackColor = Color.BurlyWood;
            }
            lblHalfLeng.Text = txtOne.Text.Substring(0, namelength / 2);
            //  while (namelength > 0)
            // {
            //  rev = rev + str[namelength];
            // namelength--;
            // }
            //lblReverse.Text = rev;
            items.Add(txtOne.Text);
            lstBox.Items.Add(txtOne.Text);
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
