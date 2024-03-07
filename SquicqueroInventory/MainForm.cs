using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SquicqueroInventory
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            startOfApp();

        }

        public static string form_value1 = "";
        public static string form_value2 = "";
        public static string form_value3 = "";
        public static string form_value4 = "";
        public static string form_value5 = "";
        public static string form_value6 = "";
        public static string form_value7 = "";
        public static string form_Part = "";
        public static int form_int = 0;
        public static BindingList<Part> form_partlist = new BindingList<Part>();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    
                    int tempimput = int.Parse(textBox1.Text);
                    Product tempprod = Inventory.lookupProduct(tempimput);


                    foreach (DataGridViewRow row in PROD_GRID_VIEW.Rows)
                    {

                        Product temprow = (Product)row.DataBoundItem;
                        if (temprow.ProductID == tempprod.ProductID)
                        {

                            PROD_GRID_VIEW.Rows[temprow.ProductID - 1].DefaultCellStyle.BackColor = Color.Yellow;
                            break;

                        }
                        else
                        {
                            PROD_GRID_VIEW.Rows[temprow.ProductID - 1].DefaultCellStyle.BackColor = Color.White;
                        }


                    }



                }
                else
                {
                    foreach (DataGridViewRow row in PROD_GRID_VIEW.Rows)
                    {
                        Product temprow = (Product)row.DataBoundItem;
                        PROD_GRID_VIEW.Rows[temprow.ProductID - 1].DefaultCellStyle.BackColor = Color.White;
                        break;
                    }
                }
            }
            catch {
                MessageBox.Show("Search must be an integer");
                return;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void PART_GRID_VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void startOfApp()
        {
            var PartGrid = new BindingSource();
            var ProductGrid = new BindingSource();


            Inventory.generateExamples();

            PartGrid.DataSource = Inventory.AllParts;
            ProductGrid.DataSource = Inventory.Products;
            this.PROD_GRID_VIEW.DataSource = ProductGrid;
            this.PART_GRID_VIEW.DataSource = PartGrid;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
        //modify
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Product tempprodmod = (Product)PROD_GRID_VIEW.CurrentRow.DataBoundItem;
                form_value1 = tempprodmod.ProductID.ToString();
                form_value2 = tempprodmod.Name.ToString();
                form_value3 = tempprodmod.InStock.ToString();
                form_value4 = tempprodmod.Price.ToString();
                form_value5 = tempprodmod.Max.ToString();
                form_value6 = tempprodmod.Min.ToString();
                form_partlist = tempprodmod.AssociatedParts;
                form_int = tempprodmod.ProductID;
                Form5 f5 = new Form5();
                f5.Show();

            }
            catch
            {
                MessageBox.Show("Product not selected, please select a product.");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product deleteProd = (Product)this.PROD_GRID_VIEW.CurrentRow.DataBoundItem;
            Inventory.removeProduct(deleteProd.ProductID);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (PART_GRID_VIEW.CurrentRow.DataBoundItem.GetType() == typeof(SquicqueroInventory.InHouse))
                {
                    InHouse temppart = (InHouse)PART_GRID_VIEW.CurrentRow.DataBoundItem;
                    form_value1 = temppart.PartID.ToString();
                    form_value2 = temppart.Name.ToString();
                    form_value3 = temppart.InStock.ToString();
                    form_value4 = temppart.Price.ToString();
                    form_value5 = temppart.Max.ToString();
                    form_value6 = temppart.Min.ToString();
                    form_value7 = temppart.MachineID.ToString();
                    form_Part = "inhouse";
                    Form3 form3 = new Form3();
                    form3.Show();

                }
                else
                {
                    Outsourced tempout = (Outsourced)PART_GRID_VIEW.CurrentRow.DataBoundItem;
                    form_value1 = tempout.PartID.ToString();
                    form_value2 = tempout.Name.ToString();
                    form_value3 = tempout.InStock.ToString();
                    form_value4 = tempout.Price.ToString();
                    form_value5 = tempout.Max.ToString();
                    form_value6 = tempout.Min.ToString();
                    form_value7 = tempout.CompanyName.ToString();
                    form_Part = "outsourced";
                    Form3 form3 = new Form3();
                    form3.Show();

                }
            }
            catch
            {
                MessageBox.Show("There is no row selected. Please select a row from the parts list to modify.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (PART_GRID_VIEW.CurrentRow.DataBoundItem.GetType() == typeof(SquicqueroInventory.InHouse))
            {
                InHouse deletehouse = (InHouse)PART_GRID_VIEW.CurrentRow.DataBoundItem;
                Inventory.removePart(deletehouse.PartID);
            }
            else
            {
                Outsourced deletesource = (Outsourced)PART_GRID_VIEW.CurrentRow.DataBoundItem;
                Inventory.removePart(deletesource.PartID);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Length > 0)
                {
                    int tempimput = int.Parse(textBox2.Text);



                    foreach (DataGridViewRow row in PART_GRID_VIEW.Rows)
                    {

                        Part temprow = (Part)row.DataBoundItem;
                        if (temprow.PartID == tempimput)
                        {
                            PART_GRID_VIEW.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.Yellow;
                            break;

                        }
                        else
                        {
                            PART_GRID_VIEW.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.White;
                        }


                    }



                }
                else
                {
                    foreach (DataGridViewRow row in PART_GRID_VIEW.Rows)
                    {
                        Part temprow = (Part)row.DataBoundItem;
                        PART_GRID_VIEW.Rows[temprow.PartID - 1].DefaultCellStyle.BackColor = Color.White;
                        break;
                    }
                }
            }
            catch {
                MessageBox.Show("Search must be an integer");
                return;
            }

        }
    }
}
