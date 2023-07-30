using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using KartRider;
using ExcData;
using Set_Data;

namespace RiderData
{
    public static class NewRider
    {
        public static short Value1 = 30000;
        public static short Value2 = 1;

        public static short Kart_V1_Cut = 0;
        public static short Kart_X_Cut = 0;
        public static short Kart_Old_Cut = 0;

        public static short MaxKart = 0;

        public static void LoadItemData()
        {
            NewRider.Kart();
            NewRider.Pet();
            NewRider.FlyingPet();
            NewRider.Character();
            NewRider.BonusCard();
            NewRider.HandGearL();
            NewRider.HeadBand();
            NewRider.Goggle();
            NewRider.Balloon();
            NewRider.Tachometer();
            NewRider.SlotItem();
            NewRider.MyRoom();
            NewRider.RenameRid();
            NewRider.ReplayTicket();
            NewRider.LucciBag();
            NewRider.Uniform();
            NewRider.Plate();
            NewRider.RidColor();
            NewRider.SkidMark();
            NewRider.Aura();
            NewRider.Dye();
            NewRider.Paint();
            NewRider.XUniquePartsData();
            NewRider.XLegendPartsData();
            NewRider.XRarePartsData();
            NewRider.XNormalPartsData();
            NewRider.V1UniquePartsData();
            NewRider.V1LegendPartsData();
            NewRider.V1RarePartsData();
            NewRider.V1NormalPartsData();
            NewRider.V1EffectData();
            NewRider.V1BoosterEffectData();
            KartExcData.Kart_ExcData();
            NewRider.NewRiderData();//라이더 인식
            Launcher.OpenGetItem = true;
        }

