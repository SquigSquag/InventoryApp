using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SquicqueroInventory
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private void form2_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e) {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void inHouseRadio_CheckedChanged(object sender, EventArgs e) { 
            if (sender == inHouseRadio)
            {
                label3.Text = "Machine ID";
                label3.Location = new Point(79, 313);
            }
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == outsourcedRadio)
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
                
                if (minPart > maxPart) {
                    MessageBox.Show("Min must be less than Max when adding a new part. Please adjust and try again.");
                    return;
                }
                if (minPart > invPart) {
                    MessageBox.Show("Min must be less than the current inventory. Please adjust and try again.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please ensure Max, Min, Invetory are integers and Price is a decimcal");
                return;
            }
            if (inHouseRadio.Checked) {
                randPart = int.Parse(textBox7.Text);
                InHouse tempInHouse = new InHouse((Inventory.AllParts.Count+1), nametemp, pricePart, invPart, minPart, maxPart, randPart);
                Inventory.addPart(tempInHouse);
                this.Close();
            }
            if (outsourcedRadio.Checked) {
                Outsourced tempOutSourced = new Outsourced((Inventory.AllParts.Count + 1), nametemp, pricePart, invPart, minPart, maxPart, textBox7.Text);
                Inventory.addPart(tempOutSourced);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
