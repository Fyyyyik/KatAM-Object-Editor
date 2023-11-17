namespace KatAM_Object_Editor.Editor
{
    partial class DialogConfirmSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogConfirmSave));
            label1 = new Label();
            label2 = new Label();
            buttonOk = new Button();
            buttonCancel = new Button();
            checkBoxShowAgain = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(368, 17);
            label1.TabIndex = 0;
            label1.Text = "Saving will change certain bytes in the ROM and may break it!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(189, 21);
            label2.TabIndex = 1;
            label2.Text = "This cannot be undone!";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(292, 109);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(199, 109);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBoxShowAgain
            // 
            checkBoxShowAgain.AutoSize = true;
            checkBoxShowAgain.Location = new Point(12, 109);
            checkBoxShowAgain.Name = "checkBoxShowAgain";
            checkBoxShowAgain.Size = new Size(167, 19);
            checkBoxShowAgain.TabIndex = 4;
            checkBoxShowAgain.Text = "Do not show me this again";
            checkBoxShowAgain.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(305, 15);
            label3.TabIndex = 5;
            label3.Text = "It is advised to backup your ROM before doing anything!";
            // 
            // DialogConfirmSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 144);
            Controls.Add(label3);
            Controls.Add(checkBoxShowAgain);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogConfirmSave";
            Text = "Warning!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonOk;
        private Button buttonCancel;
        private CheckBox checkBoxShowAgain;
        private Label label3;
    }
}