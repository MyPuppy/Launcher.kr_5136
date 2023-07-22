using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartRider
{
    public static class LauncherSystem
    {
        public static void MessageBoxType1()
        {
            MessageBox.Show("카트라이더를 종료하고 다시 시도해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        public static void MessageBoxType2()
        {
            MessageBox.Show("카트라이더가 이미 실행되어 있습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        public static void MessageBoxType3()
        {
            MessageBox.Show(Launcher.KartRider + " 파일을 찾을 수 없습니다!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Environment.Exit(1);
        }
    }
}