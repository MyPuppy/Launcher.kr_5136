using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using KartRider;

namespace RiderData
{
    public static class FavoriteItem
    {
        public static void Favorite_Item()
        {
            int itemCount = 17;
            using (OutPacket outPacket = new OutPacket("PrFavoriteItemGet"))
            {
                if (Program.FavoriteItem)
                {
                    outPacket.WriteInt(itemCount);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(839);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(854);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1045);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1098);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1239);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1247);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1276);
                    outPacket.WriteShort(81);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1297);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1348);
                    outPacket.WriteShort(115);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1385);
                    outPacket.WriteShort(145);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1387);
                    outPacket.WriteShort(147);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1401);
                    outPacket.WriteShort(159);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1419);
                    outPacket.WriteShort(173);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1430);
                    outPacket.WriteShort(179);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1433);
                    outPacket.WriteShort(181);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1435);
                    outPacket.WriteShort(182);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1440);
                    outPacket.WriteShort(184);
                    outPacket.WriteByte(0);
                }
                else
                {
                    outPacket.WriteInt(0);
                }
                RouterListener.MySession.Client.Send(outPacket);
            }
        }
    }
}