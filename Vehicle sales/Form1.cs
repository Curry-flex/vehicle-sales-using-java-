using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Car";
            comboBox1.Items.Add("Vogue");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";

            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Range Vogue")
            {
                textBox5.Text = "95000000";
            }
            if (comboBox1.Text == "Toyota Harrier")
            {
                textBox5.Text = "32000000";
            }
            if (comboBox1.Text == "Mercedes Benz")
            {
                textBox5.Text = "20000000";
            }
            if (comboBox1.Text == "Subaru")
            {
                textBox5.Text = "15000000";
            }
            if (comboBox1.Text == "Ford Ranger")
            {
                textBox5.Text = "85000000";
            }
            if (comboBox1.Text == "Toyota Land Cruiser")
            {
                textBox5.Text = "78000000";
            }
            if (comboBox1.Text == "Toyota Hilux")
            {
                textBox5.Text = "62000000";
            }
            if (comboBox1.Text == "Vogue")
            {
                textBox5.Text = "78000000";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm to Exit" ,"vehicle system",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.AppendText("=========Vehicle Sales Recipient=========\n ");
            richTextBox1.AppendText("=========------------------------=========\n ");
            richTextBox1.AppendText("=========------------------------=========\n ");

            richTextBox1.AppendText("Name  :  " + textBox1.Text + "\n ");
            richTextBox1.AppendText("Adrdres  : " + textBox2.Text + "\n ");
            richTextBox1.AppendText("Area :   " + textBox3.Text + "\n ");
            richTextBox1.AppendText("Telephone  :  " + textBox4.Text + "\n ");

            richTextBox1.AppendText("=========------------------------=========\n ");
            richTextBox1.AppendText("=========------------------------=========\n ");
            richTextBox1.AppendText("=========------------------------=========\n ");
            richTextBox1.AppendText("Tax  :  " + textBox12.Text + "\n ");
            richTextBox1.AppendText("Sub Total  :  " + textBox13.Text + "\n ");
            richTextBox1.AppendText("Total  :  " + textBox14.Text + "\n ");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox7.Text = "2556000";
                textBox7.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                textBox7.Text = "0";
                textBox7.Enabled = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox8.Text = "1200000";
                textBox8.Enabled = true;

            }
            else if (checkBox2.Checked == false)
            {
                textBox8.Text = "0";
                textBox8.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox9.Text = "1700000";
                textBox9.Enabled = true;

            }
            else if (checkBox3.Checked == false)
            {
                textBox9.Text = "0";
                textBox9.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox10.Text = "985000";
                textBox10.Enabled = true;

            }
            else if (checkBox4.Checked == false)
            {
                textBox10.Text = "0";
                textBox10.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox11.Text = "1230000";
                textBox11.Enabled = true;

            }
            else if (checkBox5.Checked == false)
            {
                textBox11.Text = "0";
                textBox11.Enabled = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 ss = new Class2();
            ss.Modified = ss.price_Modified + Double.Parse(textBox5.Text);
            ss.StereoSystem = ss.price_StereoSystem + Double.Parse(textBox5.Text);
            ss.Customized = ss.price_Customized + Double.Parse(textBox5.Text);
            ss.LatherInterior = ss.price_LatherInterior + Double.Parse(textBox5.Text);
            ss.GlobalPositioningSystem = ss.price_GlobalPositioningSystem + Double.Parse(textBox5.Text);

            double subtotal,tax,total;
            subtotal = ss.getamaount();
            tax = ss.Gettax();
            total = subtotal + tax;
            textBox13.Text = string.Format("{0:N0}",subtotal );
            textBox12.Text = string.Format("{0:N0}", tax);
            textBox14.Text = string.Format("{0:N0}", total);




        }
    }
}
