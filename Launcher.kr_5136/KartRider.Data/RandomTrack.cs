using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.Common.Utilities;
using KartRider_TrackName;
using ExcData;

namespace KartRider
{
    public class RandomTrack
    {
        public static string GameType = "item";
        public static string SetRandomTrack = "allRandom";
        public static string GameTrack = "forest_I01";

        public static void SetGameType()
        {
            if (StartGameData.StartTimeAttack_RandomTrackGameType == 0)
            {
                RandomTrack.GameType = "speed";
            }
            else if (StartGameData.StartTimeAttack_RandomTrackGameType == 1)
            {
                RandomTrack.GameType = "item";
            }
            RandomTrack.SetRandomType();
        }

        public static void SetRandomType()
        {
            if (StartGameData.StartTimeAttack_Track == 0)
            {
                RandomTrack.SetRandomTrack = "allRandom";
            }
            else if (StartGameData.StartTimeAttack_Track == 3)
            {
                RandomTrack.SetRandomTrack = "hot1Random";
            }
            else if (StartGameData.StartTimeAttack_Track == 4)
            {
                RandomTrack.SetRandomTrack = "hot2Random";
            }
            else if (StartGameData.StartTimeAttack_Track == 5)
            {
                RandomTrack.SetRandomTrack = "hot3Random";
            }
            else if (StartGameData.StartTimeAttack_Track == 6)
            {
                RandomTrack.SetRandomTrack = "hot4Random";
            }
            else if (StartGameData.StartTimeAttack_Track == 7)
            {
                RandomTrack.SetRandomTrack = "hot5Random";
            }
            else if (StartGameData.StartTimeAttack_Track == 8)
            {
                RandomTrack.SetRandomTrack = "newRandom";
            }
            else if (StartGameData.StartTimeAttack_Track == 30)
            {
                RandomTrack.SetRandomTrack = "reverseRandom";
            }
            else if (StartGameData.StartTimeAttack_Track == 33)
            {
                RandomTrack.SetRandomTrack = "newLeagueRandom";
            }
            else if (StartGameData.StartTimeAttack_Track == 40)
            {
                RandomTrack.SetRandomTrack = "speedAllRandom";
            }
            else
            {
                RandomTrack.SetRandomTrack = "Unknown";
            }
            RandomTrack.RandomTrackSetList();
        }

