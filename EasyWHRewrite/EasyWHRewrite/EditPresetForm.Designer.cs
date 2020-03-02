namespace EasyWHRewrite
{
    partial class EditPresetForm
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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.AvatarTextBox = new System.Windows.Forms.TextBox();
            this.AvatarLabel = new System.Windows.Forms.Label();
            this.NickLabel = new System.Windows.Forms.Label();
            this.NickTextBox = new System.Windows.Forms.TextBox();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(13, 25);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(162, 20);
            this.IDTextBox.TabIndex = 27;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(51, 13);
            this.IDLabel.TabIndex = 26;
            this.IDLabel.Text = "Preset ID";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 200);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(163, 23);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(12, 170);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(163, 23);
            this.DoneButton.TabIndex = 24;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AvatarTextBox
            // 
            this.AvatarTextBox.Location = new System.Drawing.Point(13, 143);
            this.AvatarTextBox.Name = "AvatarTextBox";
            this.AvatarTextBox.Size = new System.Drawing.Size(162, 20);
            this.AvatarTextBox.TabIndex = 23;
            // 
            // AvatarLabel
            // 
            this.AvatarLabel.AutoSize = true;
            this.AvatarLabel.Location = new System.Drawing.Point(12, 126);
            this.AvatarLabel.Name = "AvatarLabel";
            this.AvatarLabel.Size = new System.Drawing.Size(63, 13);
            this.AvatarLabel.TabIndex = 22;
            this.AvatarLabel.Text = "Avatar URL";
            // 
            // NickLabel
            // 
            this.NickLabel.AutoSize = true;
            this.NickLabel.Location = new System.Drawing.Point(12, 87);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(39, 13);
            this.NickLabel.TabIndex = 21;
            this.NickLabel.Text = "Name*";
            // 
            // NickTextBox
            // 
            this.NickTextBox.Location = new System.Drawing.Point(13, 103);
            this.NickTextBox.Name = "NickTextBox";
            this.NickTextBox.Size = new System.Drawing.Size(162, 20);
            this.NickTextBox.TabIndex = 20;
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(13, 64);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(162, 20);
            this.URLTextBox.TabIndex = 19;
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(12, 48);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(83, 13);
            this.URLLabel.TabIndex = 18;
            this.URLLabel.Text = "Webhook URL*";
            // 
            // EditPresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 235);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.AvatarTextBox);
            this.Controls.Add(this.AvatarLabel);
            this.Controls.Add(this.NickLabel);
            this.Controls.Add(this.NickTextBox);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.URLLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPresetForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyWH :: Edit Preset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox AvatarTextBox;
        private System.Windows.Forms.Label AvatarLabel;
        private System.Windows.Forms.Label NickLabel;
        private System.Windows.Forms.TextBox NickTextBox;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Label URLLabel;
    }
}