        public static void NewRiderData()
        {
            Console.WriteLine("LastKartSN: {0}", Launcher.LastKartSN);
            Console.WriteLine("KartSN2: {0}", Launcher.KartSN2);
            using (OutPacket oPacket = new OutPacket("PrGetRider"))
            {
                oPacket.WriteByte(1);
                oPacket.WriteByte(0);
                oPacket.WriteString(SetRider.Nickname);
                oPacket.WriteShort(0);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRider.Emblem1);
                oPacket.WriteShort(SetRider.Emblem2);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_Character);
                oPacket.WriteShort(SetRiderItem.Set_Paint);
                if (Launcher.KartOld_SN == SetRiderItem.Set_KartSN || Launcher.LastKartSN >= SetRiderItem.Set_KartSN)
                {
                    oPacket.WriteShort(SetRiderItem.Set_Kart);
                }
                else
                {
                    oPacket.WriteShort(0);
                }
                oPacket.WriteShort(SetRiderItem.Set_Plate);
                oPacket.WriteShort(SetRiderItem.Set_Goggle);
                oPacket.WriteShort(SetRiderItem.Set_Balloon);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_HeadBand);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_HandGearL);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_Uniform);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_Pet);
                oPacket.WriteShort(SetRiderItem.Set_FlyingPet);
                oPacket.WriteShort(SetRiderItem.Set_Aura);
                oPacket.WriteShort(SetRiderItem.Set_SkidMark);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_RidColor);
                oPacket.WriteShort(SetRiderItem.Set_BonusCard);
                oPacket.WriteShort(0);
                if (SetRiderItem.Set_KartSN == Launcher.KartOld_SN)
                {
                    if (Program.UseKartPlant)
                    {
                        oPacket.WriteShort(23);
                        oPacket.WriteShort(23);
                        oPacket.WriteShort(2);
                        oPacket.WriteShort(1);
                    }
                    else
                    {
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(0);
                    }
                }
                else
                {
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(0);
                }
                oPacket.WriteShort(0);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_Tachometer);
                oPacket.WriteShort(SetRiderItem.Set_Dye);
                if (SetRiderItem.Set_KartSN == Launcher.KartOld_SN)
                {
                    oPacket.WriteShort(Launcher.KartOld_SN);
                    if (Program.UseKartLevel)
                    {
                        if (SetRiderItem.Set_Kart <= 292 || SetRiderItem.Set_Kart == 358 || SetRiderItem.Set_Kart == 420 || SetRiderItem.Set_Kart == 464 || SetRiderItem.Set_Kart == 501 ||
                            SetRiderItem.Set_Kart == 837 || SetRiderItem.Set_Kart == 838 || SetRiderItem.Set_Kart == 843 || SetRiderItem.Set_Kart == 845 || SetRiderItem.Set_Kart == 847 ||
                            SetRiderItem.Set_Kart == 853 || SetRiderItem.Set_Kart == 856 || SetRiderItem.Set_Kart == 863 || SetRiderItem.Set_Kart == 873 || SetRiderItem.Set_Kart == 880 ||
                            SetRiderItem.Set_Kart == 1137 || SetRiderItem.Set_Kart == 1193 || SetRiderItem.Set_Kart == 1195 || SetRiderItem.Set_Kart == 1199 || SetRiderItem.Set_Kart == 1208 ||
                            SetRiderItem.Set_Kart == 1212 || SetRiderItem.Set_Kart == 1215 || SetRiderItem.Set_Kart == 1221 || SetRiderItem.Set_Kart == 1222 || SetRiderItem.Set_Kart == 1226 ||
                            SetRiderItem.Set_Kart == 1238 || SetRiderItem.Set_Kart == 1265 || SetRiderItem.Set_Kart == 1268 || SetRiderItem.Set_Kart == 1275 || SetRiderItem.Set_Kart == 1297)
                        {
                            oPacket.WriteShort(0);
                        }
                        else
                        {
                            oPacket.WriteShort(7);
                        }
                    }
                    else
                    {
                        oPacket.WriteShort(0);
                    }
                    oPacket.WriteShort(0);
                }
                else if (Launcher.LastKartSN >= SetRiderItem.Set_KartSN)
                {
                    oPacket.WriteShort(SetRiderItem.Set_KartSN);
                    if (Program.UseKartParts)
                    {
                        if (SetRiderItem.Set_Kart <= 1303 || SetRiderItem.Set_Kart == 1306 || SetRiderItem.Set_Kart == 1307 || SetRiderItem.Set_Kart == 1308 || SetRiderItem.Set_Kart == 1309 ||
                            SetRiderItem.Set_Kart == 1338 || SetRiderItem.Set_Kart == 1343 || SetRiderItem.Set_Kart == 1344 || SetRiderItem.Set_Kart == 1347 || SetRiderItem.Set_Kart == 1348 ||
                            SetRiderItem.Set_Kart == 1361 || SetRiderItem.Set_Kart == 1362)//X
                        {
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                        }
                        else
                        {
                            oPacket.WriteShort(1536);
                            oPacket.WriteShort(768);
                        }
                    }
                    else
                    {
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(0);
                    }
                }
                else
                {
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(0);
                }
                oPacket.WriteByte(0);
                oPacket.WriteString("");
                oPacket.WriteUInt(SetRider.Lucci);
                oPacket.WriteInt(SetRider.RP);
                for (int i = 0; i < 25; i++)
                {
                    oPacket.WriteInt(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void KartSN()
        {
            NewRider.Kart_V1_Cut = 87;
            NewRider.Kart_X_Cut = 109;
            NewRider.Kart_Old_Cut = 317;

            KartExcData.Tune_KartSN = 0;
            KartExcData.Plant_KartSN = 0;
            KartExcData.KartLevel_KartSN = 0;
            KartExcData.XParts_KartSN = 0;

            Launcher.KartSN = 0;
            Launcher.KartOld_SN = 301;
            Launcher.LastKartSN = 0;

            Launcher.KartSN2 = 0;
            Launcher.KartOld_SN2 = 1000;

            NewRider.MaxKart = 1454;
        }

        public static void Kart()
        {
            int All_Kart = NewRider.Kart_V1_Cut + NewRider.Kart_X_Cut + NewRider.Kart_Old_Cut;
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(All_Kart);
                //-----------------------------------------------------------------------------------------------------------------
                for (short i = 1; i <= NewRider.MaxKart; i++)
                {
                    if (i <= 25 || i == 27 || i == 29 || i == 45 || i == 54 || i == 59 ||
                        i == 63 || i == 70 || i == 82 || i == 95 || i == 101 || i == 103 || i == 111 || i == 114 || i == 117 || i == 210 || i == 219 || i == 220 || i == 232 || i == 265 || i == 285 ||
                        i == 292 || i == 302 || i == 311 || i == 326 || i == 357 || i == 358 || i == 361 || i == 371 || i == 378 || i == 382 || i == 420 || i == 429 || i == 433 || i == 436 || i == 437 ||
                        i == 439 || i == 453 || i == 458 || i == 459 || i == 464 || i == 473 || i == 481 || i == 484 || i == 501 || i == 510 || i == 517 || i == 531 || i == 543 || i == 550 || i == 559 ||
                        i == 564 || i == 566 || i == 574 || i == 596 || i == 597 || i == 602 || i == 604 || i == 606 || i == 608 || i == 611 || i == 619 || i == 620 || i == 624 || i == 627 || i == 630 ||
                        i == 633 || i == 636 || i == 639 || i == 643 || i == 644 || i == 647 || i == 650 || i == 666 || i == 671 || i == 681 || i == 684 || i == 700 || i == 701 || i == 702 || i == 703 ||
                        i == 704 || i == 706 || i == 707 || i == 719 || i == 720 || i == 737 || i == 738 || i == 739 || i == 788 || i == 750 || i == 751 || i == 757 || i == 764 || i == 787 || i == 794 ||
                        i == 795 || i == 796 || i == 797 || i == 800 || i == 801 || i == 805 || i == 806 || i == 808 || i == 811 || i == 813 || i == 824 || i == 827 || i == 828 || i == 829 || i == 830 ||
                        i == 832 || i == 833 || i == 835 || i == 837 || i == 838 || i == 839 || i == 840 || i == 841 || i == 843 || i == 844 || i == 845 || i == 846 || i == 847 || i == 849 || i == 850 ||
                        i == 851 || i == 852 || i == 853 || i == 854 || i == 855 || i == 856 || i == 857 || i == 858 || i == 859 || i == 861 || i == 863 || i == 864 || i == 865 || i == 866 || i == 867 ||
                        i == 868 || i == 869 || i == 872 || i == 873 || i == 874 || i == 875 || i == 877 || i == 878 || i == 879 || i == 880 || i == 882 || i == 883 || i == 884 || i == 885 || i == 887 ||
                        i == 888 || i == 889 || i == 890 || i == 891 || i == 894 || i == 896 || i == 900 || i == 901 || i == 902 || i == 905 || i == 906 || i == 907 || i == 914 || i == 915 || i == 916 ||
                        i == 917 || i == 918 || i == 919 || i == 921 || i == 922 || i == 927 || i == 930 || i == 931 || i == 932 || i == 935 || i == 937 || i == 939 || i == 940 || i == 941 || i == 942 ||
                        i == 943 || i == 944 || i == 946 || i == 947 || i == 948 || i == 949 || i == 950 || i == 951 || i == 953 || i == 954 || i == 955 || i == 956 || i == 961 || i == 962 || i == 963 ||
                        i == 967 || i == 971 || i == 977 || i == 998 || i == 999 || i == 1001 || i == 1003 || i == 1004 || i == 1005 || i == 1006 || i == 1007 || i == 1008 || i == 1009 || i == 1010 || i == 1013 ||
                        i == 1014 || i == 1015 || i == 1017 || i == 1019 || i == 1021 || i == 1022 || i == 1023 || i == 1024 || i == 1029 || i == 1031 || i == 1032 || i == 1033 || i == 1034 || i == 1035 || i == 1040 ||
                        i == 1041 || i == 1042 || i == 1043 || i == 1044 || i == 1045 || i == 1052 || i == 1054 || i == 1058 || i == 1059 || i == 1060 || i == 1061 || i == 1065 || i == 1066 || i == 1067 || i == 1068 ||
                        i == 1069 || i == 1071 || i == 1072 || i == 1074 || i == 1078 || i == 1079 || i == 1080 || i == 1082 || i == 1085 || i == 1086 || i == 1087 || i == 1089 || i == 1090 || i == 1091 || i == 1092 ||
                        i == 1094 || i == 1095 || i == 1098 || i == 1103 || i == 1137 || i == 1193 || i == 1195 || i == 1199 || i == 1206 || i == 1208 || i == 1212 || i == 1215 || i == 1221 || i == 1222 || i == 1225 ||
                        i == 1226 || i == 1229 || i == 1230 || i == 1234 || i == 1238 || i == 1239 || i == 1247 || i == 1251 || i == 1252 || i == 1261 || i == 1265 || i == 1268 || i == 1271 || i == 1275 || i == 1285 ||
                        i == 1297 || i == 1302 || //old

                        i == 1096 || i == 1097 || i == 1107 || i == 1108 || i == 1112 || i == 1114 || i == 1118 || i == 1119 || i == 1121 || i == 1122 || i == 1123 || i == 1124 || i == 1125 || i == 1126 || i == 1129 ||
                        i == 1131 || i == 1132 || i == 1133 || i == 1135 || i == 1136 || i == 1140 || i == 1144 || i == 1145 || i == 1148 || i == 1159 || i == 1160 || i == 1161 || i == 1163 || i == 1167 || i == 1168 ||
                        i == 1169 || i == 1170 || i == 1171 || i == 1173 || i == 1174 || i == 1175 || i == 1176 || i == 1178 || i == 1179 || i == 1180 || i == 1181 || i == 1182 || i == 1183 || i == 1187 || i == 1188 ||
                        i == 1191 || i == 1192 || i == 1196 || i == 1203 || i == 1204 || i == 1209 || i == 1213 || i == 1214 || i == 1217 || i == 1218 || i == 1219 || i == 1220 || i == 1223 || i == 1227 || i == 1233 ||
                        i == 1235 || i == 1236 || i == 1240 || i == 1241 || i == 1242 || i == 1243 || i == 1244 || i == 1245 || i == 1246 || i == 1248 || i == 1249 || i == 1253 || i == 1254 || i == 1255 || i == 1256 ||
                        i == 1259 || i == 1262 || i == 1269 || i == 1272 || i == 1273 || i == 1276 || i == 1277 || i == 1278 || i == 1279 || i == 1280 || i == 1281 || i == 1282 || i == 1283 || i == 1290 || i == 1291 ||
                        i == 1292 || i == 1293 || i == 1294 || i == 1296 || i == 1299 || i == 1300 || i == 1301 || i == 1303 || i == 1306 || i == 1307 || i == 1308 || i == 1309 || i == 1338 || i == 1343 || i == 1344 ||
                        i == 1347 || i == 1348 || i == 1361 || i == 1362 || //X

                        i == 1305 || i == 1310 || i == 1311 || i == 1336 || i == 1337 || i == 1339 || i == 1340 || i == 1341 || i == 1349 || i == 1350 || i == 1351 || i == 1352 || i == 1353 || i == 1354 || i == 1355 ||
                        i == 1356 || i == 1357 || i == 1359 || i == 1360 || i == 1364 || i == 1365 || i == 1369 || i == 1370 || i == 1371 || i == 1372 || i == 1373 || i == 1374 || i == 1376 || i == 1377 || i == 1378 ||
                        i == 1380 || i == 1381 || i == 1382 || i == 1383 || i == 1384 || i == 1385 || i == 1386 || i == 1387 || i == 1388 || i == 1389 || i == 1391 || i == 1392 || i == 1393 || i == 1394 || i == 1395 ||
                        i == 1396 || i == 1397 || i == 1398 || i == 1400 || i == 1401 || i == 1402 || i == 1403 || i == 1404 || i == 1406 || i == 1408 || i == 1409 || i == 1410 || i == 1411 || i == 1413 || i == 1415 ||
                        i == 1416 || i == 1417 || i == 1418 || i == 1419 || i == 1420 || i == 1421 || i == 1425 || i == 1427 || i == 1429 || i == 1430 || i == 1431 || i == 1433 || i == 1435 || i == 1438 || i == 1440 ||
                        i == 1441 || i == 1442 || i == 1443 || i == 1444 || i == 1445 || i == 1446 || i == 1447 || i == 1448 || i == 1449 || i == 1450 || i == 1451 || i == 1454) //V1
                    {
                        oPacket.WriteShort(3);
                        oPacket.WriteShort(i);
                        if (i <= 1095 || i == 1098 || i == 1103 || i == 1137 || i == 1193 || i == 1195 || i == 1199 || i == 1206 || i == 1208 || i == 1212 || i == 1215 || i == 1221 || i == 1222 || i == 1225 || i == 1226 ||
                            i == 1229 || i == 1230 || i == 1234 || i == 1238 || i == 1239 || i == 1247 || i == 1251 || i == 1252 || i == 1261 || i == 1265 || i == 1268 || i == 1271 || i == 1275 || i == 1285 || i == 1297 ||
                            i == 1302)
                        {
                            oPacket.WriteShort(Launcher.KartOld_SN);
                        }
                        else
                        {
                            Launcher.KartSN++;
                            Console.WriteLine("KartSN: {0}:{1}", i, Launcher.KartSN);
                            oPacket.WriteShort(Launcher.KartSN);
                        }
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
            Launcher.LastKartSN = Launcher.KartSN;
            Launcher.KartSN2 = Launcher.KartSN;
        }

        public static void Paint()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Paint = 96;
                oPacket.WriteInt(Paint - 25);
                for (short i = 1; i <= Paint; i++)
                {
                    if (i == 13 || i == 31 || i == 33 || i == 34 || i == 35 || i == 37 || i == 39 || i == 47 || i == 51 || i == 52 || 
                        i == 53 || i == 61 || i == 62 || i == 65 || i == 66 || i == 67 || i == 68 || i == 70 || i == 71 || i == 72 || 
                        i == 73 || i == 76 || i == 77 || i == 78 || i == 79)
                    {
                    }
                    else 
                    {
                        oPacket.WriteShort(2);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Dye()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Dye = 96;
                oPacket.WriteInt(Dye - 25);
                for (short i = 1; i <= Dye; i++)
                {
                    if (i == 13 || i == 31 || i == 33 || i == 34 || i == 35 || i == 37 || i == 39 || i == 47 || i == 51 || i == 52 ||
                        i == 53 || i == 61 || i == 62 || i == 65 || i == 66 || i == 67 || i == 68 || i == 70 || i == 71 || i == 72 ||
                        i == 73 || i == 76 || i == 77 || i == 78 || i == 79)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(70);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Character()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Character = 427;
                oPacket.WriteInt(Character - 43 - 44);
                for (short i = 1; i <= Character; i++)//Character
                {
                    if (i == 47 || i == 48 || i == 63 || i == 116 || i == 117 || i == 124 || i == 128 || i == 130 || i == 134 || i == 137 ||
                        i == 144 || i == 147 || i == 149 || i == 159 || i == 175 || i == 176 || i == 184 || i == 192 || i == 193 || i == 194 || 
                        i == 195 || i == 196 || i == 197 || i == 231 || i == 239 || i == 245 || i == 246 || i == 247 || i == 265 || i == 333 || 
                        i == 334 || i == 335 || i == 336 || i == 337 || i == 338 || i == 339 || i == 350 || i == 376 || i == 377 || i == 391 || 
                        i == 392 || i == 396 || i == 397 ||

                        i == 33 || i == 34 || i == 35 || i == 36 || i == 45 || i == 52 || i == 56 || i == 57 || i == 58 || i == 59 ||
                        i == 67 || i == 70 || i == 79 || i == 80 || i == 83 || i == 85 || i == 110 || i == 112 || i == 121 || i == 126 ||
                        i == 132 || i == 152 || i == 155 || i == 162 || i == 185 || i == 203 || i == 233 || i == 269 || i == 286 || i == 303 ||
                        i == 310 || i == 311 || i == 312 || i == 313 || i == 340 || i == 341 || i == 342 || i == 343 || i == 344 || i == 345 ||
                        i == 366 || i == 367 || i == 373 || i == 399)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(1);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Pet()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Pet = 172;
                oPacket.WriteInt(Pet + 6 - 18);
                for (short i = 30003; i <= 30008; i++)
                {
                    oPacket.WriteShort(21);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value2);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(0);
                }
                for (short i = 1; i <= Pet; i++)
                {
                    if (i == 8 || i == 10 || i == 11 || i == 14 || i == 18 || i == 50 || i == 77 || i == 85 || i == 91 || i == 92 || 
                        i == 105 || i == 107 || i == 120 || i == 136 || i == 156 || i == 158 || i == 159 || i == 162)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(21);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void FlyingPet()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int FlyingPet = 83;
                oPacket.WriteInt(FlyingPet - 8);
                for (short i = 1; i <= FlyingPet; i++)
                {
                    if (i == 20 || i == 21 || i == 22 || i == 23 || i == 24 || i == 52 || i == 55 || i == 70)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(52);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Uniform()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Uniform = 108;
                oPacket.WriteInt(Uniform - 62);
                for (short i = 1; i <= Uniform; i++)
                {
                    if (i == 15 || i == 18 || i == 20 || i == 21 || i == 23 || i == 26 || i == 31 || i == 32 || i == 33 || i == 34 ||
                        i == 40 || i == 41 || i == 42 || i == 43 || i == 44 || i == 45 || i == 46 || i == 47 || i == 48 || i == 49 ||
                        i == 51 || i == 52 || i == 53 || i == 54 || i == 55 || i == 56 || i == 57 || i == 58 || i == 59 || i == 61 ||
                        i == 62 || i == 63 || i == 64 || i == 65 || i == 66 || i == 67 || i == 68 || i == 69 || i == 70 || i == 71 ||
                        i == 73 || i == 74 || i == 75 || i == 76 || i == 77 || i == 78 || i == 79 || i == 80 || i == 81 || i == 84 ||
                        i == 87 || i == 88 || i == 89 || i == 94 || i == 95 || i == 96 || i == 97 || i == 99 || i == 100 || i == 101 ||
                        i == 102 || i == 108)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(18);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Aura()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Aura = 113;
                oPacket.WriteInt(Aura + 1 - 10);
                oPacket.WriteShort(26);
                oPacket.WriteShort(30000);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value2);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                oPacket.WriteByte(0);
                oPacket.WriteByte(0);
                oPacket.WriteShort(0);
                for (short i = 1; i <= Aura; i++)
                {
                    if (i == 28 || i == 33 || i == 35 || i == 53 || i == 54 || i == 58 || i == 59 || i == 76 || i == 78 || i == 89)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(26);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void SkidMark()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int SkidMark = 45;
                oPacket.WriteInt(SkidMark - 5);
                for (short i = 1; i <= SkidMark; i++)
                {
                    if (i == 14 || i == 20 || i == 21 || i == 24 || i == 30)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(27);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Plate()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Plate = 243;
                oPacket.WriteInt(Plate - 104);
                for (short i = 1; i <= Plate; i++)
                {
                    if (i == 57 || i == 66 || i == 67 || i == 68 || i == 75 || i == 78 || i == 80 || i == 81 || i == 88 || i == 92 ||
                        i == 97 || i == 98 || i == 99 || i == 100 || i == 105 || i == 110 || i == 111 || i == 116 || i == 120 || i == 121 ||
                        i == 122 || i == 123 || i == 124 || i == 125 || i == 126 || i == 127 || i == 128 || i == 129 || i == 130 || i == 131 ||
                        i == 133 || i == 134 || i == 139 || i == 140 || i == 141 || i == 143 || i == 146 || i == 147 || i == 148 || i == 149 ||
                        i == 150 || i == 152 || i == 153 || i == 154 || i == 155 || i == 156 || i == 157 || i == 158 || i == 159 || i == 160 ||
                        i == 161 || i == 162 || i == 163 || i == 164 || i == 165 || i == 166 || i == 167 || i == 168 || i == 169 || i == 170 ||
                        i == 171 || i == 172 || i == 173 || i == 174 || i == 175 || i == 176 || i == 177 || i == 178 || i == 179 || i == 180 ||
                        i == 181 || i == 182 || i == 183 || i == 184 || i == 186 || i == 187 || i == 188 || i == 189 || i == 190 || i == 191 ||
                        i == 192 || i == 193 || i == 194 || i == 195 || i == 196 || i == 197 || i == 198 || i == 204 || i == 206 || i == 210 ||
                        i == 211 || i == 212 || i == 214 || i == 215 || i == 216 || i == 217 || i == 218 || i == 221 || i == 227 || i == 228 ||
                        i == 229 || i == 231 || i == 239 || i == 240)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(4);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Balloon()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(5 + 304);
                for (short i = 30009; i <= 30013; i++)
                {
                    oPacket.WriteShort(9);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(0);
                }
                for (short i = 1; i <= 1355; i++)
                {
                    if (i == 71 || i == 74 || i == 118 || i == 125 || i == 139 || i == 142 || i == 149 || i == 162 || i == 182 || i == 187 ||
                        i == 195 || i == 196 || i == 199 || i == 204 || i == 210 || i == 211 || i == 214 || i == 223 || i == 224 || i == 266 ||
                        i == 272 || i == 279 || i == 296 || i == 298 || i == 299 || i == 304 || i == 305 || i == 308 || i == 310 || i == 311 ||
                        i == 385 || i == 432 || i == 433 || i == 468 || i == 482 || i == 523 || i == 535 || i == 536 || i == 537 || i == 538 ||
                        i == 539 || i == 540 || i == 541 || i == 542 || i == 543 || i == 544 || i == 545 || i == 623 || i == 632 || i == 658 ||
                        i == 670 || i == 781 || i == 798 || i == 799 || i == 817 || i == 846 || i == 868 || i == 880 || i == 904 || i == 957 ||
                        i == 959 || i == 960 || i == 1000 || i == 1001 || i == 1002 || i == 1003 || i == 1004 || i == 1008 || i == 1009 || i == 1010 ||
                        i == 1038 || i == 1039 || i == 1040 || i == 1041 || i == 1042 || i == 1044 || i == 1046 || i == 1047 || i == 1049 || i == 1050 ||
                        i == 1053 || i == 1056 || i == 1057 || i == 1058 || i == 1059 || i == 1061 || i == 1092 || i == 1095 || i == 1096 || i == 1097 ||
                        i == 1098 || i == 1112 || i == 1113 || i == 1114 || i == 1119 || i == 1122 || i == 1123 || i == 1134 || i == 1137 || i == 1138 ||
                        i == 1142 || i == 1145 || i == 1147 || i == 1148 || i == 1149 || i == 1156 || i == 1185 || i == 1187 || i == 1188 || i == 1195 ||
                        i == 1196 || i == 1197 || i == 1198 || i == 1199 || i == 1200 || i == 1203 || i == 1204 || i == 1205 || i == 1215 || i == 1216 ||
                        i == 1221 || i == 1222 || i == 1223 || i == 1224 || i == 1225 || i == 1226 || i == 1239 || i == 1245 || i == 1246 || i == 1247 ||
                        i == 1248 || i == 1249 || i == 1261 || i == 1270 || i == 1277 || i == 1278 || i == 1279 || i == 1280 || i == 1281 || i == 1283 ||
                        i == 1284 || i == 1294 || i == 1297 || i == 1298 || i == 1299 || i == 1300 || i == 1301 || i == 1303 || i == 1311 || i == 1312 ||
                        i == 1313 || i == 1315 || i == 1316 || i == 1320 || i == 1328 || i == 1329 || i == 1330 || i == 1331 || i == 1332 || i == 1333 ||
                        i == 1334 || i == 1335 || i == 1340 || i == 1341 || i == 1355 ||

                        i == 1 || i == 2 || i == 3 || i == 4 || i == 11 || i == 12 || i == 13 || i == 54 || i == 56 || i == 68 ||
                        i == 78 || i == 84 || i == 103 || i == 130 || i == 140 || i == 152 || i == 213 || i == 225 || i == 265 || i == 292 ||
                        i == 318 || i == 323 || i == 350 || i == 351 || i == 378 || i == 444 || i == 445 || i == 446 || i == 447 || i == 448 ||
                        i == 449 || i == 450 || i == 512 || i == 599 || i == 600 || i == 602 || i == 603 || i == 627 || i == 647 || i == 655 ||
                        i == 667 || i == 671 || i == 683 || i == 684 || i == 685 || i == 687 || i == 689 || i == 690 || i == 691 || i == 692 ||
                        i == 695 || i == 697 || i == 705 || i == 730 || i == 745 || i == 746 || i == 747 || i == 756 || i == 768 || i == 790 ||
                        i == 791 || i == 794 || i == 795 || i == 796 || i == 800 || i == 808 || i == 822 || i == 823 || i == 824 || i == 828 ||
                        i == 850 || i == 862 || i == 863 || i == 864 || i == 865 || i == 866 || i == 867 || i == 877 || i == 878 || i == 879 ||
                        i == 882 || i == 883 || i == 969 || i == 970 || i == 1045 || i == 1060 || i == 1066 || i == 1067 || i == 1069 || i == 1075 ||
                        i == 1076 || i == 1093 || i == 1100 || i == 1109 || i == 1172 || i == 1178 || i == 1179 || i == 1180 || i == 1181 || i == 1182 ||
                        i == 1183 || i == 1184 || i == 1202 || i == 1208 || i == 1209 || i == 1210 || i == 1211 || i == 1228 || i == 1232 || i == 1233 ||
                        i == 1234 || i == 1235 || i == 1236 || i == 1237 || i == 1254 || i == 1255 || i == 1256 || i == 1257 || i == 1258 || i == 1260 ||
                        i == 1271 || i == 1272 || i == 1273 || i == 1274 || i == 1275 || i == 1276 || i == 1305 || i == 1306 || i == 1307 || i == 1308 ||
                        i == 1321 || i == 1336 || i == 1337 || i == 1338 || i == 1339 || i == 1342 || i == 1343 || i == 1345 || i == 1354)
                    {
                        oPacket.WriteShort(9);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value1);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Goggle()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Goggle = 237;
                oPacket.WriteInt(Goggle + 5 - 29);
                for (short i = 30000; i <= 30004; i++)
                {
                    oPacket.WriteShort(8);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value2);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(0);
                }
                for (short i = 1; i <= Goggle; i++)
                {
                    if (i == 7 || i == 8 || i == 13 || i == 28 || i == 33 || i == 36 || i == 41 || i == 43 || i == 49 || i == 51 ||
                        i == 60 || i == 64 || i == 65 || i == 67 || i == 83 || i == 92 || i == 105 || i == 121 || i == 126 || i == 127 ||
                        i == 128 || i == 140 || i == 141 || i == 148 || i == 156 || i == 159 || i == 175 || i == 214 || i == 219)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(8);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void HeadBand()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int HeadBand = 640;
                oPacket.WriteInt(HeadBand + 5 - 50);
                for (short i = 30003; i <= 30007; i++)
                {
                    oPacket.WriteShort(11);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(0);
                }
                for (short i = 1; i <= HeadBand; i++)
                {
                    if (i == 16 || i == 21 || i == 23 || i == 29 || i == 37 || i == 39 || i == 40 || i == 41 || i == 43 || i == 44 ||
                        i == 46 || i == 59 || i == 60 || i == 62 || i == 63 || i == 70 || i == 79 || i == 89 || i == 118 || i == 156 ||
                        i == 167 || i == 168 || i == 201 || i == 206 || i == 207 || i == 213 || i == 215 || i == 216 || i == 218 || i == 261 ||
                        i == 291 || i == 327 || i == 353 || i == 385 || i == 386 || i == 387 || i == 412 || i == 414 || i == 466 || i == 468 ||
                        i == 503 || i == 506 || i == 527 || i == 529 || i == 531 || i == 551 || i == 577 || i == 607 || i == 610 || i == 612)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(11);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value1);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void HandGearL()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int HandGearL = 433;
                oPacket.WriteInt(HandGearL + 6 - 84);
                for (short i = 30002; i <= 30011; i++)
                {
                    if (i == 30007 || i == 30008 || i == 30009 || i == 30010)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(16);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                for (short i = 1; i <= HandGearL; i++)
                {
                    if (i == 21 || i == 23 || i == 44 || i == 45 || i == 48 || i == 58 || i == 61 || i == 63 || i == 67 || i == 71 ||
                        i == 86 || i == 90 || i == 96 || i == 100 || i == 101 || i == 118 || i == 119 || i == 120 || i == 126 || i == 134 ||
                        i == 137 || i == 138 || i == 140 || i == 145 || i == 152 || i == 153 || i == 154 || i == 159 || i == 160 || i == 161 ||
                        i == 162 || i == 169 || i == 172 || i == 173 || i == 176 || i == 182 || i == 183 || i == 186 || i == 189 || i == 190 ||
                        i == 195 || i == 196 || i == 197 || i == 199 || i == 201 || i == 202 || i == 203 || i == 204 || i == 215 || i == 216 ||
                        i == 218 || i == 219 || i == 230 || i == 237 || i == 239 || i == 243 || i == 250 || i == 255 || i == 273 || i == 276 ||
                        i == 277 || i == 278 || i == 283 || i == 285 || i == 286 || i == 288 || i == 290 || i == 291 || i == 292 || i == 293 ||
                        i == 311 || i == 316 || i == 317 || i == 318 || i == 319 || i == 333 || i == 339 || i == 340 || i == 366 || i == 369 ||
                        i == 382 || i == 401 || i == 402 || i == 403)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(16);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void MyRoom()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int MyRoom = 52;
                oPacket.WriteInt(MyRoom - 14);
                for (short i = 1; i <= MyRoom; i++)
                {
                    if (i == 1 || i == 4 || i == 5 || i == 10 || i == 11 || i == 12 || i == 14 || i == 15 || i == 16 || i == 22 || i == 27 || i == 28 || i == 37 || i == 50)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(28);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void RidColor()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int RidColor = 5;
                oPacket.WriteInt(RidColor);
                for (short i = 1; i <= RidColor; i++)
                {
                    oPacket.WriteShort(31);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value2);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void BonusCard()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int BonusCard = 6;
                oPacket.WriteInt(BonusCard);
                for (short i = 1; i <= BonusCard; i++)
                {
                    oPacket.WriteShort(32);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value2);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void SlotItem()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(2);
                short Value = 0;
                for (short i = 1; i <= 2; i++)
                {
                    oPacket.WriteShort(7);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    if (i == 1)
                    {
                        Value = SetRider.SlotChanger;
                    }
                    else
                    {
                        Value = NewRider.Value1;
                    }
                    oPacket.WriteShort(Value);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void RenameRid()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteShort(23);
                oPacket.WriteShort(1);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value1);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                oPacket.WriteByte(0);
                oPacket.WriteByte(0);
                oPacket.WriteShort(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void ReplayTicket()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteShort(13);
                oPacket.WriteShort(1);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value2);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                oPacket.WriteByte(0);
                oPacket.WriteByte(0);
                oPacket.WriteShort(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void LucciBag()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteShort(23);
                oPacket.WriteShort(3);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value2);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                oPacket.WriteByte(0);
                oPacket.WriteByte(0);
                oPacket.WriteShort(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Tachometer()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteShort(61);
                oPacket.WriteShort(1);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value2);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                oPacket.WriteByte(0);
                oPacket.WriteByte(0);
                oPacket.WriteShort(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void XUniquePartsData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(40);
                byte Grade = 1;
                //-----------------------------------------------------------------X 유니크 파츠
                for (short i = 1053; i <= 1080; i += 3)
                {
                    oPacket.WriteShort(63);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1053; i <= 1080; i += 3)
                {
                    oPacket.WriteShort(64);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1053; i <= 1080; i += 3)
                {
                    oPacket.WriteShort(65);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1053; i <= 1080; i += 3)
                {
                    oPacket.WriteShort(66);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void XLegendPartsData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(40);
                byte Grade = 2;
                //-----------------------------------------------------------------X 레전드 파츠
                for (short i = 1005; i <= 1050; i += 5)
                {
                    oPacket.WriteShort(63);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1005; i <= 1050; i += 5)
                {
                    oPacket.WriteShort(64);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1005; i <= 1050; i += 5)
                {
                    oPacket.WriteShort(65);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1005; i <= 1050; i += 5)
                {
                    oPacket.WriteShort(66);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void XRarePartsData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(40);
                byte Grade = 3;
                //-----------------------------------------------------------------X 레어 파츠
                for (short i = 910; i <= 1000; i += 10)
                {
                    oPacket.WriteShort(63);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 910; i <= 1000; i += 10)
                {
                    oPacket.WriteShort(64);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 910; i <= 1000; i += 10)
                {
                    oPacket.WriteShort(65);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 910; i <= 1000; i += 10)
                {
                    oPacket.WriteShort(66);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void XNormalPartsData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(40);
                byte Grade = 4;
                //-----------------------------------------------------------------X 일반 파츠
                for (short i = 810; i <= 900; i += 10)
                {
                    oPacket.WriteShort(63);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 810; i <= 900; i += 10)
                {
                    oPacket.WriteShort(64);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 810; i <= 900; i += 10)
                {
                    oPacket.WriteShort(65);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                 for (short i = 810; i <= 900; i += 10)
                {
                    oPacket.WriteShort(66);
                    oPacket.WriteShort(1);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        //-----------------------------------------------------------------------------------------------V1 파츠 관련
        public static void V1UniquePartsData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(40);
                byte Grade = 1;
                //-----------------------------------------------------------------V1 유니크 파츠
                for (short i = 1153; i <= 1180; i += 3)
                {
                    oPacket.WriteShort(63);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1053; i <= 1080; i += 3)
                {
                    oPacket.WriteShort(64);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1153; i <= 1180; i += 3)
                {
                    oPacket.WriteShort(65);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1053; i <= 1080; i += 3)
                {
                    oPacket.WriteShort(66);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void V1LegendPartsData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(40);
                byte Grade = 2;
                //-----------------------------------------------------------------V1 레전드 파츠
                for (short i = 1105; i <= 1150; i += 5)
                {
                    oPacket.WriteShort(63);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1005; i <= 1050; i += 5)
                {
                    oPacket.WriteShort(64);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1105; i <= 1150; i += 5)
                {
                    oPacket.WriteShort(65);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1005; i <= 1050; i += 5)
                {
                    oPacket.WriteShort(66);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void V1RarePartsData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(40);
                byte Grade = 3;
                //-----------------------------------------------------------------V1 레어 파츠
                for (short i = 1010; i <= 1100; i += 10)
                {
                    oPacket.WriteShort(63);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 910; i <= 1000; i += 10)
                {
                    oPacket.WriteShort(64);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 1010; i <= 1100; i += 10)
                {
                    oPacket.WriteShort(65);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 910; i <= 1000; i += 10)
                {
                    oPacket.WriteShort(66);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void V1NormalPartsData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(40);
                byte Grade = 4;
                //-----------------------------------------------------------------V1 일반 파츠
                for (short i = 910; i <= 1000; i += 10)
                {
                    oPacket.WriteShort(63);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 810; i <= 900; i += 10)
                {
                    oPacket.WriteShort(64);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 910; i <= 1000; i += 10)
                {
                    oPacket.WriteShort(65);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                for (short i = 810; i <= 900; i += 10)
                {
                    oPacket.WriteShort(66);
                    oPacket.WriteShort(2);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(Grade);
                    oPacket.WriteShort(i);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void V1EffectData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int V1Effect = 18;
                oPacket.WriteInt(V1Effect);
                for (short i = 1; i <= V1Effect; i++)
                {
                    oPacket.WriteShort(68);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(5);
                    oPacket.WriteShort(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void V1BoosterEffectData()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int V1BoosterEffect = 23;
                oPacket.WriteInt(V1BoosterEffect);
                for (short i = 1; i <= V1BoosterEffect; i++)
                {
                    oPacket.WriteShort(69);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(-1);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(5);
                    oPacket.WriteShort(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }
    }
}