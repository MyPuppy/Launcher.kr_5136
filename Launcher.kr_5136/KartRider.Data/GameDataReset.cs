﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider_SN;
using RiderData;
using ExcData;
using Set_Data;

namespace KartRider
{
    public class GameDataReset
    {
        public static void RandomTrack_DataReset()
        {
            RandomTrack.GameType = "item";
            RandomTrack.SetRandomTrack = "allRandom";
            RandomTrack.GameTrack = "forest_I01";
        }

        public static void GameType_DataReset()
        {
            GameType.TimeAttack_RP = 0;
            GameType.TimeAttack_Lucci = 0;
            GameType.RewardType = 0;
            GameType.min = 0;
            GameType.sec = 0;
            GameType.mil = 0;
            GameType.S4_DriftMaxGauge = 1f;
            GameType.S6_BoosterTime = 2000000f;
            GameType.ScenarioType = 0;
            GameType.StartType = 0;
            GameType.EnterMyRoomType = 0;
        }

        public static void StartGame_DataReset()
        {
            StartGameData.StartTimeAttack_Unk1 = 0;
            StartGameData.StartTimeAttack_Unk2 = 0;
            StartGameData.StartTimeAttack_Track = 0;
            StartGameData.StartTimeAttack_SpeedType = 0;
            StartGameData.StartTimeAttack_GameType = 0;
            StartGameData.Kart_id = 0;
            StartGameData.FlyingPet_id = 0;
            StartGameData.StartTimeAttack_StartType = 0;
            StartGameData.StartTimeAttack_Unk3 = 0;
            StartGameData.StartTimeAttack_Unk4 = 0;
            StartGameData.StartTimeAttack_Unk5 = 0;
            StartGameData.StartTimeAttack_RankingTimaAttackType = 0;
            StartGameData.StartTimeAttack_TimaAttackMpdeType = 0;
            StartGameData.StartTimeAttack_TimaAttackMpde = 0;
            StartGameData.StartTimeAttack_RandomTrackGameType = 0;
        }

        public static void SpeedType_DataReset()
        {
            SpeedType.AddSpec_SteerConstraint = 0f;
            SpeedType.AddSpec_DriftEscapeForce = 0f;
            SpeedType.AddSpec_TransAccelFactor = 0f;
            SpeedType.DragFactor = 0f;
            SpeedType.ForwardAccelForce = 0f;
            SpeedType.BackwardAccelForce = 0f;
            SpeedType.GripBrakeForce = 0f;
            SpeedType.SlipBrakeForce = 0f;
            SpeedType.SteerConstraint = 0f;
            SpeedType.DriftEscapeForce = 0f;
            SpeedType.CornerDrawFactor = 0f;
            SpeedType.DriftMaxGauge = 0f;
            SpeedType.TransAccelFactor = 0f;
            SpeedType.BoostAccelFactor = 0f;
            SpeedType.StartForwardAccelForceItem = 0f;
            SpeedType.StartForwardAccelForceSpeed = 0f;
        }

        public static void FlyingPet_DataReset()
        {
            FlyingPet.DragFactor = 0f;
            FlyingPet.ForwardAccelForce = 0f;
            FlyingPet.DriftEscapeForce = 0f;
            FlyingPet.CornerDrawFactor = 0f;
            FlyingPet.NormalBoosterTime = 0f;
            FlyingPet.ItemBoosterTime = 0f;
            FlyingPet.TeamBoosterTime = 0f;
            FlyingPet.StartForwardAccelForceItem = 0f;
            FlyingPet.StartForwardAccelForceSpeed = 0f;
        }

