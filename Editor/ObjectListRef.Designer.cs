namespace KatAM_Object_Editor.Editor
{
    partial class ObjectListRef
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
            listBoxObjects = new ListBox();
            SuspendLayout();
            // 
            // listBoxObjects
            // 
            listBoxObjects.FormattingEnabled = true;
            listBoxObjects.ItemHeight = 15;
            listBoxObjects.Location = new Point(12, 12);
            listBoxObjects.Name = "listBoxObjects";
            listBoxObjects.Size = new Size(292, 409);
            listBoxObjects.TabIndex = 0;
            // 
            // ObjectListRef
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 432);
            Controls.Add(listBoxObjects);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ObjectListRef";
            Text = "ObjectListRef";
            Load += ObjectListRef_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxObjects;
    }
}