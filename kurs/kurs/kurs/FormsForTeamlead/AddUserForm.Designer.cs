namespace kurs.FormsForTeamlead
{
    partial class AddUserForm
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
            this.userNameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.userRoleField = new System.Windows.Forms.TextBox();
            this.userEmailField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButtom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.userNameField.Location = new System.Drawing.Point(97, 191);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(271, 59);
            this.userNameField.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.registerLabel.Location = new System.Drawing.Point(549, 378);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(0, 31);
            this.registerLabel.TabIndex = 8;
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameField.Location = new System.Drawing.Point(507, 191);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(271, 59);
            this.userSurnameField.TabIndex = 7;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(215, 371);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(362, 45);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегаться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // userRoleField
            // 
            this.userRoleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userRoleField.Location = new System.Drawing.Point(507, 304);
            this.userRoleField.Name = "userRoleField";
            this.userRoleField.Size = new System.Drawing.Size(271, 47);
            this.userRoleField.TabIndex = 4;
            this.userRoleField.UseSystemPasswordChar = true;
            // 
            // userEmailField
            // 
            this.userEmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userEmailField.Location = new System.Drawing.Point(97, 292);
            this.userEmailField.Multiline = true;
            this.userEmailField.Name = "userEmailField";
            this.userEmailField.Size = new System.Drawing.Size(271, 59);
            this.userEmailField.TabIndex = 2;
            this.userEmailField.TextChanged += new System.EventHandler(this.userEmailField_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.registerLabel);
            this.panel1.Controls.Add(this.userSurnameField);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.userRoleField);
            this.panel1.Controls.Add(this.userEmailField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.closeButtom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 119);
            this.panel2.TabIndex = 0;
            // 
            // closeButtom
            // 
            this.closeButtom.AutoSize = true;
            this.closeButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButtom.ForeColor = System.Drawing.Color.Coral;
            this.closeButtom.Location = new System.Drawing.Point(776, 0);
            this.closeButtom.Name = "closeButtom";
            this.closeButtom.Size = new System.Drawing.Size(24, 29);
            this.closeButtom.TabIndex = 1;
            this.closeButtom.Text = "х";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox userRoleField;
        private System.Windows.Forms.TextBox userEmailField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButtom;
    }
}