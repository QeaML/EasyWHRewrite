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
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoSubtextLabel = new System.Windows.Forms.Label();
            this.SloganLabel = new System.Windows.Forms.Label();
            this.LoginMethodsGroup = new System.Windows.Forms.GroupBox();
            this.PresetsButton = new System.Windows.Forms.Button();
            this.ManualButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.LoginMethodsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoLabel.Location = new System.Drawing.Point(13, 13);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(382, 128);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "EasyWH";
            // 
            // LogoSubtextLabel
            // 
            this.LogoSubtextLabel.AutoSize = true;
            this.LogoSubtextLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoSubtextLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoSubtextLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogoSubtextLabel.Location = new System.Drawing.Point(356, 42);
            this.LogoSubtextLabel.Name = "LogoSubtextLabel";
            this.LogoSubtextLabel.Size = new System.Drawing.Size(88, 25);
            this.LogoSubtextLabel.TabIndex = 1;
            this.LogoSubtextLabel.Text = "Rewritten";
            // 
            // SloganLabel
            // 
            this.SloganLabel.AutoSize = true;
            this.SloganLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SloganLabel.Location = new System.Drawing.Point(28, 141);
            this.SloganLabel.Name = "SloganLabel";
            this.SloganLabel.Size = new System.Drawing.Size(323, 40);
            this.SloganLabel.TabIndex = 2;
            this.SloganLabel.Text = "Discord webhooks, easier.";
            // 
            // LoginMethodsGroup
            // 
            this.LoginMethodsGroup.Controls.Add(this.PresetsButton);
            this.LoginMethodsGroup.Controls.Add(this.ManualButton);
            this.LoginMethodsGroup.Location = new System.Drawing.Point(35, 185);
            this.LoginMethodsGroup.Name = "LoginMethodsGroup";
            this.LoginMethodsGroup.Size = new System.Drawing.Size(399, 53);
            this.LoginMethodsGroup.TabIndex = 3;
            this.LoginMethodsGroup.TabStop = false;
            this.LoginMethodsGroup.Text = "Login Methods";
            // 
            // PresetsButton
            // 
            this.PresetsButton.Location = new System.Drawing.Point(203, 19);
            this.PresetsButton.Name = "PresetsButton";
            this.PresetsButton.Size = new System.Drawing.Size(190, 25);
            this.PresetsButton.TabIndex = 1;
            this.PresetsButton.Text = "Presets";
            this.PresetsButton.UseVisualStyleBackColor = true;
            this.PresetsButton.Click += new System.EventHandler(this.PresetsButton_Click);
            // 
            // ManualButton
            // 
            this.ManualButton.Location = new System.Drawing.Point(6, 19);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(190, 25);
            this.ManualButton.TabIndex = 0;
            this.ManualButton.Text = "Manual";
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(392, 266);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(316, 128);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(80, 13);
            this.VersionLabel.TabIndex = 5;
            this.VersionLabel.Text = "<VersionLabel>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 301);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.LoginMethodsGroup);
            this.Controls.Add(this.SloganLabel);
            this.Controls.Add(this.LogoSubtextLabel);
            this.Controls.Add(this.LogoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "EasyWH";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LoginMethodsGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label LogoSubtextLabel;
        private System.Windows.Forms.Label SloganLabel;
        private System.Windows.Forms.GroupBox LoginMethodsGroup;
        private System.Windows.Forms.Button PresetsButton;
        private System.Windows.Forms.Button ManualButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label VersionLabel;
    }
}

