using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_WindowsForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName= textBox1.Text;
            string lName = textBox2.Text;
            string day = comboBox2.Text;
            string month = comboBox3.Text;
            string year = comboBox4.Text;
            string gender = comboBox1.Text;
            string email = textBox3.Text;
            string adress = textBox9.Text;
            string city = textBox8.Text;
            string state = textBox10.Text;
            string phone = textBox12.Text;

            string output = String.Format("First Name: {0} \nLast Name: {1} \nDay: {2} Month: {3} " +
                "Year: {4} \nGender: {5} \nEmail: {6} \nAdress: {7} \nCity: {8} \nState: {9} \nPhone: {10}",fName,lName,day,month,year,gender,email,adress,city,state,phone);
            richTextBox1.Text = output;

        }
    }
}
