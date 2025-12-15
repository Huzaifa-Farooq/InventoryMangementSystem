namespace InventoryManagementSystem.Controls
{
    partial class SaleControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSearch = new TextBox();
            listBoxResults = new ListBox();
            groupBox1 = new GroupBox();
            ItemCount = new NumericUpDown();
            AddButton = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            GenerateBillButton = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            textBoxReturn = new TextBox();
            label3 = new Label();
            textBoxPaid = new TextBox();
            label2 = new Label();
            TotalPriceTextBox = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemCount).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(6, 33);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search product...";
            textBoxSearch.Size = new Size(254, 31);
            textBoxSearch.TabIndex = 4;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // listBoxResults
            // 
            listBoxResults.ItemHeight = 25;
            listBoxResults.Location = new Point(6, 134);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(340, 279);
            listBoxResults.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ItemCount);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(listBoxResults);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(6, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 415);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Items";
            // 
            // ItemCount
            // 
            ItemCount.Location = new Point(287, 34);
            ItemCount.Name = "ItemCount";
            ItemCount.Size = new Size(59, 31);
            ItemCount.TabIndex = 9;
            ItemCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddButton
            // 
            AddButton.Location = new Point(234, 94);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(364, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(911, 413);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(899, 376);
            dataGridView1.TabIndex = 0;
            // 
            // GenerateBillButton
            // 
            GenerateBillButton.Location = new Point(905, 496);
            GenerateBillButton.Name = "GenerateBillButton";
            GenerateBillButton.Size = new Size(150, 78);
            GenerateBillButton.TabIndex = 3;
            GenerateBillButton.Text = "Done";
            GenerateBillButton.UseVisualStyleBackColor = true;
            GenerateBillButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(75, 38);
            label1.TabIndex = 1;
            label1.Text = "Total";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxReturn);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBoxPaid);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(TotalPriceTextBox);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(221, 437);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(591, 185);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // textBoxReturn
            // 
            textBoxReturn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxReturn.Location = new Point(370, 78);
            textBoxReturn.Multiline = true;
            textBoxReturn.Name = "textBoxReturn";
            textBoxReturn.ReadOnly = true;
            textBoxReturn.Size = new Size(149, 83);
            textBoxReturn.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(395, 27);
            label3.Name = "label3";
            label3.Size = new Size(99, 38);
            label3.TabIndex = 5;
            label3.Text = "Return";
            // 
            // textBoxPaid
            // 
            textBoxPaid.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPaid.Location = new Point(182, 78);
            textBoxPaid.Multiline = true;
            textBoxPaid.Name = "textBoxPaid";
            textBoxPaid.Size = new Size(149, 83);
            textBoxPaid.TabIndex = 4;
            textBoxPaid.TextChanged += textBoxPaid_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 27);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(69, 38);
            label2.TabIndex = 3;
            label2.Text = "Paid";
            // 
            // TotalPriceTextBox
            // 
            TotalPriceTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPriceTextBox.Location = new Point(6, 78);
            TotalPriceTextBox.Multiline = true;
            TotalPriceTextBox.Name = "TotalPriceTextBox";
            TotalPriceTextBox.ReadOnly = true;
            TotalPriceTextBox.Size = new Size(149, 83);
            TotalPriceTextBox.TabIndex = 2;
            TotalPriceTextBox.TextChanged += textBox1_TextChanged;
            // 
            // SaleControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(GenerateBillButton);
            Name = "SaleControl";
            Size = new Size(1291, 615);
            Load += SaleControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemCount).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxSearch;
        private ListBox listBoxResults;
        private GroupBox groupBox1;
        private Button AddButton;
        private GroupBox groupBox2;
        private Button GenerateBillButton;
        private Label label1;
        private NumericUpDown ItemCount;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox textBoxPaid;
        private TextBox TotalPriceTextBox;
        private TextBox textBoxReturn;
        private Label label3;
    }
}
