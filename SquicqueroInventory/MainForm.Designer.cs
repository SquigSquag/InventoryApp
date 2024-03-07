namespace SquicqueroInventory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PART_GRID_VIEW = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            Main_Form_Add_Prod_Butt = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label3 = new Label();
            inventoryBindingSource = new BindingSource(components);
            PROD_GRID_VIEW = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PART_GRID_VIEW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PROD_GRID_VIEW).BeginInit();
            SuspendLayout();
            // 
            // PART_GRID_VIEW
            // 
            PART_GRID_VIEW.AllowUserToAddRows = false;
            PART_GRID_VIEW.AllowUserToDeleteRows = false;
            PART_GRID_VIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PART_GRID_VIEW.Location = new Point(65, 159);
            PART_GRID_VIEW.Margin = new Padding(3, 4, 3, 4);
            PART_GRID_VIEW.Name = "PART_GRID_VIEW";
            PART_GRID_VIEW.RowHeadersVisible = false;
            PART_GRID_VIEW.RowHeadersWidth = 51;
            PART_GRID_VIEW.Size = new Size(689, 296);
            PART_GRID_VIEW.TabIndex = 0;
            PART_GRID_VIEW.CellContentClick += PART_GRID_VIEW_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(65, 123);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 2;
            label1.Text = "Parts";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(927, 123);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 3;
            label2.Text = "Products";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1151, 113);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(288, 112);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 5;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1243, 113);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(381, 112);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 27);
            textBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(1439, 488);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 8;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Main_Form_Add_Prod_Butt
            // 
            Main_Form_Add_Prod_Butt.Location = new Point(1346, 488);
            Main_Form_Add_Prod_Butt.Margin = new Padding(3, 4, 3, 4);
            Main_Form_Add_Prod_Butt.Name = "Main_Form_Add_Prod_Butt";
            Main_Form_Add_Prod_Butt.Size = new Size(86, 31);
            Main_Form_Add_Prod_Butt.TabIndex = 9;
            Main_Form_Add_Prod_Butt.Text = "Add";
            Main_Form_Add_Prod_Butt.UseVisualStyleBackColor = true;
            Main_Form_Add_Prod_Butt.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1531, 488);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 10;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(670, 488);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 13;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(485, 488);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 31);
            button7.TabIndex = 12;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(577, 488);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 11;
            button8.Text = "Modify";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1531, 668);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(86, 31);
            button9.TabIndex = 14;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(696, 12);
            label3.Name = "label3";
            label3.Size = new Size(348, 32);
            label3.TabIndex = 15;
            label3.Text = "Inventory Management System";
            label3.Click += label3_Click;
            // 
            // inventoryBindingSource
            // 
            inventoryBindingSource.DataSource = typeof(Inventory);
            // 
            // PROD_GRID_VIEW
            // 
            PROD_GRID_VIEW.AllowUserToAddRows = false;
            PROD_GRID_VIEW.AllowUserToDeleteRows = false;
            PROD_GRID_VIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PROD_GRID_VIEW.Location = new Point(927, 159);
            PROD_GRID_VIEW.Margin = new Padding(3, 4, 3, 4);
            PROD_GRID_VIEW.Name = "PROD_GRID_VIEW";
            PROD_GRID_VIEW.RowHeadersVisible = false;
            PROD_GRID_VIEW.RowHeadersWidth = 51;
            PROD_GRID_VIEW.Size = new Size(690, 296);
            PROD_GRID_VIEW.TabIndex = 1;
            PROD_GRID_VIEW.CellContentClick += dataGridView2_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 715);
            Controls.Add(label3);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(Main_Form_Add_Prod_Butt);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PROD_GRID_VIEW);
            Controls.Add(PART_GRID_VIEW);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Main Screen";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)PART_GRID_VIEW).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PROD_GRID_VIEW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PART_GRID_VIEW;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Button Main_Form_Add_Prod_Butt;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label3;
        private BindingSource inventoryBindingSource;
        private DataGridView PROD_GRID_VIEW;
    }
}
