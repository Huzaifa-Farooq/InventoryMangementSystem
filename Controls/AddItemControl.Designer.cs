using System.Windows.Forms;

namespace InventoryManagementSystem.Controls
{
    partial class AddItemControl
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
            labelName = new Label();
            textBoxName = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new RichTextBox();
            labelCategory = new Label();
            textBoxCategory = new TextBox();
            labelQuantity = new Label();
            numericUpDownQuantity = new NumericUpDown();
            labelPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            buttonAdd = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(50, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(63, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(162, 24);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 31);
            textBoxName.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(50, 70);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(106, 25);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(162, 67);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(400, 103);
            textBoxDescription.TabIndex = 3;
            textBoxDescription.Text = "";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(50, 197);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(88, 25);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Category:";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(162, 191);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(200, 31);
            textBoxCategory.TabIndex = 5;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(50, 237);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(84, 25);
            labelQuantity.TabIndex = 6;
            labelQuantity.Text = "Quantity:";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(162, 231);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(120, 31);
            numericUpDownQuantity.TabIndex = 7;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(50, 277);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(53, 25);
            labelPrice.TabIndex = 8;
            labelPrice.Text = "Price:";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(162, 271);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 31);
            numericUpDownPrice.TabIndex = 9;
            numericUpDownPrice.ValueChanged += numericUpDownPrice_ValueChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(182, 317);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 35);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add Item";
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(307, 317);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 35);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddItemControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelCategory);
            Controls.Add(textBoxCategory);
            Controls.Add(labelQuantity);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(labelPrice);
            Controls.Add(numericUpDownPrice);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCancel);
            Name = "AddItemControl";
            Size = new Size(658, 409);
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelDescription;
        private RichTextBox textBoxDescription;
        private Label labelCategory;
        private TextBox textBoxCategory;
        private Label labelQuantity;
        private NumericUpDown numericUpDownQuantity;
        private Label labelPrice;
        private NumericUpDown numericUpDownPrice;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}
