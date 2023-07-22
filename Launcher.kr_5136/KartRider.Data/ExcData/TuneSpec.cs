using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider;
using Set_Data;

namespace ExcData
{
    public class TuneSpec
    {
        public static float Tune_DriftEscapeForce = 0f;
        public static float Tune_TransAccelFactor = 0f;
        public static float Tune_StartBoosterTimeSpeed = 0f;

        public static float Plant_ForwardAccelForce = 0f;
        public static float Plant_TransAccelFactor = 0f;
        public static float Plant_StartBoosterTimeSpeed = 0f;
        public static float Plant_GripBrakeForce = 0f;
        public static float Plant_RearGripFactor = 0f;
        public static float Plant_FrontGripFactor = 0f;
        public static float Plant_CornerDrawFactor = 0f;
        public static float Plant_DriftEscapeForce = 0f;
        public static float Plant_DriftMaxGauge = 0f;
        public static float Plant_NormalBoosterTime = 0f;

        public static float KartLevel_ForwardAccelForce = 0f;
        public static float KartLevel_CornerDrawFactor = 0f;
        public static float KartLevel_DriftEscapeForce = 0f;
        public static float KartLevel_StartBoosterTimeItem = 0f;
        public static float KartLevel_StartBoosterTimeSpeed = 0f;
        public static float KartLevel_TransAccelFactor = 0f;

        public static void Tune_TypeC()
        {
            TuneSpec.Tune_DriftEscapeForce = 210f;//3
            TuneSpec.Tune_TransAccelFactor = 0.012f;//2
            TuneSpec.Tune_StartBoosterTimeSpeed = 530f;//2
            Console.WriteLine("팩토리 적용됨 (Type: C)");
        }

        public static void Tune_TypeH()
        {
            TuneSpec.Tune_DriftEscapeForce = 210f;//3
            TuneSpec.Tune_TransAccelFactor = 0.012f;//2
            TuneSpec.Tune_StartBoosterTimeSpeed = 800f;//3
            Console.WriteLine("팩토리 적용됨 (Type: H)");
        }

        public static void Tune_TypeA()
        {
            TuneSpec.Tune_DriftEscapeForce = 210f;//3
            TuneSpec.Tune_TransAccelFactor = 0.018f;//3
            TuneSpec.Tune_StartBoosterTimeSpeed = 800f;//3
            Console.WriteLine("팩토리 적용됨 (Type: A)");
        }

        public static void Reset_Tune_SpecData()
        {
            TuneSpec.Tune_DriftEscapeForce = 0f;
            TuneSpec.Tune_TransAccelFactor = 0f;
            TuneSpec.Tune_StartBoosterTimeSpeed = 0f;
        }

        public static void Plant_SpecData()
        {
            //태고의 빛
            TuneSpec.Plant_ForwardAccelForce = 1f;
            TuneSpec.Plant_TransAccelFactor = 0.002f;
            TuneSpec.Plant_StartBoosterTimeSpeed = 30f;

            //엑스 스트림
            TuneSpec.Plant_GripBrakeForce = -12f;
            TuneSpec.Plant_RearGripFactor = 0.3f;
            TuneSpec.Plant_FrontGripFactor = 0.3f;
            //TuneSpec.Plant_CornerDrawFactor = 0.001f;

            //와일드 서클
            TuneSpec.Plant_DriftEscapeForce = 90f;
            //TuneSpec.Plant_CornerDrawFactor = 0.0005f;

            //골든 로제타 킷
            TuneSpec.Plant_DriftMaxGauge = -80f;
            TuneSpec.Plant_NormalBoosterTime = 120f;

            //엑스 스트림 + 와일드 서클 통합
            TuneSpec.Plant_CornerDrawFactor = 0.0015f;
            Console.WriteLine("플랜트 적용됨");
        }

        public static void Reset_Plant_SpecData()
        {
            //태고의 빛
            TuneSpec.Plant_ForwardAccelForce = 0f;
            TuneSpec.Plant_TransAccelFactor = 0f;
            TuneSpec.Plant_StartBoosterTimeSpeed = 0f;

            //엑스 스트림
            TuneSpec.Plant_GripBrakeForce = 0f;
            TuneSpec.Plant_RearGripFactor = 0f;
            TuneSpec.Plant_FrontGripFactor = 0f;
            //TuneSpec.Plant_CornerDrawFactor = 0f;

            //와일드 서클
            TuneSpec.Plant_DriftEscapeForce = 0f;
            //TuneSpec.Plant_CornerDrawFactor = 0f;

            //골든 로제타 킷
            TuneSpec.Plant_DriftMaxGauge = 0f;
            TuneSpec.Plant_NormalBoosterTime = 0f;

            //엑스 스트림 + 와일드 서클 통합
            TuneSpec.Plant_CornerDrawFactor = 0f;
        }

