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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int co = 0;
        int Mi = 0;
        int Or = 0;
        int So = 0;


        private void Form1_Load(object sender, EventArgs e) {
          
        }
 

  

        public void button1_Click(object sender, EventArgs e)
        
            {
            if (checkBox1.Checked == true)
            {
                if (comboBox1.Items.IndexOf(comboBox1.Text) == 0)
                {

                    co = 2 *  1;
                }

            
                else  if (comboBox1.Items.IndexOf(comboBox1.Text) == 1)
                {

                    co = 2 * 2;
                }

                 else  if (comboBox1.Items.IndexOf(comboBox1.Text) == 2)
                {

                    co = 2 * 3;
                }
                Program.coco = co;
            }
            //milk
            if (checkBox2.Checked == true)
            {
                if (comboBox2.Items.IndexOf(comboBox2.Text) == 0)
                {

                    Mi = 1 * 1;
                }


                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 1)
                {

                    Mi = 1 * 2;
                }

                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 2)
                {

                    Mi = 1 * 3;
                }
                Program.milk = Mi;
            }
            //orange juice
            if (checkBox3.Checked == true)
            {
                if (comboBox3.Items.IndexOf(comboBox3.Text) == 0)
                {

                    Or = 3 * 1;
                }


                else if (comboBox3.Items.IndexOf(comboBox3.Text) == 1)
                {

                    Or = 3 * 2;
                }

                else if (comboBox3.Items.IndexOf(comboBox3.Text) == 2)
                {

                    Or = 3 * 3;
                }
                Program.orange= Or;
            }
            //soda water
            if (checkBox4.Checked == true)
            {
                if (comboBox4.Items.IndexOf(comboBox4.Text) == 0)
                {

                    So = 5 * 1;
                }


                else if (comboBox4.Items.IndexOf(comboBox4.Text) == 1)
                {

                    So = 5 * 2;
                }

                else if (comboBox4.Items.IndexOf(comboBox4.Text) == 2)
                {

                    So = 5 * 3;
                }
                Program.soda = So;
            }






//checkbox






            if (
                    (((checkBox1.Checked == true) && (comboBox1.Items.IndexOf(comboBox1.Text) == 0)) || ((checkBox1.Checked == true) && comboBox1.Items.IndexOf(comboBox1.Text) == 1) || ((checkBox1.Checked == true) && (comboBox1.Items.IndexOf(comboBox1.Text) == 2)))   //cocacola 
                   || (((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 0)) || ((checkBox2.Checked == true) && comboBox2.Items.IndexOf(comboBox2.Text) == 1) || ((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 2)))
                   || (((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 0)) || ((checkBox3.Checked == true) && comboBox3.Items.IndexOf(comboBox3.Text) == 1) || ((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 2)))
                   || (((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 0)) || ((checkBox4.Checked == true) && comboBox4.Items.IndexOf(comboBox4.Text) == 1) || ((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 2)))

                    )
                {

                Form2 frame = new Form2();
                frame.label1.Text = " Cocacola's QTY is " + Program.coco / 2 + "\r\n" +
            "Milk's QTY is" + Program.milk / 1 + "\r\n" +
           "Orange juice's QTY is" + Program.orange / 3 + "\r\n" +
           "Soda Water's QTY is " + Program.soda / 5 + "\r\n";
                frame.timer1.Start();
                frame.Show();
            }
            
        }
    }
}
