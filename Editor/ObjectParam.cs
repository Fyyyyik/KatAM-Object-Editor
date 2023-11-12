using KatAM_Object_Editor.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatAM_Object_Editor
{
    public partial class ObjectParam : UserControl
    {
        MainForm mainFormInstance;

        public ObjectParam(MainForm mainForm)
        {
            InitializeComponent();

            mainFormInstance = mainForm;
        }

        private void ObjectParam_Load(object sender, EventArgs e)
        {
            if (mainFormInstance != null)
            {
                labelAddress.Text = "";
            }
            else
            {
                labelAddress.Text = "ERROR, please restart the application.";
            }
        }

        private void listViewObjs_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Unused shit, too annoying to remove so just ignore it
            // LevelDataManager levelDataManager = new LevelDataManager();
            // levelDataManager.OpenParam(listViewObjs.SelectedIndices[0]);
        }

        private void listViewObjs_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> parameters = new List<int>();

            if (listViewObjs.SelectedItems.Count > 0)
            {
                foreach (List<int> savedParameters in mainFormInstance.changedParams)
                {
                    if (savedParameters[0] == listViewObjs.SelectedIndices[0])
                    {
                        parameters = new List<int>(savedParameters);
                        parameters.RemoveAt(0);
                        DisplayParams(parameters);
                        return;
                    }
                }

                LevelDataManager levelDataManager = new LevelDataManager();
                parameters = new List<int>(levelDataManager.OpenParam(listViewObjs.SelectedIndices[0], mainFormInstance));
                DisplayParams(parameters);
            }
        }

        private void numericUpDownDmg1_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        private void numericUpDownDmg2_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        private void numericUpDownHP_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        private void numericUpDownCopy_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        private void numericUpDownPalette_ValueChanged(object sender, EventArgs e)
        {
            WriteValueToSavedList();
        }

        void WriteValueToSavedList()
        {
            foreach (List<int> paramObj in mainFormInstance.changedParams)
            {
                if (paramObj[0] == listViewObjs.SelectedIndices[0])
                {
                    paramObj[1] = (int)numericUpDownDmg1.Value;
                    paramObj[2] = (int)numericUpDownDmg2.Value;
                    paramObj[3] = (int)numericUpDownHP.Value;
                    paramObj[4] = (int)numericUpDownCopy.Value;
                    paramObj[5] = (int)numericUpDownPalette.Value;
                    return;
                }
            }

            mainFormInstance.changedParams.Add(new List<int> { listViewObjs.SelectedIndices[0], (int)numericUpDownDmg1.Value, (int)numericUpDownDmg2.Value,
                (int)numericUpDownHP.Value, (int)numericUpDownCopy.Value, (int)numericUpDownPalette.Value });
        }

        void DisplayParams(List<int> parameters)
        {
            if (mainFormInstance.showAdresses)
            {
                LevelDataManager levelDataManager = new LevelDataManager();
                long address = levelDataManager.GetParamOffset(listViewObjs.SelectedIndices[0], mainFormInstance);
                labelAddress.Text = $"Object param's adress in ROM : {address.ToString("X")}";
            }

            // DMG1
            try
            {
                numericUpDownDmg1.Value = parameters[0];
            }
            catch
            {
                MessageBox.Show("The value for DMG1 has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // DMG2
            try
            {
                numericUpDownDmg2.Value = parameters[1];
            }
            catch
            {
                MessageBox.Show("The value for DMG2 has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // HP
            try
            {
                numericUpDownHP.Value = parameters[2];
            }
            catch
            {
                MessageBox.Show("The value for HP has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // COPY
            try
            {
                numericUpDownCopy.Value = parameters[3];
            }
            catch
            {
                MessageBox.Show("The value for COPY has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // PLT
            try
            {
                numericUpDownPalette.Value = parameters[4];
            }
            catch
            {
                MessageBox.Show("The value for PLT has not been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
