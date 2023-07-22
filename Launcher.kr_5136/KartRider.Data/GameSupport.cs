using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using System.Net;
using Set_Data;

namespace KartRider
{
    public static class GameSupport
    {
        public static void PcFirstMessage()
        {
            uint first_val = 2919676295;
            uint second_val = 263300380;
            using (OutPacket outPacket = new OutPacket("PcFirstMessage"))
            {
                outPacket.WriteUShort(SessionGroup.usLocale);
                outPacket.WriteUShort(1);
                outPacket.WriteUShort(Program.Version);
                outPacket.WriteString("http://kart.dn.nexoncdn.co.kr/patch");
                outPacket.WriteUInt(first_val);
                outPacket.WriteUInt(second_val);
                outPacket.WriteByte(SessionGroup.nClientLoc);
                outPacket.WriteString("QyvKvO60jogWDupzJ7gm0kRQdooFjWRjSjlq0gu/x2k=");
                outPacket.WriteHexString("00 00 00 00 00 00 00 00 0F 00 00 00 00 00 00 00 00 2E 31 2E 31 37 2E 36 00 00 00 00 00 00 00");
                outPacket.WriteString("GXQstj1A95XiHvjrOGuPkzdyL+7qxETl/cPlUZk2KA4=");
                RouterListener.MySession.Client.Send(outPacket);
            }
            RouterListener.MySession.Client._RIV = first_val ^ second_val;
            RouterListener.MySession.Client._SIV = first_val ^ second_val;
        }

        public static void OnDisconnect()
        {
            RouterListener.MySession.Client.Disconnect();
        }

