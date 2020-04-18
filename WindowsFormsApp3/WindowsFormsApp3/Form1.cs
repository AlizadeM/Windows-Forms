using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int Adult;
        int Child;
        int Infant;
        string morad = "Adult";
        string morchild = "Child";
        string morinf = "Infant";

        



        public Form1()
        {
            InitializeComponent();

              

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show ("Error, Please select different city.");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value <= System.DateTime.Now)
            {
                MessageBox.Show("Please select a valid date");
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = dateTimePicker2.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            Adult--;

            if (Adult < 1)
            {
                Adult = 1;
            }
            label1.Text = Adult.ToString();

            if (Adult > 1)
            {
                morad = "Adults";
            }
            else
            {
                morad = "Adult";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adult++;

            if (Adult > 9)
            {
                Adult = 9;
            }
            label1.Text = Adult.ToString();
            if (Adult > 1)
            {
                morad = "Adults";
            }
            else
            {
                morad = "Adult";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Child--;

            if (Child < 0)
            {
                Child = 0;
            }

            label3.Text = Child.ToString();
            if (Child > 1)
            {
                morchild = "Children";

            }
            else
            {
                morchild = "Child";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Child++;

            if (Child > 9)
            {
                Child = 9;
            }

            label3.Text = Child.ToString();
            if (Child > 1)
            {
                morchild = "Children";

            }
            else
            {
                morchild = "Child";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Infant--;

            if (Infant < 0)
            {
                Infant = 0;
            }

            label5.Text = Infant.ToString();
            if (Infant > 1)
            {
                morinf = "Infants";
            }
            else
            {
                morinf = "Infant";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Infant++;

            if (Infant > 9)
            {
                Infant = 9;
            }

            label5.Text = Infant.ToString();
            if (Infant > 1)
            {
                morinf = "Infants";
            }
            else
            {
                morinf = "Infant";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }

        private void buybutton_Click(object sender, EventArgs e)
        {
            
            

            

            if (dateTimePicker1.Visible == true)
            {
                MessageBox.Show("Your ticket has been purchased. \n You will fly from " + comboBox1.SelectedItem + " to " + comboBox2.SelectedItem + " with " + Adult + " "+ morad + " " + Child + " "+ morchild + " " + Infant + " "+morinf );
            }
            else
            {
                MessageBox.Show("Your ticket has been purchased. \n You will fly to "+ comboBox1.SelectedItem+"with "+Adult+ " "+ morad +" " + Child + " "+ morchild + " " + Infant +" "+ morinf );
            }
        }
    }
}
