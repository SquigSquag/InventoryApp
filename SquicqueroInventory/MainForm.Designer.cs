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
            PART_GRID_VIEW.Location = new Point(57, 119);
            PART_GRID_VIEW.Name = "PART_GRID_VIEW";
            PART_GRID_VIEW.RowHeadersVisible = false;
            PART_GRID_VIEW.Size = new Size(603, 222);
            PART_GRID_VIEW.TabIndex = 0;
            PART_GRID_VIEW.CellContentClick += PART_GRID_VIEW_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(57, 92);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 2;
            label1.Text = "Parts";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(811, 92);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 3;
            label2.Text = "Products";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1007, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(252, 84);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1088, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 23);
            textBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(1259, 366);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Main_Form_Add_Prod_Butt
            // 
            Main_Form_Add_Prod_Butt.Location = new Point(1178, 366);
            Main_Form_Add_Prod_Butt.Name = "Main_Form_Add_Prod_Butt";
            Main_Form_Add_Prod_Butt.Size = new Size(75, 23);
            Main_Form_Add_Prod_Butt.TabIndex = 9;
            Main_Form_Add_Prod_Butt.Text = "Add";
            Main_Form_Add_Prod_Butt.UseVisualStyleBackColor = true;
            Main_Form_Add_Prod_Butt.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1340, 366);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(586, 366);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 13;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(424, 366);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 12;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(505, 366);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 11;
            button8.Text = "Modify";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1340, 501);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 14;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(609, 9);
            label3.Name = "label3";
            label3.Size = new Size(271, 25);
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
            PROD_GRID_VIEW.Location = new Point(811, 119);
            PROD_GRID_VIEW.Name = "PROD_GRID_VIEW";
            PROD_GRID_VIEW.RowHeadersVisible = false;
            PROD_GRID_VIEW.Size = new Size(604, 222);
            PROD_GRID_VIEW.TabIndex = 1;
            PROD_GRID_VIEW.CellContentClick += dataGridView2_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 536);
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
