using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KartRider;

namespace Set_Data
{
    public static class config
    {
        public static byte FavoriteItem_Use = 1;
        public static byte PreventItem_Use = 0;
        public static byte SpeedPatch_Use = 0;

        public static void Load_FavoriteItem()
        {
            string Load_FavoriteItem = FileName.config_LoadFile + FileName.config_FavoriteItem + FileName.Extension;
            if (File.Exists(Load_FavoriteItem))
            {
                string textValue = System.IO.File.ReadAllText(Load_FavoriteItem);
                config.FavoriteItem_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_FavoriteItem, false))
                {
                    streamWriter.Write(config.FavoriteItem_Use);
                }
            }
            config.Check_FavoriteItem();
        }

        public static void Load_PreventItem()
        {
            string Load_PreventItem = FileName.config_LoadFile + FileName.config_PreventItem + FileName.Extension;
            if (File.Exists(Load_PreventItem))
            {
                string textValue = System.IO.File.ReadAllText(Load_PreventItem);
                config.PreventItem_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_PreventItem, false))
                {
                    streamWriter.Write(config.PreventItem_Use);
                }
            }
            config.Check_PreventItem();
        }

        public static void Load_SpeedPatch()
        {
            string Load_SpeedPatch = FileName.config_LoadFile + FileName.config_SpeedPatch + FileName.Extension;
            if (File.Exists(Load_SpeedPatch))
            {
                string textValue = System.IO.File.ReadAllText(Load_SpeedPatch);
                config.SpeedPatch_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_SpeedPatch, false))
                {
                    streamWriter.Write(config.SpeedPatch_Use);
                }
            }
            config.Check_SpeedPatch();
        }

        public static void Check_FavoriteItem()
        {
            if (config.FavoriteItem_Use == 0)
            {
                Program.FavoriteItem = false;
            }
            else
            {
                Program.FavoriteItem = true;
            }
        }

        public static void Check_PreventItem()
        {
            if (config.PreventItem_Use == 0)
            {
                Program.PreventItem = false;
            }
            else
            {
                Program.PreventItem = true;
            }
        }

        public static void Check_SpeedPatch()
        {
            if (config.SpeedPatch_Use == 0)
            {
                Program.SpeedPatch = false;
                Program.LauncherDlg.Text = "Launcher";
            }
            else
            {
                Program.SpeedPatch = true;
                Program.LauncherDlg.Text = "Launcher (속도 패치)";
            }
        }

        public static void Load_ALL()
        {
            config.Load_FavoriteItem();
            config.Load_PreventItem();
            config.Load_SpeedPatch();
        }
    }
}