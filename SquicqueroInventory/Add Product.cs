using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquicqueroInventory
{
    public partial class Form4 : Form
    {
        BindingList<Part> PartGrid = new BindingList<Part>();

        public Form4()
        {
            InitializeComponent();

            var CandidateGrid = new BindingSource();
            CandidateGrid.DataSource = Inventory.AllParts;
            var AddedGrid = new BindingSource();
            AddedGrid.DataSource = PartGrid;
            dataGridView1.DataSource = CandidateGrid;
            dataGridView2.DataSource = AddedGrid;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem.GetType() == typeof(SquicqueroInventory.InHouse))
            {
                InHouse tempPart = (InHouse)dataGridView1.CurrentRow.DataBoundItem;
                PartGrid.Add(tempPart);
            }
            else
            {
                Outsourced tempPart = (Outsourced)dataGridView1.CurrentRow.DataBoundItem;
                PartGrid.Add(tempPart);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem.GetType() == typeof(SquicqueroInventory.InHouse))
            {
                InHouse tempPart = (InHouse)dataGridView1.CurrentRow.DataBoundItem;
                PartGrid.Remove(tempPart);
            }
            else
            {
                Outsourced tempPart = (Outsourced)dataGridView1.CurrentRow.DataBoundItem;
                PartGrid.Remove(tempPart);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tempname;
            int tempinv;
            decimal tempprice;
            int tempmin;
            int tempmax;

            
            try
            {
                tempname = textBox5.Text;
                tempinv = int.Parse(textBox3.Text);
                tempprice = decimal.Parse(textBox4.Text);
                tempmin = int.Parse(textBox6.Text);
                tempmax = int.Parse(textBox7.Text);

                if (tempmin > tempinv)
                {
                    MessageBox.Show("Min cannot be larger than the current inventory. Please adjust.");
                    return;
                }
                else if (tempmax < tempinv) {
                    MessageBox.Show("Max cannot be smaller than the current inventory. Please adjust.");
                    return;
                }

                if (PartGrid.Count > 0)
                {
                    Product tempprod = new Product(Inventory.Products.Count + 1, tempname, tempprice, tempinv, tempmin, tempmax, PartGrid);
                    Inventory.addProduct(tempprod);
                    this.Close();

                }

                else
                {
                    Product tempprod = new Product(Inventory.Products.Count + 1, tempname, tempprice, tempinv, tempmin, tempmax);
                    Inventory.addProduct(tempprod);
                    this.Close();
                }


            }

            catch
            {
                MessageBox.Show("Please ensure Max, Min, Invetory are integers and Price is a decimcal");
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