        public static void SpRpLotteryPacket()
        {
            using (OutPacket outPacket = new OutPacket("SpRpLotteryPacket"))
            {
                outPacket.WriteHexString("05 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00");
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void PrGetGameOption()
        {
            using (OutPacket outPacket = new OutPacket("PrGetGameOption"))
            {
                outPacket.WriteFloat(SetGameOption.Set_BGM);
                outPacket.WriteFloat(SetGameOption.Set_Sound);
                outPacket.WriteByte(SetGameOption.Main_BGM);
                outPacket.WriteByte(SetGameOption.Sound_effect);
                outPacket.WriteByte(SetGameOption.Full_screen);
                outPacket.WriteByte(SetGameOption.Unk1);
                outPacket.WriteByte(SetGameOption.Unk2);
                outPacket.WriteByte(SetGameOption.Unk3);
                outPacket.WriteByte(SetGameOption.Unk4);
                outPacket.WriteByte(SetGameOption.Unk5);
                outPacket.WriteByte(SetGameOption.Unk6);
                outPacket.WriteByte(SetGameOption.Unk7);
                outPacket.WriteByte(SetGameOption.Unk8);
                outPacket.WriteByte(SetGameOption.Unk9);
                outPacket.WriteByte(SetGameOption.Unk10);
                outPacket.WriteByte(SetGameOption.Unk11);
                outPacket.WriteByte(SetGameOption.BGM_Check);
                outPacket.WriteByte(SetGameOption.Sound_Check);
                outPacket.WriteByte(SetGameOption.Unk12);
                outPacket.WriteByte(SetGameOption.Unk13);
                outPacket.WriteByte(SetGameOption.GameType);
                outPacket.WriteByte(SetGameOption.SetGhost);
                outPacket.WriteByte(SetGameOption.SpeedType);
                outPacket.WriteByte(SetGameOption.Unk14);
                outPacket.WriteByte(SetGameOption.Unk15);
                outPacket.WriteByte(SetGameOption.Unk16);
                outPacket.WriteByte(SetGameOption.Unk17);
                outPacket.WriteByte(SetGameOption.Set_screen);
                outPacket.WriteByte(SetGameOption.Unk18);
                outPacket.WriteBytes(new byte[80]);
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void ChRpEnterMyRoomPacket()
        {
            if (GameType.EnterMyRoomType == 0)
            {
                using (OutPacket outPacket = new OutPacket("ChRpEnterMyRoomPacket"))
                {
                    outPacket.WriteString(SetRider.Nickname);
                    outPacket.WriteByte(0);
                    outPacket.WriteShort(SetMyRoom.MyRoom);
                    outPacket.WriteByte(SetMyRoom.MyRoomBGM);
                    outPacket.WriteByte(SetMyRoom.UseRoomPwd);
                    outPacket.WriteByte(0);
                    outPacket.WriteByte(SetMyRoom.UseItemPwd);
                    outPacket.WriteByte(SetMyRoom.TalkLock);
                    outPacket.WriteString(SetMyRoom.RoomPwd);
                    outPacket.WriteString("");
                    outPacket.WriteString(SetMyRoom.ItemPwd);
                    outPacket.WriteShort(SetMyRoom.MyRoomKart1);
                    outPacket.WriteShort(SetMyRoom.MyRoomKart2);
                    RouterListener.MySession.Client.Send(outPacket);
                }
            }
            else
            {
                using (OutPacket outPacket = new OutPacket("ChRpEnterMyRoomPacket"))
                {
                    outPacket.WriteString("");
                    outPacket.WriteByte(GameType.EnterMyRoomType);
                    outPacket.WriteShort(0);
                    outPacket.WriteByte(0);
                    outPacket.WriteByte(0);
                    outPacket.WriteByte(0);
                    outPacket.WriteByte(0);
                    outPacket.WriteByte(1);
                    outPacket.WriteString("");//RoomPwd
                    outPacket.WriteString("");
                    outPacket.WriteString("");//ItemPwd 
                    outPacket.WriteShort(0);
                    outPacket.WriteShort(0);
                    RouterListener.MySession.Client.Send(outPacket);
                }
            }
        }

        public static void RmNotiMyRoomInfoPacket()
        {
            using (OutPacket outPacket = new OutPacket("RmNotiMyRoomInfoPacket"))
            {
                outPacket.WriteShort(SetMyRoom.MyRoom);
                outPacket.WriteByte(SetMyRoom.MyRoomBGM);
                outPacket.WriteByte(SetMyRoom.UseRoomPwd);
                outPacket.WriteByte(0);
                outPacket.WriteByte(SetMyRoom.UseItemPwd);
                outPacket.WriteByte(SetMyRoom.TalkLock);
                outPacket.WriteString(SetMyRoom.RoomPwd);
                outPacket.WriteString("");
                outPacket.WriteString(SetMyRoom.ItemPwd);
                outPacket.WriteShort(SetMyRoom.MyRoomKart1);
                outPacket.WriteShort(SetMyRoom.MyRoomKart2);
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void PrGetRiderInfo()
        {
            using (OutPacket outPacket = new OutPacket("PrGetRiderInfo"))
            {
                outPacket.WriteByte(1);
                outPacket.WriteUInt(SetRider.UserNO);
                outPacket.WriteString(SetRider.UserID);
                outPacket.WriteString(SetRider.Nickname);
                outPacket.WriteHexString("3C 9A 17 43");//2008.02.08
                for (int i = 1; i <= Program.MAX_EQP_P; i++)
                {
                    outPacket.WriteShort(0);
                }
                outPacket.WriteByte(0);
                outPacket.WriteString("");
                outPacket.WriteInt(SetRider.RP);
                outPacket.WriteInt(0);
                outPacket.WriteByte(6);//Licenses
                outPacket.WriteHexString(Program.DataTime);
                outPacket.WriteBytes(new byte[17]);
                outPacket.WriteShort(SetRider.Emblem1);
                outPacket.WriteShort(SetRider.Emblem2);
                outPacket.WriteShort(0);
                outPacket.WriteString(SetRider.RiderIntro);
                outPacket.WriteInt(SetRider.Premium);
                outPacket.WriteByte(1);
                if (SetRider.Premium == 0)
                    outPacket.WriteInt(0);
                else if (SetRider.Premium == 1)
                    outPacket.WriteInt(10000);
                else if (SetRider.Premium == 2)
                    outPacket.WriteInt(30000);
                else if (SetRider.Premium == 3)
                    outPacket.WriteInt(60000);
                else if (SetRider.Premium == 4)
                    outPacket.WriteInt(120000);
                else if (SetRider.Premium == 5)
                    outPacket.WriteInt(200000);
                else
                    outPacket.WriteInt(0);
                if (SetRider.ClubMark_LOGO == 0)
                {
                    outPacket.WriteInt(0);
                    outPacket.WriteInt(0);
                    outPacket.WriteInt(0);
                    outPacket.WriteString("");
                }
                else
                {
                    outPacket.WriteInt(SetRider.ClubCode);
                    outPacket.WriteInt(SetRider.ClubMark_LOGO);
                    outPacket.WriteInt(SetRider.ClubMark_LINE);
                    outPacket.WriteString(SetRider.ClubName);
                }
                outPacket.WriteInt(0);
                outPacket.WriteByte(SetRider.Ranker);
                outPacket.WriteInt(0);
                outPacket.WriteInt(0);
                outPacket.WriteInt(0);
                outPacket.WriteInt(0);
                outPacket.WriteInt(0);
                outPacket.WriteByte(0);
                outPacket.WriteByte(0);
                outPacket.WriteByte(0);
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void PrCheckMyClubStatePacket()
        {
            using (OutPacket outPacket = new OutPacket("PrCheckMyClubStatePacket"))
            {
                if (SetRider.ClubMark_LOGO == 0)
                {
                    outPacket.WriteInt(0);
                    outPacket.WriteString("");
                    outPacket.WriteInt(0);
                    outPacket.WriteInt(0);
                }
                else
                {
                    outPacket.WriteInt(SetRider.ClubCode);
                    outPacket.WriteString(SetRider.ClubName);
                    outPacket.WriteInt(SetRider.ClubMark_LOGO);
                    outPacket.WriteInt(SetRider.ClubMark_LINE);
                }
                outPacket.WriteShort(5);//Grade
                outPacket.WriteString(SetRider.Nickname);
                outPacket.WriteInt(1);//ClubMember
                outPacket.WriteByte(5);//Level
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void ChRequestChStaticReplyPacket()
        {
            using (OutPacket outPacket = new OutPacket("ChRequestChStaticReplyPacket"))
            {
                outPacket.WriteHexString("01 4F 03 00 00 53 01 1D B3 D2 6C 8E 0F 00 00 78 DA A5 96 F9 53 1A 31 14 C7 5F BD 2F 58 60 05 C5 5A 6A EF BB 55 AB F6 3E 76 41 1C 7F 68 A7 A3 FD DD 51 41 EB 88 E0 00 D6 DA BF BE DF 97 34 75 B3 64 B3 4B C5 99 B8 49 3E EF C8 CB 4B F2 AA 44 E4 39 68 8E A8 4B 75 3A A1 4D 6A 52 0D BD 32 B5 D0 DB C3 57 13 E3 E3 29 20 1D 3A C5 67 1D D3 DF D1 EE 62 BA 8A B6 03 C1 81 11 4C 9F D0 05 6D 41 8A E5 06 83 2A BF A2 3D 87 62 D9 53 B2 43 D1 88 F2 61 B8 14 AB 45 79 50 17 ED 32 AD 43 74 9F 7E 60 B4 89 FE 48 29 D6 86 5D C1 68 3E D6 03 39 CA 81 AA D3 58 3E D6 5E 10 9F D0 A3 1A 76 69 32 63 0D BA F4 78 2A 63 D5 21 A1 94 63 D4 14 F4 25 ED 18 F5 04 11 C7 B5 FA 13 44 33 AE D5 AB 20 9A 9D 01 7A 48 67 E8 34 04 24 E3 A5 EF 83 1E CB 5C 56 13 B9 B4 A3 AF DA 4D 03 93 3A 4E 80 1C 21 33 9B 98 E0 1C BD C0 58 83 A6 39 6D F7 F0 D9 C5 5F 03 52 F9 31 0C 1C E0 73 17 EA D5 FA 0A C1 41 B5 92 19 73 D8 F9 FF 81 38 33 BC 8E 59 F3 06 EA 50 71 2A 90 33 5F FE 0E 2B 7D 73 A6 49 A5 E7 FA AC 70 BF 45 C7 68 CF E0 A0 FC DE B4 E6 DF 7C 3F 42 CA D2 8D 9C 51 68 BB 67 FD A5 38 50 69 BC 59 4C A8 51 0F D6 42 31 A1 7E 5D EC 56 C9 BA E8 1D 64 49 1B 62 BF 91 17 E6 00 DC 76 44 C6 B5 45 3A D6 60 AD 0D BD BF 20 78 B9 BB 77 0A C6 8C D8 16 F9 57 83 BD F3 90 53 77 0B C6 EC 88 16 B8 97 8F 70 42 5F 8D B2 7C BF 60 C5 7B 43 FD C0 8D 5D A4 42 1F 16 23 50 FB E5 F7 A8 3F 31 15 92 C7 73 89 1D D3 23 F6 64 21 B1 60 74 D8 9F C6 5B 37 67 DD 33 DE 80 AE B8 E4 DA 38 BC 7C CD F0 6D C4 D3 87 46 1F 9E 27 15 50 F6 5E CC 5B 05 EC 9B B1 F8 3F C2 CA F2 92 5D B8 21 30 BE A2 EB 86 44 5B E6 8B F9 A7 10 ED 00 E9 40 41 0B 13 F5 7F C0 CB 6C 04 F0 0D 3D 39 C6 EE AD 0C 89 0B BE 81 EE 1E AD A6 03 9D 2D 58 DF 07 1F 0C DA 5A CA 08 A8 75 BE 32 3F C6 1B 62 BB 4F E9 35 DF 00 6D B8 C1 49 E2 43 4B 0B F2 C7 9A 81 37 E9 08 44 99 78 CB 40 4D 84 A6 8B 60 5D 86 4D 45 F5 9D 7C 84 BB A2 DB 10 50 78 D7 DE 67 7A 90 DE 00 7F C8 05 9E 8D 60 72 F2 88 4C E5 AE 10 F8 98 33 94 7E 26 F0 93 1B F9 94 85 D1 CF 6E E4 D3 18 46 7D C7 E0 A7 5E 79 96 CD 0F AD 0E 55 CC 0F AD 0E AD 4F C7 1A DB 11 E3 1C DD 6A 3A 00 57 90 32 AD 10 BA A1 D7 4B 26 84 5F DA 6B 34 1A AA 31 3C 62 3F 68 9C E2 AB 6E 8F C1 01 1A 0E E4 AD 47 2B 3C 38 48 69 6B 32 7B B4 C6 D8 90 30 62 3B 14 1E AD 32 38 4C FD 15 BA BC 28 1A A1 FE CA 5D AE A3 20 19 5F 8B F2 49 04 1D 5F 91 72 10 68 82 E2 B3 C8 67 70 92 B2 09 72 C9 43 1F BF A9 44 B0 2F E1 54 04 AC BF 07 1E 71 A9 0B A7 93 C0 BE 84 9D 44 70 59 C2 99 44 70 45 C2 D9 10 6C 0E 9C 07 1C BF 5C 22 D8 97 B0 1B 01 87 A3 C1 E7 03 87 21 09 EC 4B 38 9F 08 2E 4B B8 90 08 AE 48 78 86 AE F2 A0 2D B1 8A 59 BA CA 83 BA C8 2A FE 00 7C 60 B3 1E");
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void PrDynamicCommand()
        {
            using (OutPacket outPacket = new OutPacket("PrDynamicCommand"))
            {
                outPacket.WriteByte(0);
                outPacket.WriteInt(0);
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void PrQuestUX2ndPacket()
        {
            //questGroupIndex='2' seasonId='17' kartPassSetId='1' unk='0' id='13'
            //EX) 217010013
            int NormalQuest = 7;
            int KartPassQuest = 0;
            int All_Quest = NormalQuest + KartPassQuest;
            using (OutPacket outPacket = new OutPacket("PrQuestUX2ndPacket"))
            {
                outPacket.WriteInt(1);
                outPacket.WriteInt(1);
                outPacket.WriteInt(All_Quest);
                for (int i = 1211; i <= 1217; i++)
                {
                    outPacket.WriteInt(i);
                    outPacket.WriteInt(i);
                    outPacket.WriteInt(0);
                    outPacket.WriteInt(0);
                    outPacket.WriteInt(0);
                    outPacket.WriteInt(0);
                    outPacket.WriteInt(2);
                    outPacket.WriteInt(0);
                    outPacket.WriteByte(0);
                }
                /*
                //questGroupIndex='1'
                outPacket.WriteInt(117002301);
                outPacket.WriteInt(117002301);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                outPacket.WriteInt(117002302);
                outPacket.WriteInt(117002302);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                outPacket.WriteInt(117002303);
                outPacket.WriteInt(117002303);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                //questGroupIndex = '2'
                outPacket.WriteInt(217010013);
                outPacket.WriteInt(217010013);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                outPacket.WriteInt(217020014);
                outPacket.WriteInt(217020014);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                outPacket.WriteInt(217030017);
                outPacket.WriteInt(217030017);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                outPacket.WriteInt(217040021);
                outPacket.WriteInt(217040021);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                //questGroupIndex='3'
                outPacket.WriteInt(317010001);
                outPacket.WriteInt(317010001);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                outPacket.WriteInt(317020002);
                outPacket.WriteInt(317020002);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                outPacket.WriteInt(317030003);
                outPacket.WriteInt(317030003);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                outPacket.WriteInt(317040004);
                outPacket.WriteInt(317040004);
                outPacket.WriteHexString("00 00 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00");
                */
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void PrLogin()
        {
            using (OutPacket outPacket = new OutPacket("PrLogin"))
            {
                outPacket.WriteInt(0);
                outPacket.WriteHexString(Program.DataTime);
                outPacket.WriteUInt(SetRider.UserNO);
                outPacket.WriteString(SetRider.UserID);
                outPacket.WriteByte(2);
                outPacket.WriteByte(1);
                outPacket.WriteByte(0);
                outPacket.WriteInt(0);
                outPacket.WriteByte(0);
                outPacket.WriteInt(1415577599);
                outPacket.WriteUInt(SetRider.pmap);
                for (int i = 0; i < 11; i++)
                {
                    outPacket.WriteInt(0);
                }
                outPacket.WriteByte(0);
                outPacket.WriteEndPoint(IPAddress.Parse(RouterListener.forceConnect), 39311);
                outPacket.WriteEndPoint(IPAddress.Parse(RouterListener.forceConnect), 39312);
                outPacket.WriteInt(0);
                outPacket.WriteString("");
                outPacket.WriteInt(0);
                outPacket.WriteByte(1);
                outPacket.WriteString("content");
                outPacket.WriteInt(0);
                outPacket.WriteInt(1);
                outPacket.WriteString("cc");
                outPacket.WriteString(SessionGroup.Service);
                outPacket.WriteInt(0);
                outPacket.WriteByte(0);
                outPacket.WriteByte(SetGameOption.Set_screen);
                RouterListener.MySession.Client.Send(outPacket);
            }
        }
    }
}
