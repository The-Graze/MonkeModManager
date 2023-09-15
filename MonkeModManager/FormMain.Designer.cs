﻿namespace MonkeModManager
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRestoreMods = new System.Windows.Forms.Button();
            this.buttonBackupMods = new System.Windows.Forms.Button();
            this.buttonUninstallAll = new System.Windows.Forms.Button();
            this.buttonModInfo = new System.Windows.Forms.Button();
            this.buttonToggleMods = new System.Windows.Forms.Button();
            this.buttonOpenGameFolder = new System.Windows.Forms.Button();
            this.buttonOpenConfig = new System.Windows.Forms.Button();
            this.buttonBepInEx = new System.Windows.Forms.Button();
            this.listViewMods = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.ForeColor = System.Drawing.Color.White;
            this.textBoxDirectory.Location = new System.Drawing.Point(3, 32);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(529, 22);
            this.textBoxDirectory.TabIndex = 0;
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonFolderBrowser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonFolderBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolderBrowser.ForeColor = System.Drawing.Color.White;
            this.buttonFolderBrowser.Location = new System.Drawing.Point(331, 3);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(26, 23);
            this.buttonFolderBrowser.TabIndex = 1;
            this.buttonFolderBrowser.Text = "..";
            this.buttonFolderBrowser.UseVisualStyleBackColor = false;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gorilla Tag Folder Path:";
            // 
            // buttonInstall
            // 
            this.buttonInstall.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonInstall.Enabled = false;
            this.buttonInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstall.ForeColor = System.Drawing.Color.White;
            this.buttonInstall.Location = new System.Drawing.Point(538, 154);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(112, 23);
            this.buttonInstall.TabIndex = 4;
            this.buttonInstall.Text = "Install / Update";
            this.buttonInstall.UseVisualStyleBackColor = false;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelStatus.Location = new System.Drawing.Point(433, 8);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status: Null";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(124, 26);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.viewInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.viewInfoToolStripMenuItem.Text = "View Info";
            this.viewInfoToolStripMenuItem.Click += new System.EventHandler(this.viewInfoToolStripMenuItem_Click);
            // 
            // buttonRestoreMods
            // 
            this.buttonRestoreMods.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRestoreMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonRestoreMods.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonRestoreMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreMods.ForeColor = System.Drawing.Color.White;
            this.buttonRestoreMods.Location = new System.Drawing.Point(538, 334);
            this.buttonRestoreMods.Name = "buttonRestoreMods";
            this.buttonRestoreMods.Size = new System.Drawing.Size(112, 23);
            this.buttonRestoreMods.TabIndex = 3;
            this.buttonRestoreMods.Text = "Restore Mods";
            this.buttonRestoreMods.UseVisualStyleBackColor = false;
            this.buttonRestoreMods.Click += new System.EventHandler(this.buttonRestoreMods_Click);
            // 
            // buttonBackupMods
            // 
            this.buttonBackupMods.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonBackupMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonBackupMods.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonBackupMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackupMods.ForeColor = System.Drawing.Color.White;
            this.buttonBackupMods.Location = new System.Drawing.Point(538, 274);
            this.buttonBackupMods.Name = "buttonBackupMods";
            this.buttonBackupMods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonBackupMods.Size = new System.Drawing.Size(112, 23);
            this.buttonBackupMods.TabIndex = 1;
            this.buttonBackupMods.Text = "Backup Mods";
            this.buttonBackupMods.UseVisualStyleBackColor = false;
            this.buttonBackupMods.Click += new System.EventHandler(this.buttonBackupMods_Click);
            // 
            // buttonUninstallAll
            // 
            this.buttonUninstallAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUninstallAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonUninstallAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonUninstallAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUninstallAll.ForeColor = System.Drawing.Color.White;
            this.buttonUninstallAll.Location = new System.Drawing.Point(538, 214);
            this.buttonUninstallAll.Name = "buttonUninstallAll";
            this.buttonUninstallAll.Size = new System.Drawing.Size(112, 23);
            this.buttonUninstallAll.TabIndex = 0;
            this.buttonUninstallAll.Text = "Uninstall All Mods";
            this.buttonUninstallAll.UseVisualStyleBackColor = false;
            this.buttonUninstallAll.Click += new System.EventHandler(this.buttonUninstallAll_Click);
            // 
            // buttonModInfo
            // 
            this.buttonModInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonModInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonModInfo.Enabled = false;
            this.buttonModInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonModInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModInfo.ForeColor = System.Drawing.Color.White;
            this.buttonModInfo.Location = new System.Drawing.Point(538, 94);
            this.buttonModInfo.Name = "buttonModInfo";
            this.buttonModInfo.Size = new System.Drawing.Size(112, 23);
            this.buttonModInfo.TabIndex = 9;
            this.buttonModInfo.Text = "View Mod Info";
            this.buttonModInfo.UseVisualStyleBackColor = false;
            this.buttonModInfo.Click += new System.EventHandler(this.buttonModInfo_Click);
            // 
            // buttonToggleMods
            // 
            this.buttonToggleMods.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonToggleMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonToggleMods.Enabled = false;
            this.buttonToggleMods.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonToggleMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToggleMods.ForeColor = System.Drawing.Color.White;
            this.buttonToggleMods.Location = new System.Drawing.Point(538, 34);
            this.buttonToggleMods.Name = "buttonToggleMods";
            this.buttonToggleMods.Size = new System.Drawing.Size(112, 23);
            this.buttonToggleMods.TabIndex = 10;
            this.buttonToggleMods.Text = "Disable Mods";
            this.buttonToggleMods.UseVisualStyleBackColor = false;
            this.buttonToggleMods.Click += new System.EventHandler(this.buttonToggleMods_Click);
            // 
            // buttonOpenGameFolder
            // 
            this.buttonOpenGameFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonOpenGameFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonOpenGameFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenGameFolder.ForeColor = System.Drawing.Color.White;
            this.buttonOpenGameFolder.Location = new System.Drawing.Point(398, 58);
            this.buttonOpenGameFolder.Name = "buttonOpenGameFolder";
            this.buttonOpenGameFolder.Size = new System.Drawing.Size(134, 23);
            this.buttonOpenGameFolder.TabIndex = 5;
            this.buttonOpenGameFolder.Text = "Game Folder";
            this.buttonOpenGameFolder.UseVisualStyleBackColor = false;
            this.buttonOpenGameFolder.Click += new System.EventHandler(this.buttonOpenGameFolder_Click);
            // 
            // buttonOpenConfig
            // 
            this.buttonOpenConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonOpenConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonOpenConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenConfig.ForeColor = System.Drawing.Color.White;
            this.buttonOpenConfig.Location = new System.Drawing.Point(3, 58);
            this.buttonOpenConfig.Name = "buttonOpenConfig";
            this.buttonOpenConfig.Size = new System.Drawing.Size(134, 23);
            this.buttonOpenConfig.TabIndex = 5;
            this.buttonOpenConfig.Text = "Config Folder";
            this.buttonOpenConfig.UseVisualStyleBackColor = false;
            this.buttonOpenConfig.Click += new System.EventHandler(this.buttonOpenConfigFolder_Click);
            // 
            // buttonBepInEx
            // 
            this.buttonBepInEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonBepInEx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonBepInEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBepInEx.ForeColor = System.Drawing.Color.White;
            this.buttonBepInEx.Location = new System.Drawing.Point(201, 58);
            this.buttonBepInEx.Name = "buttonBepInEx";
            this.buttonBepInEx.Size = new System.Drawing.Size(134, 23);
            this.buttonBepInEx.TabIndex = 5;
            this.buttonBepInEx.Text = "BepInEx Folder";
            this.buttonBepInEx.UseVisualStyleBackColor = false;
            this.buttonBepInEx.Click += new System.EventHandler(this.buttonOpenBepInExFolder_Click);
            // 
            // listViewMods
            // 
            this.listViewMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listViewMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMods.CheckBoxes = true;
            this.listViewMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderAuthor});
            this.listViewMods.ContextMenuStrip = this.contextMenuStripMain;
            this.listViewMods.ForeColor = System.Drawing.Color.White;
            this.listViewMods.FullRowSelect = true;
            this.listViewMods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewMods.HideSelection = false;
            this.listViewMods.Location = new System.Drawing.Point(0, 89);
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(532, 292);
            this.listViewMods.TabIndex = 0;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            this.listViewMods.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewMods_ItemChecked);
            this.listViewMods.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMods_ItemSelectionChanged);
            this.listViewMods.SelectedIndexChanged += new System.EventHandler(this.listViewMods_SelectedIndexChanged);
            this.listViewMods.DoubleClick += new System.EventHandler(this.listViewMods_DoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 321;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 162;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(662, 378);
            this.Controls.Add(this.listViewMods);
            this.Controls.Add(this.buttonOpenConfig);
            this.Controls.Add(this.buttonBepInEx);
            this.Controls.Add(this.buttonOpenGameFolder);
            this.Controls.Add(this.buttonBackupMods);
            this.Controls.Add(this.buttonRestoreMods);
            this.Controls.Add(this.buttonToggleMods);
            this.Controls.Add(this.buttonModInfo);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonUninstallAll);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFolderBrowser);
            this.Controls.Add(this.textBoxDirectory);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monke Mod Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.Button buttonModInfo;
        private System.Windows.Forms.Button buttonUninstallAll;
        private System.Windows.Forms.Button buttonBackupMods;
        private System.Windows.Forms.Button buttonRestoreMods;
        private System.Windows.Forms.Button buttonToggleMods;
        private System.Windows.Forms.Button buttonBepInEx;
        private System.Windows.Forms.Button buttonOpenConfig;
        private System.Windows.Forms.Button buttonOpenGameFolder;
        public System.Windows.Forms.ListView listViewMods;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
    }
}

