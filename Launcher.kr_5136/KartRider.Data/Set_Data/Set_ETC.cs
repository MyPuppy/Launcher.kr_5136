using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KartRider;

namespace Set_Data
{
    public static class Set_ETC
    {
        public static byte KartTune_Use = 0;
        public static byte KartPlant_Use = 0;
        public static byte KartLevel_Use = 0;
        public static byte KartParts_Use = 0;
        public static bool UseKartTune = false;
        public static bool UseKartPlant = false;
        public static bool UseKartLevel = false;
        public static bool UseKartParts = false;

        public static void Load_KartTune()
        {
            string Load_KartTune = FileName.config_LoadFile + FileName.SetETC_KartTune + FileName.Extension;
            if (File.Exists(Load_KartTune))
            {
                string textValue = System.IO.File.ReadAllText(Load_KartTune);
                Set_ETC.KartTune_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_KartTune, false))
                {
                    streamWriter.Write(Set_ETC.KartTune_Use);
                }
            }
            Set_ETC.Check_KartTune();
        }

        public static void Load_KartTune2()
        {
            string Load_KartTune = FileName.config_LoadFile + FileName.SetETC_KartTune + FileName.Extension;
            if (File.Exists(Load_KartTune))
            {
                string textValue = System.IO.File.ReadAllText(Load_KartTune);
                Set_ETC.KartTune_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_KartTune, false))
                {
                    streamWriter.Write(Set_ETC.KartTune_Use);
                }
            }
            if (Set_ETC.KartTune_Use == 0)
            {
                Program.OptionsDlg.UseKartTune_CheckBox.Checked = false;
            }
            else
            {
                Program.OptionsDlg.UseKartTune_CheckBox.Checked = true;
            }
        }

        public static void Load_KartPlant()
        {
            string Load_KartPlant = FileName.config_LoadFile + FileName.SetETC_KartPlant + FileName.Extension;
            if (File.Exists(Load_KartPlant))
            {
                string textValue = System.IO.File.ReadAllText(Load_KartPlant);
                Set_ETC.KartPlant_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_KartPlant, false))
                {
                    streamWriter.Write(Set_ETC.KartPlant_Use);
                }
            }
            Set_ETC.Check_KartPlant();
        }

        public static void Load_KartPlant2()
        {
            string Load_KartPlant = FileName.config_LoadFile + FileName.SetETC_KartPlant + FileName.Extension;
            if (File.Exists(Load_KartPlant))
            {
                string textValue = System.IO.File.ReadAllText(Load_KartPlant);
                Set_ETC.KartPlant_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_KartPlant, false))
                {
                    streamWriter.Write(Set_ETC.KartPlant_Use);
                }
            }
            if (Set_ETC.KartPlant_Use == 0)
            {
                Program.OptionsDlg.UseKartPlant_CheckBox.Checked = false;
            }
            else
            {
                Program.OptionsDlg.UseKartPlant_CheckBox.Checked = true;
            }
        }

        public static void Load_KartLevel()
        {
            string Load_KartLevel = FileName.config_LoadFile + FileName.SetETC_KartLevel + FileName.Extension;
            if (File.Exists(Load_KartLevel))
            {
                string textValue = System.IO.File.ReadAllText(Load_KartLevel);
                Set_ETC.KartLevel_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_KartLevel, false))
                {
                    streamWriter.Write(Set_ETC.KartLevel_Use);
                }
            }
            Set_ETC.Check_KartLevel();
        }

        public static void Load_KartLevel2()
        {
            string Load_KartLevel = FileName.config_LoadFile + FileName.SetETC_KartLevel + FileName.Extension;
            if (File.Exists(Load_KartLevel))
            {
                string textValue = System.IO.File.ReadAllText(Load_KartLevel);
                Set_ETC.KartLevel_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_KartLevel, false))
                {
                    streamWriter.Write(Set_ETC.KartLevel_Use);
                }
            }
            if (Set_ETC.KartLevel_Use == 0)
            {
                Program.OptionsDlg.UseKartLevel_CheckBox.Checked = false;
            }
            else
            {
                Program.OptionsDlg.UseKartLevel_CheckBox.Checked = true;
            }
        }

        public static void Load_KartParts()
        {
            string Load_KartParts = FileName.config_LoadFile + FileName.SetETC_KartParts + FileName.Extension;
            if (File.Exists(Load_KartParts))
            {
                string textValue = System.IO.File.ReadAllText(Load_KartParts);
                Set_ETC.KartParts_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_KartParts, false))
                {
                    streamWriter.Write(Set_ETC.KartParts_Use);
                }
            }
            Set_ETC.Check_KartParts();
        }

        public static void Load_KartParts2()
        {
            string Load_KartParts = FileName.config_LoadFile + FileName.SetETC_KartParts + FileName.Extension;
            if (File.Exists(Load_KartParts))
            {
                string textValue = System.IO.File.ReadAllText(Load_KartParts);
                Set_ETC.KartParts_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_KartParts, false))
                {
                    streamWriter.Write(Set_ETC.KartParts_Use);
                }
            }
            if (Set_ETC.KartParts_Use == 0)
            {
                Program.OptionsDlg.UseKartParts_CheckBox.Checked = false;
            }
            else
            {
                Program.OptionsDlg.UseKartParts_CheckBox.Checked = true;
            }
        }

        public static void Save_KartTune()
        {
            string LoadFile = FileName.config_LoadFile + FileName.SetETC_KartTune + FileName.Extension;
            using (StreamWriter streamWriter = new StreamWriter(LoadFile, false))
            {
                streamWriter.Write(Set_ETC.KartTune_Use);
            }
        }

        public static void Save_KartPlant()
        {
            string LoadFile = FileName.config_LoadFile + FileName.SetETC_KartPlant + FileName.Extension;
            using (StreamWriter streamWriter = new StreamWriter(LoadFile, false))
            {
                streamWriter.Write(Set_ETC.KartPlant_Use);
            }
        }

        public static void Save_KartLevel()
        {
            string LoadFile = FileName.config_LoadFile + FileName.SetETC_KartLevel + FileName.Extension;
            using (StreamWriter streamWriter = new StreamWriter(LoadFile, false))
            {
                streamWriter.Write(Set_ETC.KartLevel_Use);
            }
        }

        public static void Save_KartParts()
        {
            string LoadFile = FileName.config_LoadFile + FileName.SetETC_KartParts + FileName.Extension;
            using (StreamWriter streamWriter = new StreamWriter(LoadFile, false))
            {
                streamWriter.Write(Set_ETC.KartParts_Use);
            }
        }

        public static void Check_KartTune()
        {
            if (Set_ETC.KartTune_Use == 0)
            {
                Set_ETC.UseKartTune = false;
            }
            else
            {
                Set_ETC.UseKartTune = true;
            }
        }

        public static void Check_KartPlant()
        {
            if (Set_ETC.KartPlant_Use == 0)
            {
                Set_ETC.UseKartPlant = false;
            }
            else
            {
                Set_ETC.UseKartPlant = true;
            }
        }

        public static void Check_KartLevel()
        {
            if (Set_ETC.KartLevel_Use == 0)
            {
                Set_ETC.UseKartLevel = false;
            }
            else
            {
                Set_ETC.UseKartLevel = true;
            }
        }

        public static void Check_KartParts()
        {
            if (Set_ETC.KartParts_Use == 0)
            {
                Set_ETC.UseKartParts = false;
            }
            else
            {
                Set_ETC.UseKartParts = true;
            }
        }

        public static void Load_ALL()
        {
            Set_ETC.Load_KartTune();
            Set_ETC.Load_KartPlant();
            Set_ETC.Load_KartLevel();
            Set_ETC.Load_KartParts();
        }

        public static void Load_ALL2()
        {
            Set_ETC.Load_KartTune2();
            Set_ETC.Load_KartPlant2();
            Set_ETC.Load_KartLevel2();
            Set_ETC.Load_KartParts2();
        }
    }
}