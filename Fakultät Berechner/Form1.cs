using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace Fakultät_Berechner
{
    public partial class Form1 : Form
    {
        BigInteger n;
        int ZBZ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ZBZ = Convert.ToInt32(textBox1.Text);
                n = 1;
                for (int i = 1; i <= ZBZ; i++)
                {
                    n = n * i;
                }
                textBox2.Text = n.ToString();
            }
            catch
            {
                textBox2.Text = "Fehler";
            }
        }

    }
}
