using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Set_Data;

namespace KartRider
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void UseKartTune_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseKartTune_CheckBox.Checked == true)
            {
                Set_ETC.KartTune_Use = 1;
            }
            else if (UseKartTune_CheckBox.Checked == false)
            {
                Set_ETC.KartTune_Use = 0;
            }
            Set_ETC.Save_KartTune();
            Set_ETC.Check_KartTune();
        }

        private void UseKartPlant_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseKartPlant_CheckBox.Checked == true)
            {
                Set_ETC.KartPlant_Use = 1;
            }
            else if (UseKartPlant_CheckBox.Checked == false)
            {
                Set_ETC.KartPlant_Use = 0;
            }
            Set_ETC.Save_KartPlant();
            Set_ETC.Check_KartPlant();
        }

        private void UseKartLevel_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseKartLevel_CheckBox.Checked == true)
            {
                Set_ETC.KartLevel_Use = 1;
            }
            else if (UseKartLevel_CheckBox.Checked == false)
            {
                Set_ETC.KartLevel_Use = 0;
            }
            Set_ETC.Save_KartLevel();
            Set_ETC.Check_KartLevel();
        }

        private void UseKartParts_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseKartParts_CheckBox.Checked == true)
            {
                Set_ETC.KartParts_Use = 1;
            }
            else if (UseKartParts_CheckBox.Checked == false)
            {
                Set_ETC.KartParts_Use = 0;
            }
            Set_ETC.Save_KartParts();
            Set_ETC.Check_KartParts();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            Set_ETC.Load_ALL2();
        }
    }
}