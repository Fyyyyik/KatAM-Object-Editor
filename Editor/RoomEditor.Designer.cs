namespace KatAM_Object_Editor
{
    partial class RoomEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelRoomMain = new Panel();
            labelRoomGameobj = new Label();
            listBoxRooms = new ListBox();
            panelRoomControl = new Panel();
            labelAdress = new Label();
            buttonObjectList = new Button();
            listBoxRoomObjs = new ListBox();
            panelProperties = new Panel();
            numericUpDownSpeed = new NumericUpDown();
            labelSpeed = new Label();
            label1 = new Label();
            numericUpDownBehaviour = new NumericUpDown();
            numericUpDownHorizontal = new NumericUpDown();
            labelBehaviour = new Label();
            labelHorizontal = new Label();
            numericUpDownid = new NumericUpDown();
            numericUpDownVertical = new NumericUpDown();
            labelObjid = new Label();
            labelRoomObjects = new Label();
            labelRoomMain = new Label();
            toolTip1 = new ToolTip(components);
            panelRoomMain.SuspendLayout();
            panelRoomControl.SuspendLayout();
            panelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBehaviour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHorizontal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVertical).BeginInit();
            SuspendLayout();
            // 
            // panelRoomMain
            // 
            panelRoomMain.BorderStyle = BorderStyle.FixedSingle;
            panelRoomMain.Controls.Add(labelRoomGameobj);
            panelRoomMain.Controls.Add(listBoxRooms);
            panelRoomMain.Controls.Add(panelRoomControl);
            panelRoomMain.Controls.Add(labelRoomObjects);
            panelRoomMain.Location = new Point(3, 15);
            panelRoomMain.Name = "panelRoomMain";
            panelRoomMain.Size = new Size(921, 499);
            panelRoomMain.TabIndex = 0;
            // 
            // labelRoomGameobj
            // 
            labelRoomGameobj.AutoSize = true;
            labelRoomGameobj.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelRoomGameobj.Location = new Point(320, 5);
            labelRoomGameobj.Name = "labelRoomGameobj";
            labelRoomGameobj.Size = new Size(102, 17);
            labelRoomGameobj.TabIndex = 0;
            labelRoomGameobj.Text = "Objects in room";
            // 
            // listBoxRooms
            // 
            listBoxRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxRooms.FormattingEnabled = true;
            listBoxRooms.ItemHeight = 21;
            listBoxRooms.Location = new Point(13, 65);
            listBoxRooms.Name = "listBoxRooms";
            listBoxRooms.Size = new Size(251, 403);
            listBoxRooms.TabIndex = 3;
            listBoxRooms.SelectedIndexChanged += listBoxRooms_SelectedIndexChanged;
            // 
            // panelRoomControl
            // 
            panelRoomControl.BorderStyle = BorderStyle.FixedSingle;
            panelRoomControl.Controls.Add(labelAdress);
            panelRoomControl.Controls.Add(buttonObjectList);
            panelRoomControl.Controls.Add(listBoxRoomObjs);
            panelRoomControl.Controls.Add(panelProperties);
            panelRoomControl.Location = new Point(287, 13);
            panelRoomControl.Name = "panelRoomControl";
            panelRoomControl.Size = new Size(617, 465);
            panelRoomControl.TabIndex = 2;
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(12, 33);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(137, 15);
            labelAdress.TabIndex = 15;
            labelAdress.Text = "Object address in ROM : ";
            // 
            // buttonObjectList
            // 
            buttonObjectList.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonObjectList.Location = new Point(500, 427);
            buttonObjectList.Name = "buttonObjectList";
            buttonObjectList.Size = new Size(112, 27);
            buttonObjectList.TabIndex = 14;
            buttonObjectList.Text = "Open object list";
            buttonObjectList.UseVisualStyleBackColor = true;
            buttonObjectList.Click += buttonObjectList_Click;
            // 
            // listBoxRoomObjs
            // 
            listBoxRoomObjs.FormattingEnabled = true;
            listBoxRoomObjs.ItemHeight = 15;
            listBoxRoomObjs.Location = new Point(12, 51);
            listBoxRoomObjs.Name = "listBoxRoomObjs";
            listBoxRoomObjs.Size = new Size(348, 394);
            listBoxRoomObjs.TabIndex = 13;
            listBoxRoomObjs.SelectedIndexChanged += listBoxRoomObjs_SelectedIndexChanged;
            // 
            // panelProperties
            // 
            panelProperties.BorderStyle = BorderStyle.FixedSingle;
            panelProperties.Controls.Add(numericUpDownSpeed);
            panelProperties.Controls.Add(labelSpeed);
            panelProperties.Controls.Add(label1);
            panelProperties.Controls.Add(numericUpDownBehaviour);
            panelProperties.Controls.Add(numericUpDownHorizontal);
            panelProperties.Controls.Add(labelBehaviour);
            panelProperties.Controls.Add(labelHorizontal);
            panelProperties.Controls.Add(numericUpDownid);
            panelProperties.Controls.Add(numericUpDownVertical);
            panelProperties.Controls.Add(labelObjid);
            panelProperties.Location = new Point(378, 51);
            panelProperties.Name = "panelProperties";
            panelProperties.Size = new Size(127, 358);
            panelProperties.TabIndex = 12;
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(12, 324);
            numericUpDownSpeed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.RightToLeft = RightToLeft.No;
            numericUpDownSpeed.Size = new Size(86, 23);
            numericUpDownSpeed.TabIndex = 13;
            toolTip1.SetToolTip(numericUpDownSpeed, "Appears to make Gordos really fast when\r\nput at a high value but makes basically\r\neverything else stop moving by putting\r\nit to something else than 0.\r\nNeeds more info to specify exact use.");
            numericUpDownSpeed.ValueChanged += numericUpDownSpeed_ValueChanged;
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(12, 306);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(44, 15);
            labelSpeed.TabIndex = 12;
            labelSpeed.Text = "Speed?";
            toolTip1.SetToolTip(labelSpeed, "Appears to make Gordos really fast when\r\nput at a high value but makes basically\r\neverything else stop moving by putting\r\nit to something else than 0.\r\nNeeds more info to specify exact use.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 6;
            label1.Text = "Vertical position";
            toolTip1.SetToolTip(label1, "The position of the object on the Y axis.\r\nThe lower it is, the higher it will be.");
            // 
            // numericUpDownBehaviour
            // 
            numericUpDownBehaviour.Location = new Point(12, 246);
            numericUpDownBehaviour.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBehaviour.Name = "numericUpDownBehaviour";
            numericUpDownBehaviour.RightToLeft = RightToLeft.No;
            numericUpDownBehaviour.Size = new Size(86, 23);
            numericUpDownBehaviour.TabIndex = 11;
            toolTip1.SetToolTip(numericUpDownBehaviour, "Decides how the object should act.\r\nExact use varies depending on the object.");
            numericUpDownBehaviour.ValueChanged += numericUpDownBehaviour_ValueChanged;
            // 
            // numericUpDownHorizontal
            // 
            numericUpDownHorizontal.Location = new Point(12, 29);
            numericUpDownHorizontal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownHorizontal.Name = "numericUpDownHorizontal";
            numericUpDownHorizontal.RightToLeft = RightToLeft.No;
            numericUpDownHorizontal.Size = new Size(86, 23);
            numericUpDownHorizontal.TabIndex = 4;
            toolTip1.SetToolTip(numericUpDownHorizontal, "The position of the object on the X axis.\r\nThe lower it is, the further to the left\r\nit will be.");
            numericUpDownHorizontal.ValueChanged += numericUpDownHorizontal_ValueChanged;
            // 
            // labelBehaviour
            // 
            labelBehaviour.AutoSize = true;
            labelBehaviour.Location = new Point(12, 228);
            labelBehaviour.Name = "labelBehaviour";
            labelBehaviour.Size = new Size(60, 15);
            labelBehaviour.TabIndex = 10;
            labelBehaviour.Text = "Behaviour";
            toolTip1.SetToolTip(labelBehaviour, "Decides how the object should act.\r\nExact use varies depending on the object.");
            // 
            // labelHorizontal
            // 
            labelHorizontal.AutoSize = true;
            labelHorizontal.Location = new Point(12, 11);
            labelHorizontal.Name = "labelHorizontal";
            labelHorizontal.Size = new Size(108, 15);
            labelHorizontal.TabIndex = 5;
            labelHorizontal.Text = "Horizontal position";
            toolTip1.SetToolTip(labelHorizontal, "The position of the object on the X axis.\r\nThe lower it is, the further to the left\r\nit will be.");
            // 
            // numericUpDownid
            // 
            numericUpDownid.Location = new Point(12, 170);
            numericUpDownid.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownid.Name = "numericUpDownid";
            numericUpDownid.RightToLeft = RightToLeft.No;
            numericUpDownid.Size = new Size(86, 23);
            numericUpDownid.TabIndex = 9;
            toolTip1.SetToolTip(numericUpDownid, "Represents what object should spawn.\r\nYou can see a full list of objects by\r\nclicking the \"Open object list\" button.");
            numericUpDownid.ValueChanged += numericUpDownid_ValueChanged;
            // 
            // numericUpDownVertical
            // 
            numericUpDownVertical.Location = new Point(12, 99);
            numericUpDownVertical.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownVertical.Name = "numericUpDownVertical";
            numericUpDownVertical.RightToLeft = RightToLeft.No;
            numericUpDownVertical.Size = new Size(86, 23);
            numericUpDownVertical.TabIndex = 7;
            toolTip1.SetToolTip(numericUpDownVertical, "The position of the object on the Y axis.\r\nThe lower it is, the higher it will be.");
            numericUpDownVertical.ValueChanged += numericUpDownVertical_ValueChanged;
            // 
            // labelObjid
            // 
            labelObjid.AutoSize = true;
            labelObjid.Location = new Point(12, 152);
            labelObjid.Name = "labelObjid";
            labelObjid.Size = new Size(56, 15);
            labelObjid.TabIndex = 8;
            labelObjid.Text = "Object ID";
            toolTip1.SetToolTip(labelObjid, "Represents what object should spawn.\r\nYou can see a full list of objects by\r\nclicking the \"Open object list\" button.");
            // 
            // labelRoomObjects
            // 
            labelRoomObjects.AutoSize = true;
            labelRoomObjects.Location = new Point(87, 47);
            labelRoomObjects.Name = "labelRoomObjects";
            labelRoomObjects.Size = new Size(82, 15);
            labelRoomObjects.TabIndex = 1;
            labelRoomObjects.Text = "Room Objects";
            // 
            // labelRoomMain
            // 
            labelRoomMain.AutoSize = true;
            labelRoomMain.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelRoomMain.Location = new Point(28, 6);
            labelRoomMain.Name = "labelRoomMain";
            labelRoomMain.Size = new Size(82, 17);
            labelRoomMain.TabIndex = 1;
            labelRoomMain.Text = "Room Editor";
            // 
            // RoomEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelRoomMain);
            Controls.Add(panelRoomMain);
            Name = "RoomEditor";
            Size = new Size(927, 517);
            Load += RoomEditor_Load;
            panelRoomMain.ResumeLayout(false);
            panelRoomMain.PerformLayout();
            panelRoomControl.ResumeLayout(false);
            panelRoomControl.PerformLayout();
            panelProperties.ResumeLayout(false);
            panelProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBehaviour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHorizontal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVertical).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRoomMain;
        private Label labelRoomMain;
        private Label labelRoomObjects;
        private Panel panelRoomControl;
        private Label labelRoomGameobj;
        private Label labelHorizontal;
        private NumericUpDown numericUpDownHorizontal;
        private NumericUpDown numericUpDownid;
        private Label labelObjid;
        private NumericUpDown numericUpDownVertical;
        private Label label1;
        private NumericUpDown numericUpDownBehaviour;
        private Label labelBehaviour;
        private Panel panelProperties;
        private ListBox listBoxRooms;
        private ListBox listBoxRoomObjs;
        private Button buttonObjectList;
        private Label labelAdress;
        private NumericUpDown numericUpDownSpeed;
        private Label labelSpeed;
        private ToolTip toolTip1;
    }
}