        public static void Kart_DataReset()
        {
            Kart.draftMulAccelFactor = 0f;
            Kart.draftTick = 0;
            Kart.driftBoostMulAccelFactor = 0f;
            Kart.driftBoostTick = 0;
            Kart.chargeBoostBySpeed = 0f;
            Kart.SpeedSlotCapacity = 0;
            Kart.ItemSlotCapacity = 0;
            Kart.SpecialSlotCapacity = 0;
            Kart.UseTransformBooster = false;
            Kart.motorcycleType = false;
            Kart.BikeRearWheel = false;
            Kart.Mass = 0f;
            Kart.AirFriction = 0f;
            Kart.DragFactor = 0f;
            Kart.ForwardAccelForce = 0f;
            Kart.BackwardAccelForce = 0f;
            Kart.GripBrakeForce = 0f;
            Kart.SlipBrakeForce = 0f;
            Kart.MaxSteerAngle = 0f;
            Kart.SteerConstraint = 0f;
            Kart.FrontGripFactor = 0f;
            Kart.RearGripFactor = 0f;
            Kart.DriftTriggerFactor = 0f;
            Kart.DriftTriggerTime = 0f;
            Kart.DriftSlipFactor = 0f;
            Kart.DriftEscapeForce = 0f;
            Kart.CornerDrawFactor = 0f;
            Kart.DriftLeanFactor = 0f;
            Kart.SteerLeanFactor = 0f;
            Kart.DriftMaxGauge = 0f;
            Kart.NormalBoosterTime = 0f;
            Kart.ItemBoosterTime = 0f;
            Kart.TeamBoosterTime = 0f;
            Kart.AnimalBoosterTime = 0f;
            Kart.SuperBoosterTime = 0f;
            Kart.TransAccelFactor = 0f;
            Kart.BoostAccelFactor = 0f;
            Kart.StartBoosterTimeItem = 0f;
            Kart.StartBoosterTimeSpeed = 0f;
            Kart.StartForwardAccelForceItem = 0f;
            Kart.StartForwardAccelForceSpeed = 0f;
            Kart.DriftGaguePreservePercent = 0f;
            Kart.UseExtendedAfterBooster = false;
            Kart.BoostAccelFactorOnlyItem = 0f;
            Kart.antiCollideBalance = 0f;
            Kart.dualBoosterSetAuto = false;
            Kart.dualBoosterTickMin = 0;
            Kart.dualBoosterTickMax = 0;
            Kart.dualMulAccelFactor = 0f;
            Kart.dualTransLowSpeed = 0f;
            Kart.PartsEngineLock = false;
            Kart.PartsWheelLock = false;
            Kart.PartsSteeringLock = false;
            Kart.PartsBoosterLock = false;
            Kart.PartsCoatingLock = false;
            Kart.PartsTailLampLock = false;
            Kart.chargeInstAccelGaugeByBoost = 0f;
            Kart.chargeInstAccelGaugeByGrip = 0f;
            Kart.chargeInstAccelGaugeByWall = 0f;
            Kart.instAccelFactor = 0f;
            Kart.instAccelGaugeCooldownTime = 0;
            Kart.instAccelGaugeLength = 0f;
            Kart.instAccelGaugeMinUsable = 0f;
            Kart.instAccelGaugeMinVelBound = 0f;
            Kart.instAccelGaugeMinVelLoss = 0f;
            Kart.useExtendedAfterBoosterMore = false;
            Kart.wallCollGaugeCooldownTime = 0;
            Kart.wallCollGaugeMaxVelLoss = 0f;
            Kart.wallCollGaugeMinVelBound = 0f;
            Kart.wallCollGaugeMinVelLoss = 0f;
        }

        public static void Check_UseKartUpgrade()
        {
            if (Set_ETC.UseKartTune)
            {
                Program.UseKartTune = true;
            }
            else
            {
                Program.UseKartTune = false;
            }
            if (Set_ETC.UseKartPlant)
            {
                Program.UseKartPlant = true;
            }
            else
            {
                Program.UseKartPlant = false;
            }
            if (Set_ETC.UseKartLevel)
            {
                Program.UseKartLevel = true;
            }
            else
            {
                Program.UseKartLevel = false;
            }
            if (Set_ETC.UseKartParts)
            {
                Program.UseKartParts = true;
            }
            else
            {
                Program.UseKartParts = false;
            }
        }

        public static void DataReset()
        {
            Launcher.OpenGetItem = false;
            if (SetRider.Lucci > SessionGroup.LucciMax)
            {
                SetRider.Lucci = SessionGroup.LucciMax;
            }
            NewRider.KartSN();
            GameDataReset.RandomTrack_DataReset();
            GameDataReset.GameType_DataReset();
            GameDataReset.StartGame_DataReset();
            GameDataReset.SpeedType_DataReset();
            GameDataReset.FlyingPet_DataReset();
            GameDataReset.Kart_DataReset();
            GameDataReset.Check_UseKartUpgrade();
            PartsDataReset.PartsSpecReset();
            TuneSpec.Reset_Tune_SpecData();
            TuneSpec.Reset_Plant_SpecData();
            TuneSpec.Reset_KartLevel_SpecData();
            SpeedPatch.SpeedPatcData();
            GameSupport.PrLogin();
            Console.WriteLine("Login...OK");
        }
    }
}