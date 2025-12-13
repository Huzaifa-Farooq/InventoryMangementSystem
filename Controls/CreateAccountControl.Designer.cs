using WinFormsApp1.Models;

namespace InventoryManagementSystem.Controls
{
    partial class CreateAccountControl
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
            labelUsername = new Label();
            labelPassword = new Label();
            labelRole = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxRole = new ComboBox();
            buttonCreate = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.Location = new Point(50, 40);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(100, 23);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.Location = new Point(50, 85);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 23);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // labelRole
            // 
            labelRole.Location = new Point(50, 130);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(100, 23);
            labelRole.TabIndex = 4;
            labelRole.Text = "Role:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(160, 35);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 31);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(160, 80);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(200, 31);
            textBoxPassword.TabIndex = 3;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Location = new Point(160, 125);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(200, 33);
            comboBoxRole.TabIndex = 5;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(160, 180);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(79, 41);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create Account";
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(280, 180);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(80, 41);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonCancel_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelUsername);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelRole);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonCreate);
            Controls.Add(buttonCancel);
            Name = "CreateAccount";
            Size = new Size(588, 336);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelPassword;
        private Label labelRole;

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;

        private ComboBox comboBoxRole;

        private Button buttonCreate;
        private Button buttonCancel;

    }
}
