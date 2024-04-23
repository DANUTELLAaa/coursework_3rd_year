namespace kurs
{
    partial class mainMenuForDeveloper
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
            this.GoToBackButton = new System.Windows.Forms.Button();
            this.ComeToRequestForRaiseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToBackButton
            // 
            this.GoToBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToBackButton.Location = new System.Drawing.Point(11, 194);
            this.GoToBackButton.Name = "GoToBackButton";
            this.GoToBackButton.Size = new System.Drawing.Size(100, 44);
            this.GoToBackButton.TabIndex = 11;
            this.GoToBackButton.Text = "НАЗАД";
            this.GoToBackButton.UseVisualStyleBackColor = true;
            this.GoToBackButton.Click += new System.EventHandler(this.GoToBackButton_Click);
            // 
            // ComeToRequestForRaiseButton
            // 
            this.ComeToRequestForRaiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComeToRequestForRaiseButton.Location = new System.Drawing.Point(156, 121);
            this.ComeToRequestForRaiseButton.Margin = new System.Windows.Forms.Padding(2);
            this.ComeToRequestForRaiseButton.Name = "ComeToRequestForRaiseButton";
            this.ComeToRequestForRaiseButton.Size = new System.Drawing.Size(160, 64);
            this.ComeToRequestForRaiseButton.TabIndex = 9;
            this.ComeToRequestForRaiseButton.Text = "Попросить повышение";
            this.ComeToRequestForRaiseButton.UseVisualStyleBackColor = true;
            this.ComeToRequestForRaiseButton.Click += new System.EventHandler(this.ComeToRequestForRaiseButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "Главное меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(369, 215);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(75, 23);
            this.messageButton.TabIndex = 12;
            this.messageButton.Text = "Сообщения";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // mainMenuForDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 265);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.GoToBackButton);
            this.Controls.Add(this.ComeToRequestForRaiseButton);
            this.Controls.Add(this.label1);
            this.Name = "mainMenuForDeveloper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainMenuForDeveloper_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToBackButton;
        private System.Windows.Forms.Button ComeToRequestForRaiseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button messageButton;
    }
}