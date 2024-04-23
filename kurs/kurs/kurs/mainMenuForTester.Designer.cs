namespace kurs
{
    partial class mainMenuForTester
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
            this.messageButton = new System.Windows.Forms.Button();
            this.GoToBackButton = new System.Windows.Forms.Button();
            this.KickDeveloperButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(359, 264);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(75, 23);
            this.messageButton.TabIndex = 17;
            this.messageButton.Text = "Сообщения";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // GoToBackButton
            // 
            this.GoToBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToBackButton.Location = new System.Drawing.Point(11, 251);
            this.GoToBackButton.Name = "GoToBackButton";
            this.GoToBackButton.Size = new System.Drawing.Size(100, 44);
            this.GoToBackButton.TabIndex = 16;
            this.GoToBackButton.Text = "НАЗАД";
            this.GoToBackButton.UseVisualStyleBackColor = true;
            this.GoToBackButton.Click += new System.EventHandler(this.GoToBackButton_Click);
            // 
            // KickDeveloperButton
            // 
            this.KickDeveloperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KickDeveloperButton.Location = new System.Drawing.Point(159, 141);
            this.KickDeveloperButton.Margin = new System.Windows.Forms.Padding(2);
            this.KickDeveloperButton.Name = "KickDeveloperButton";
            this.KickDeveloperButton.Size = new System.Drawing.Size(138, 40);
            this.KickDeveloperButton.TabIndex = 14;
            this.KickDeveloperButton.Text = "Пнуть разработчика";
            this.KickDeveloperButton.UseVisualStyleBackColor = true;
            this.KickDeveloperButton.Click += new System.EventHandler(this.KickDeveloperButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 62);
            this.label1.TabIndex = 13;
            this.label1.Text = "Главное меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenuForTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 299);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.GoToBackButton);
            this.Controls.Add(this.KickDeveloperButton);
            this.Controls.Add(this.label1);
            this.Name = "mainMenuForTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForTester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainMenuForTester_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button GoToBackButton;
        private System.Windows.Forms.Button KickDeveloperButton;
        private System.Windows.Forms.Label label1;
    }
}