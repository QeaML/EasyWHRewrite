namespace EasyWHRewrite
{
    partial class PresetsForm
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
            this.PresetList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PresetLabel = new System.Windows.Forms.Label();
            this.PresetInfoGroup = new System.Windows.Forms.GroupBox();
            this.PresetInfoLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.UseButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CloneButton = new System.Windows.Forms.Button();
            this.PresetInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PresetList
            // 
            this.PresetList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID});
            this.PresetList.HideSelection = false;
            this.PresetList.Location = new System.Drawing.Point(12, 29);
            this.PresetList.Name = "PresetList";
            this.PresetList.Size = new System.Drawing.Size(217, 416);
            this.PresetList.TabIndex = 0;
            this.PresetList.UseCompatibleStateImageBehavior = false;
            this.PresetList.SelectedIndexChanged += new System.EventHandler(this.PresetList_SelectedIndexChanged);
            // 
            // PresetLabel
            // 
            this.PresetLabel.AutoSize = true;
            this.PresetLabel.Location = new System.Drawing.Point(13, 13);
            this.PresetLabel.Name = "PresetLabel";
            this.PresetLabel.Size = new System.Drawing.Size(82, 13);
            this.PresetLabel.TabIndex = 1;
            this.PresetLabel.Text = "Avilable Presets";
            // 
            // PresetInfoGroup
            // 
            this.PresetInfoGroup.Controls.Add(this.PresetInfoLabel);
            this.PresetInfoGroup.Location = new System.Drawing.Point(236, 29);
            this.PresetInfoGroup.Name = "PresetInfoGroup";
            this.PresetInfoGroup.Size = new System.Drawing.Size(284, 100);
            this.PresetInfoGroup.TabIndex = 2;
            this.PresetInfoGroup.TabStop = false;
            this.PresetInfoGroup.Text = "Preset Info";
            // 
            // PresetInfoLabel
            // 
            this.PresetInfoLabel.AutoSize = true;
            this.PresetInfoLabel.Location = new System.Drawing.Point(7, 20);
            this.PresetInfoLabel.Name = "PresetInfoLabel";
            this.PresetInfoLabel.Size = new System.Drawing.Size(229, 13);
            this.PresetInfoLabel.TabIndex = 0;
            this.PresetInfoLabel.Text = "Select a preset to see information about it here.";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(235, 393);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(150, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.Location = new System.Drawing.Point(235, 364);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(150, 23);
            this.DeleteAllButton.TabIndex = 4;
            this.DeleteAllButton.Text = "Delete All";
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // UseButton
            // 
            this.UseButton.Enabled = false;
            this.UseButton.Location = new System.Drawing.Point(236, 136);
            this.UseButton.Name = "UseButton";
            this.UseButton.Size = new System.Drawing.Size(150, 23);
            this.UseButton.TabIndex = 5;
            this.UseButton.Text = "Use";
            this.UseButton.UseVisualStyleBackColor = true;
            this.UseButton.Click += new System.EventHandler(this.UseButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(235, 223);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(150, 23);
            this.NewButton.TabIndex = 6;
            this.NewButton.Text = "New...";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(235, 422);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(150, 23);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(234, 252);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(235, 194);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 23);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit...";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CloneButton
            // 
            this.CloneButton.Enabled = false;
            this.CloneButton.Location = new System.Drawing.Point(236, 165);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(150, 23);
            this.CloneButton.TabIndex = 10;
            this.CloneButton.Text = "Clone...";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // PresetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 457);
            this.Controls.Add(this.CloneButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.UseButton);
            this.Controls.Add(this.DeleteAllButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.PresetInfoGroup);
            this.Controls.Add(this.PresetLabel);
            this.Controls.Add(this.PresetList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PresetsForm";
            this.ShowIcon = false;
            this.Text = "EasyWH :: Presets";
            this.PresetInfoGroup.ResumeLayout(false);
            this.PresetInfoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PresetList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Label PresetLabel;
        private System.Windows.Forms.GroupBox PresetInfoGroup;
        private System.Windows.Forms.Label PresetInfoLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteAllButton;
        private System.Windows.Forms.Button UseButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CloneButton;
    }
}