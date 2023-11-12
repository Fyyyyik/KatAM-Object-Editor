namespace KatAM_Object_Editor.Editor
{
    partial class VersionSelect
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
            labelMain = new Label();
            btn_usa = new Button();
            btn_japanese = new Button();
            btn_eu = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMain.Location = new Point(91, 19);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(167, 20);
            labelMain.TabIndex = 0;
            labelMain.Text = "Select the game version";
            // 
            // btn_usa
            // 
            btn_usa.Location = new Point(134, 100);
            btn_usa.Name = "btn_usa";
            btn_usa.Size = new Size(75, 23);
            btn_usa.TabIndex = 1;
            btn_usa.Text = "American";
            btn_usa.UseVisualStyleBackColor = true;
            btn_usa.Click += btn_usa_Click;
            // 
            // btn_japanese
            // 
            btn_japanese.Location = new Point(32, 100);
            btn_japanese.Name = "btn_japanese";
            btn_japanese.Size = new Size(75, 23);
            btn_japanese.TabIndex = 2;
            btn_japanese.Text = "Japanese";
            btn_japanese.UseVisualStyleBackColor = true;
            btn_japanese.Click += btn_japanese_Click;
            // 
            // btn_eu
            // 
            btn_eu.Location = new Point(238, 100);
            btn_eu.Name = "btn_eu";
            btn_eu.Size = new Size(75, 23);
            btn_eu.TabIndex = 3;
            btn_eu.Text = "Europe";
            btn_eu.UseVisualStyleBackColor = true;
            btn_eu.Click += btn_eu_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(134, 134);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // VersionSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 169);
            Controls.Add(btn_cancel);
            Controls.Add(btn_eu);
            Controls.Add(btn_japanese);
            Controls.Add(btn_usa);
            Controls.Add(labelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VersionSelect";
            ShowIcon = false;
            Text = "Version Select";
            Load += VersionSelect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMain;
        private Button btn_usa;
        private Button btn_japanese;
        private Button btn_eu;
        private Button btn_cancel;
    }
}