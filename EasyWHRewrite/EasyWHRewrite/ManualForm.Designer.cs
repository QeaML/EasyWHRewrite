namespace EasyWHRewrite
{
    partial class ManualForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualForm));
            this.URLLabel = new System.Windows.Forms.Label();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.NickTextBox = new System.Windows.Forms.TextBox();
            this.NickLabel = new System.Windows.Forms.Label();
            this.AvatarLabel = new System.Windows.Forms.Label();
            this.AvatarTextBox = new System.Windows.Forms.TextBox();
            this.ChatButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(12, 14);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(83, 13);
            this.URLLabel.TabIndex = 0;
            this.URLLabel.Text = "Webhook URL*";
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(13, 30);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(162, 20);
            this.URLTextBox.TabIndex = 1;
            // 
            // NickTextBox
            // 
            this.NickTextBox.Location = new System.Drawing.Point(13, 69);
            this.NickTextBox.Name = "NickTextBox";
            this.NickTextBox.Size = new System.Drawing.Size(162, 20);
            this.NickTextBox.TabIndex = 2;
            // 
            // NickLabel
            // 
            this.NickLabel.AutoSize = true;
            this.NickLabel.Location = new System.Drawing.Point(12, 53);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(39, 13);
            this.NickLabel.TabIndex = 3;
            this.NickLabel.Text = "Name*";
            // 
            // AvatarLabel
            // 
            this.AvatarLabel.AutoSize = true;
            this.AvatarLabel.Location = new System.Drawing.Point(12, 92);
            this.AvatarLabel.Name = "AvatarLabel";
            this.AvatarLabel.Size = new System.Drawing.Size(63, 13);
            this.AvatarLabel.TabIndex = 4;
            this.AvatarLabel.Text = "Avatar URL";
            // 
            // AvatarTextBox
            // 
            this.AvatarTextBox.Location = new System.Drawing.Point(13, 109);
            this.AvatarTextBox.Name = "AvatarTextBox";
            this.AvatarTextBox.Size = new System.Drawing.Size(162, 20);
            this.AvatarTextBox.TabIndex = 5;
            // 
            // ChatButton
            // 
            this.ChatButton.ForeColor = System.Drawing.Color.Black;
            this.ChatButton.Location = new System.Drawing.Point(12, 136);
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.Size = new System.Drawing.Size(163, 23);
            this.ChatButton.TabIndex = 6;
            this.ChatButton.Text = "Chat";
            this.ChatButton.UseVisualStyleBackColor = true;
            this.ChatButton.Click += new System.EventHandler(this.ChatButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(12, 166);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(163, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(187, 200);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChatButton);
            this.Controls.Add(this.AvatarTextBox);
            this.Controls.Add(this.AvatarLabel);
            this.Controls.Add(this.NickLabel);
            this.Controls.Add(this.NickTextBox);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.URLLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyWH :: Manual Log-in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.TextBox NickTextBox;
        private System.Windows.Forms.Label NickLabel;
        private System.Windows.Forms.Label AvatarLabel;
        private System.Windows.Forms.TextBox AvatarTextBox;
        private System.Windows.Forms.Button ChatButton;
        private System.Windows.Forms.Button BackButton;
    }
}