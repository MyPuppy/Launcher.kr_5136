using KartRider.Common.Utilities;
using KartRider.IO;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KartRider
{
	internal static class Program
	{
		public static Launcher LauncherDlg;
		public static GetKart GetKartDlg;
		public static Options OptionsDlg;
		public static int MAX_EQP_P;
		public static bool UseKartTune;
		public static bool UseKartPlant;
		public static bool UseKartLevel;
		public static bool UseKartParts;
		public static bool SpeedPatch;
		public static bool FavoriteItem;
		public static bool PreventItem;
		public static bool Developer_Name;
		public static ushort Version;
		public static string DataTime;

		static Program()
		{
			Program.MAX_EQP_P = 32;
			Program.Developer_Name = true;
			Program.Version = 5136;
			Program.DataTime = "D6 AF 00 00"; //"C1 AF 00 00" 2023-03-10) //"D6 AF 00 00" 2023-03-31)
		}

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Launcher StartLauncher = new Launcher();
			Program.LauncherDlg = StartLauncher;
			Application.Run(StartLauncher);
		}
	}
}