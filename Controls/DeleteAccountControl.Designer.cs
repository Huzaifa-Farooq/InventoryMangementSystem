namespace InventoryManagementSystem.Controls
{
    partial class DeleteAccountControl
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
            labelTitle = new Label();
            labelUsers = new Label();
            textBoxUsername = new TextBox();
            buttonDelete = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(20, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(189, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Delete Account";
            // 
            // labelUsers
            // 
            labelUsers.AutoSize = true;
            labelUsers.Location = new Point(20, 55);
            labelUsers.Name = "labelUsers";
            labelUsers.Size = new Size(100, 25);
            labelUsers.TabIndex = 1;
            labelUsers.Text = "Select user:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(20, 80);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(300, 31);
            textBoxUsername.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(20, 260);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 43);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete Account";
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(150, 260);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(92, 43);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonCancel_Click;
            // 
            // DeleteAccountControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTitle);
            Controls.Add(labelUsers);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCancel);
            Name = "DeleteAccountControl";
            Size = new Size(360, 340);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelUsers;
        private TextBox textBoxUsername;
        private Button buttonDelete;
        private Button buttonCancel;
    }
}