        public static void KartLevel_SpecData()
        {
            TuneSpec.KartLevel_ForwardAccelForce = 1.5f;
            TuneSpec.KartLevel_CornerDrawFactor = 0.0005f;
            TuneSpec.KartLevel_DriftEscapeForce = 50f;
            TuneSpec.KartLevel_StartBoosterTimeItem = 100f;
            TuneSpec.KartLevel_StartBoosterTimeSpeed = 100f;
            TuneSpec.KartLevel_TransAccelFactor = 0.005f;
            Console.WriteLine("튜닝 적용됨");
        }

        public static void Reset_KartLevel_SpecData()
        {
            TuneSpec.KartLevel_ForwardAccelForce = 0f;
            TuneSpec.KartLevel_CornerDrawFactor = 0f;
            TuneSpec.KartLevel_DriftEscapeForce = 0f;
            TuneSpec.KartLevel_StartBoosterTimeItem = 0f;
            TuneSpec.KartLevel_StartBoosterTimeSpeed = 0f;
            TuneSpec.KartLevel_TransAccelFactor = 0f;
        }

        public static void Use_TuneSpec()
        {
            if (Program.UseKartTune)
            {
                if (SetRiderItem.Set_Kart == 0)
                {
                    TuneSpec.Reset_Tune_SpecData();
                }
                else if (SetRiderItem.Set_KartSN == Launcher.KartOld_SN)
                {
                    if (SetRiderItem.Set_Kart == 700 || SetRiderItem.Set_Kart == 701 || SetRiderItem.Set_Kart == 702 || SetRiderItem.Set_Kart == 703 || SetRiderItem.Set_Kart == 704 || 
                        SetRiderItem.Set_Kart == 750 || SetRiderItem.Set_Kart == 751 || SetRiderItem.Set_Kart == 788)
                    {
                        TuneSpec.Tune_TypeC();
                    }
                    else if (SetRiderItem.Set_Kart == 633 || SetRiderItem.Set_Kart == 647 || SetRiderItem.Set_Kart == 650 || SetRiderItem.Set_Kart == 671 || SetRiderItem.Set_Kart == 681 ||
                             SetRiderItem.Set_Kart == 719 || SetRiderItem.Set_Kart == 787)
                    {
                        TuneSpec.Tune_TypeH();
                    }
                    else
                    {
                        TuneSpec.Tune_TypeA();
                    }
                }
                else if (SetRiderItem.Set_KartSN <= Launcher.LastKartSN)
                {
                    TuneSpec.Tune_TypeA();
                }
                else
                {
                    TuneSpec.Reset_Tune_SpecData();
                }
            }
            else
            {
                if (SetRiderItem.Set_Kart == 700 || SetRiderItem.Set_Kart == 701 || SetRiderItem.Set_Kart == 702 || SetRiderItem.Set_Kart == 703 || SetRiderItem.Set_Kart == 704 ||
                    SetRiderItem.Set_Kart == 750 || SetRiderItem.Set_Kart == 751 || SetRiderItem.Set_Kart == 788)
                {
                    TuneSpec.Tune_TypeC();
                }
                else if (SetRiderItem.Set_Kart == 633 || SetRiderItem.Set_Kart == 647 || SetRiderItem.Set_Kart == 650 || SetRiderItem.Set_Kart == 671 || SetRiderItem.Set_Kart == 681 ||
                         SetRiderItem.Set_Kart == 719 || SetRiderItem.Set_Kart == 787)
                {
                    TuneSpec.Tune_TypeH();
                }
                else
                {
                    TuneSpec.Reset_Tune_SpecData();
                }
            }
        }

        public static void Use_PlantSpec()
        {
            if (Program.UseKartPlant)
            {
                if (SetRiderItem.Set_Kart == 0)
                {
                    TuneSpec.Reset_Plant_SpecData();
                }
                else if (SetRiderItem.Set_KartSN == Launcher.KartOld_SN)
                {
                    TuneSpec.Plant_SpecData();
                }
                else
                {
                    TuneSpec.Reset_Plant_SpecData();
                }
            }
            else
            {
                TuneSpec.Reset_Plant_SpecData();
            }
        }

        public static void Use_KartLevelSpec()
        {
            if (Program.UseKartLevel)
            {
                if (SetRiderItem.Set_Kart == 0)
                {
                    TuneSpec.Reset_KartLevel_SpecData();
                }
                else if (SetRiderItem.Set_KartSN == Launcher.KartOld_SN)
                {
                    TuneSpec.KartLevel_SpecData();
                }
                else
                {
                    TuneSpec.Reset_KartLevel_SpecData();
                }
            }
            else
            {
                TuneSpec.Reset_KartLevel_SpecData();
            }
        }
    }
}
