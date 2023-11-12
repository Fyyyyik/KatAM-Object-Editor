namespace KatAM_Object_Editor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InitializeConfig();
            Application.Run(new MainForm());
        }

        static void InitializeConfig()
        {
            if (File.Exists(@$"{AppDomain.CurrentDomain.BaseDirectory}\config.ini") == false)
            {
                // Create new config.ini and give the default values
                ConfigIniFile config = new ConfigIniFile($@"{AppDomain.CurrentDomain.BaseDirectory}\config.ini");

                config.WriteValue("Misc", "UseHex", "false");
                config.WriteValue("Params", "ShowAdresses", "false");
            }
        }
    }
}