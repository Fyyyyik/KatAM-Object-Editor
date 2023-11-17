namespace KatAM_Object_Editor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            showAddressesToolStripMenuItem = new ToolStripMenuItem();
            useHexToolStripMenuItem = new ToolStripMenuItem();
            documentationToolStripMenuItem = new ToolStripMenuItem();
            panel_main = new Panel();
            btn_objectedit = new Button();
            btn_roomedit = new Button();
            showWarningWhenSavingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, preferencesToolStripMenuItem, documentationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(951, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAddressesToolStripMenuItem, useHexToolStripMenuItem, showWarningWhenSavingToolStripMenuItem });
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(80, 20);
            preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // showAddressesToolStripMenuItem
            // 
            showAddressesToolStripMenuItem.Name = "showAddressesToolStripMenuItem";
            showAddressesToolStripMenuItem.Size = new Size(218, 22);
            showAddressesToolStripMenuItem.Text = "Show addresses";
            showAddressesToolStripMenuItem.Click += showAddressesToolStripMenuItem_Click;
            // 
            // useHexToolStripMenuItem
            // 
            useHexToolStripMenuItem.Name = "useHexToolStripMenuItem";
            useHexToolStripMenuItem.Size = new Size(218, 22);
            useHexToolStripMenuItem.Text = "Use hex";
            useHexToolStripMenuItem.Click += useHexToolStripMenuItem_Click;
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new Size(102, 20);
            documentationToolStripMenuItem.Text = "Documentation";
            documentationToolStripMenuItem.Click += documentationToolStripMenuItem_Click;
            // 
            // panel_main
            // 
            panel_main.Location = new Point(12, 56);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(927, 517);
            panel_main.TabIndex = 1;
            // 
            // btn_objectedit
            // 
            btn_objectedit.Location = new Point(15, 27);
            btn_objectedit.Name = "btn_objectedit";
            btn_objectedit.Size = new Size(449, 23);
            btn_objectedit.TabIndex = 2;
            btn_objectedit.Text = "Object Param Editor";
            btn_objectedit.UseVisualStyleBackColor = true;
            btn_objectedit.Click += btn_objectedit_Click;
            // 
            // btn_roomedit
            // 
            btn_roomedit.Location = new Point(490, 27);
            btn_roomedit.Name = "btn_roomedit";
            btn_roomedit.Size = new Size(449, 23);
            btn_roomedit.TabIndex = 3;
            btn_roomedit.Text = "Room Editor";
            btn_roomedit.UseVisualStyleBackColor = true;
            btn_roomedit.Click += btn_roomedit_Click;
            // 
            // showWarningWhenSavingToolStripMenuItem
            // 
            showWarningWhenSavingToolStripMenuItem.Name = "showWarningWhenSavingToolStripMenuItem";
            showWarningWhenSavingToolStripMenuItem.Size = new Size(218, 22);
            showWarningWhenSavingToolStripMenuItem.Text = "Show warning when saving";
            showWarningWhenSavingToolStripMenuItem.Click += showWarningWhenSavingToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 585);
            Controls.Add(btn_roomedit);
            Controls.Add(btn_objectedit);
            Controls.Add(panel_main);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "KatAM Object Editor";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Panel panel_main;
        private Button btn_objectedit;
        private Button btn_roomedit;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private ToolStripMenuItem showAddressesToolStripMenuItem;
        private ToolStripMenuItem useHexToolStripMenuItem;
        private ToolStripMenuItem showWarningWhenSavingToolStripMenuItem;
    }
}