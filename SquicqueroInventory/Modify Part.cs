using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquicqueroInventory
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            if (MainForm.form_Part == "inhouse")
            {
                radioButton1.Checked = true;

            }
            else
            {
                radioButton2.Checked = true;

            }
            textBox1.Text = MainForm.form_value1;
            textBox5.Text = MainForm.form_value2;
            textBox4.Text = MainForm.form_value3;
            textBox3.Text = MainForm.form_value4;
            textBox2.Text = MainForm.form_value5;
            textBox6.Text = MainForm.form_value6;
            textBox7.Text = MainForm.form_value7;


        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton1)
            {
                label3.Text = "Machine ID";
                label3.Location = new Point(79, 313);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton2)
            {
                label3.Text = "Company Name";
                label3.Location = new Point(56, 313);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nametemp;
            int minPart;
            int maxPart;
            int invPart;
            decimal pricePart;
            int randPart;


            try
            {
                nametemp = textBox5.Text;
                minPart = int.Parse(textBox6.Text);
                maxPart = int.Parse(textBox2.Text);
                invPart = int.Parse(textBox4.Text);
                pricePart = decimal.Parse(textBox3.Text);

                if (minPart > maxPart)
                {
                    MessageBox.Show("Min must be less than Max when adding a new part. Please adjust and try again.");
                    return;
                }
                if (minPart > invPart)
                {
                    MessageBox.Show("Min must be less than the current inventory. Please adjust and try again.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please ensure Max, Min, Invetory are integers and Price is a decimcal");
                return;
            }
            if (radioButton1.Checked)
            {
                randPart = int.Parse(textBox7.Text);
                int tempid = int.Parse(textBox1.Text);
                InHouse tempInHouse = new InHouse(tempid, nametemp, pricePart, invPart, minPart, maxPart, randPart);
                Inventory.updatePart(tempid, tempInHouse);
                this.Close();
            }
            else if (radioButton2.Checked)
            {
                int tempid = int.Parse(textBox1.Text);
                Outsourced tempOutSourced = new Outsourced(tempid, nametemp, pricePart, invPart, minPart, maxPart, textBox7.Text);
                Inventory.updatePart(tempid, tempOutSourced);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
