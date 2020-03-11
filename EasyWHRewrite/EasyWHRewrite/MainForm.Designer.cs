namespace EasyWHRewrite
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoSubtextLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.ManualButton = new System.Windows.Forms.Button();
            this.PresetsButton = new System.Windows.Forms.Button();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoLabel.Location = new System.Drawing.Point(-5, 1);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(382, 128);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "EasyWH";
            this.LogoLabel.Click += new System.EventHandler(this.LogoLabel_Click);
            // 
            // LogoSubtextLabel
            // 
            this.LogoSubtextLabel.AutoSize = true;
            this.LogoSubtextLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoSubtextLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoSubtextLabel.ForeColor = System.Drawing.Color.White;
            this.LogoSubtextLabel.Location = new System.Drawing.Point(257, 107);
            this.LogoSubtextLabel.Name = "LogoSubtextLabel";
            this.LogoSubtextLabel.Size = new System.Drawing.Size(88, 25);
            this.LogoSubtextLabel.TabIndex = 1;
            this.LogoSubtextLabel.Text = "Rewritten";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(17, 116);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VersionLabel.Size = new System.Drawing.Size(117, 13);
            this.VersionLabel.TabIndex = 5;
            this.VersionLabel.Text = "(this is placeholder text)";
            // 
            // Settings
            // 
            this.Settings.Enabled = false;
            this.Settings.ForeColor = System.Drawing.Color.Black;
            this.Settings.Location = new System.Drawing.Point(17, 210);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(328, 25);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // ManualButton
            // 
            this.ManualButton.ForeColor = System.Drawing.Color.Black;
            this.ManualButton.Location = new System.Drawing.Point(17, 148);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(328, 25);
            this.ManualButton.TabIndex = 0;
            this.ManualButton.Text = "Manual";
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // PresetsButton
            // 
            this.PresetsButton.ForeColor = System.Drawing.Color.Black;
            this.PresetsButton.Location = new System.Drawing.Point(17, 179);
            this.PresetsButton.Name = "PresetsButton";
            this.PresetsButton.Size = new System.Drawing.Size(328, 25);
            this.PresetsButton.TabIndex = 1;
            this.PresetsButton.Text = "Presets";
            this.PresetsButton.UseVisualStyleBackColor = true;
            this.PresetsButton.Click += new System.EventHandler(this.PresetsButton_Click);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(12, 238);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(117, 13);
            this.UpdateLabel.TabIndex = 7;
            this.UpdateLabel.Text = "(this is placeholder text)";
            this.UpdateLabel.Click += new System.EventHandler(this.UpdateLabel_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.ForeColor = System.Drawing.Color.Black;
            this.AboutButton.Location = new System.Drawing.Point(325, 12);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(20, 20);
            this.AboutButton.TabIndex = 8;
            this.AboutButton.Text = "?";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(357, 260);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.PresetsButton);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.ManualButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.LogoSubtextLabel);
            this.Controls.Add(this.LogoLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyWH";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label LogoSubtextLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button ManualButton;
        private System.Windows.Forms.Button PresetsButton;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Button AboutButton;
    }
}

