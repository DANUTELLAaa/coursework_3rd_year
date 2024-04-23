namespace kurs
{
    partial class mainMenuForTeamLead
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
            this.GoToBackButton = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComeToAddUserButton
            // 
            this.ComeToAddUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComeToAddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComeToAddUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ComeToAddUserButton.Location = new System.Drawing.Point(11, 116);
            this.ComeToAddUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.ComeToAddUserButton.Name = "ComeToAddUserButton";
            this.ComeToAddUserButton.Size = new System.Drawing.Size(138, 40);
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
            this.outputListUsers.Location = new System.Drawing.Point(153, 116);
            this.outputListUsers.Margin = new System.Windows.Forms.Padding(2);
            this.outputListUsers.Name = "outputListUsers";
            this.outputListUsers.Size = new System.Drawing.Size(138, 40);
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
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Главное меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComeToRemoveUserButton
            // 
            this.ComeToRemoveUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComeToRemoveUserButton.Location = new System.Drawing.Point(295, 116);
            this.ComeToRemoveUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.ComeToRemoveUserButton.Name = "ComeToRemoveUserButton";
            this.ComeToRemoveUserButton.Size = new System.Drawing.Size(130, 40);
            this.ComeToRemoveUserButton.TabIndex = 3;
            this.ComeToRemoveUserButton.Text = "Уволить сотрудника";
            this.ComeToRemoveUserButton.UseVisualStyleBackColor = true;
            this.ComeToRemoveUserButton.Click += new System.EventHandler(this.ComeToRemoveUserButton_Click_1);
            // 
            // GoToBackButton
            // 
            this.GoToBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToBackButton.Location = new System.Drawing.Point(12, 186);
            this.GoToBackButton.Name = "GoToBackButton";
            this.GoToBackButton.Size = new System.Drawing.Size(100, 44);
            this.GoToBackButton.TabIndex = 5;
            this.GoToBackButton.Text = "НАЗАД";
            this.GoToBackButton.UseVisualStyleBackColor = true;
            this.GoToBackButton.Click += new System.EventHandler(this.GoToBackButton_Click);
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(350, 207);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(75, 23);
            this.messageButton.TabIndex = 18;
            this.messageButton.Text = "Сообщения";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // mainMenuForTeamLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(436, 242);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.GoToBackButton);
            this.Controls.Add(this.ComeToRemoveUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputListUsers);
            this.Controls.Add(this.ComeToAddUserButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainMenuForTeamLead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainMenuForTeamLead_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComeToAddUserButton;
        private System.Windows.Forms.Button outputListUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComeToRemoveUserButton;
        private System.Windows.Forms.Button GoToBackButton;
        private System.Windows.Forms.Button messageButton;
    }
}