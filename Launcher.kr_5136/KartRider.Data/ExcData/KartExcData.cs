using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider;
using KartRider.IO;
using RiderData;

namespace ExcData
{
    public static class KartExcData
    {
        public static short Tune_KartSN = 0;
        public static short Plant_KartSN = 0;
        public static short KartLevel_KartSN = 0;
        public static short XParts_KartSN = 0;

        public static void Kart_ExcData()
        {
            int TuneCount = NewRider.Kart_V1_Cut + NewRider.Kart_X_Cut + NewRider.Kart_Old_Cut;
            int PlantCount = NewRider.Kart_Old_Cut;
            int KartLevelCount = NewRider.Kart_Old_Cut;
            short KartSN = Launcher.KartOld_SN;

            if (Program.UseKartTune)
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteInt(TuneCount);
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
                            i == 1226 || i == 1229 || i == 1230 || i == 1234 || i == 1238 || i == 1239 || i == 1247 || i == 1251 || i == 1252 || i == 1261 || i == 1264 || i == 1265 || i == 1268 || i == 1271 || i == 1275 ||
                            i == 1285 || i == 1297 || i == 1302 || //old

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
                                i == 1229 || i == 1230 || i == 1234 || i == 1238 || i == 1239 || i == 1247 || i == 1251 || i == 1252 || i == 1261 || i == 1264 || i == 1265 || i == 1268 || i == 1271 || i == 1275 || i == 1285 ||
                                i == 1297 || i == 1302)
                            {
                                oPacket.WriteShort(KartSN);
                            }
                            else
                            {
                                KartExcData.Tune_KartSN++;
                                Console.WriteLine("Tune_KartSN: {0}:{1}", i, KartExcData.Tune_KartSN);
                                oPacket.WriteShort(KartExcData.Tune_KartSN);
                            }
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(603);
                            oPacket.WriteShort(703);
                            oPacket.WriteShort(903);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                        }
                    }
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
            if (Program.UseKartPlant)
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(PlantCount);
                    for (short i = 1; i <= 1302; i++)
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
                            i == 1226 || i == 1229 || i == 1230 || i == 1234 || i == 1238 || i == 1239 || i == 1247 || i == 1251 || i == 1252 || i == 1261 || i == 1264 || i == 1265 || i == 1268 || i == 1271 || i == 1275 ||
                            i == 1285 || i == 1297 || i == 1302)
                        {
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteInt(4);
                            oPacket.WriteShort(43);
                            oPacket.WriteShort(23);
                            oPacket.WriteShort(44);
                            oPacket.WriteShort(2);
                            oPacket.WriteShort(45);
                            oPacket.WriteShort(23);
                            oPacket.WriteShort(46);
                            oPacket.WriteShort(1);
                        }
                    }
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
            if (Program.UseKartLevel)
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(KartLevelCount);
                    for (short i = 1; i <= 1302; i++)
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
                            i == 1226 || i == 1229 || i == 1230 || i == 1234 || i == 1238 || i == 1239 || i == 1247 || i == 1251 || i == 1252 || i == 1261 || i == 1264 || i == 1265 || i == 1268 || i == 1271 || i == 1275 ||
                            i == 1285 || i == 1297 || i == 1302)
                        {
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteShort(5);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(10);
                            oPacket.WriteShort(5);
                            oPacket.WriteShort(10);
                            oPacket.WriteShort(10);
                            if (i <= 292 || i == 358 || i == 420 || i == 464 || i == 501 || i == 837 || i == 838 || i == 843 || i == 845 || i == 847 ||
                                i == 853 || i == 856 || i == 863 || i == 873 || i == 880 || i == 1137 || i == 1193 || i == 1195 || i == 1199 || i == 1208 ||
                                i == 1212 || i == 1215 || i == 1221 || i == 1222 || i == 1226 || i == 1238 || i == 1265 || i == 1268 || i == 1275 || i == 1297)
                            {
                                oPacket.WriteShort(0);
                            }
                            else
                            {
                                oPacket.WriteShort(6); //코팅
                            }
                        }
                    }
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
            KartExcData.XKart_ExcData();
        }

        public static void XKart_ExcData()
        {
            int XParts = NewRider.Kart_V1_Cut + NewRider.Kart_X_Cut;

            using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
            {
                oPacket.WriteByte(0);
                oPacket.WriteByte(0);
                oPacket.WriteByte(0);
                oPacket.WriteByte(4);
                oPacket.WriteByte(0);
                oPacket.WriteByte(0);
                oPacket.WriteInt(0);
                oPacket.WriteInt(0);
                oPacket.WriteInt(0);
                oPacket.WriteInt(XParts);
                for (short i = 1096; i <= NewRider.MaxKart; i++)
                {
                    if (i == 1096 || i == 1097 || i == 1107 || i == 1108 || i == 1112 || i == 1114 || i == 1118 || i == 1119 || i == 1121 || i == 1122 || i == 1123 || i == 1124 || i == 1125 || i == 1126 || i == 1129 ||
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
                        KartExcData.XParts_KartSN++;
                        Console.WriteLine("XParts_KartSN: {0}:{1}", i, KartExcData.XParts_KartSN);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(KartExcData.XParts_KartSN);
                        if (Program.UseKartParts)
                        {
                            oPacket.WriteShort(0);
                            for (byte l = 0; l < 4; l++)
                            {
                                oPacket.WriteByte(255);
                            }
                            Launcher.KartSN = KartExcData.XParts_KartSN;
                            if (i <= 1303 || i == 1306 || i == 1307 || i == 1308 || i == 1309 || i == 1338 || i == 1343 || i == 1344 || i == 1347 || i == 1348 || i == 1361 || i == 1362)//X
                            {
                                for (int k = 1; k <= 4; k++)
                                {
                                    PartSpec.Item_Id = 1;
                                    PartSpec.Grade = 1;
                                    if (k == 1)
                                    {
                                        PartSpec.Item_Cat_Id = 63;
                                    }
                                    else if (k == 2)
                                    {
                                        PartSpec.Item_Cat_Id = 64;
                                    }
                                    else if (k == 3)
                                    {
                                        PartSpec.Item_Cat_Id = 65;
                                    }
                                    else if (k == 4)
                                    {
                                        PartSpec.Item_Cat_Id = 66;
                                    }
                                    PartSpec.PartsValue = 1080;
                                    PartSpec.PartSpecData();
                                }
                                oPacket.WriteShort(1);
                                oPacket.WriteByte(1);
                                oPacket.WriteShort(1080);
                                oPacket.WriteShort(1);
                                oPacket.WriteByte(1);
                                oPacket.WriteShort(1080);
                                oPacket.WriteShort(1);
                                oPacket.WriteByte(1);
                                oPacket.WriteShort(1080);
                                oPacket.WriteShort(1);
                                oPacket.WriteByte(1);
                                oPacket.WriteShort(1080);
                                oPacket.WriteShort(0);
                                oPacket.WriteByte(0);
                                oPacket.WriteShort(0);
                                oPacket.WriteShort(0);
                                oPacket.WriteByte(0);
                                oPacket.WriteShort(0);
                            }
                            else
                            {
                                for (int k = 1; k <= 4; k++)
                                {
                                    PartSpec.Item_Id = 2;
                                    PartSpec.Grade = 1;
                                    if (k == 1)
                                    {
                                        PartSpec.Item_Cat_Id = 63;
                                        PartSpec.PartsValue = 1180;
                                    }
                                    else if (k == 2)
                                    {
                                        PartSpec.Item_Cat_Id = 64;
                                        PartSpec.PartsValue = 1080;
                                    }
                                    else if (k == 3)
                                    {
                                        PartSpec.Item_Cat_Id = 65;
                                        PartSpec.PartsValue = 1180;
                                    }
                                    else if (k == 4)
                                    {
                                        PartSpec.Item_Cat_Id = 66;
                                        PartSpec.PartsValue = 1080;
                                    }
                                    PartSpec.PartSpecData();
                                }
                                oPacket.WriteShort(2);
                                oPacket.WriteByte(1);
                                oPacket.WriteShort(1180);
                                oPacket.WriteShort(2);
                                oPacket.WriteByte(1);
                                oPacket.WriteShort(1080);
                                oPacket.WriteShort(2);
                                oPacket.WriteByte(1);
                                oPacket.WriteShort(1180);
                                oPacket.WriteShort(2);
                                oPacket.WriteByte(1);
                                oPacket.WriteShort(1080);
                                oPacket.WriteShort(6);
                                oPacket.WriteByte(0);
                                oPacket.WriteShort(0);
                                oPacket.WriteShort(3);
                                oPacket.WriteByte(0);
                                oPacket.WriteShort(0);
                            }
                        }
                        else
                        {
                            oPacket.WriteHexString("00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                        }
                    }
                }
                oPacket.WriteInt(0);
                oPacket.WriteInt(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }
    }
}