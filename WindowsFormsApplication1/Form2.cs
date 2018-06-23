using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        int total = 0;
        int discount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            total = Program.coco + Program.milk + Program.soda + Program.orange;
            discount = Convert.ToInt32(total * 0.8);
            if (radioButton2.Checked == true)
            {
                label2.Text = "The total is $" + total;
            }else if (radioButton1.Checked == true)
            {
                label2.Text = "The total was $" + total+"\r\n" +
                    "After discount is"+discount;
            }
        }
        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i>= 20)
                {
                    label2.Text = "Time out, please order again.";
                }
            if (i== 25)
                {
                    this.Close();
                }

        }
    }
}
