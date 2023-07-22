using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using KartRider.IO;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace KartRider
{
    public partial class GetKart : Form
    {
        public static short Item_Type = 0;
        public static short Item_Code = 0;

        public GetKart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetKart.Item_Type = short.Parse(this.tx_ItemType.Text);
            GetKart.Item_Code = short.Parse(this.tx_ItemCode.Text);
            if (Launcher.OpenGetItem)
            {
                (new Thread(() =>
                {
                    button1.Enabled = false;
                    Thread.Sleep(300);
                    if (GetKart.Item_Type == 3)
                    {
                        if (GetKart.Item_Code <= 1095 || GetKart.Item_Code == 1098 || GetKart.Item_Code == 1099 || GetKart.Item_Code == 1100 || GetKart.Item_Code == 1101 || GetKart.Item_Code == 1102 || GetKart.Item_Code == 1103 || GetKart.Item_Code == 1104 || GetKart.Item_Code == 1105 || GetKart.Item_Code == 1137 ||
                            GetKart.Item_Code == 1193 || GetKart.Item_Code == 1194 || GetKart.Item_Code == 1195 || GetKart.Item_Code == 1198 || GetKart.Item_Code == 1199 || GetKart.Item_Code == 1205 || GetKart.Item_Code == 1206 || GetKart.Item_Code == 1207 || GetKart.Item_Code == 1208 || GetKart.Item_Code == 1210 ||
                            GetKart.Item_Code == 1212 || GetKart.Item_Code == 1215 || GetKart.Item_Code == 1216 || GetKart.Item_Code == 1221 || GetKart.Item_Code == 1222 || GetKart.Item_Code == 1225 || GetKart.Item_Code == 1226 || GetKart.Item_Code == 1229 || GetKart.Item_Code == 1230 || GetKart.Item_Code == 1234 ||
                            GetKart.Item_Code == 1237 || GetKart.Item_Code == 1238 || GetKart.Item_Code == 1239 || GetKart.Item_Code == 1247 || GetKart.Item_Code == 1251 || GetKart.Item_Code == 1252 || GetKart.Item_Code == 1257 || GetKart.Item_Code == 1260 || GetKart.Item_Code == 1261 || GetKart.Item_Code == 1263 ||
                            GetKart.Item_Code == 1264 || GetKart.Item_Code == 1265 || GetKart.Item_Code == 1266 || GetKart.Item_Code == 1267 || GetKart.Item_Code == 1268 || GetKart.Item_Code == 1270 || GetKart.Item_Code == 1271 || GetKart.Item_Code == 1274 || GetKart.Item_Code == 1275 || GetKart.Item_Code == 1288 ||
                            GetKart.Item_Code == 1289 || GetKart.Item_Code == 1297 || GetKart.Item_Code == 1298 || GetKart.Item_Code == 1302)
                        {
                            if (Launcher.KartOld_SN2 < 30000)
                            {
                                Launcher.KartOld_SN2++;
                                Console.WriteLine("KartOld_SN2: {0}", Launcher.KartOld_SN2);
                                using (OutPacket outPacket = new OutPacket("PrRequestKartInfoPacket"))
                                {
                                    outPacket.WriteByte(1);
                                    outPacket.WriteInt(1);
                                    outPacket.WriteShort(GetKart.Item_Type);
                                    outPacket.WriteShort(GetKart.Item_Code);
                                    outPacket.WriteShort(Launcher.KartOld_SN2);
                                    outPacket.WriteShort(1);//수량
                                    outPacket.WriteShort(0);
                                    outPacket.WriteShort(-1);
                                    outPacket.WriteShort(0);
                                    outPacket.WriteShort(0);
                                    outPacket.WriteShort(0);
                                    RouterListener.MySession.Client.Send(outPacket);
                                }
                            }
                            else
                            {
                                MessageBox.Show("생성할 수 있는 차량의 최대값을 초과했습니다.");
                            }
                        }
                        else if (Launcher.KartSN2 < 300)
                        {
                            Launcher.KartSN2++;
                            Console.WriteLine("KartSN2: {0}", Launcher.KartSN2);
                            using (OutPacket outPacket = new OutPacket("PrRequestKartInfoPacket"))
                            {
                                outPacket.WriteByte(1);
                                outPacket.WriteInt(1);
                                outPacket.WriteShort(GetKart.Item_Type);
                                outPacket.WriteShort(GetKart.Item_Code);
                                outPacket.WriteShort(Launcher.KartSN2);
                                outPacket.WriteShort(1);//수량
                                outPacket.WriteShort(0);
                                outPacket.WriteShort(-1);
                                outPacket.WriteShort(0);
                                outPacket.WriteShort(0);
                                outPacket.WriteShort(0);
                                RouterListener.MySession.Client.Send(outPacket);
                            }
                        }
                        else
                        {
                            MessageBox.Show("생성할 수 있는 차량의 최대값을 초과했습니다.");
                        }
                    }
                    else
                    {
                        using (OutPacket outPacket = new OutPacket("PrRequestKartInfoPacket"))
                        {
                            outPacket.WriteByte(1);
                            outPacket.WriteInt(1);
                            outPacket.WriteShort(GetKart.Item_Type);
                            outPacket.WriteShort(GetKart.Item_Code);
                            outPacket.WriteUShort(0);
                            outPacket.WriteShort(1);//수량
                            outPacket.WriteShort(0);
                            outPacket.WriteShort(-1);
                            outPacket.WriteShort(0);
                            outPacket.WriteShort(0);
                            outPacket.WriteShort(0);
                            RouterListener.MySession.Client.Send(outPacket);
                        }
                    }
                    Thread.Sleep(300);
                    button1.Enabled = true;
                })).Start();
            }
        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            this.tx_ItemType.Text = string.Concat(GetKart.Item_Type);
            this.tx_ItemCode.Text = string.Concat(GetKart.Item_Code);
        }

        private void tx_ItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))          
            {
                e.Handled = true;
            }
        }

        private void tx_ItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))         
            {
                e.Handled = true;
            }
        }
    }
}