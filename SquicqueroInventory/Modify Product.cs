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
    public partial class Form5 : Form
    {
        BindingList<Part> ProdPartTemp = MainForm.form_partlist;
        public Form5()
        {
            InitializeComponent();
            textBox2.Text = MainForm.form_value1;
            textBox5.Text = MainForm.form_value2;
            textBox3.Text = MainForm.form_value3;
            textBox4.Text = MainForm.form_value4;
            textBox7.Text = MainForm.form_value5;
            textBox6.Text = MainForm.form_value6;

            var TopPartList = new BindingSource();
            var BotPartList = new BindingSource();
            TopPartList.DataSource = Inventory.AllParts;
            BotPartList.DataSource = ProdPartTemp;

            dataGridView1.DataSource = TopPartList;
            dataGridView2.DataSource = BotPartList;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //cancel
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //save
        private void button4_Click(object sender, EventArgs e)
        {
            string tempname;
            int tempinv;
            decimal tempprice;
            int tempmin;
            int tempmax;
            int tempid;


            try
            {
                tempname = textBox5.Text;
                tempinv = int.Parse(textBox3.Text);
                tempprice = decimal.Parse(textBox4.Text);
                tempmin = int.Parse(textBox6.Text);
                tempmax = int.Parse(textBox7.Text);
                tempid = int.Parse(textBox2.Text);

                if (tempmin > tempinv)
                {
                    MessageBox.Show("Min cannot be larger than the current inventory. Please adjust.");
                    return;
                }
                else if (tempmax < tempinv)
                {
                    MessageBox.Show("Max cannot be smaller than the current inventory. Please adjust.");
                    return;
                }

                if (ProdPartTemp.Count > 0)
                {
                    Product tempprod = new Product(tempid, tempname, tempprice, tempinv, tempmin, tempmax, ProdPartTemp);
                    Inventory.updateProduct(tempprod.ProductID, tempprod);
                    this.Close();

                }

                else
                {
                    Product tempprod = new Product(tempid, tempname, tempprice, tempinv, tempmin, tempmax);
                    Inventory.updateProduct(tempprod.ProductID, tempprod);
                    this.Close();
                }


            }

            catch
            {
                MessageBox.Show("Please ensure Max, Min, Invetory are integers and Price is a decimcal");
                return;
            }

        }
        //add part
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem.GetType() == typeof(SquicqueroInventory.InHouse))
            {
                InHouse tempPart = (InHouse)dataGridView1.CurrentRow.DataBoundItem;
                ProdPartTemp.Add(tempPart);
            }
            else
            {
                Outsourced tempPart = (Outsourced)dataGridView1.CurrentRow.DataBoundItem;
                ProdPartTemp.Add(tempPart);
            }
        }
        //delete part
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem.GetType() == typeof(SquicqueroInventory.InHouse))
            {
                InHouse tempPart = (InHouse)dataGridView1.CurrentRow.DataBoundItem;
                ProdPartTemp.Remove(tempPart);
            }
            else
            {
                Outsourced tempPart = (Outsourced)dataGridView1.CurrentRow.DataBoundItem;
                ProdPartTemp.Remove(tempPart);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {

                    int tempimput = int.Parse(textBox1.Text);
                    Part temppart = Inventory.lookupPart(tempimput);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        Part temprow = (Part)row.DataBoundItem;
                        if (temprow.PartID == temppart.PartID)
                        {

                            dataGridView1.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.Yellow;
                            

                        }
                        else
                        {
                            dataGridView1.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.White;
                        }


                    }



                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        Part temprow = (Part)row.DataBoundItem;
                        dataGridView1.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.White;
                        
                    }
                }
            }
            catch {
                MessageBox.Show("Must be an integer");
            };

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text.Length > 0)
                {
                    int tempprodid = MainForm.form_int;
                    int tempimput = int.Parse(textBox8.Text);
                    Product temppart = Inventory.lookupProduct(tempprodid);
                    Part secpart = temppart.lookupAssociatedPart(tempimput);


                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {

                        Part temprow = (Part)row.DataBoundItem;
                        if (temprow.PartID == secpart.PartID)
                        {

                            dataGridView2.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.Yellow;

                        }
                        else
                        {
                            dataGridView2.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.White;
                        }


                    }



                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        Part temprow = (Part)row.DataBoundItem;
                        dataGridView2.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.White;
                        
                    }
                }
            }
            catch {
                MessageBox.Show("Must be an integer");
                return;
            }


        }
    }
}
