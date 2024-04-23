namespace kurs
{
    partial class sendMessageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.messageField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отправка сообшения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(91, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите собщение";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendMessage.FlatAppearance.BorderSize = 0;
            this.buttonSendMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonSendMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMessage.Location = new System.Drawing.Point(361, 481);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(362, 45);
            this.buttonSendMessage.TabIndex = 5;
            this.buttonSendMessage.Text = "Отправить";
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // messageField
            // 
            this.messageField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageField.Location = new System.Drawing.Point(97, 178);
            this.messageField.Multiline = true;
            this.messageField.Name = "messageField";
            this.messageField.Size = new System.Drawing.Size(905, 297);
            this.messageField.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.registerLabel);
            this.panel1.Controls.Add(this.buttonSendMessage);
            this.panel1.Controls.Add(this.messageField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 571);
            this.panel1.TabIndex = 3;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 119);
            this.panel2.TabIndex = 0;
            // 
            // sendMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1014, 571);
            this.Controls.Add(this.panel1);
            this.Name = "sendMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sendMessageForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox messageField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Panel panel2;
    }
}