        public static void RandomTrackSetList()
        {
            Random random = new Random();
            if (RandomTrack.SetRandomTrack == "allRandom")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 191);
                    if (track == 1) RandomTrack.GameTrack = "forest_I01";
                    else if (track == 2) RandomTrack.GameTrack = "forest_I02";
                    else if (track == 3) RandomTrack.GameTrack = "forest_I03";
                    else if (track == 4) RandomTrack.GameTrack = "forest_I04";
                    else if (track == 5) RandomTrack.GameTrack = "forest_I05";
                    else if (track == 6) RandomTrack.GameTrack = "forest_I06";
                    else if (track == 7) RandomTrack.GameTrack = "forest_I07";
                    else if (track == 8) RandomTrack.GameTrack = "forest_I08";
                    else if (track == 9) RandomTrack.GameTrack = "forest_I09";
                    else if (track == 10) RandomTrack.GameTrack = "desert_I01";
                    else if (track == 11) RandomTrack.GameTrack = "desert_I10";
                    else if (track == 12) RandomTrack.GameTrack = "desert_I02";
                    else if (track == 13) RandomTrack.GameTrack = "desert_I11";
                    else if (track == 14) RandomTrack.GameTrack = "desert_I03";
                    else if (track == 15) RandomTrack.GameTrack = "desert_I04";
                    else if (track == 16) RandomTrack.GameTrack = "desert_I05";
                    else if (track == 17) RandomTrack.GameTrack = "desert_I06";
                    else if (track == 18) RandomTrack.GameTrack = "desert_I07";
                    else if (track == 19) RandomTrack.GameTrack = "desert_I08";
                    else if (track == 20) RandomTrack.GameTrack = "village_I01";
                    else if (track == 21) RandomTrack.GameTrack = "village_I02";
                    else if (track == 22) RandomTrack.GameTrack = "village_I11";
                    else if (track == 23) RandomTrack.GameTrack = "village_I03";
                    else if (track == 24) RandomTrack.GameTrack = "village_I04";
                    else if (track == 25) RandomTrack.GameTrack = "village_I05";
                    else if (track == 26) RandomTrack.GameTrack = "village_I14";
                    else if (track == 27) RandomTrack.GameTrack = "village_I06";
                    else if (track == 28) RandomTrack.GameTrack = "village_I07";
                    else if (track == 29) RandomTrack.GameTrack = "village_I08";
                    else if (track == 30) RandomTrack.GameTrack = "ice_I01";
                    else if (track == 31) RandomTrack.GameTrack = "ice_I02";
                    else if (track == 32) RandomTrack.GameTrack = "ice_I03";
                    else if (track == 33) RandomTrack.GameTrack = "ice_I04";
                    else if (track == 34) RandomTrack.GameTrack = "ice_I05";
                    else if (track == 35) RandomTrack.GameTrack = "ice_I06";
                    else if (track == 36) RandomTrack.GameTrack = "ice_I07";
                    else if (track == 37) RandomTrack.GameTrack = "ice_I08";
                    else if (track == 38) RandomTrack.GameTrack = "tomb_I01";
                    else if (track == 39) RandomTrack.GameTrack = "tomb_I02";
                    else if (track == 40) RandomTrack.GameTrack = "tomb_I03";
                    else if (track == 41) RandomTrack.GameTrack = "tomb_I04";
                    else if (track == 42) RandomTrack.GameTrack = "tomb_I05";
                    else if (track == 43) RandomTrack.GameTrack = "tomb_I06";
                    else if (track == 44) RandomTrack.GameTrack = "tomb_I07";
                    else if (track == 45) RandomTrack.GameTrack = "mine_I01";
                    else if (track == 46) RandomTrack.GameTrack = "mine_I02";
                    else if (track == 47) RandomTrack.GameTrack = "mine_I03";
                    else if (track == 48) RandomTrack.GameTrack = "mine_I04";
                    else if (track == 49) RandomTrack.GameTrack = "mine_I05";
                    else if (track == 50) RandomTrack.GameTrack = "northeu_I01";
                    else if (track == 51) RandomTrack.GameTrack = "northeu_I02";
                    else if (track == 52) RandomTrack.GameTrack = "northeu_I03";
                    else if (track == 53) RandomTrack.GameTrack = "northeu_I04";
                    else if (track == 54) RandomTrack.GameTrack = "northeu_I05";
                    else if (track == 55) RandomTrack.GameTrack = "northeu_I06";
                    else if (track == 56) RandomTrack.GameTrack = "northeu_I07";
                    else if (track == 57) RandomTrack.GameTrack = "northeu_I08";
                    else if (track == 58) RandomTrack.GameTrack = "northeu_I09";
                    else if (track == 59) RandomTrack.GameTrack = "factory_I01";
                    else if (track == 60) RandomTrack.GameTrack = "factory_I02";
                    else if (track == 61) RandomTrack.GameTrack = "factory_I03";
                    else if (track == 62) RandomTrack.GameTrack = "factory_I04";
                    else if (track == 63) RandomTrack.GameTrack = "factory_I05";
                    else if (track == 64) RandomTrack.GameTrack = "factory_I06";
                    else if (track == 65) RandomTrack.GameTrack = "factory_I07";
                    else if (track == 66) RandomTrack.GameTrack = "pirate_I01";
                    else if (track == 67) RandomTrack.GameTrack = "pirate_I02";
                    else if (track == 68) RandomTrack.GameTrack = "pirate_I03";
                    else if (track == 69) RandomTrack.GameTrack = "pirate_I04";
                    else if (track == 70) RandomTrack.GameTrack = "pirate_I05";
                    else if (track == 71) RandomTrack.GameTrack = "fairy_I01";
                    else if (track == 72) RandomTrack.GameTrack = "fairy_I02";
                    else if (track == 73) RandomTrack.GameTrack = "fairy_I03";
                    else if (track == 74) RandomTrack.GameTrack = "fairy_I04";
                    else if (track == 75) RandomTrack.GameTrack = "fairy_I05";
                    else if (track == 76) RandomTrack.GameTrack = "moonhill_I01";
                    else if (track == 77) RandomTrack.GameTrack = "moonhill_I02";
                    else if (track == 78) RandomTrack.GameTrack = "moonhill_I03";
                    else if (track == 79) RandomTrack.GameTrack = "moonhill_I04";
                    else if (track == 80) RandomTrack.GameTrack = "moonhill_I05";
                    else if (track == 81) RandomTrack.GameTrack = "gold_I01";
                    else if (track == 82) RandomTrack.GameTrack = "gold_I02";
                    else if (track == 83) RandomTrack.GameTrack = "gold_I03";
                    else if (track == 84) RandomTrack.GameTrack = "gold_I04";
                    else if (track == 85) RandomTrack.GameTrack = "gold_I05";
                    else if (track == 86) RandomTrack.GameTrack = "gold_I06";
                    else if (track == 87) RandomTrack.GameTrack = "china_I01";
                    else if (track == 88) RandomTrack.GameTrack = "china_I02";
                    else if (track == 89) RandomTrack.GameTrack = "china_I03";
                    else if (track == 90) RandomTrack.GameTrack = "china_I04";
                    else if (track == 91) RandomTrack.GameTrack = "china_I05";
                    else if (track == 92) RandomTrack.GameTrack = "china_I07";
                    else if (track == 93) RandomTrack.GameTrack = "castle_I01";
                    else if (track == 94) RandomTrack.GameTrack = "castle_I02";
                    else if (track == 95) RandomTrack.GameTrack = "castle_I03";
                    else if (track == 96) RandomTrack.GameTrack = "castle_I04";
                    else if (track == 97) RandomTrack.GameTrack = "castle_I05";
                    else if (track == 98) RandomTrack.GameTrack = "castle_I06";
                    else if (track == 99) RandomTrack.GameTrack = "nymph_I01";
                    else if (track == 100) RandomTrack.GameTrack = "nymph_I02";
                    else if (track == 101) RandomTrack.GameTrack = "nymph_I03";
                    else if (track == 102) RandomTrack.GameTrack = "nymph_I04";
                    else if (track == 103) RandomTrack.GameTrack = "nymph_I05";
                    else if (track == 104) RandomTrack.GameTrack = "mechanic_I01";
                    else if (track == 105) RandomTrack.GameTrack = "mechanic_I02";
                    else if (track == 106) RandomTrack.GameTrack = "wkc_I01";
                    else if (track == 107) RandomTrack.GameTrack = "brodi_I01";
                    else if (track == 108) RandomTrack.GameTrack = "brodi_I02";
                    else if (track == 109) RandomTrack.GameTrack = "park_I01";
                    else if (track == 110) RandomTrack.GameTrack = "beach_I01";
                    else if (track == 111) RandomTrack.GameTrack = "beach_I02";
                    else if (track == 112) RandomTrack.GameTrack = "beach_I03";
                    else if (track == 113) RandomTrack.GameTrack = "steam_I01";
                    else if (track == 114) RandomTrack.GameTrack = "jurassic_I01";
                    else if (track == 115) RandomTrack.GameTrack = "jurassic_I02";
                    else if (track == 116) RandomTrack.GameTrack = "world_I01";
                    else if (track == 117) RandomTrack.GameTrack = "world_I02";
                    else if (track == 118) RandomTrack.GameTrack = "world_I03";
                    else if (track == 119) RandomTrack.GameTrack = "world_I05";
                    else if (track == 120) RandomTrack.GameTrack = "nemo_I01";
                    else if (track == 121) RandomTrack.GameTrack = "nemo_I02";
                    else if (track == 122) RandomTrack.GameTrack = "nemo_I03";
                    else if (track == 123) RandomTrack.GameTrack = "sword_I01";
                    else if (track == 124) RandomTrack.GameTrack = "sword_I02";
                    else if (track == 125) RandomTrack.GameTrack = "god_I01";
                    else if (track == 126) RandomTrack.GameTrack = "god_I02";
                    else if (track == 127) RandomTrack.GameTrack = "god_I03";
                    else if (track == 128) RandomTrack.GameTrack = "abyss_I01";
                    else if (track == 129) RandomTrack.GameTrack = "abyss_I02";
                    else if (track == 130) RandomTrack.GameTrack = "abyss_I03";
                    else if (track == 131) RandomTrack.GameTrack = "camelot_I01";
                    else if (track == 132) RandomTrack.GameTrack = "camelot_I02";
                    else if (track == 133) RandomTrack.GameTrack = "camelot_I03";
                    else if (track == 134) RandomTrack.GameTrack = "olympos_I01";
                    else if (track == 135) RandomTrack.GameTrack = "olympos_I02";
                    else if (track == 136) RandomTrack.GameTrack = "olympos_I03";
                    else if (track == 137) RandomTrack.GameTrack = "korea_I01";
                    else if (track == 138) RandomTrack.GameTrack = "korea_I02";
                    else if (track == 139) RandomTrack.GameTrack = "korea_I03";
                    else if (track == 140) RandomTrack.GameTrack = "korea_I04";
                    else if (track == 141) RandomTrack.GameTrack = "korea_I05";
                    else if (track == 142) RandomTrack.GameTrack = "mabi_I01";
                    else if (track == 143) RandomTrack.GameTrack = "mabi_I02";
                    else if (track == 144) RandomTrack.GameTrack = "maple_I01";
                    else if (track == 145) RandomTrack.GameTrack = "maple_I02";
                    else if (track == 146) RandomTrack.GameTrack = "maple_I03";
                    else if (track == 147) RandomTrack.GameTrack = "desert_I01_rvs";
                    else if (track == 148) RandomTrack.GameTrack = "desert_I02_rvs";
                    else if (track == 149) RandomTrack.GameTrack = "desert_I03_rvs";
                    else if (track == 150) RandomTrack.GameTrack = "desert_I04_rvs";
                    else if (track == 151) RandomTrack.GameTrack = "desert_I05_rvs";
                    else if (track == 152) RandomTrack.GameTrack = "factory_I01_rvs";
                    else if (track == 153) RandomTrack.GameTrack = "factory_I02_rvs";
                    else if (track == 154) RandomTrack.GameTrack = "factory_I03_rvs";
                    else if (track == 155) RandomTrack.GameTrack = "factory_I04_rvs";
                    else if (track == 156) RandomTrack.GameTrack = "fairy_I02_rvs";
                    else if (track == 157) RandomTrack.GameTrack = "fairy_I03_rvs";
                    else if (track == 158) RandomTrack.GameTrack = "forest_I01_rvs";
                    else if (track == 159) RandomTrack.GameTrack = "forest_I02_rvs";
                    else if (track == 160) RandomTrack.GameTrack = "forest_I03_rvs";
                    else if (track == 161) RandomTrack.GameTrack = "forest_I04_rvs";
                    else if (track == 162) RandomTrack.GameTrack = "forest_I05_rvs";
                    else if (track == 163) RandomTrack.GameTrack = "forest_I07_rvs";
                    else if (track == 164) RandomTrack.GameTrack = "ice_I01_rvs";
                    else if (track == 165) RandomTrack.GameTrack = "ice_I02_rvs";
                    else if (track == 166) RandomTrack.GameTrack = "ice_I03_rvs";
                    else if (track == 167) RandomTrack.GameTrack = "ice_I04_rvs";
                    else if (track == 168) RandomTrack.GameTrack = "ice_I05_rvs";
                    else if (track == 169) RandomTrack.GameTrack = "korea_I01_rvs";
                    else if (track == 170) RandomTrack.GameTrack = "korea_I03_rvs";
                    else if (track == 171) RandomTrack.GameTrack = "mabi_I01_rvs";
                    else if (track == 172) RandomTrack.GameTrack = "mine_I01_rvs";
                    else if (track == 173) RandomTrack.GameTrack = "mine_I02_rvs";
                    else if (track == 174) RandomTrack.GameTrack = "northeu_I01_rvs";
                    else if (track == 175) RandomTrack.GameTrack = "northeu_I02_rvs";
                    else if (track == 176) RandomTrack.GameTrack = "northeu_I03_rvs";
                    else if (track == 177) RandomTrack.GameTrack = "northeu_I04_rvs";
                    else if (track == 178) RandomTrack.GameTrack = "northeu_I05_rvs";
                    else if (track == 179) RandomTrack.GameTrack = "northeu_I06_rvs";
                    else if (track == 180) RandomTrack.GameTrack = "northeu_I07_rvs";
                    else if (track == 181) RandomTrack.GameTrack = "pirate_I01_rvs";
                    else if (track == 182) RandomTrack.GameTrack = "pirate_I02_rvs";
                    else if (track == 183) RandomTrack.GameTrack = "pirate_I04_rvs";
                    else if (track == 184) RandomTrack.GameTrack = "tomb_I01_rvs";
                    else if (track == 185) RandomTrack.GameTrack = "village_I01_rvs";
                    else if (track == 186) RandomTrack.GameTrack = "village_I02_rvs";
                    else if (track == 187) RandomTrack.GameTrack = "village_I03_rvs";
                    else if (track == 188) RandomTrack.GameTrack = "village_I04_rvs";
                    else if (track == 189) RandomTrack.GameTrack = "village_I05_rvs";
                    else if (track == 190) RandomTrack.GameTrack = "village_I13_rvs";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 324);
                    if (track == 1) RandomTrack.GameTrack = "forest_I01";
                    else if (track == 2) RandomTrack.GameTrack = "forest_I02";
                    else if (track == 3) RandomTrack.GameTrack = "forest_I03";
                    else if (track == 4) RandomTrack.GameTrack = "forest_I04";
                    else if (track == 5) RandomTrack.GameTrack = "forest_I05";
                    else if (track == 6) RandomTrack.GameTrack = "forest_I06";
                    else if (track == 7) RandomTrack.GameTrack = "forest_I07";
                    else if (track == 8) RandomTrack.GameTrack = "forest_I08";
                    else if (track == 9) RandomTrack.GameTrack = "forest_I09";
                    else if (track == 10) RandomTrack.GameTrack = "forest_R02";
                    else if (track == 11) RandomTrack.GameTrack = "forest_R03";
                    else if (track == 12) RandomTrack.GameTrack = "forest_R04";
                    else if (track == 13) RandomTrack.GameTrack = "forest_R05";
                    else if (track == 14) RandomTrack.GameTrack = "forest_R06";
                    else if (track == 15) RandomTrack.GameTrack = "forest_R07";
                    else if (track == 16) RandomTrack.GameTrack = "desert_I01";
                    else if (track == 17) RandomTrack.GameTrack = "desert_I10";
                    else if (track == 18) RandomTrack.GameTrack = "desert_I02";
                    else if (track == 19) RandomTrack.GameTrack = "desert_I11";
                    else if (track == 20) RandomTrack.GameTrack = "desert_I03";
                    else if (track == 21) RandomTrack.GameTrack = "desert_I04";
                    else if (track == 22) RandomTrack.GameTrack = "desert_I05";
                    else if (track == 23) RandomTrack.GameTrack = "desert_I06";
                    else if (track == 24) RandomTrack.GameTrack = "desert_I07";
                    else if (track == 25) RandomTrack.GameTrack = "desert_I08";
                    else if (track == 26) RandomTrack.GameTrack = "desert_R01";
                    else if (track == 27) RandomTrack.GameTrack = "desert_R02";
                    else if (track == 28) RandomTrack.GameTrack = "desert_R03";
                    else if (track == 29) RandomTrack.GameTrack = "desert_R04";
                    else if (track == 30) RandomTrack.GameTrack = "desert_R06";
                    else if (track == 31) RandomTrack.GameTrack = "village_I01";
                    else if (track == 32) RandomTrack.GameTrack = "village_I02";
                    else if (track == 33) RandomTrack.GameTrack = "village_I11";
                    else if (track == 34) RandomTrack.GameTrack = "village_I03";
                    else if (track == 35) RandomTrack.GameTrack = "village_I04";
                    else if (track == 36) RandomTrack.GameTrack = "village_I05";
                    else if (track == 37) RandomTrack.GameTrack = "village_I14";
                    else if (track == 38) RandomTrack.GameTrack = "village_I06";
                    else if (track == 39) RandomTrack.GameTrack = "village_I07";
                    else if (track == 40) RandomTrack.GameTrack = "village_I08";
                    else if (track == 41) RandomTrack.GameTrack = "village_R01";
                    else if (track == 42) RandomTrack.GameTrack = "village_R10";
                    else if (track == 43) RandomTrack.GameTrack = "village_R02";
                    else if (track == 44) RandomTrack.GameTrack = "village_R11";
                    else if (track == 45) RandomTrack.GameTrack = "village_R03";
                    else if (track == 46) RandomTrack.GameTrack = "village_R12";
                    else if (track == 47) RandomTrack.GameTrack = "village_R04";
                    else if (track == 48) RandomTrack.GameTrack = "village_R13";
                    else if (track == 49) RandomTrack.GameTrack = "village_R05";
                    else if (track == 50) RandomTrack.GameTrack = "village_R14";
                    else if (track == 51) RandomTrack.GameTrack = "village_R06";
                    else if (track == 52) RandomTrack.GameTrack = "village_R07";
                    else if (track == 53) RandomTrack.GameTrack = "ice_I01";
                    else if (track == 54) RandomTrack.GameTrack = "ice_I02";
                    else if (track == 55) RandomTrack.GameTrack = "ice_I03";
                    else if (track == 56) RandomTrack.GameTrack = "ice_I04";
                    else if (track == 57) RandomTrack.GameTrack = "ice_I05";
                    else if (track == 58) RandomTrack.GameTrack = "ice_I06";
                    else if (track == 59) RandomTrack.GameTrack = "ice_I07";
                    else if (track == 60) RandomTrack.GameTrack = "ice_I08";
                    else if (track == 61) RandomTrack.GameTrack = "ice_R01";
                    else if (track == 62) RandomTrack.GameTrack = "ice_R02";
                    else if (track == 63) RandomTrack.GameTrack = "ice_R03";
                    else if (track == 64) RandomTrack.GameTrack = "ice_R04";
                    else if (track == 65) RandomTrack.GameTrack = "ice_R05";
                    else if (track == 66) RandomTrack.GameTrack = "tomb_I01";
                    else if (track == 67) RandomTrack.GameTrack = "tomb_I02";
                    else if (track == 68) RandomTrack.GameTrack = "tomb_I03";
                    else if (track == 69) RandomTrack.GameTrack = "tomb_I04";
                    else if (track == 70) RandomTrack.GameTrack = "tomb_I05";
                    else if (track == 71) RandomTrack.GameTrack = "tomb_I06";
                    else if (track == 72) RandomTrack.GameTrack = "tomb_I07";
                    else if (track == 73) RandomTrack.GameTrack = "tomb_R01";
                    else if (track == 74) RandomTrack.GameTrack = "tomb_R02";
                    else if (track == 75) RandomTrack.GameTrack = "tomb_R03";
                    else if (track == 76) RandomTrack.GameTrack = "tomb_R04";
                    else if (track == 77) RandomTrack.GameTrack = "mine_I01";
                    else if (track == 78) RandomTrack.GameTrack = "mine_I02";
                    else if (track == 79) RandomTrack.GameTrack = "mine_I03";
                    else if (track == 80) RandomTrack.GameTrack = "mine_I04";
                    else if (track == 81) RandomTrack.GameTrack = "mine_I05";
                    else if (track == 82) RandomTrack.GameTrack = "mine_R01";
                    else if (track == 83) RandomTrack.GameTrack = "mine_R02";
                    else if (track == 84) RandomTrack.GameTrack = "mine_R03";
                    else if (track == 85) RandomTrack.GameTrack = "mine_R04";
                    else if (track == 86) RandomTrack.GameTrack = "mine_R05";
                    else if (track == 87) RandomTrack.GameTrack = "northeu_I01";
                    else if (track == 88) RandomTrack.GameTrack = "northeu_I02";
                    else if (track == 89) RandomTrack.GameTrack = "northeu_I03";
                    else if (track == 90) RandomTrack.GameTrack = "northeu_I04";
                    else if (track == 91) RandomTrack.GameTrack = "northeu_I05";
                    else if (track == 92) RandomTrack.GameTrack = "northeu_I06";
                    else if (track == 93) RandomTrack.GameTrack = "northeu_I07";
                    else if (track == 94) RandomTrack.GameTrack = "northeu_I08";
                    else if (track == 95) RandomTrack.GameTrack = "northeu_I09";
                    else if (track == 96) RandomTrack.GameTrack = "northeu_R01";
                    else if (track == 97) RandomTrack.GameTrack = "northeu_R02";
                    else if (track == 98) RandomTrack.GameTrack = "northeu_R03";
                    else if (track == 99) RandomTrack.GameTrack = "factory_I01";
                    else if (track == 100) RandomTrack.GameTrack = "factory_I02";
                    else if (track == 101) RandomTrack.GameTrack = "factory_I03";
                    else if (track == 102) RandomTrack.GameTrack = "factory_I04";
                    else if (track == 103) RandomTrack.GameTrack = "factory_I05";
                    else if (track == 104) RandomTrack.GameTrack = "factory_I06";
                    else if (track == 105) RandomTrack.GameTrack = "factory_I07";
                    else if (track == 106) RandomTrack.GameTrack = "factory_R01";
                    else if (track == 107) RandomTrack.GameTrack = "factory_R02";
                    else if (track == 108) RandomTrack.GameTrack = "factory_R03";
                    else if (track == 109) RandomTrack.GameTrack = "pirate_I01";
                    else if (track == 110) RandomTrack.GameTrack = "pirate_I02";
                    else if (track == 111) RandomTrack.GameTrack = "pirate_I03";
                    else if (track == 112) RandomTrack.GameTrack = "pirate_I04";
                    else if (track == 113) RandomTrack.GameTrack = "pirate_I05";
                    else if (track == 114) RandomTrack.GameTrack = "pirate_R01";
                    else if (track == 115) RandomTrack.GameTrack = "pirate_R02";
                    else if (track == 116) RandomTrack.GameTrack = "pirate_R03";
                    else if (track == 117) RandomTrack.GameTrack = "pirate_R04";
                    else if (track == 118) RandomTrack.GameTrack = "pirate_R05";
                    else if (track == 119) RandomTrack.GameTrack = "fairy_I01";
                    else if (track == 120) RandomTrack.GameTrack = "fairy_I02";
                    else if (track == 121) RandomTrack.GameTrack = "fairy_I03";
                    else if (track == 122) RandomTrack.GameTrack = "fairy_I04";
                    else if (track == 123) RandomTrack.GameTrack = "fairy_I05";
                    else if (track == 124) RandomTrack.GameTrack = "fairy_R01";
                    else if (track == 125) RandomTrack.GameTrack = "fairy_R02";
                    else if (track == 126) RandomTrack.GameTrack = "fairy_R03";
                    else if (track == 127) RandomTrack.GameTrack = "moonhill_I01";
                    else if (track == 128) RandomTrack.GameTrack = "moonhill_I02";
                    else if (track == 129) RandomTrack.GameTrack = "moonhill_I03";
                    else if (track == 130) RandomTrack.GameTrack = "moonhill_I04";
                    else if (track == 131) RandomTrack.GameTrack = "moonhill_I05";
                    else if (track == 132) RandomTrack.GameTrack = "moonhill_R01";
                    else if (track == 133) RandomTrack.GameTrack = "moonhill_R02";
                    else if (track == 134) RandomTrack.GameTrack = "moonhill_R04";
                    else if (track == 135) RandomTrack.GameTrack = "gold_I01";
                    else if (track == 136) RandomTrack.GameTrack = "gold_I02";
                    else if (track == 137) RandomTrack.GameTrack = "gold_I03";
                    else if (track == 138) RandomTrack.GameTrack = "gold_I04";
                    else if (track == 139) RandomTrack.GameTrack = "gold_I05";
                    else if (track == 140) RandomTrack.GameTrack = "gold_I06";
                    else if (track == 141) RandomTrack.GameTrack = "gold_R01";
                    else if (track == 142) RandomTrack.GameTrack = "gold_R02";
                    else if (track == 143) RandomTrack.GameTrack = "china_I01";
                    else if (track == 144) RandomTrack.GameTrack = "china_I02";
                    else if (track == 145) RandomTrack.GameTrack = "china_I03";
                    else if (track == 146) RandomTrack.GameTrack = "china_I04";
                    else if (track == 147) RandomTrack.GameTrack = "china_I05";
                    else if (track == 148) RandomTrack.GameTrack = "china_I07";
                    else if (track == 149) RandomTrack.GameTrack = "china_R01";
                    else if (track == 150) RandomTrack.GameTrack = "china_R02";
                    else if (track == 151) RandomTrack.GameTrack = "china_R03";
                    else if (track == 152) RandomTrack.GameTrack = "china_R04";
                    else if (track == 153) RandomTrack.GameTrack = "china_R05";
                    else if (track == 154) RandomTrack.GameTrack = "china_R07";
                    else if (track == 155) RandomTrack.GameTrack = "castle_I01";
                    else if (track == 156) RandomTrack.GameTrack = "castle_I02";
                    else if (track == 157) RandomTrack.GameTrack = "castle_I03";
                    else if (track == 158) RandomTrack.GameTrack = "castle_I04";
                    else if (track == 159) RandomTrack.GameTrack = "castle_I05";
                    else if (track == 160) RandomTrack.GameTrack = "castle_I06";
                    else if (track == 161) RandomTrack.GameTrack = "castle_R01";
                    else if (track == 162) RandomTrack.GameTrack = "castle_R02";
                    else if (track == 163) RandomTrack.GameTrack = "nymph_I01";
                    else if (track == 164) RandomTrack.GameTrack = "nymph_I02";
                    else if (track == 165) RandomTrack.GameTrack = "nymph_I03";
                    else if (track == 166) RandomTrack.GameTrack = "nymph_I04";
                    else if (track == 167) RandomTrack.GameTrack = "nymph_I05";
                    else if (track == 168) RandomTrack.GameTrack = "nymph_R01";
                    else if (track == 169) RandomTrack.GameTrack = "nymph_R02";
                    else if (track == 170) RandomTrack.GameTrack = "mechanic_I01";
                    else if (track == 171) RandomTrack.GameTrack = "mechanic_I02";
                    else if (track == 172) RandomTrack.GameTrack = "mechanic_R01";
                    else if (track == 173) RandomTrack.GameTrack = "wkc_I01";
                    else if (track == 174) RandomTrack.GameTrack = "wkc_R01";
                    else if (track == 175) RandomTrack.GameTrack = "wkc_R02";
                    else if (track == 176) RandomTrack.GameTrack = "wkc_R11";
                    else if (track == 177) RandomTrack.GameTrack = "wkc_R03";
                    else if (track == 178) RandomTrack.GameTrack = "wkc_R04";
                    else if (track == 179) RandomTrack.GameTrack = "wkc_R05";
                    else if (track == 180) RandomTrack.GameTrack = "wkc_R09";
                    else if (track == 181) RandomTrack.GameTrack = "brodi_I01";
                    else if (track == 182) RandomTrack.GameTrack = "brodi_I02";
                    else if (track == 183) RandomTrack.GameTrack = "brodi_R01";
                    else if (track == 184) RandomTrack.GameTrack = "brodi_R02";
                    else if (track == 185) RandomTrack.GameTrack = "park_I01";
                    else if (track == 186) RandomTrack.GameTrack = "park_R01";
                    else if (track == 187) RandomTrack.GameTrack = "park_R02";
                    else if (track == 188) RandomTrack.GameTrack = "beach_I01";
                    else if (track == 189) RandomTrack.GameTrack = "beach_I02";
                    else if (track == 190) RandomTrack.GameTrack = "beach_I03";
                    else if (track == 191) RandomTrack.GameTrack = "beach_R01";
                    else if (track == 192) RandomTrack.GameTrack = "beach_R02";
                    else if (track == 193) RandomTrack.GameTrack = "beach_R03";
                    else if (track == 194) RandomTrack.GameTrack = "beach_R04";
                    else if (track == 195) RandomTrack.GameTrack = "steam_I01";
                    else if (track == 196) RandomTrack.GameTrack = "steam_R01";
                    else if (track == 197) RandomTrack.GameTrack = "steam_R02";
                    else if (track == 198) RandomTrack.GameTrack = "jurassic_I01";
                    else if (track == 199) RandomTrack.GameTrack = "jurassic_I02";
                    else if (track == 200) RandomTrack.GameTrack = "jurassic_R01";
                    else if (track == 201) RandomTrack.GameTrack = "jurassic_R03";
                    else if (track == 202) RandomTrack.GameTrack = "jurassic_R04";
                    else if (track == 203) RandomTrack.GameTrack = "world_I01";
                    else if (track == 204) RandomTrack.GameTrack = "world_I02";
                    else if (track == 205) RandomTrack.GameTrack = "world_I03";
                    else if (track == 206) RandomTrack.GameTrack = "world_I05";
                    else if (track == 207) RandomTrack.GameTrack = "world_R01";
                    else if (track == 208) RandomTrack.GameTrack = "world_R10";
                    else if (track == 209) RandomTrack.GameTrack = "world_R02";
                    else if (track == 210) RandomTrack.GameTrack = "world_R03";
                    else if (track == 211) RandomTrack.GameTrack = "world_R04";
                    else if (track == 212) RandomTrack.GameTrack = "world_R05";
                    else if (track == 213) RandomTrack.GameTrack = "world_R06";
                    else if (track == 214) RandomTrack.GameTrack = "nemo_I01";
                    else if (track == 215) RandomTrack.GameTrack = "nemo_I02";
                    else if (track == 216) RandomTrack.GameTrack = "nemo_I03";
                    else if (track == 217) RandomTrack.GameTrack = "nemo_R01";
                    else if (track == 218) RandomTrack.GameTrack = "nemo_R02";
                    else if (track == 219) RandomTrack.GameTrack = "nemo_R03";
                    else if (track == 220) RandomTrack.GameTrack = "sword_I01";
                    else if (track == 221) RandomTrack.GameTrack = "sword_I02";
                    else if (track == 222) RandomTrack.GameTrack = "sword_R01";
                    else if (track == 223) RandomTrack.GameTrack = "sword_R02";
                    else if (track == 224) RandomTrack.GameTrack = "sword_R03";
                    else if (track == 225) RandomTrack.GameTrack = "god_I01";
                    else if (track == 226) RandomTrack.GameTrack = "god_I02";
                    else if (track == 227) RandomTrack.GameTrack = "god_I03";
                    else if (track == 228) RandomTrack.GameTrack = "god_R01";
                    else if (track == 229) RandomTrack.GameTrack = "god_R02";
                    else if (track == 230) RandomTrack.GameTrack = "god_R03";
                    else if (track == 231) RandomTrack.GameTrack = "abyss_I01";
                    else if (track == 232) RandomTrack.GameTrack = "abyss_I02";
                    else if (track == 233) RandomTrack.GameTrack = "abyss_I03";
                    else if (track == 234) RandomTrack.GameTrack = "abyss_R01";
                    else if (track == 235) RandomTrack.GameTrack = "abyss_R02";
                    else if (track == 236) RandomTrack.GameTrack = "abyss_R03";
                    else if (track == 237) RandomTrack.GameTrack = "abyss_R04";
                    else if (track == 238) RandomTrack.GameTrack = "abyss_R05";
                    else if (track == 239) RandomTrack.GameTrack = "camelot_I01";
                    else if (track == 240) RandomTrack.GameTrack = "camelot_I02";
                    else if (track == 241) RandomTrack.GameTrack = "camelot_I03";
                    else if (track == 242) RandomTrack.GameTrack = "camelot_R01";
                    else if (track == 243) RandomTrack.GameTrack = "camelot_R02";
                    else if (track == 244) RandomTrack.GameTrack = "camelot_R03";
                    else if (track == 245) RandomTrack.GameTrack = "olympos_I01";
                    else if (track == 246) RandomTrack.GameTrack = "olympos_I02";
                    else if (track == 247) RandomTrack.GameTrack = "olympos_I03";
                    else if (track == 248) RandomTrack.GameTrack = "olympos_R01";
                    else if (track == 249) RandomTrack.GameTrack = "olympos_R02";
                    else if (track == 250) RandomTrack.GameTrack = "korea_I01";
                    else if (track == 251) RandomTrack.GameTrack = "korea_I02";
                    else if (track == 252) RandomTrack.GameTrack = "korea_I03";
                    else if (track == 253) RandomTrack.GameTrack = "korea_I04";
                    else if (track == 254) RandomTrack.GameTrack = "korea_I05";
                    else if (track == 255) RandomTrack.GameTrack = "korea_R01";
                    else if (track == 256) RandomTrack.GameTrack = "korea_R02";
                    else if (track == 257) RandomTrack.GameTrack = "korea_R03";
                    else if (track == 258) RandomTrack.GameTrack = "mabi_I01";
                    else if (track == 259) RandomTrack.GameTrack = "mabi_I02";
                    else if (track == 260) RandomTrack.GameTrack = "mabi_R01";
                    else if (track == 261) RandomTrack.GameTrack = "mabi_R02";
                    else if (track == 262) RandomTrack.GameTrack = "maple_I01";
                    else if (track == 263) RandomTrack.GameTrack = "maple_I02";
                    else if (track == 264) RandomTrack.GameTrack = "maple_I03";
                    else if (track == 265) RandomTrack.GameTrack = "maple_R01";
                    else if (track == 266) RandomTrack.GameTrack = "maple_R02";
                    else if (track == 267) RandomTrack.GameTrack = "maple_R03";
                    else if (track == 268) RandomTrack.GameTrack = "abyss_R02_rvs";
                    else if (track == 269) RandomTrack.GameTrack = "china_R02_rvs";
                    else if (track == 270) RandomTrack.GameTrack = "desert_I01_rvs";
                    else if (track == 271) RandomTrack.GameTrack = "desert_I02_rvs";
                    else if (track == 272) RandomTrack.GameTrack = "desert_I03_rvs";
                    else if (track == 273) RandomTrack.GameTrack = "desert_I04_rvs";
                    else if (track == 274) RandomTrack.GameTrack = "desert_I05_rvs";
                    else if (track == 275) RandomTrack.GameTrack = "desert_R01_rvs";
                    else if (track == 276) RandomTrack.GameTrack = "factory_I01_rvs";
                    else if (track == 277) RandomTrack.GameTrack = "factory_I02_rvs";
                    else if (track == 278) RandomTrack.GameTrack = "factory_I03_rvs";
                    else if (track == 279) RandomTrack.GameTrack = "factory_I04_rvs";
                    else if (track == 280) RandomTrack.GameTrack = "fairy_I02_rvs";
                    else if (track == 281) RandomTrack.GameTrack = "fairy_I03_rvs";
                    else if (track == 282) RandomTrack.GameTrack = "forest_I01_rvs";
                    else if (track == 283) RandomTrack.GameTrack = "forest_I02_rvs";
                    else if (track == 284) RandomTrack.GameTrack = "forest_I03_rvs";
                    else if (track == 285) RandomTrack.GameTrack = "forest_I04_rvs";
                    else if (track == 286) RandomTrack.GameTrack = "forest_I05_rvs";
                    else if (track == 287) RandomTrack.GameTrack = "forest_I07_rvs";
                    else if (track == 288) RandomTrack.GameTrack = "forest_R02_rvs";
                    else if (track == 289) RandomTrack.GameTrack = "ice_I01_rvs";
                    else if (track == 290) RandomTrack.GameTrack = "ice_I02_rvs";
                    else if (track == 291) RandomTrack.GameTrack = "ice_I03_rvs";
                    else if (track == 292) RandomTrack.GameTrack = "ice_I04_rvs";
                    else if (track == 293) RandomTrack.GameTrack = "ice_I05_rvs";
                    else if (track == 294) RandomTrack.GameTrack = "korea_I01_rvs";
                    else if (track == 295) RandomTrack.GameTrack = "korea_I03_rvs";
                    else if (track == 296) RandomTrack.GameTrack = "korea_R01_rvs";
                    else if (track == 297) RandomTrack.GameTrack = "korea_R02_rvs";
                    else if (track == 298) RandomTrack.GameTrack = "korea_R03_rvs";
                    else if (track == 299) RandomTrack.GameTrack = "mabi_I01_rvs";
                    else if (track == 300) RandomTrack.GameTrack = "mabi_R01_rvs";
                    else if (track == 301) RandomTrack.GameTrack = "mine_I01_rvs";
                    else if (track == 302) RandomTrack.GameTrack = "mine_I02_rvs";
                    else if (track == 303) RandomTrack.GameTrack = "northeu_I01_rvs";
                    else if (track == 304) RandomTrack.GameTrack = "northeu_I02_rvs";
                    else if (track == 305) RandomTrack.GameTrack = "northeu_I03_rvs";
                    else if (track == 306) RandomTrack.GameTrack = "northeu_I04_rvs";
                    else if (track == 307) RandomTrack.GameTrack = "northeu_I05_rvs";
                    else if (track == 308) RandomTrack.GameTrack = "northeu_I06_rvs";
                    else if (track == 309) RandomTrack.GameTrack = "northeu_I07_rvs";
                    else if (track == 310) RandomTrack.GameTrack = "pirate_I01_rvs";
                    else if (track == 311) RandomTrack.GameTrack = "pirate_I02_rvs";
                    else if (track == 312) RandomTrack.GameTrack = "pirate_I04_rvs";
                    else if (track == 313) RandomTrack.GameTrack = "pirate_R01_rvs";
                    else if (track == 314) RandomTrack.GameTrack = "tomb_I01_rvs";
                    else if (track == 315) RandomTrack.GameTrack = "tomb_R01_rvs";
                    else if (track == 316) RandomTrack.GameTrack = "village_I01_rvs";
                    else if (track == 317) RandomTrack.GameTrack = "village_I02_rvs";
                    else if (track == 318) RandomTrack.GameTrack = "village_I03_rvs";
                    else if (track == 319) RandomTrack.GameTrack = "village_I04_rvs";
                    else if (track == 320) RandomTrack.GameTrack = "village_I05_rvs";
                    else if (track == 321) RandomTrack.GameTrack = "village_I13_rvs";
                    else if (track == 322) RandomTrack.GameTrack = "village_R01_rvs";
                    else if (track == 323) RandomTrack.GameTrack = "village_R03_rvs";
                }
            }
            else if (RandomTrack.SetRandomTrack == "hot1Random")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 17);
                    if (track == 1) RandomTrack.GameTrack = "desert_I03";
                    else if (track == 2) RandomTrack.GameTrack = "factory_I04";
                    else if (track == 3) RandomTrack.GameTrack = "forest_I01";
                    else if (track == 4) RandomTrack.GameTrack = "forest_I07";
                    else if (track == 5) RandomTrack.GameTrack = "gold_I01";
                    else if (track == 6) RandomTrack.GameTrack = "gold_I03";
                    else if (track == 7) RandomTrack.GameTrack = "ice_I02";
                    else if (track == 8) RandomTrack.GameTrack = "ice_I03";
                    else if (track == 9) RandomTrack.GameTrack = "maple_I02";
                    else if (track == 10) RandomTrack.GameTrack = "northeu_I07";
                    else if (track == 11) RandomTrack.GameTrack = "nymph_I04";
                    else if (track == 12) RandomTrack.GameTrack = "pirate_I02";
                    else if (track == 13) RandomTrack.GameTrack = "sword_I01";
                    else if (track == 14) RandomTrack.GameTrack = "tomb_I04";
                    else if (track == 15) RandomTrack.GameTrack = "village_I04";
                    else if (track == 16) RandomTrack.GameTrack = "village_I05";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 16);
                    if (track == 1) RandomTrack.GameTrack = "china_I01";
                    else if (track == 2) RandomTrack.GameTrack = "china_I02";
                    else if (track == 3) RandomTrack.GameTrack = "desert_I04";
                    else if (track == 4) RandomTrack.GameTrack = "forest_I03";
                    else if (track == 5) RandomTrack.GameTrack = "forest_I04";
                    else if (track == 6) RandomTrack.GameTrack = "forest_I07";
                    else if (track == 7) RandomTrack.GameTrack = "gold_I01";
                    else if (track == 8) RandomTrack.GameTrack = "nemo_I01";
                    else if (track == 9) RandomTrack.GameTrack = "abyss_R05";
                    else if (track == 10) RandomTrack.GameTrack = "steam_R01";
                    else if (track == 11) RandomTrack.GameTrack = "sword_I01";
                    else if (track == 12) RandomTrack.GameTrack = "village_I03";
                    else if (track == 13) RandomTrack.GameTrack = "village_I04";
                    else if (track == 14) RandomTrack.GameTrack = "village_R06";
                    else if (track == 15) RandomTrack.GameTrack = "wkc_R01";
                }
            }
            else if (RandomTrack.SetRandomTrack == "hot2Random")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 21);
                    if (track == 1) RandomTrack.GameTrack = "abyss_I02";
                    else if (track == 2) RandomTrack.GameTrack = "china_I01";
                    else if (track == 3) RandomTrack.GameTrack = "china_I02";
                    else if (track == 4) RandomTrack.GameTrack = "desert_I06";
                    else if (track == 5) RandomTrack.GameTrack = "fairy_I03";
                    else if (track == 6) RandomTrack.GameTrack = "gold_I04";
                    else if (track == 7) RandomTrack.GameTrack = "gold_I05";
                    else if (track == 8) RandomTrack.GameTrack = "ice_I06";
                    else if (track == 9) RandomTrack.GameTrack = "ice_I07";
                    else if (track == 10) RandomTrack.GameTrack = "korea_I02";
                    else if (track == 11) RandomTrack.GameTrack = "korea_I04";
                    else if (track == 12) RandomTrack.GameTrack = "mabi_I01";
                    else if (track == 13) RandomTrack.GameTrack = "maple_I01";
                    else if (track == 14) RandomTrack.GameTrack = "maple_I02";
                    else if (track == 15) RandomTrack.GameTrack = "nemo_I02";
                    else if (track == 16) RandomTrack.GameTrack = "northeu_I05";
                    else if (track == 17) RandomTrack.GameTrack = "northeu_I06";
                    else if (track == 18) RandomTrack.GameTrack = "nymph_I04";
                    else if (track == 19) RandomTrack.GameTrack = "nymph_I05";
                    else if (track == 20) RandomTrack.GameTrack = "pirate_I02";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 21);
                    if (track == 1) RandomTrack.GameTrack = "abyss_R05";
                    else if (track == 2) RandomTrack.GameTrack = "beach_I02";
                    else if (track == 3) RandomTrack.GameTrack = "beach_R01";
                    else if (track == 4) RandomTrack.GameTrack = "china_I01";
                    else if (track == 5) RandomTrack.GameTrack = "china_I02";
                    else if (track == 6) RandomTrack.GameTrack = "china_R07";
                    else if (track == 7) RandomTrack.GameTrack = "god_R02";
                    else if (track == 8) RandomTrack.GameTrack = "jurassic_R04";
                    else if (track == 9) RandomTrack.GameTrack = "korea_R03";
                    else if (track == 10) RandomTrack.GameTrack = "maple_R01";
                    else if (track == 11) RandomTrack.GameTrack = "maple_R02";
                    else if (track == 12) RandomTrack.GameTrack = "park_R01";
                    else if (track == 13) RandomTrack.GameTrack = "steam_R01";
                    else if (track == 14) RandomTrack.GameTrack = "village_R01";
                    else if (track == 15) RandomTrack.GameTrack = "village_R06";
                    else if (track == 16) RandomTrack.GameTrack = "village_R12";
                    else if (track == 17) RandomTrack.GameTrack = "wkc_R01";
                    else if (track == 18) RandomTrack.GameTrack = "wkc_R04";
                    else if (track == 19) RandomTrack.GameTrack = "world_R01";
                    else if (track == 20) RandomTrack.GameTrack = "world_R02";
                }
            }
            else if (RandomTrack.SetRandomTrack == "hot3Random")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 26);
                    if (track == 1) RandomTrack.GameTrack = "village_I14";
                    else if (track == 2) RandomTrack.GameTrack = "camelot_I02";
                    else if (track == 3) RandomTrack.GameTrack = "desert_I08";
                    else if (track == 4) RandomTrack.GameTrack = "desert_I10";
                    else if (track == 5) RandomTrack.GameTrack = "fairy_I02";
                    else if (track == 6) RandomTrack.GameTrack = "god_I02";
                    else if (track == 7) RandomTrack.GameTrack = "gold_I04";
                    else if (track == 8) RandomTrack.GameTrack = "ice_I05";
                    else if (track == 9) RandomTrack.GameTrack = "desert_I11";
                    else if (track == 10) RandomTrack.GameTrack = "jurassic_I02";
                    else if (track == 11) RandomTrack.GameTrack = "korea_I03";
                    else if (track == 12) RandomTrack.GameTrack = "forest_I09";
                    else if (track == 13) RandomTrack.GameTrack = "maple_I01";
                    else if (track == 14) RandomTrack.GameTrack = "mine_I04";
                    else if (track == 15) RandomTrack.GameTrack = "northeu_I05";
                    else if (track == 16) RandomTrack.GameTrack = "northeu_I06";
                    else if (track == 17) RandomTrack.GameTrack = "olympos_I01";
                    else if (track == 18) RandomTrack.GameTrack = "olympos_I03";
                    else if (track == 19) RandomTrack.GameTrack = "pirate_I02";
                    else if (track == 20) RandomTrack.GameTrack = "tomb_I01";
                    else if (track == 21) RandomTrack.GameTrack = "tomb_I02";
                    else if (track == 22) RandomTrack.GameTrack = "tomb_I05";
                    else if (track == 23) RandomTrack.GameTrack = "tomb_I06";
                    else if (track == 24) RandomTrack.GameTrack = "village_I01";
                    else if (track == 25) RandomTrack.GameTrack = "world_I01";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 26);
                    if (track == 1) RandomTrack.GameTrack = "beach_R01";
                    else if (track == 2) RandomTrack.GameTrack = "brodi_R01";
                    else if (track == 3) RandomTrack.GameTrack = "china_R03";
                    else if (track == 4) RandomTrack.GameTrack = "china_R05";
                    else if (track == 5) RandomTrack.GameTrack = "china_R07";
                    else if (track == 6) RandomTrack.GameTrack = "god_R02";
                    else if (track == 7) RandomTrack.GameTrack = "jurassic_R03";
                    else if (track == 8) RandomTrack.GameTrack = "jurassic_R04";
                    else if (track == 9) RandomTrack.GameTrack = "korea_R03";
                    else if (track == 10) RandomTrack.GameTrack = "maple_R01";
                    else if (track == 11) RandomTrack.GameTrack = "maple_R02";
                    else if (track == 12) RandomTrack.GameTrack = "village_R14";
                    else if (track == 13) RandomTrack.GameTrack = "nemo_R01";
                    else if (track == 14) RandomTrack.GameTrack = "forest_R07";
                    else if (track == 15) RandomTrack.GameTrack = "northeu_R03";
                    else if (track == 16) RandomTrack.GameTrack = "desert_R06";
                    else if (track == 17) RandomTrack.GameTrack = "village_R01";
                    else if (track == 18) RandomTrack.GameTrack = "village_R07";
                    else if (track == 19) RandomTrack.GameTrack = "village_R12";
                    else if (track == 20) RandomTrack.GameTrack = "wkc_R02";
                    else if (track == 21) RandomTrack.GameTrack = "wkc_R04";
                    else if (track == 22) RandomTrack.GameTrack = "world_R01";
                    else if (track == 23) RandomTrack.GameTrack = "world_R02";
                    else if (track == 24) RandomTrack.GameTrack = "world_R06";
                    else if (track == 25) RandomTrack.GameTrack = "world_R10";
                }
            }
            else if (RandomTrack.SetRandomTrack == "hot4Random")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 31);
                    if (track == 1) RandomTrack.GameTrack = "beach_I01";
                    else if (track == 2) RandomTrack.GameTrack = "camelot_I02";
                    else if (track == 3) RandomTrack.GameTrack = "castle_I02";
                    else if (track == 4) RandomTrack.GameTrack = "castle_I05";
                    else if (track == 5) RandomTrack.GameTrack = "china_C01";
                    else if (track == 6) RandomTrack.GameTrack = "china_I05";
                    else if (track == 7) RandomTrack.GameTrack = "desert_I11";
                    else if (track == 8) RandomTrack.GameTrack = "desert_I05";
                    else if (track == 9) RandomTrack.GameTrack = "desert_I08";
                    else if (track == 10) RandomTrack.GameTrack = "factory_I02";
                    else if (track == 11) RandomTrack.GameTrack = "factory_I03";
                    else if (track == 12) RandomTrack.GameTrack = "fairy_I04";
                    else if (track == 13) RandomTrack.GameTrack = "forest_I06";
                    else if (track == 14) RandomTrack.GameTrack = "god_I02";
                    else if (track == 15) RandomTrack.GameTrack = "gold_I06";
                    else if (track == 16) RandomTrack.GameTrack = "ice_I05";
                    else if (track == 17) RandomTrack.GameTrack = "jurassic_I01";
                    else if (track == 18) RandomTrack.GameTrack = "jurassic_I02";
                    else if (track == 19) RandomTrack.GameTrack = "korea_I03";
                    else if (track == 20) RandomTrack.GameTrack = "korea_I03_rvs";
                    else if (track == 21) RandomTrack.GameTrack = "korea_I05";
                    else if (track == 22) RandomTrack.GameTrack = "mine_C04";
                    else if (track == 23) RandomTrack.GameTrack = "mine_I01";
                    else if (track == 24) RandomTrack.GameTrack = "mine_I02";
                    else if (track == 25) RandomTrack.GameTrack = "tomb_I01";
                    else if (track == 26) RandomTrack.GameTrack = "tomb_I02";
                    else if (track == 27) RandomTrack.GameTrack = "tomb_I06";
                    else if (track == 28) RandomTrack.GameTrack = "village_I01";
                    else if (track == 29) RandomTrack.GameTrack = "village_I06";
                    else if (track == 30) RandomTrack.GameTrack = "world_I01";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 31);
                    if (track == 1) RandomTrack.GameTrack = "brodi_R01";
                    else if (track == 2) RandomTrack.GameTrack = "camelot_R02";
                    else if (track == 3) RandomTrack.GameTrack = "china_R01";
                    else if (track == 4) RandomTrack.GameTrack = "china_R02";
                    else if (track == 5) RandomTrack.GameTrack = "village_R14";
                    else if (track == 6) RandomTrack.GameTrack = "desert_R04";
                    else if (track == 7) RandomTrack.GameTrack = "factory_R03";
                    else if (track == 8) RandomTrack.GameTrack = "fairy_R02";
                    else if (track == 9) RandomTrack.GameTrack = "forest_R05";
                    else if (track == 10) RandomTrack.GameTrack = "forest_R06";
                    else if (track == 11) RandomTrack.GameTrack = "gold_R01";
                    else if (track == 12) RandomTrack.GameTrack = "ice_R03";
                    else if (track == 13) RandomTrack.GameTrack = "korea_R01";
                    else if (track == 14) RandomTrack.GameTrack = "korea_R02";
                    else if (track == 15) RandomTrack.GameTrack = "mabi_R01";
                    else if (track == 16) RandomTrack.GameTrack = "mechanic_R01";
                    else if (track == 17) RandomTrack.GameTrack = "mine_R04";
                    else if (track == 18) RandomTrack.GameTrack = "moonhill_R01";
                    else if (track == 19) RandomTrack.GameTrack = "northeu_R02";
                    else if (track == 20) RandomTrack.GameTrack = "nymph_R01";
                    else if (track == 21) RandomTrack.GameTrack = "olympos_R01";
                    else if (track == 22) RandomTrack.GameTrack = "olympos_R02";
                    else if (track == 23) RandomTrack.GameTrack = "pirate_R01";
                    else if (track == 24) RandomTrack.GameTrack = "pirate_R03";
                    else if (track == 25) RandomTrack.GameTrack = "sword_R01";
                    else if (track == 26) RandomTrack.GameTrack = "village_R05";
                    else if (track == 27) RandomTrack.GameTrack = "village_R07";
                    else if (track == 28) RandomTrack.GameTrack = "village_R11";
                    else if (track == 29) RandomTrack.GameTrack = "wkc_R02";
                    else if (track == 30) RandomTrack.GameTrack = "world_R06";
                }
            }
            else if (RandomTrack.SetRandomTrack == "hot5Random")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 31);
                    if (track == 1) RandomTrack.GameTrack = "beach_I01";
                    else if (track == 2) RandomTrack.GameTrack = "castle_I05";
                    else if (track == 3) RandomTrack.GameTrack = "china_C01";
                    else if (track == 4) RandomTrack.GameTrack = "china_I05";
                    else if (track == 5) RandomTrack.GameTrack = "desert_I02";
                    else if (track == 6) RandomTrack.GameTrack = "desert_I02_rvs";
                    else if (track == 7) RandomTrack.GameTrack = "desert_I05";
                    else if (track == 8) RandomTrack.GameTrack = "desert_I05_rvs";
                    else if (track == 9) RandomTrack.GameTrack = "factory_I02";
                    else if (track == 10) RandomTrack.GameTrack = "factory_I03";
                    else if (track == 11) RandomTrack.GameTrack = "factory_I07";
                    else if (track == 12) RandomTrack.GameTrack = "fairy_I04";
                    else if (track == 13) RandomTrack.GameTrack = "forest_I06";
                    else if (track == 14) RandomTrack.GameTrack = "god_I02";
                    else if (track == 15) RandomTrack.GameTrack = "ice_I05";
                    else if (track == 16) RandomTrack.GameTrack = "ice_I05_rvs";
                    else if (track == 17) RandomTrack.GameTrack = "jurassic_I01";
                    else if (track == 18) RandomTrack.GameTrack = "jurassic_I02";
                    else if (track == 19) RandomTrack.GameTrack = "korea_I03_rvs";
                    else if (track == 20) RandomTrack.GameTrack = "mine_C04";
                    else if (track == 21) RandomTrack.GameTrack = "mine_I01";
                    else if (track == 22) RandomTrack.GameTrack = "mine_I01_rvs";
                    else if (track == 23) RandomTrack.GameTrack = "mine_I02";
                    else if (track == 24) RandomTrack.GameTrack = "mine_I02_rvs";
                    else if (track == 25) RandomTrack.GameTrack = "tomb_I01";
                    else if (track == 26) RandomTrack.GameTrack = "tomb_I01_rvs";
                    else if (track == 27) RandomTrack.GameTrack = "tomb_I02";
                    else if (track == 28) RandomTrack.GameTrack = "tomb_I07";
                    else if (track == 29) RandomTrack.GameTrack = "village_I01";
                    else if (track == 30) RandomTrack.GameTrack = "village_I06";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 31);
                    if (track == 1) RandomTrack.GameTrack = "abyss_R01";
                    else if (track == 2) RandomTrack.GameTrack = "abyss_R02";
                    else if (track == 3) RandomTrack.GameTrack = "abyss_R02_rvs";
                    else if (track == 4) RandomTrack.GameTrack = "castle_R01";
                    else if (track == 5) RandomTrack.GameTrack = "desert_R01";
                    else if (track == 6) RandomTrack.GameTrack = "desert_R01_rvs";
                    else if (track == 7) RandomTrack.GameTrack = "factory_R01";
                    else if (track == 8) RandomTrack.GameTrack = "fairy_R01";
                    else if (track == 9) RandomTrack.GameTrack = "fairy_R03";
                    else if (track == 10) RandomTrack.GameTrack = "forest_R02";
                    else if (track == 11) RandomTrack.GameTrack = "forest_R02_rvs";
                    else if (track == 12) RandomTrack.GameTrack = "forest_R03";
                    else if (track == 13) RandomTrack.GameTrack = "forest_R04";
                    else if (track == 14) RandomTrack.GameTrack = "gold_R01";
                    else if (track == 15) RandomTrack.GameTrack = "gold_R02";
                    else if (track == 16) RandomTrack.GameTrack = "ice_I01";
                    else if (track == 17) RandomTrack.GameTrack = "ice_R01";
                    else if (track == 18) RandomTrack.GameTrack = "ice_R02";
                    else if (track == 19) RandomTrack.GameTrack = "jurassic_R01";
                    else if (track == 20) RandomTrack.GameTrack = "mine_R01";
                    else if (track == 21) RandomTrack.GameTrack = "mine_R02";
                    else if (track == 22) RandomTrack.GameTrack = "mine_R03";
                    else if (track == 23) RandomTrack.GameTrack = "moonhill_R02";
                    else if (track == 24) RandomTrack.GameTrack = "northeu_R01";
                    else if (track == 25) RandomTrack.GameTrack = "pirate_R01_rvs";
                    else if (track == 26) RandomTrack.GameTrack = "pirate_R02";
                    else if (track == 27) RandomTrack.GameTrack = "pirate_R04";
                    else if (track == 28) RandomTrack.GameTrack = "tomb_R02";
                    else if (track == 29) RandomTrack.GameTrack = "tomb_R03";
                    else if (track == 30) RandomTrack.GameTrack = "village_R03";
                }
            }
            else if (RandomTrack.SetRandomTrack == "newRandom")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 11);
                    if (track == 1) RandomTrack.GameTrack = "village_I14";
                    else if (track == 2) RandomTrack.GameTrack = "forest_I09";
                    else if (track == 3) RandomTrack.GameTrack = "desert_I11";
                    else if (track == 4) RandomTrack.GameTrack = "nymph_I04";
                    else if (track == 5) RandomTrack.GameTrack = "nymph_I05";
                    else if (track == 6) RandomTrack.GameTrack = "maple_I03";
                    else if (track == 7) RandomTrack.GameTrack = "maple_I01";
                    else if (track == 8) RandomTrack.GameTrack = "maple_I02";
                    else if (track == 9) RandomTrack.GameTrack = "korea_I05";
                    else if (track == 10) RandomTrack.GameTrack = "desert_I10";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 11);
                    if (track == 1) RandomTrack.GameTrack = "village_I14";
                    else if (track == 2) RandomTrack.GameTrack = "forest_R07";
                    else if (track == 3) RandomTrack.GameTrack = "desert_R06";
                    else if (track == 4) RandomTrack.GameTrack = "forest_I09";
                    else if (track == 5) RandomTrack.GameTrack = "desert_I11";
                    else if (track == 6) RandomTrack.GameTrack = "village_R14";
                    else if (track == 7) RandomTrack.GameTrack = "nymph_I04";
                    else if (track == 8) RandomTrack.GameTrack = "nymph_I05";
                    else if (track == 9) RandomTrack.GameTrack = "maple_R03";
                    else if (track == 10) RandomTrack.GameTrack = "maple_I03";
                }
            }
            else if (RandomTrack.SetRandomTrack == "reverseRandom")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 45);
                    if (track == 1) RandomTrack.GameTrack = "desert_I01_rvs";
                    else if (track == 2) RandomTrack.GameTrack = "desert_I02_rvs";
                    else if (track == 3) RandomTrack.GameTrack = "desert_I03_rvs";
                    else if (track == 4) RandomTrack.GameTrack = "desert_I04_rvs";
                    else if (track == 5) RandomTrack.GameTrack = "desert_I05_rvs";
                    else if (track == 6) RandomTrack.GameTrack = "factory_I01_rvs";
                    else if (track == 7) RandomTrack.GameTrack = "factory_I02_rvs";
                    else if (track == 8) RandomTrack.GameTrack = "factory_I03_rvs";
                    else if (track == 9) RandomTrack.GameTrack = "factory_I04_rvs";
                    else if (track == 10) RandomTrack.GameTrack = "fairy_I02_rvs";
                    else if (track == 11) RandomTrack.GameTrack = "fairy_I03_rvs";
                    else if (track == 12) RandomTrack.GameTrack = "forest_I01_rvs";
                    else if (track == 13) RandomTrack.GameTrack = "forest_I02_rvs";
                    else if (track == 14) RandomTrack.GameTrack = "forest_I03_rvs";
                    else if (track == 15) RandomTrack.GameTrack = "forest_I04_rvs";
                    else if (track == 16) RandomTrack.GameTrack = "forest_I05_rvs";
                    else if (track == 17) RandomTrack.GameTrack = "forest_I07_rvs";
                    else if (track == 18) RandomTrack.GameTrack = "ice_I01_rvs";
                    else if (track == 19) RandomTrack.GameTrack = "ice_I02_rvs";
                    else if (track == 20) RandomTrack.GameTrack = "ice_I03_rvs";
                    else if (track == 21) RandomTrack.GameTrack = "ice_I04_rvs";
                    else if (track == 22) RandomTrack.GameTrack = "ice_I05_rvs";
                    else if (track == 23) RandomTrack.GameTrack = "korea_I01_rvs";
                    else if (track == 24) RandomTrack.GameTrack = "korea_I03_rvs";
                    else if (track == 25) RandomTrack.GameTrack = "mabi_I01_rvs";
                    else if (track == 26) RandomTrack.GameTrack = "mine_I01_rvs";
                    else if (track == 27) RandomTrack.GameTrack = "mine_I02_rvs";
                    else if (track == 28) RandomTrack.GameTrack = "northeu_I01_rvs";
                    else if (track == 29) RandomTrack.GameTrack = "northeu_I02_rvs";
                    else if (track == 30) RandomTrack.GameTrack = "northeu_I03_rvs";
                    else if (track == 31) RandomTrack.GameTrack = "northeu_I04_rvs";
                    else if (track == 32) RandomTrack.GameTrack = "northeu_I05_rvs";
                    else if (track == 33) RandomTrack.GameTrack = "northeu_I06_rvs";
                    else if (track == 34) RandomTrack.GameTrack = "northeu_I07_rvs";
                    else if (track == 35) RandomTrack.GameTrack = "pirate_I01_rvs";
                    else if (track == 36) RandomTrack.GameTrack = "pirate_I02_rvs";
                    else if (track == 37) RandomTrack.GameTrack = "pirate_I04_rvs";
                    else if (track == 38) RandomTrack.GameTrack = "tomb_I01_rvs";
                    else if (track == 39) RandomTrack.GameTrack = "village_I01_rvs";
                    else if (track == 40) RandomTrack.GameTrack = "village_I02_rvs";
                    else if (track == 41) RandomTrack.GameTrack = "village_I03_rvs";
                    else if (track == 42) RandomTrack.GameTrack = "village_I04_rvs";
                    else if (track == 43) RandomTrack.GameTrack = "village_I05_rvs";
                    else if (track == 44) RandomTrack.GameTrack = "village_I13_rvs";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 57);
                    if (track == 1) RandomTrack.GameTrack = "abyss_R02_rvs";
                    else if (track == 2) RandomTrack.GameTrack = "china_R02_rvs";
                    else if (track == 3) RandomTrack.GameTrack = "desert_I01_rvs";
                    else if (track == 4) RandomTrack.GameTrack = "desert_I02_rvs";
                    else if (track == 5) RandomTrack.GameTrack = "desert_I03_rvs";
                    else if (track == 6) RandomTrack.GameTrack = "desert_I04_rvs";
                    else if (track == 7) RandomTrack.GameTrack = "desert_I05_rvs";
                    else if (track == 8) RandomTrack.GameTrack = "desert_R01_rvs";
                    else if (track == 9) RandomTrack.GameTrack = "factory_I01_rvs";
                    else if (track == 10) RandomTrack.GameTrack = "factory_I02_rvs";
                    else if (track == 11) RandomTrack.GameTrack = "factory_I03_rvs";
                    else if (track == 12) RandomTrack.GameTrack = "factory_I04_rvs";
                    else if (track == 13) RandomTrack.GameTrack = "fairy_I02_rvs";
                    else if (track == 14) RandomTrack.GameTrack = "fairy_I03_rvs";
                    else if (track == 15) RandomTrack.GameTrack = "forest_I01_rvs";
                    else if (track == 16) RandomTrack.GameTrack = "forest_I02_rvs";
                    else if (track == 17) RandomTrack.GameTrack = "forest_I03_rvs";
                    else if (track == 18) RandomTrack.GameTrack = "forest_I04_rvs";
                    else if (track == 19) RandomTrack.GameTrack = "forest_I05_rvs";
                    else if (track == 20) RandomTrack.GameTrack = "forest_I07_rvs";
                    else if (track == 21) RandomTrack.GameTrack = "forest_R02_rvs";
                    else if (track == 22) RandomTrack.GameTrack = "ice_I01_rvs";
                    else if (track == 23) RandomTrack.GameTrack = "ice_I02_rvs";
                    else if (track == 24) RandomTrack.GameTrack = "ice_I03_rvs";
                    else if (track == 25) RandomTrack.GameTrack = "ice_I04_rvs";
                    else if (track == 26) RandomTrack.GameTrack = "ice_I05_rvs";
                    else if (track == 27) RandomTrack.GameTrack = "korea_I01_rvs";
                    else if (track == 28) RandomTrack.GameTrack = "korea_I03_rvs";
                    else if (track == 29) RandomTrack.GameTrack = "korea_R01_rvs";
                    else if (track == 30) RandomTrack.GameTrack = "korea_R02_rvs";
                    else if (track == 31) RandomTrack.GameTrack = "korea_R03_rvs";
                    else if (track == 32) RandomTrack.GameTrack = "mabi_I01_rvs";
                    else if (track == 33) RandomTrack.GameTrack = "mabi_R01_rvs";
                    else if (track == 34) RandomTrack.GameTrack = "mine_I01_rvs";
                    else if (track == 35) RandomTrack.GameTrack = "mine_I02_rvs";
                    else if (track == 36) RandomTrack.GameTrack = "northeu_I01_rvs";
                    else if (track == 37) RandomTrack.GameTrack = "northeu_I02_rvs";
                    else if (track == 38) RandomTrack.GameTrack = "northeu_I03_rvs";
                    else if (track == 39) RandomTrack.GameTrack = "northeu_I04_rvs";
                    else if (track == 40) RandomTrack.GameTrack = "northeu_I05_rvs";
                    else if (track == 41) RandomTrack.GameTrack = "northeu_I06_rvs";
                    else if (track == 42) RandomTrack.GameTrack = "northeu_I07_rvs";
                    else if (track == 43) RandomTrack.GameTrack = "pirate_I01_rvs";
                    else if (track == 44) RandomTrack.GameTrack = "pirate_I02_rvs";
                    else if (track == 45) RandomTrack.GameTrack = "pirate_I04_rvs";
                    else if (track == 46) RandomTrack.GameTrack = "pirate_R01_rvs";
                    else if (track == 47) RandomTrack.GameTrack = "tomb_I01_rvs";
                    else if (track == 48) RandomTrack.GameTrack = "tomb_R01_rvs";
                    else if (track == 49) RandomTrack.GameTrack = "village_I01_rvs";
                    else if (track == 50) RandomTrack.GameTrack = "village_I02_rvs";
                    else if (track == 51) RandomTrack.GameTrack = "village_I03_rvs";
                    else if (track == 52) RandomTrack.GameTrack = "village_I04_rvs";
                    else if (track == 53) RandomTrack.GameTrack = "village_I05_rvs";
                    else if (track == 54) RandomTrack.GameTrack = "village_I13_rvs";
                    else if (track == 55) RandomTrack.GameTrack = "village_R01_rvs";
                    else if (track == 56) RandomTrack.GameTrack = "village_R03_rvs";
                }
            }
            else if (RandomTrack.SetRandomTrack == "newLeagueRandom")
            {
                if (RandomTrack.GameType == "item")
                {
                    int track = random.Next(1, 17);
                    if (track == 1) RandomTrack.GameTrack = "china_C01";
                    else if (track == 2) RandomTrack.GameTrack = "desert_I02_rvs";
                    else if (track == 3) RandomTrack.GameTrack = "factory_I05";
                    else if (track == 4) RandomTrack.GameTrack = "fairy_I02";
                    else if (track == 5) RandomTrack.GameTrack = "forest_I06";
                    else if (track == 6) RandomTrack.GameTrack = "gold_I02";
                    else if (track == 7) RandomTrack.GameTrack = "ice_I05";
                    else if (track == 8) RandomTrack.GameTrack = "korea_I03";
                    else if (track == 9) RandomTrack.GameTrack = "korea_I05";
                    else if (track == 10) RandomTrack.GameTrack = "mabi_I01";
                    else if (track == 11) RandomTrack.GameTrack = "mine_C04";
                    else if (track == 12) RandomTrack.GameTrack = "mine_I01";
                    else if (track == 13) RandomTrack.GameTrack = "mine_I02";
                    else if (track == 14) RandomTrack.GameTrack = "northeu_I06";
                    else if (track == 15) RandomTrack.GameTrack = "tomb_I05";
                    else if (track == 16) RandomTrack.GameTrack = "tomb_I07";
                }
                else if (RandomTrack.GameType == "speed")
                {
                    int track = random.Next(1, 33);
                    if (track == 1) RandomTrack.GameTrack = "abyss_R01";
                    else if (track == 2) RandomTrack.GameTrack = "castle_R01";
                    else if (track == 3) RandomTrack.GameTrack = "china_R02_rvs";
                    else if (track == 4) RandomTrack.GameTrack = "fairy_R01";
                    else if (track == 5) RandomTrack.GameTrack = "forest_R05";
                    else if (track == 6) RandomTrack.GameTrack = "god_R03";
                    else if (track == 7) RandomTrack.GameTrack = "gold_R01";
                    else if (track == 8) RandomTrack.GameTrack = "ice_R02";
                    else if (track == 9) RandomTrack.GameTrack = "jurassic_R01";
                    else if (track == 10) RandomTrack.GameTrack = "korea_R01";
                    else if (track == 11) RandomTrack.GameTrack = "korea_R02";
                    else if (track == 12) RandomTrack.GameTrack = "mabi_R01";
                    else if (track == 13) RandomTrack.GameTrack = "maple_R02";
                    else if (track == 14) RandomTrack.GameTrack = "maple_R03";
                    else if (track == 15) RandomTrack.GameTrack = "mechanic_R01";
                    else if (track == 16) RandomTrack.GameTrack = "mine_R03";
                    else if (track == 17) RandomTrack.GameTrack = "moonhill_R01";
                    else if (track == 18) RandomTrack.GameTrack = "moonhill_R02";
                    else if (track == 19) RandomTrack.GameTrack = "moonhill_R04";
                    else if (track == 20) RandomTrack.GameTrack = "nemo_R03";
                    else if (track == 21) RandomTrack.GameTrack = "northeu_R01";
                    else if (track == 22) RandomTrack.GameTrack = "northeu_R02";
                    else if (track == 23) RandomTrack.GameTrack = "northeu_R03";
                    else if (track == 24) RandomTrack.GameTrack = "olympos_R01";
                    else if (track == 25) RandomTrack.GameTrack = "olympos_R02";
                    else if (track == 26) RandomTrack.GameTrack = "pirate_R02";
                    else if (track == 27) RandomTrack.GameTrack = "pirate_R04";
                    else if (track == 28) RandomTrack.GameTrack = "sword_R02";
                    else if (track == 29) RandomTrack.GameTrack = "tomb_R02";
                    else if (track == 30) RandomTrack.GameTrack = "tomb_R03";
                    else if (track == 31) RandomTrack.GameTrack = "wkc_R02";
                    else if (track == 32) RandomTrack.GameTrack = "world_R06";
                }
            }
            else if (RandomTrack.SetRandomTrack == "speedAllRandom")
            {
                int track = random.Next(1, 122);
                if (track == 1) RandomTrack.GameTrack = "forest_R02";
                else if (track == 2) RandomTrack.GameTrack = "forest_R03";
                else if (track == 3) RandomTrack.GameTrack = "forest_R04";
                else if (track == 4) RandomTrack.GameTrack = "forest_R05";
                else if (track == 5) RandomTrack.GameTrack = "forest_R06";
                else if (track == 6) RandomTrack.GameTrack = "forest_R07";
                else if (track == 7) RandomTrack.GameTrack = "desert_R01";
                else if (track == 8) RandomTrack.GameTrack = "desert_R02";
                else if (track == 9) RandomTrack.GameTrack = "desert_R03";
                else if (track == 10) RandomTrack.GameTrack = "desert_R04";
                else if (track == 11) RandomTrack.GameTrack = "desert_R06";
                else if (track == 12) RandomTrack.GameTrack = "village_R01";
                else if (track == 13) RandomTrack.GameTrack = "village_R10";
                else if (track == 14) RandomTrack.GameTrack = "village_R02";
                else if (track == 15) RandomTrack.GameTrack = "village_R11";
                else if (track == 16) RandomTrack.GameTrack = "village_R03";
                else if (track == 17) RandomTrack.GameTrack = "village_R12";
                else if (track == 18) RandomTrack.GameTrack = "village_R04";
                else if (track == 19) RandomTrack.GameTrack = "village_R13";
                else if (track == 20) RandomTrack.GameTrack = "village_R05";
                else if (track == 21) RandomTrack.GameTrack = "village_R14";
                else if (track == 22) RandomTrack.GameTrack = "village_R06";
                else if (track == 23) RandomTrack.GameTrack = "village_R07";
                else if (track == 24) RandomTrack.GameTrack = "ice_R01";
                else if (track == 25) RandomTrack.GameTrack = "ice_R02";
                else if (track == 26) RandomTrack.GameTrack = "ice_R03";
                else if (track == 27) RandomTrack.GameTrack = "ice_R04";
                else if (track == 28) RandomTrack.GameTrack = "ice_R05";
                else if (track == 29) RandomTrack.GameTrack = "tomb_R01";
                else if (track == 30) RandomTrack.GameTrack = "tomb_R02";
                else if (track == 31) RandomTrack.GameTrack = "tomb_R03";
                else if (track == 32) RandomTrack.GameTrack = "tomb_R04";
                else if (track == 33) RandomTrack.GameTrack = "mine_R01";
                else if (track == 34) RandomTrack.GameTrack = "mine_R02";
                else if (track == 35) RandomTrack.GameTrack = "mine_R03";
                else if (track == 36) RandomTrack.GameTrack = "mine_R04";
                else if (track == 37) RandomTrack.GameTrack = "mine_R05";
                else if (track == 38) RandomTrack.GameTrack = "northeu_R01";
                else if (track == 39) RandomTrack.GameTrack = "northeu_R02";
                else if (track == 40) RandomTrack.GameTrack = "northeu_R03";
                else if (track == 41) RandomTrack.GameTrack = "factory_R01";
                else if (track == 42) RandomTrack.GameTrack = "factory_R02";
                else if (track == 43) RandomTrack.GameTrack = "factory_R03";
                else if (track == 44) RandomTrack.GameTrack = "pirate_R01";
                else if (track == 45) RandomTrack.GameTrack = "pirate_R02";
                else if (track == 46) RandomTrack.GameTrack = "pirate_R03";
                else if (track == 47) RandomTrack.GameTrack = "pirate_R04";
                else if (track == 48) RandomTrack.GameTrack = "pirate_R05";
                else if (track == 49) RandomTrack.GameTrack = "fairy_R01";
                else if (track == 50) RandomTrack.GameTrack = "fairy_R02";
                else if (track == 51) RandomTrack.GameTrack = "fairy_R03";
                else if (track == 52) RandomTrack.GameTrack = "moonhill_R01";
                else if (track == 53) RandomTrack.GameTrack = "moonhill_R02";
                else if (track == 54) RandomTrack.GameTrack = "moonhill_R04";
                else if (track == 55) RandomTrack.GameTrack = "gold_R01";
                else if (track == 56) RandomTrack.GameTrack = "gold_R02";
                else if (track == 57) RandomTrack.GameTrack = "china_R01";
                else if (track == 58) RandomTrack.GameTrack = "china_R02";
                else if (track == 59) RandomTrack.GameTrack = "china_R03";
                else if (track == 60) RandomTrack.GameTrack = "china_R04";
                else if (track == 61) RandomTrack.GameTrack = "china_R05";
                else if (track == 62) RandomTrack.GameTrack = "china_R07";
                else if (track == 63) RandomTrack.GameTrack = "castle_R01";
                else if (track == 64) RandomTrack.GameTrack = "castle_R02";
                else if (track == 65) RandomTrack.GameTrack = "nymph_R01";
                else if (track == 66) RandomTrack.GameTrack = "nymph_R02";
                else if (track == 67) RandomTrack.GameTrack = "mechanic_R01";
                else if (track == 68) RandomTrack.GameTrack = "wkc_R01";
                else if (track == 69) RandomTrack.GameTrack = "wkc_R02";
                else if (track == 70) RandomTrack.GameTrack = "wkc_R11";
                else if (track == 71) RandomTrack.GameTrack = "wkc_R03";
                else if (track == 72) RandomTrack.GameTrack = "wkc_R04";
                else if (track == 73) RandomTrack.GameTrack = "wkc_R05";
                else if (track == 74) RandomTrack.GameTrack = "wkc_R09";
                else if (track == 75) RandomTrack.GameTrack = "brodi_R01";
                else if (track == 76) RandomTrack.GameTrack = "brodi_R02";
                else if (track == 77) RandomTrack.GameTrack = "park_R01";
                else if (track == 78) RandomTrack.GameTrack = "park_R02";
                else if (track == 79) RandomTrack.GameTrack = "beach_R01";
                else if (track == 80) RandomTrack.GameTrack = "beach_R02";
                else if (track == 81) RandomTrack.GameTrack = "beach_R03";
                else if (track == 82) RandomTrack.GameTrack = "beach_R04";
                else if (track == 83) RandomTrack.GameTrack = "steam_R01";
                else if (track == 84) RandomTrack.GameTrack = "steam_R02";
                else if (track == 85) RandomTrack.GameTrack = "jurassic_R01";
                else if (track == 86) RandomTrack.GameTrack = "jurassic_R03";
                else if (track == 87) RandomTrack.GameTrack = "jurassic_R04";
                else if (track == 88) RandomTrack.GameTrack = "world_R01";
                else if (track == 89) RandomTrack.GameTrack = "world_R10";
                else if (track == 90) RandomTrack.GameTrack = "world_R02";
                else if (track == 91) RandomTrack.GameTrack = "world_R03";
                else if (track == 92) RandomTrack.GameTrack = "world_R04";
                else if (track == 93) RandomTrack.GameTrack = "world_R05";
                else if (track == 94) RandomTrack.GameTrack = "world_R06";
                else if (track == 95) RandomTrack.GameTrack = "nemo_R01";
                else if (track == 96) RandomTrack.GameTrack = "nemo_R02";
                else if (track == 97) RandomTrack.GameTrack = "nemo_R03";
                else if (track == 98) RandomTrack.GameTrack = "sword_R01";
                else if (track == 99) RandomTrack.GameTrack = "sword_R02";
                else if (track == 100) RandomTrack.GameTrack = "sword_R03";
                else if (track == 101) RandomTrack.GameTrack = "god_R01";
                else if (track == 102) RandomTrack.GameTrack = "god_R02";
                else if (track == 103) RandomTrack.GameTrack = "god_R03";
                else if (track == 104) RandomTrack.GameTrack = "abyss_R01";
                else if (track == 105) RandomTrack.GameTrack = "abyss_R02";
                else if (track == 106) RandomTrack.GameTrack = "abyss_R03";
                else if (track == 107) RandomTrack.GameTrack = "abyss_R04";
                else if (track == 108) RandomTrack.GameTrack = "abyss_R05";
                else if (track == 109) RandomTrack.GameTrack = "camelot_R01";
                else if (track == 110) RandomTrack.GameTrack = "camelot_R02";
                else if (track == 111) RandomTrack.GameTrack = "camelot_R03";
                else if (track == 112) RandomTrack.GameTrack = "olympos_R01";
                else if (track == 113) RandomTrack.GameTrack = "olympos_R02";
                else if (track == 114) RandomTrack.GameTrack = "korea_R01";
                else if (track == 115) RandomTrack.GameTrack = "korea_R02";
                else if (track == 116) RandomTrack.GameTrack = "korea_R03";
                else if (track == 117) RandomTrack.GameTrack = "mabi_R01";
                else if (track == 118) RandomTrack.GameTrack = "mabi_R02";
                else if (track == 119) RandomTrack.GameTrack = "maple_R01";
                else if (track == 120) RandomTrack.GameTrack = "maple_R02";
                else if (track == 121) RandomTrack.GameTrack = "maple_R03";
            }
            if (RandomTrack.SetRandomTrack != "Unknown")
            {
                StartGameData.StartTimeAttack_Track = Adler32Helper.GenerateAdler32_UNICODE(RandomTrack.GameTrack, 0);
                Console.WriteLine("RandomTrack: {0} / {1} / {2}", RandomTrack.GameType, RandomTrack.SetRandomTrack, RandomTrack.GameTrack);
            }
            SpeedType.SpeedTypeData();
        }
    }
}