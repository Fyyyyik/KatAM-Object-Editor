using KatAM_Object_Editor.Editor;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace KatAM_Object_Editor
{
    public partial class MainForm : Form
    {
        public bool showAdresses;
        public bool useHex;

        public string openedFilePath;
        public string openedFileVersion;

        public string openedFilePathC;
        public string openedFileVersionC;

        public string iniFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\config.ini";

        public List<List<int>> changedParams = new List<List<int>>();
        public List<List<long>> changedLevels = new List<List<long>>();

        public List<string> listItems = new List<string>
        {
                "Waddle Dee (0)",
                "Bronto Burt (1)",
                "Blipper (2)",
                "Glunk (3)",
                "Squishy (4)",
                "Scarfy Normal (5)",
                "Gordo (6)",
                "Snooter Normal (7)",
                "Chip (8)",
                "Soarar (9)",
                "Haley (10)",
                "Roly-Poly (11)",
                "Cupie (12)",
                "Blockin (13)",
                "Snooter Angered (14)",
                "Leap (15)",
                "Jack (16)",
                "Big Waddle Dee (17)",
                "Waddle Doo (18)",
                "Flamer (19)",
                "Hot Head (20)",
                "Laser Ball (21)",
                "Pengy (22)",
                "Rocky (23)",
                "Sir Kibble (24)",
                "Sparky (25)",
                "Sword Knight (26)",
                "UFO (27)",
                "Twister (28)",
                "Wheelie (29)",
                "Noddy (30)",
                "Golem Press (31)",
                "Golem Alt Roll (32)",
                "Golem Punch (33)",
                "Foley Normal (34)",
                "Shooty (35)",
                "Scarfy Angered (36)",
                "Boxin (37)",
                "Cookin (38)",
                "Minny (39)",
                "Bomber (40)",
                "Heavy Knight (41)",
                "Giant Rocky (42)",
                "Metal Guardian (43)",
                "Stoppy [Unused, won't load] (44)",
                "Batty (45)",
                "Foley Falling (46)",
                "Bang-Bang (47)",
                "Crash Ball (48)",
                "??? (49)",
                "Droppy (50)",
                "Prank (51)",
                "Mirra (52)",
                "Shotzo (53)",
                "Shadow Kirby (54)",
                "Arena Waddle Dee (55)",
                "Mr. Frosty (56)",
                "Bonkers (57)",
                "Phan Phan (58)",
                "Batafire (59)",
                "Box Boxer (60)",
                "Boxy (61)",
                "Master Hand [Mid-Boss] (62)",
                "Bombar (63)",
                "??? (64)",
                "??? (65)",
                "??? (66)",
                "??? (67)",
                "??? (68)",
                "Kracko (69)",
                "King Golem (70)",
                "Master Hand [Boss] (71)",
                "Gobbler (72)",
                "Wiz (73)",
                "Moley (74)",
                "Mega Titan (75)",
                "Titan Head (76)",
                "Crazy Hand (77)",
                "Dark Meta Knight [Final Encounter] (78)",
                "Dark Mind [1] (79)",
                "Dark Mind [2] (80)",
                "Dark Mind [Shooting Segment] (81)",
                "Dark Meta Knight [Radish Ruins] (82)",
                "Nothing (83)",
                "Nothing (84)",
                "Nothing (85)",
                "Nothing (86)",
                "Nothing (87)",
                "Nothing (88)",
                "Nothing (89)",
                "Nothing (90)",
                "Nothing (91)",
                "Nothing (92)",
                "Nothing (93)",
                "Cherry (94)",
                "Energy Drink (95)",
                "Meat (96)",
                "Maxim Tomato (97)",
                "Battery (98)",
                "1UP (99)",
                "Invicibility Candy (100)",
                "Mirror Shard (101)",
                "Nothing (102)",
                "Nothing (103)",
                "Nothing (104)",
                "Nothing (105)",
                "Nothing (106)",
                "Nothing (107)",
                "Nothing (108)",
                "Small Button (109)",
                "Small Flame (110)",
                "Mirror Door (111)",
                "Unused Shotzo Variant (112)",
                "Sliding Pillar (113)",
                "Boss Endurance Mirror (114)",
                "??? (115)",
                "??? (116)",
                "??? (117)",
                "??? (118)",
                "Camera Locker Object (119)",
                "Fuse (120)",
                "Small Heave-Ho block (121)",
                "??? (122)",
                "Star Platform (123)",
                "Wall flame (124)",
                "Big Heave-Ho block (125)",
                "Duplicate of 125 (126)",
                "CPU mover (127)",
                "Small treasure chest (128)",
                "Big treasure chest (129)",
                "??? (130)",
                "??? (131)",
                "Warp Star (132)",
                "Warp Star [Goal Game] (133)",
                "Big Switch (134)",
                "??? (135)",
                "Duplicate of 125 (136)",
                "Duplicate of 125 (137)",
                "Fuse Cannon (138)",
                "Manual Direction Cannon (139)",
                "Mirror Door [HUB] (140)",
                "Stake (141)",
                "Cutscene loader (142)",
                "Galaxia in pedestal [can't be collected] (143)",
                "Air current effect (144)",
                "??? (145)",
                "Copy Essences (146)",
                "Copy Essences (147)",
                "Copy Essences (148)",
                "Copy Essences (149)",
                "Random Copy Essence (150)",
                "Freezes the game (151)",
                "Galaxia in pedestal [collectable] (152)",
                "??? (153)",
                "Resets the game (154)",
                "King Golem's rock (155)",
                "King Golem's Gordo (156)",
                "Foley's propeller leaves (157)",
                "Frying pan (158)",
                "Pacriel (159)",
                "Sir Kibble's cutter projectile (160)",
                "??? (161)",
                "Parasol enemy (162)",
                "Ability Star (163)",
                "Master Sword Ability Star (164)",
                "Impact Star (165)",
                "Mr. Frosty's ice cube",
                "Mr. Frosty's big ice cube (167)",
                "Bonker's coconut (168)",
                "Bonker's big coconut (169)",
                "Phan Phan's apple (170)",
                "Prank's fireball (171)",
                "Prank's ice cube (172)",
                "Prank's bomb (173)",
                "Prank's frying pan (174)",
                "Banana peel (175)",
                "Boxy's present box (176)",
                "Exhaled star (177)",
                "Bombar's bomb (178)",
                "Bombar's missile (179)",
                "Box Boxer's hadouken (180)",
                "Wiz' rugby ball (181)",
                "Wiz' mini-car (182)",
                "Wiz' balloon (183)",
                "Wiz' bomb (184)",
                "Wiz' cloud (185)",
                "Poisonous apple (186)",
                "Wiz' Droppy variant (187)",
                "Mega Titan arm 1 (188)",
                "Mega Titan arm 2 (189)",
                "Mega Titan arm 3 (190)",
                "Mega Titan arm 4 (191)",
                "Titan Head's missile (192)",
                "Moley's boulder (193)",
                "Moley's screw (194)",
                "Moley's tire (195)",
                "Moley's big bomb (196)",
                "Moley's massive boulder (197)",
                "Moley's oil barrel (198)",
                "Moley's spike ball (199)",
                "Master Hand's fire bullet (200)",
                "Small bomb (201)",
                "??? (202)",
                "Dark Mind's red star projectile (203)",
                "Dark Mind's blue star projectile (204)",
                "Dark Mind's purple star projectile (205)",
                "Dark Mind's green star projectile (206)",
                "??? (207)",
                "??? (208)",
                "??? (209)",
                "Dark Mind's laser (210)",
                "Dark Mind's shooter cutter (211)",
                "Crashes the game (212)",
                "Cutter projectile (213)",
                "Glunk's bullet (214)",
                "Shotzo's bullet (215)",
                "Cupie's arrow (216)",
                "??? (217)",
                "Shooty's bomb (218)",
                "Resets the game (219)"
        };

        public MainForm()
        {
            InitializeComponent();

            this.CenterToScreen();
            openedFilePath = "";
            openedFileVersion = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = false;

            ConfigIniFile config = new ConfigIniFile(iniFilePath);
            if (config.ReadValue("Misc", "UseHex") == "false")
            {
                useHexToolStripMenuItem.Checked = false;
                useHex = false;
            }
            else
            {
                useHexToolStripMenuItem.Checked = true;
                useHex = true;
            }

            if (config.ReadValue("Params", "ShowAdresses") == "false")
            {
                showAddressesToolStripMenuItem.Checked = false;
                showAdresses = false;
            }
            else
            {
                showAddressesToolStripMenuItem.Checked = true;
                showAdresses = true;
            }
        }

        private void btn_objectedit_Click(object sender, EventArgs e)
        {
            if (openedFilePath == "")
            {
                MessageBox.Show("Please open a KatAM ROM first.", "Why so fast?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (openedFileVersion == "")
            {
                MessageBox.Show("The version of the ROM has not been specified! Try reopening it.", "An unusual error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ObjectParam objParamCtrl = new ObjectParam(this);

            panel_main.Controls.Clear();
            panel_main.Controls.Add(objParamCtrl);
        }

        private void btn_roomedit_Click(object sender, EventArgs e)
        {
            if (openedFilePath == "")
            {
                MessageBox.Show("Please open a KatAM ROM first.", "Why so fast?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (openedFileVersion == "")
            {
                MessageBox.Show("The version of the ROM has not been specified! Try reopening it.", "An unusual error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RoomEditor roomEditCtrl = new RoomEditor(this);

            panel_main.Controls.Clear();
            panel_main.Controls.Add(roomEditCtrl);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openedFilePathC = openedFilePath;
            openedFileVersionC = openedFileVersion;

            using (FileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    openedFilePath = dialog.FileName;

                    VersionSelect versionSelect = new VersionSelect(this);
                    versionSelect.ShowDialog();
                }
            }

            saveToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Make sure you backuped up your ROM! Saving will PERMANENTLY change certain bytes.", "Careful!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Cancel)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            string normalTitle = this.Text;
            this.Text = $"{normalTitle} - Saving {openedFilePath}";

            LevelDataManager levelDataManager = new LevelDataManager();
            foreach (List<int> paramList in changedParams)
            {
                levelDataManager.SaveParam(paramList, this);
            }
            foreach (List<long> levelParams in changedLevels)
            {
                List<long> levelParamsWithNoAdress = new List<long>(levelParams);
                levelParamsWithNoAdress.RemoveAt(0);
                List<int> properties = new List<int>();
                foreach (long levelParam in levelParamsWithNoAdress)
                {
                    properties.Add(ManualCastLongToInt(levelParam));
                }
                levelDataManager.SaveObject(this, levelParams[0], properties);
            }

            Cursor = Cursors.Default;
            this.Text = normalTitle;
        }

        private void showAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigIniFile config = new ConfigIniFile(iniFilePath);

            if (showAdresses)
            {
                showAddressesToolStripMenuItem.Checked = false;
                showAdresses = false;
                config.WriteValue("Params", "ShowAdresses", "false");
            }
            else
            {
                showAddressesToolStripMenuItem.Checked = true;
                showAdresses = true;
                config.WriteValue("Params", "ShowAdresses", "true");
            }
        }

        private void useHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigIniFile config = new ConfigIniFile(iniFilePath);

            if (useHex)
            {
                useHexToolStripMenuItem.Checked = false;
                useHex = false;
                config.WriteValue("Misc", "UseHex", "false");
            }
            else
            {
                useHexToolStripMenuItem.Checked = true;
                useHex = true;
                config.WriteValue("Misc", "UseHex", "true");
            }
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("This will open the url https://docs.google.com/document/d/1Qq5E7htD9IR6VcgRAJH2OfcGSzoqnm_t8gRmuONw8TU/edit?usp=sharing in your default web browser. Do you want to proceed?", "Vyroz is really cool!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirm == DialogResult.No)
            {
                return;
            }

            string vyrozIsVeryCool = "https://docs.google.com/document/d/1Qq5E7htD9IR6VcgRAJH2OfcGSzoqnm_t8gRmuONw8TU/edit?usp=sharing";
            OpenUrl(vyrozIsVeryCool);
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        public int ManualCastLongToInt(long value)
        {
            int newValue = 0;
            while (newValue < value)
            {
                newValue++;
            }
            return newValue;
        }
    }

    public class ConfigIniFile
    {
        string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

        public ConfigIniFile(string INIPath)
        {
            path = INIPath;
        }

        public void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }

        public string ReadValue(string section, string key)
        {
            var retVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", retVal, 255, path);
            return retVal.ToString();
        }
    }
}