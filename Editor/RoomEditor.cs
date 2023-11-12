using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KatAM_Object_Editor.Editor;
using System.Diagnostics;
using System.Security.Cryptography;

namespace KatAM_Object_Editor
{
    public partial class RoomEditor : UserControl
    {
        bool isUpdate = false;
        bool isSelectIndexChanged;

        public List<long> roomOffsets = new List<long>();
        public List<long> objOffsetsOfRoom = new List<long>();

        MainForm mainFormInstance;

        public RoomEditor(MainForm mainForm)
        {
            InitializeComponent();

            mainFormInstance = mainForm;
        }

        private void RoomEditor_Load(object sender, EventArgs e)
        {
            LevelDataManager levelDataManager = new LevelDataManager();
            List<object> rooms = new List<object>(levelDataManager.GetRooms(mainFormInstance, this));
            listBoxRooms.Items.Clear();
            foreach (object room in rooms)
            {
                listBoxRooms.Items.Add(room);
            }

            labelAdress.Text = "";
        }

        private void comboBoxRoomSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAdress.Text = "";

            List<object> objs = new List<object>();

            LevelDataManager levelDataManager = new LevelDataManager();
            objs = new List<object>(levelDataManager.GetRoomObjects(mainFormInstance, roomOffsets[listBoxRooms.SelectedIndices[0]], this));
            listBoxRoomObjs.Items.Clear();
            foreach (object obj in objs)
            {
                listBoxRoomObjs.Items.Add(obj);
            }

            UpdateObjects();
        }

        private void listBoxRoomObjs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigIniFile config = new ConfigIniFile($@"{AppDomain.CurrentDomain.BaseDirectory}\config.ini");
            if (config.ReadValue("Params", "ShowAdresses") == "true")
            {
                labelAdress.Text = $"Object adress in ROM : {objOffsetsOfRoom[listBoxRoomObjs.SelectedIndices[0]].ToString("X")}";
            }

            if (isUpdate)
            {
                isUpdate = false;
                return;
            }

            List<int> properties = new List<int>();

            foreach (List<long> parameters in mainFormInstance.changedLevels)
            {
                if (parameters[0] == objOffsetsOfRoom[listBoxRoomObjs.SelectedIndices[0]])
                {
                    List<long> noAdress = new List<long>(parameters);
                    noAdress.RemoveAt(0);
                    foreach (long value in noAdress)
                    {
                        properties.Add(mainFormInstance.ManualCastLongToInt(value));
                    }
                    DisplayProperties(properties);
                    return;
                }
            }

            LevelDataManager levelDataManager = new LevelDataManager();
            properties = new List<int>(levelDataManager.GetObjectProperties(mainFormInstance, objOffsetsOfRoom[listBoxRoomObjs.SelectedIndices[0]]));
            DisplayProperties(properties);
        }

        private void numericUpDownHorizontal_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        private void numericUpDownVertical_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        private void numericUpDownid_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        private void numericUpDownBehaviour_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        void WriteValueToSavedList()
        {
            Debug.WriteLine("WriteValueToSavedList : started");
            if (isUpdate)
            {
                isUpdate = false;
                return;
            }

            UpdateObjects();
            foreach (List<long> parameters in mainFormInstance.changedLevels)
            {
                if (parameters[0] == objOffsetsOfRoom[listBoxRoomObjs.SelectedIndices[0]])
                {
                    parameters[1] = (long)numericUpDownHorizontal.Value;
                    parameters[2] = (long)numericUpDownVertical.Value;
                    parameters[3] = (long)numericUpDownid.Value;
                    parameters[4] = (long)numericUpDownBehaviour.Value;
                    return;
                }
            }
            mainFormInstance.changedLevels.Add(new List<long> { objOffsetsOfRoom[listBoxRoomObjs.SelectedIndices[0]], (long)numericUpDownHorizontal.Value, (long)numericUpDownVertical.Value, (long)numericUpDownid.Value, (long)numericUpDownBehaviour.Value });
        }

        void UpdateObjects()
        {
            return;


            LevelDataManager levelDataManager = new LevelDataManager();
            List<int> objIds = new List<int>();
            for (int i = 0; i < listBoxRoomObjs.Items.Count; i++)
            {
                List<int> properties = new List<int>(levelDataManager.GetObjectProperties(mainFormInstance, objOffsetsOfRoom[i]));
                objIds.Add(properties[2]);
            }

            isUpdate = true;
            for (int i = 0; i < listBoxRoomObjs.Items.Count; i++)
            {
                //listBoxRoomObjs.Items[i] = listItems[objIds[i]];
            }
        }

        void DisplayProperties(List<int> properties)
        {
            isSelectIndexChanged = true;
            // X position
            try
            {
                numericUpDownHorizontal.Value = properties[0];
            }
            catch
            {
                MessageBox.Show("The value for the X position has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Y position
            try
            {
                numericUpDownVertical.Value = properties[1];
            }
            catch
            {
                MessageBox.Show("The value for the Y position has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Object ID
            try
            {
                numericUpDownid.Value = properties[2];
            }
            catch
            {
                MessageBox.Show("The value for the object ID has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Behaviour
            try
            {
                numericUpDownBehaviour.Value = properties[3];
            }
            catch
            {
                MessageBox.Show("The value for the behaviour has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonObjectList_Click(object sender, EventArgs e)
        {
            ObjectListRef form = new ObjectListRef(mainFormInstance);
            form.Show();
        }
    }
}
