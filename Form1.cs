using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Заповніть e-mail");
                isValid = false;
            }
            else{
                errorProvider1.Clear();
            }
            if (!textBox3.Text.Contains('@'))
            {
                errorProvider1.SetError(textBox3, "e-mail адреса повинна містити @");
                isValid = false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider2.SetError(textBox1, "Заповніть ім'я та прізвище");
                isValid = false;
            }
            else
            {
                errorProvider2.Clear();
            }
            if (string.IsNullOrEmpty(textBox2.Text)|| textBox2.Text =="Опишіть проблему")
            {
                errorProvider3.SetError(textBox2, "Опишіть проблему");
                isValid = false;
            }
            else
            {
                errorProvider3.Clear();
            }
            if (isValid)
            {
                String userData = "Email: " + textBox3.Text + " "
                   + "Name: " + textBox1.Text + "Problem: " + textBox2.Text;

                File.AppendAllText("log.txt", userData);

                MessageBox.Show("Ваша проблема буде вирішена, очікуйте відповіді!");
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
            }
      
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
