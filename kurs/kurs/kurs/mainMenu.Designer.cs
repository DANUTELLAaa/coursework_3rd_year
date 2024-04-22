namespace kurs
{
    partial class mainMenu
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
            this.ComeToAddUserButton = new System.Windows.Forms.Button();
            this.outputListUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComeToRemoveUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComeToAddUserButton
            // 
            this.ComeToAddUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComeToAddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComeToAddUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ComeToAddUserButton.Location = new System.Drawing.Point(22, 139);
            this.ComeToAddUserButton.Name = "ComeToAddUserButton";
            this.ComeToAddUserButton.Size = new System.Drawing.Size(184, 53);
            this.ComeToAddUserButton.TabIndex = 0;
            this.ComeToAddUserButton.Text = "Добавить сотрудника";
            this.ComeToAddUserButton.UseVisualStyleBackColor = true;
            this.ComeToAddUserButton.Click += new System.EventHandler(this.ComeToAddUserButton_Click);
            // 
            // outputListUsers
            // 
            this.outputListUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputListUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputListUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.outputListUsers.Location = new System.Drawing.Point(199, 219);
            this.outputListUsers.Name = "outputListUsers";
            this.outputListUsers.Size = new System.Drawing.Size(184, 49);
            this.outputListUsers.TabIndex = 1;
            this.outputListUsers.Text = "Список сотрудников";
            this.outputListUsers.UseVisualStyleBackColor = true;
            this.outputListUsers.Click += new System.EventHandler(this.outputListUsers_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Главное меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComeToRemoveUserButton
            // 
            this.ComeToRemoveUserButton.Location = new System.Drawing.Point(382, 139);
            this.ComeToRemoveUserButton.Name = "ComeToRemoveUserButton";
            this.ComeToRemoveUserButton.Size = new System.Drawing.Size(173, 53);
            this.ComeToRemoveUserButton.TabIndex = 3;
            this.ComeToRemoveUserButton.Text = "Уволить сотрудника";
            this.ComeToRemoveUserButton.UseVisualStyleBackColor = true;
            this.ComeToRemoveUserButton.Click += new System.EventHandler(this.ComeToRemoveUserButton_Click_1);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(581, 298);
            this.Controls.Add(this.ComeToRemoveUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputListUsers);
            this.Controls.Add(this.ComeToAddUserButton);
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComeToAddUserButton;
        private System.Windows.Forms.Button outputListUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComeToRemoveUserButton;
    }
}