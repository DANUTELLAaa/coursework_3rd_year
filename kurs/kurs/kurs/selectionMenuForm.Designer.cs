namespace kurs
{
    partial class selectionMenuForm
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
            this.ComeToTesterButton = new System.Windows.Forms.Button();
            this.ComeToTeamLeadButton = new System.Windows.Forms.Button();
            this.ComeToDeveloperButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComeToTesterButton
            // 
            this.ComeToTesterButton.Location = new System.Drawing.Point(54, 158);
            this.ComeToTesterButton.Name = "ComeToTesterButton";
            this.ComeToTesterButton.Size = new System.Drawing.Size(98, 42);
            this.ComeToTesterButton.TabIndex = 0;
            this.ComeToTesterButton.Text = "Тестрировщик";
            this.ComeToTesterButton.UseVisualStyleBackColor = true;
            this.ComeToTesterButton.Click += new System.EventHandler(this.ComeToTesterButton_Click);
            // 
            // ComeToTeamLeadButton
            // 
            this.ComeToTeamLeadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ComeToTeamLeadButton.Location = new System.Drawing.Point(54, 94);
            this.ComeToTeamLeadButton.Name = "ComeToTeamLeadButton";
            this.ComeToTeamLeadButton.Size = new System.Drawing.Size(98, 42);
            this.ComeToTeamLeadButton.TabIndex = 1;
            this.ComeToTeamLeadButton.Text = "Тимлид";
            this.ComeToTeamLeadButton.UseVisualStyleBackColor = true;
            this.ComeToTeamLeadButton.Click += new System.EventHandler(this.ComeToTeamLeadButton_Click);
            // 
            // ComeToDeveloperButton
            // 
            this.ComeToDeveloperButton.Location = new System.Drawing.Point(54, 222);
            this.ComeToDeveloperButton.Name = "ComeToDeveloperButton";
            this.ComeToDeveloperButton.Size = new System.Drawing.Size(98, 42);
            this.ComeToDeveloperButton.TabIndex = 2;
            this.ComeToDeveloperButton.Text = "Разработчик";
            this.ComeToDeveloperButton.UseVisualStyleBackColor = true;
            this.ComeToDeveloperButton.Click += new System.EventHandler(this.ComeToDeveloperButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кто ты?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectionMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(206, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComeToDeveloperButton);
            this.Controls.Add(this.ComeToTeamLeadButton);
            this.Controls.Add(this.ComeToTesterButton);
            this.Name = "selectionMenuForm";
            this.Text = "selectionMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComeToTesterButton;
        private System.Windows.Forms.Button ComeToTeamLeadButton;
        private System.Windows.Forms.Button ComeToDeveloperButton;
        private System.Windows.Forms.Label label1;
    }
}