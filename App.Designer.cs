namespace WinFormsApp1
{
    partial class App
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonsPanel = new Panel();
            delAccBtn = new Button();
            createAccBtn = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            MainContent = new Panel();
            addItemBtn = new Button();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Controls.Add(addItemBtn);
            ButtonsPanel.Controls.Add(delAccBtn);
            ButtonsPanel.Controls.Add(createAccBtn);
            ButtonsPanel.Controls.Add(button3);
            ButtonsPanel.Controls.Add(button2);
            ButtonsPanel.Controls.Add(button1);
            ButtonsPanel.Location = new Point(98, 6);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(843, 43);
            ButtonsPanel.TabIndex = 0;
            ButtonsPanel.Paint += ButtonsPanel_Paint;
            // 
            // delAccBtn
            // 
            delAccBtn.Location = new Point(537, 3);
            delAccBtn.Name = "delAccBtn";
            delAccBtn.Size = new Size(149, 34);
            delAccBtn.TabIndex = 4;
            delAccBtn.Text = "Delete Account";
            delAccBtn.UseVisualStyleBackColor = true;
            delAccBtn.Click += delAccBtn_Click;
            // 
            // createAccBtn
            // 
            createAccBtn.Location = new Point(382, 3);
            createAccBtn.Name = "createAccBtn";
            createAccBtn.Size = new Size(149, 34);
            createAccBtn.TabIndex = 3;
            createAccBtn.Text = "Create Account";
            createAccBtn.UseVisualStyleBackColor = true;
            createAccBtn.Click += createAccBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(692, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(131, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Do Sale";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainContent
            // 
            MainContent.Location = new Point(0, 55);
            MainContent.Name = "MainContent";
            MainContent.Size = new Size(1115, 696);
            MainContent.TabIndex = 1;
            // 
            // addItemBtn
            // 
            addItemBtn.Location = new Point(249, 3);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(127, 34);
            addItemBtn.TabIndex = 5;
            addItemBtn.Text = "Add Item";
            addItemBtn.UseVisualStyleBackColor = true;
            addItemBtn.Click += button4_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 751);
            Controls.Add(MainContent);
            Controls.Add(ButtonsPanel);
            Name = "App";
            Text = "App";
            Load += App_Load;
            ButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ButtonsPanel;
        private Panel MainContent;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button delAccBtn;
        private Button createAccBtn;
        private Button addItemBtn;
    }
}