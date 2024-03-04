using System.Security.Cryptography.X509Certificates;

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
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
            if (PART_GRID_VIEW.CurrentRow.DataBoundItem.GetType() == typeof(SquicqueroInventory.InHouse)){
                InHouse deletehouse = (InHouse)PART_GRID_VIEW.CurrentRow.DataBoundItem;
                Inventory.removePart(deletehouse.PartID);
            }
            else {
                Outsourced deletesource = (Outsourced)PART_GRID_VIEW.CurrentRow.DataBoundItem;
                Inventory.removePart(deletesource.PartID);
            }
        }
    }
}
