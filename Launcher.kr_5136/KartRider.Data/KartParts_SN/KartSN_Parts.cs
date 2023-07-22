using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider;
using ExcData;

namespace KartRider_SN
{
    public class KartSN_Parts
    {
        public static void KartSN_Data()
        {
            Console.WriteLine("-------------------------------------------------------------");
            if (KartSN_Count.KartSN_1 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_1 = 0;
                    TransAccelFactor_Count.TransAccelFactor_1 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_1 = 0;
                    SteerConstraint_Count.SteerConstraint_1 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_1 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_1 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_1 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_1 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_1: {0}", TransAccelFactor_Count.TransAccelFactor_1);
                Console.WriteLine("SteerConstraint_1: {0}", SteerConstraint_Count.SteerConstraint_1);
                Console.WriteLine("DriftEscapeForce_1: {0}", DriftEscapeForce_Count.DriftEscapeForce_1);
                Console.WriteLine("NormalBoosterTime_1: {0}", NormalBoosterTime_Count.NormalBoosterTime_1);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_1;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_1;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_1;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_1;
            }
            else if (KartSN_Count.KartSN_2 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_2 = 0;
                    TransAccelFactor_Count.TransAccelFactor_2 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_2 = 0;
                    SteerConstraint_Count.SteerConstraint_2 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_2 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_2 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_2 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_2 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_2: {0}", TransAccelFactor_Count.TransAccelFactor_2);
                Console.WriteLine("SteerConstraint_2: {0}", SteerConstraint_Count.SteerConstraint_2);
                Console.WriteLine("DriftEscapeForce_2: {0}", DriftEscapeForce_Count.DriftEscapeForce_2);
                Console.WriteLine("NormalBoosterTime_2: {0}", NormalBoosterTime_Count.NormalBoosterTime_2);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_2;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_2;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_2;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_2;
            }
            else if (KartSN_Count.KartSN_3 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_3 = 0;
                    TransAccelFactor_Count.TransAccelFactor_3 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_3 = 0;
                    SteerConstraint_Count.SteerConstraint_3 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_3 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_3 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_3 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_3 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_3: {0}", TransAccelFactor_Count.TransAccelFactor_3);
                Console.WriteLine("SteerConstraint_3: {0}", SteerConstraint_Count.SteerConstraint_3);
                Console.WriteLine("DriftEscapeForce_3: {0}", DriftEscapeForce_Count.DriftEscapeForce_3);
                Console.WriteLine("NormalBoosterTime_3: {0}", NormalBoosterTime_Count.NormalBoosterTime_3);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_3;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_3;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_3;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_3;
            }
            else if (KartSN_Count.KartSN_4 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_4 = 0;
                    TransAccelFactor_Count.TransAccelFactor_4 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_4 = 0;
                    SteerConstraint_Count.SteerConstraint_4 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_4 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_4 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_4 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_4 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_4: {0}", TransAccelFactor_Count.TransAccelFactor_4);
                Console.WriteLine("SteerConstraint_4: {0}", SteerConstraint_Count.SteerConstraint_4);
                Console.WriteLine("DriftEscapeForce_4: {0}", DriftEscapeForce_Count.DriftEscapeForce_4);
                Console.WriteLine("NormalBoosterTime_4: {0}", NormalBoosterTime_Count.NormalBoosterTime_4);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_4;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_4;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_4;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_4;
            }
            else if (KartSN_Count.KartSN_5 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_5 = 0;
                    TransAccelFactor_Count.TransAccelFactor_5 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_5 = 0;
                    SteerConstraint_Count.SteerConstraint_5 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_5 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_5 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_5 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_5 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_5: {0}", TransAccelFactor_Count.TransAccelFactor_5);
                Console.WriteLine("SteerConstraint_5: {0}", SteerConstraint_Count.SteerConstraint_5);
                Console.WriteLine("DriftEscapeForce_5: {0}", DriftEscapeForce_Count.DriftEscapeForce_5);
                Console.WriteLine("NormalBoosterTime_5: {0}", NormalBoosterTime_Count.NormalBoosterTime_5);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_5;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_5;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_5;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_5;
            }
            else if (KartSN_Count.KartSN_6 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_6 = 0;
                    TransAccelFactor_Count.TransAccelFactor_6 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_6 = 0;
                    SteerConstraint_Count.SteerConstraint_6 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_6 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_6 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_6 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_6 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_6: {0}", TransAccelFactor_Count.TransAccelFactor_6);
                Console.WriteLine("SteerConstraint_6: {0}", SteerConstraint_Count.SteerConstraint_6);
                Console.WriteLine("DriftEscapeForce_6: {0}", DriftEscapeForce_Count.DriftEscapeForce_6);
                Console.WriteLine("NormalBoosterTime_6: {0}", NormalBoosterTime_Count.NormalBoosterTime_6);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_6;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_6;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_6;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_6;
            }
            else if (KartSN_Count.KartSN_7 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_7 = 0;
                    TransAccelFactor_Count.TransAccelFactor_7 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_7 = 0;
                    SteerConstraint_Count.SteerConstraint_7 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_7 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_7 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_7 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_7 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_7: {0}", TransAccelFactor_Count.TransAccelFactor_7);
                Console.WriteLine("SteerConstraint_7: {0}", SteerConstraint_Count.SteerConstraint_7);
                Console.WriteLine("DriftEscapeForce_7: {0}", DriftEscapeForce_Count.DriftEscapeForce_7);
                Console.WriteLine("NormalBoosterTime_7: {0}", NormalBoosterTime_Count.NormalBoosterTime_7);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_7;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_7;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_7;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_7;
            }
            else if (KartSN_Count.KartSN_8 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_8 = 0;
                    TransAccelFactor_Count.TransAccelFactor_8 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_8 = 0;
                    SteerConstraint_Count.SteerConstraint_8 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_8 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_8 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_8 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_8 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_8: {0}", TransAccelFactor_Count.TransAccelFactor_8);
                Console.WriteLine("SteerConstraint_8: {0}", SteerConstraint_Count.SteerConstraint_8);
                Console.WriteLine("DriftEscapeForce_8: {0}", DriftEscapeForce_Count.DriftEscapeForce_8);
                Console.WriteLine("NormalBoosterTime_8: {0}", NormalBoosterTime_Count.NormalBoosterTime_8);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_8;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_8;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_8;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_8;
            }
            else if (KartSN_Count.KartSN_9 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_9 = 0;
                    TransAccelFactor_Count.TransAccelFactor_9 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_9 = 0;
                    SteerConstraint_Count.SteerConstraint_9 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_9 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_9 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_9 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_9 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_9: {0}", TransAccelFactor_Count.TransAccelFactor_9);
                Console.WriteLine("SteerConstraint_9: {0}", SteerConstraint_Count.SteerConstraint_9);
                Console.WriteLine("DriftEscapeForce_9: {0}", DriftEscapeForce_Count.DriftEscapeForce_9);
                Console.WriteLine("NormalBoosterTime_9: {0}", NormalBoosterTime_Count.NormalBoosterTime_9);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_9;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_9;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_9;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_9;
            }
            else if (KartSN_Count.KartSN_10 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_10 = 0;
                    TransAccelFactor_Count.TransAccelFactor_10 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_10 = 0;
                    SteerConstraint_Count.SteerConstraint_10 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_10 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_10 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_10 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_10 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_10: {0}", TransAccelFactor_Count.TransAccelFactor_10);
                Console.WriteLine("SteerConstraint_10: {0}", SteerConstraint_Count.SteerConstraint_10);
                Console.WriteLine("DriftEscapeForce_10: {0}", DriftEscapeForce_Count.DriftEscapeForce_10);
                Console.WriteLine("NormalBoosterTime_10: {0}", NormalBoosterTime_Count.NormalBoosterTime_10);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_10;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_10;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_10;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_10;
            }
            else if (KartSN_Count.KartSN_11 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_11 = 0;
                    TransAccelFactor_Count.TransAccelFactor_11 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_11 = 0;
                    SteerConstraint_Count.SteerConstraint_11 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_11 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_11 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_11 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_11 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_11: {0}", TransAccelFactor_Count.TransAccelFactor_11);
                Console.WriteLine("SteerConstraint_11: {0}", SteerConstraint_Count.SteerConstraint_11);
                Console.WriteLine("DriftEscapeForce_11: {0}", DriftEscapeForce_Count.DriftEscapeForce_11);
                Console.WriteLine("NormalBoosterTime_11: {0}", NormalBoosterTime_Count.NormalBoosterTime_11);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_11;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_11;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_11;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_11;
            }
            else if (KartSN_Count.KartSN_12 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_12 = 0;
                    TransAccelFactor_Count.TransAccelFactor_12 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_12 = 0;
                    SteerConstraint_Count.SteerConstraint_12 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_12 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_12 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_12 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_12 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_12: {0}", TransAccelFactor_Count.TransAccelFactor_12);
                Console.WriteLine("SteerConstraint_12: {0}", SteerConstraint_Count.SteerConstraint_12);
                Console.WriteLine("DriftEscapeForce_12: {0}", DriftEscapeForce_Count.DriftEscapeForce_12);
                Console.WriteLine("NormalBoosterTime_12: {0}", NormalBoosterTime_Count.NormalBoosterTime_12);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_12;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_12;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_12;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_12;
            }
            else if (KartSN_Count.KartSN_13 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_13 = 0;
                    TransAccelFactor_Count.TransAccelFactor_13 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_13 = 0;
                    SteerConstraint_Count.SteerConstraint_13 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_13 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_13 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_13 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_13 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_13: {0}", TransAccelFactor_Count.TransAccelFactor_13);
                Console.WriteLine("SteerConstraint_13: {0}", SteerConstraint_Count.SteerConstraint_13);
                Console.WriteLine("DriftEscapeForce_13: {0}", DriftEscapeForce_Count.DriftEscapeForce_13);
                Console.WriteLine("NormalBoosterTime_13: {0}", NormalBoosterTime_Count.NormalBoosterTime_13);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_13;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_13;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_13;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_13;
            }
            else if (KartSN_Count.KartSN_14 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_14 = 0;
                    TransAccelFactor_Count.TransAccelFactor_14 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_14 = 0;
                    SteerConstraint_Count.SteerConstraint_14 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_14 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_14 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_14 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_14 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_14: {0}", TransAccelFactor_Count.TransAccelFactor_14);
                Console.WriteLine("SteerConstraint_14: {0}", SteerConstraint_Count.SteerConstraint_14);
                Console.WriteLine("DriftEscapeForce_14: {0}", DriftEscapeForce_Count.DriftEscapeForce_14);
                Console.WriteLine("NormalBoosterTime_14: {0}", NormalBoosterTime_Count.NormalBoosterTime_14);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_14;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_14;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_14;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_14;
            }
            else if (KartSN_Count.KartSN_15 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_15 = 0;
                    TransAccelFactor_Count.TransAccelFactor_15 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_15 = 0;
                    SteerConstraint_Count.SteerConstraint_15 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_15 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_15 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_15 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_15 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_15: {0}", TransAccelFactor_Count.TransAccelFactor_15);
                Console.WriteLine("SteerConstraint_15: {0}", SteerConstraint_Count.SteerConstraint_15);
                Console.WriteLine("DriftEscapeForce_15: {0}", DriftEscapeForce_Count.DriftEscapeForce_15);
                Console.WriteLine("NormalBoosterTime_15: {0}", NormalBoosterTime_Count.NormalBoosterTime_15);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_15;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_15;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_15;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_15;
            }
            else if (KartSN_Count.KartSN_16 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_16 = 0;
                    TransAccelFactor_Count.TransAccelFactor_16 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_16 = 0;
                    SteerConstraint_Count.SteerConstraint_16 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_16 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_16 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_16 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_16 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_16: {0}", TransAccelFactor_Count.TransAccelFactor_16);
                Console.WriteLine("SteerConstraint_16: {0}", SteerConstraint_Count.SteerConstraint_16);
                Console.WriteLine("DriftEscapeForce_16: {0}", DriftEscapeForce_Count.DriftEscapeForce_16);
                Console.WriteLine("NormalBoosterTime_16: {0}", NormalBoosterTime_Count.NormalBoosterTime_16);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_16;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_16;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_16;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_16;
            }
            else if (KartSN_Count.KartSN_17 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_17 = 0;
                    TransAccelFactor_Count.TransAccelFactor_17 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_17 = 0;
                    SteerConstraint_Count.SteerConstraint_17 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_17 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_17 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_17 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_17 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_17: {0}", TransAccelFactor_Count.TransAccelFactor_17);
                Console.WriteLine("SteerConstraint_17: {0}", SteerConstraint_Count.SteerConstraint_17);
                Console.WriteLine("DriftEscapeForce_17: {0}", DriftEscapeForce_Count.DriftEscapeForce_17);
                Console.WriteLine("NormalBoosterTime_17: {0}", NormalBoosterTime_Count.NormalBoosterTime_17);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_17;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_17;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_17;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_17;
            }
            else if (KartSN_Count.KartSN_18 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_18 = 0;
                    TransAccelFactor_Count.TransAccelFactor_18 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_18 = 0;
                    SteerConstraint_Count.SteerConstraint_18 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_18 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_18 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_18 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_18 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_18: {0}", TransAccelFactor_Count.TransAccelFactor_18);
                Console.WriteLine("SteerConstraint_18: {0}", SteerConstraint_Count.SteerConstraint_18);
                Console.WriteLine("DriftEscapeForce_18: {0}", DriftEscapeForce_Count.DriftEscapeForce_18);
                Console.WriteLine("NormalBoosterTime_18: {0}", NormalBoosterTime_Count.NormalBoosterTime_18);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_18;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_18;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_18;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_18;
            }
            else if (KartSN_Count.KartSN_19 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_19 = 0;
                    TransAccelFactor_Count.TransAccelFactor_19 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_19 = 0;
                    SteerConstraint_Count.SteerConstraint_19 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_19 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_19 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_19 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_19 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_19: {0}", TransAccelFactor_Count.TransAccelFactor_19);
                Console.WriteLine("SteerConstraint_19: {0}", SteerConstraint_Count.SteerConstraint_19);
                Console.WriteLine("DriftEscapeForce_19: {0}", DriftEscapeForce_Count.DriftEscapeForce_19);
                Console.WriteLine("NormalBoosterTime_19: {0}", NormalBoosterTime_Count.NormalBoosterTime_19);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_19;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_19;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_19;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_19;
            }
            else if (KartSN_Count.KartSN_20 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_20 = 0;
                    TransAccelFactor_Count.TransAccelFactor_20 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_20 = 0;
                    SteerConstraint_Count.SteerConstraint_20 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_20 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_20 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_20 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_20 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_20: {0}", TransAccelFactor_Count.TransAccelFactor_20);
                Console.WriteLine("SteerConstraint_20: {0}", SteerConstraint_Count.SteerConstraint_20);
                Console.WriteLine("DriftEscapeForce_20: {0}", DriftEscapeForce_Count.DriftEscapeForce_20);
                Console.WriteLine("NormalBoosterTime_20: {0}", NormalBoosterTime_Count.NormalBoosterTime_20);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_20;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_20;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_20;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_20;
            }
            else if (KartSN_Count.KartSN_21 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_21 = 0;
                    TransAccelFactor_Count.TransAccelFactor_21 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_21 = 0;
                    SteerConstraint_Count.SteerConstraint_21 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_21 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_21 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_21 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_21 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_21: {0}", TransAccelFactor_Count.TransAccelFactor_21);
                Console.WriteLine("SteerConstraint_21: {0}", SteerConstraint_Count.SteerConstraint_21);
                Console.WriteLine("DriftEscapeForce_21: {0}", DriftEscapeForce_Count.DriftEscapeForce_21);
                Console.WriteLine("NormalBoosterTime_21: {0}", NormalBoosterTime_Count.NormalBoosterTime_21);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_21;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_21;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_21;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_21;
            }
            else if (KartSN_Count.KartSN_22 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_22 = 0;
                    TransAccelFactor_Count.TransAccelFactor_22 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_22 = 0;
                    SteerConstraint_Count.SteerConstraint_22 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_22 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_22 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_22 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_22 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_22: {0}", TransAccelFactor_Count.TransAccelFactor_22);
                Console.WriteLine("SteerConstraint_22: {0}", SteerConstraint_Count.SteerConstraint_22);
                Console.WriteLine("DriftEscapeForce_22: {0}", DriftEscapeForce_Count.DriftEscapeForce_22);
                Console.WriteLine("NormalBoosterTime_22: {0}", NormalBoosterTime_Count.NormalBoosterTime_22);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_22;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_22;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_22;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_22;
            }
            else if (KartSN_Count.KartSN_23 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_23 = 0;
                    TransAccelFactor_Count.TransAccelFactor_23 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_23 = 0;
                    SteerConstraint_Count.SteerConstraint_23 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_23 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_23 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_23 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_23 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_23: {0}", TransAccelFactor_Count.TransAccelFactor_23);
                Console.WriteLine("SteerConstraint_23: {0}", SteerConstraint_Count.SteerConstraint_23);
                Console.WriteLine("DriftEscapeForce_23: {0}", DriftEscapeForce_Count.DriftEscapeForce_23);
                Console.WriteLine("NormalBoosterTime_23: {0}", NormalBoosterTime_Count.NormalBoosterTime_23);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_23;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_23;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_23;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_23;
            }
            else if (KartSN_Count.KartSN_24 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_24 = 0;
                    TransAccelFactor_Count.TransAccelFactor_24 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_24 = 0;
                    SteerConstraint_Count.SteerConstraint_24 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_24 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_24 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_24 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_24 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_24: {0}", TransAccelFactor_Count.TransAccelFactor_24);
                Console.WriteLine("SteerConstraint_24: {0}", SteerConstraint_Count.SteerConstraint_24);
                Console.WriteLine("DriftEscapeForce_24: {0}", DriftEscapeForce_Count.DriftEscapeForce_24);
                Console.WriteLine("NormalBoosterTime_24: {0}", NormalBoosterTime_Count.NormalBoosterTime_24);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_24;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_24;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_24;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_24;
            }
            else if (KartSN_Count.KartSN_25 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_25 = 0;
                    TransAccelFactor_Count.TransAccelFactor_25 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_25 = 0;
                    SteerConstraint_Count.SteerConstraint_25 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_25 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_25 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_25 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_25 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_25: {0}", TransAccelFactor_Count.TransAccelFactor_25);
                Console.WriteLine("SteerConstraint_25: {0}", SteerConstraint_Count.SteerConstraint_25);
                Console.WriteLine("DriftEscapeForce_25: {0}", DriftEscapeForce_Count.DriftEscapeForce_25);
                Console.WriteLine("NormalBoosterTime_25: {0}", NormalBoosterTime_Count.NormalBoosterTime_25);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_25;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_25;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_25;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_25;
            }
            else if (KartSN_Count.KartSN_26 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_26 = 0;
                    TransAccelFactor_Count.TransAccelFactor_26 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_26 = 0;
                    SteerConstraint_Count.SteerConstraint_26 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_26 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_26 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_26 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_26 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_26: {0}", TransAccelFactor_Count.TransAccelFactor_26);
                Console.WriteLine("SteerConstraint_26: {0}", SteerConstraint_Count.SteerConstraint_26);
                Console.WriteLine("DriftEscapeForce_26: {0}", DriftEscapeForce_Count.DriftEscapeForce_26);
                Console.WriteLine("NormalBoosterTime_26: {0}", NormalBoosterTime_Count.NormalBoosterTime_26);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_26;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_26;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_26;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_26;
            }
            else if (KartSN_Count.KartSN_27 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_27 = 0;
                    TransAccelFactor_Count.TransAccelFactor_27 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_27 = 0;
                    SteerConstraint_Count.SteerConstraint_27 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_27 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_27 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_27 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_27 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_27: {0}", TransAccelFactor_Count.TransAccelFactor_27);
                Console.WriteLine("SteerConstraint_27: {0}", SteerConstraint_Count.SteerConstraint_27);
                Console.WriteLine("DriftEscapeForce_27: {0}", DriftEscapeForce_Count.DriftEscapeForce_27);
                Console.WriteLine("NormalBoosterTime_27: {0}", NormalBoosterTime_Count.NormalBoosterTime_27);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_27;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_27;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_27;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_27;
            }
            else if (KartSN_Count.KartSN_28 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_28 = 0;
                    TransAccelFactor_Count.TransAccelFactor_28 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_28 = 0;
                    SteerConstraint_Count.SteerConstraint_28 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_28 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_28 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_28 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_28 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_28: {0}", TransAccelFactor_Count.TransAccelFactor_28);
                Console.WriteLine("SteerConstraint_28: {0}", SteerConstraint_Count.SteerConstraint_28);
                Console.WriteLine("DriftEscapeForce_28: {0}", DriftEscapeForce_Count.DriftEscapeForce_28);
                Console.WriteLine("NormalBoosterTime_28: {0}", NormalBoosterTime_Count.NormalBoosterTime_28);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_28;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_28;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_28;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_28;
            }
            else if (KartSN_Count.KartSN_29 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_29 = 0;
                    TransAccelFactor_Count.TransAccelFactor_29 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_29 = 0;
                    SteerConstraint_Count.SteerConstraint_29 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_29 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_29 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_29 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_29 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_29: {0}", TransAccelFactor_Count.TransAccelFactor_29);
                Console.WriteLine("SteerConstraint_29: {0}", SteerConstraint_Count.SteerConstraint_29);
                Console.WriteLine("DriftEscapeForce_29: {0}", DriftEscapeForce_Count.DriftEscapeForce_29);
                Console.WriteLine("NormalBoosterTime_29: {0}", NormalBoosterTime_Count.NormalBoosterTime_29);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_29;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_29;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_29;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_29;
            }
            else if (KartSN_Count.KartSN_30 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_30 = 0;
                    TransAccelFactor_Count.TransAccelFactor_30 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_30 = 0;
                    SteerConstraint_Count.SteerConstraint_30 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_30 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_30 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_30 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_30 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_30: {0}", TransAccelFactor_Count.TransAccelFactor_30);
                Console.WriteLine("SteerConstraint_30: {0}", SteerConstraint_Count.SteerConstraint_30);
                Console.WriteLine("DriftEscapeForce_30: {0}", DriftEscapeForce_Count.DriftEscapeForce_30);
                Console.WriteLine("NormalBoosterTime_30: {0}", NormalBoosterTime_Count.NormalBoosterTime_30);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_30;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_30;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_30;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_30;
            }
            else if (KartSN_Count.KartSN_31 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_31 = 0;
                    TransAccelFactor_Count.TransAccelFactor_31 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_31 = 0;
                    SteerConstraint_Count.SteerConstraint_31 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_31 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_31 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_31 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_31 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_31: {0}", TransAccelFactor_Count.TransAccelFactor_31);
                Console.WriteLine("SteerConstraint_31: {0}", SteerConstraint_Count.SteerConstraint_31);
                Console.WriteLine("DriftEscapeForce_31: {0}", DriftEscapeForce_Count.DriftEscapeForce_31);
                Console.WriteLine("NormalBoosterTime_31: {0}", NormalBoosterTime_Count.NormalBoosterTime_31);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_31;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_31;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_31;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_31;
            }
            else if (KartSN_Count.KartSN_32 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_32 = 0;
                    TransAccelFactor_Count.TransAccelFactor_32 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_32 = 0;
                    SteerConstraint_Count.SteerConstraint_32 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_32 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_32 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_32 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_32 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_32: {0}", TransAccelFactor_Count.TransAccelFactor_32);
                Console.WriteLine("SteerConstraint_32: {0}", SteerConstraint_Count.SteerConstraint_32);
                Console.WriteLine("DriftEscapeForce_32: {0}", DriftEscapeForce_Count.DriftEscapeForce_32);
                Console.WriteLine("NormalBoosterTime_32: {0}", NormalBoosterTime_Count.NormalBoosterTime_32);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_32;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_32;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_32;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_32;
            }
            else if (KartSN_Count.KartSN_33 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_33 = 0;
                    TransAccelFactor_Count.TransAccelFactor_33 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_33 = 0;
                    SteerConstraint_Count.SteerConstraint_33 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_33 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_33 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_33 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_33 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_33: {0}", TransAccelFactor_Count.TransAccelFactor_33);
                Console.WriteLine("SteerConstraint_33: {0}", SteerConstraint_Count.SteerConstraint_33);
                Console.WriteLine("DriftEscapeForce_33: {0}", DriftEscapeForce_Count.DriftEscapeForce_33);
                Console.WriteLine("NormalBoosterTime_33: {0}", NormalBoosterTime_Count.NormalBoosterTime_33);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_33;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_33;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_33;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_33;
            }
            else if (KartSN_Count.KartSN_34 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_34 = 0;
                    TransAccelFactor_Count.TransAccelFactor_34 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_34 = 0;
                    SteerConstraint_Count.SteerConstraint_34 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_34 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_34 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_34 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_34 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_34: {0}", TransAccelFactor_Count.TransAccelFactor_34);
                Console.WriteLine("SteerConstraint_34: {0}", SteerConstraint_Count.SteerConstraint_34);
                Console.WriteLine("DriftEscapeForce_34: {0}", DriftEscapeForce_Count.DriftEscapeForce_34);
                Console.WriteLine("NormalBoosterTime_34: {0}", NormalBoosterTime_Count.NormalBoosterTime_34);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_34;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_34;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_34;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_34;
            }
            else if (KartSN_Count.KartSN_35 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_35 = 0;
                    TransAccelFactor_Count.TransAccelFactor_35 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_35 = 0;
                    SteerConstraint_Count.SteerConstraint_35 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_35 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_35 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_35 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_35 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_35: {0}", TransAccelFactor_Count.TransAccelFactor_35);
                Console.WriteLine("SteerConstraint_35: {0}", SteerConstraint_Count.SteerConstraint_35);
                Console.WriteLine("DriftEscapeForce_35: {0}", DriftEscapeForce_Count.DriftEscapeForce_35);
                Console.WriteLine("NormalBoosterTime_35: {0}", NormalBoosterTime_Count.NormalBoosterTime_35);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_35;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_35;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_35;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_35;
            }
            else if (KartSN_Count.KartSN_36 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_36 = 0;
                    TransAccelFactor_Count.TransAccelFactor_36 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_36 = 0;
                    SteerConstraint_Count.SteerConstraint_36 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_36 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_36 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_36 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_36 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_36: {0}", TransAccelFactor_Count.TransAccelFactor_36);
                Console.WriteLine("SteerConstraint_36: {0}", SteerConstraint_Count.SteerConstraint_36);
                Console.WriteLine("DriftEscapeForce_36: {0}", DriftEscapeForce_Count.DriftEscapeForce_36);
                Console.WriteLine("NormalBoosterTime_36: {0}", NormalBoosterTime_Count.NormalBoosterTime_36);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_36;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_36;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_36;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_36;
            }
            else if (KartSN_Count.KartSN_37 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_37 = 0;
                    TransAccelFactor_Count.TransAccelFactor_37 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_37 = 0;
                    SteerConstraint_Count.SteerConstraint_37 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_37 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_37 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_37 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_37 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_37: {0}", TransAccelFactor_Count.TransAccelFactor_37);
                Console.WriteLine("SteerConstraint_37: {0}", SteerConstraint_Count.SteerConstraint_37);
                Console.WriteLine("DriftEscapeForce_37: {0}", DriftEscapeForce_Count.DriftEscapeForce_37);
                Console.WriteLine("NormalBoosterTime_37: {0}", NormalBoosterTime_Count.NormalBoosterTime_37);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_37;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_37;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_37;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_37;
            }
            else if (KartSN_Count.KartSN_38 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_38 = 0;
                    TransAccelFactor_Count.TransAccelFactor_38 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_38 = 0;
                    SteerConstraint_Count.SteerConstraint_38 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_38 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_38 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_38 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_38 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_38: {0}", TransAccelFactor_Count.TransAccelFactor_38);
                Console.WriteLine("SteerConstraint_38: {0}", SteerConstraint_Count.SteerConstraint_38);
                Console.WriteLine("DriftEscapeForce_38: {0}", DriftEscapeForce_Count.DriftEscapeForce_38);
                Console.WriteLine("NormalBoosterTime_38: {0}", NormalBoosterTime_Count.NormalBoosterTime_38);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_38;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_38;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_38;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_38;
            }
            else if (KartSN_Count.KartSN_39 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_39 = 0;
                    TransAccelFactor_Count.TransAccelFactor_39 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_39 = 0;
                    SteerConstraint_Count.SteerConstraint_39 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_39 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_39 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_39 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_39 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_39: {0}", TransAccelFactor_Count.TransAccelFactor_39);
                Console.WriteLine("SteerConstraint_39: {0}", SteerConstraint_Count.SteerConstraint_39);
                Console.WriteLine("DriftEscapeForce_39: {0}", DriftEscapeForce_Count.DriftEscapeForce_39);
                Console.WriteLine("NormalBoosterTime_39: {0}", NormalBoosterTime_Count.NormalBoosterTime_39);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_39;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_39;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_39;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_39;
            }
            else if (KartSN_Count.KartSN_40 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_40 = 0;
                    TransAccelFactor_Count.TransAccelFactor_40 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_40 = 0;
                    SteerConstraint_Count.SteerConstraint_40 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_40 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_40 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_40 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_40 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_40: {0}", TransAccelFactor_Count.TransAccelFactor_40);
                Console.WriteLine("SteerConstraint_40: {0}", SteerConstraint_Count.SteerConstraint_40);
                Console.WriteLine("DriftEscapeForce_40: {0}", DriftEscapeForce_Count.DriftEscapeForce_40);
                Console.WriteLine("NormalBoosterTime_40: {0}", NormalBoosterTime_Count.NormalBoosterTime_40);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_40;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_40;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_40;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_40;
            }
            else if (KartSN_Count.KartSN_41 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_41 = 0;
                    TransAccelFactor_Count.TransAccelFactor_41 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_41 = 0;
                    SteerConstraint_Count.SteerConstraint_41 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_41 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_41 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_41 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_41 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_41: {0}", TransAccelFactor_Count.TransAccelFactor_41);
                Console.WriteLine("SteerConstraint_41: {0}", SteerConstraint_Count.SteerConstraint_41);
                Console.WriteLine("DriftEscapeForce_41: {0}", DriftEscapeForce_Count.DriftEscapeForce_41);
                Console.WriteLine("NormalBoosterTime_41: {0}", NormalBoosterTime_Count.NormalBoosterTime_41);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_41;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_41;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_41;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_41;
            }
            else if (KartSN_Count.KartSN_42 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_42 = 0;
                    TransAccelFactor_Count.TransAccelFactor_42 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_42 = 0;
                    SteerConstraint_Count.SteerConstraint_42 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_42 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_42 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_42 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_42 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_42: {0}", TransAccelFactor_Count.TransAccelFactor_42);
                Console.WriteLine("SteerConstraint_42: {0}", SteerConstraint_Count.SteerConstraint_42);
                Console.WriteLine("DriftEscapeForce_42: {0}", DriftEscapeForce_Count.DriftEscapeForce_42);
                Console.WriteLine("NormalBoosterTime_42: {0}", NormalBoosterTime_Count.NormalBoosterTime_42);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_42;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_42;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_42;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_42;
            }
            else if (KartSN_Count.KartSN_43 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_43 = 0;
                    TransAccelFactor_Count.TransAccelFactor_43 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_43 = 0;
                    SteerConstraint_Count.SteerConstraint_43 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_43 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_43 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_43 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_43 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_43: {0}", TransAccelFactor_Count.TransAccelFactor_43);
                Console.WriteLine("SteerConstraint_43: {0}", SteerConstraint_Count.SteerConstraint_43);
                Console.WriteLine("DriftEscapeForce_43: {0}", DriftEscapeForce_Count.DriftEscapeForce_43);
                Console.WriteLine("NormalBoosterTime_43: {0}", NormalBoosterTime_Count.NormalBoosterTime_43);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_43;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_43;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_43;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_43;
            }
            else if (KartSN_Count.KartSN_44 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_44 = 0;
                    TransAccelFactor_Count.TransAccelFactor_44 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_44 = 0;
                    SteerConstraint_Count.SteerConstraint_44 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_44 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_44 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_44 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_44 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_44: {0}", TransAccelFactor_Count.TransAccelFactor_44);
                Console.WriteLine("SteerConstraint_44: {0}", SteerConstraint_Count.SteerConstraint_44);
                Console.WriteLine("DriftEscapeForce_44: {0}", DriftEscapeForce_Count.DriftEscapeForce_44);
                Console.WriteLine("NormalBoosterTime_44: {0}", NormalBoosterTime_Count.NormalBoosterTime_44);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_44;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_44;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_44;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_44;
            }
            else if (KartSN_Count.KartSN_45 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_45 = 0;
                    TransAccelFactor_Count.TransAccelFactor_45 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_45 = 0;
                    SteerConstraint_Count.SteerConstraint_45 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_45 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_45 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_45 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_45 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_45: {0}", TransAccelFactor_Count.TransAccelFactor_45);
                Console.WriteLine("SteerConstraint_45: {0}", SteerConstraint_Count.SteerConstraint_45);
                Console.WriteLine("DriftEscapeForce_45: {0}", DriftEscapeForce_Count.DriftEscapeForce_45);
                Console.WriteLine("NormalBoosterTime_45: {0}", NormalBoosterTime_Count.NormalBoosterTime_45);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_45;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_45;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_45;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_45;
            }
            else if (KartSN_Count.KartSN_46 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_46 = 0;
                    TransAccelFactor_Count.TransAccelFactor_46 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_46 = 0;
                    SteerConstraint_Count.SteerConstraint_46 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_46 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_46 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_46 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_46 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_46: {0}", TransAccelFactor_Count.TransAccelFactor_46);
                Console.WriteLine("SteerConstraint_46: {0}", SteerConstraint_Count.SteerConstraint_46);
                Console.WriteLine("DriftEscapeForce_46: {0}", DriftEscapeForce_Count.DriftEscapeForce_46);
                Console.WriteLine("NormalBoosterTime_46: {0}", NormalBoosterTime_Count.NormalBoosterTime_46);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_46;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_46;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_46;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_46;
            }
            else if (KartSN_Count.KartSN_47 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_47 = 0;
                    TransAccelFactor_Count.TransAccelFactor_47 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_47 = 0;
                    SteerConstraint_Count.SteerConstraint_47 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_47 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_47 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_47 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_47 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_47: {0}", TransAccelFactor_Count.TransAccelFactor_47);
                Console.WriteLine("SteerConstraint_47: {0}", SteerConstraint_Count.SteerConstraint_47);
                Console.WriteLine("DriftEscapeForce_47: {0}", DriftEscapeForce_Count.DriftEscapeForce_47);
                Console.WriteLine("NormalBoosterTime_47: {0}", NormalBoosterTime_Count.NormalBoosterTime_47);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_47;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_47;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_47;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_47;
            }
            else if (KartSN_Count.KartSN_48 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_48 = 0;
                    TransAccelFactor_Count.TransAccelFactor_48 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_48 = 0;
                    SteerConstraint_Count.SteerConstraint_48 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_48 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_48 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_48 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_48 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_48: {0}", TransAccelFactor_Count.TransAccelFactor_48);
                Console.WriteLine("SteerConstraint_48: {0}", SteerConstraint_Count.SteerConstraint_48);
                Console.WriteLine("DriftEscapeForce_48: {0}", DriftEscapeForce_Count.DriftEscapeForce_48);
                Console.WriteLine("NormalBoosterTime_48: {0}", NormalBoosterTime_Count.NormalBoosterTime_48);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_48;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_48;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_48;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_48;
            }
            else if (KartSN_Count.KartSN_49 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_49 = 0;
                    TransAccelFactor_Count.TransAccelFactor_49 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_49 = 0;
                    SteerConstraint_Count.SteerConstraint_49 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_49 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_49 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_49 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_49 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_49: {0}", TransAccelFactor_Count.TransAccelFactor_49);
                Console.WriteLine("SteerConstraint_49: {0}", SteerConstraint_Count.SteerConstraint_49);
                Console.WriteLine("DriftEscapeForce_49: {0}", DriftEscapeForce_Count.DriftEscapeForce_49);
                Console.WriteLine("NormalBoosterTime_49: {0}", NormalBoosterTime_Count.NormalBoosterTime_49);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_49;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_49;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_49;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_49;
            }
            else if (KartSN_Count.KartSN_50 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_50 = 0;
                    TransAccelFactor_Count.TransAccelFactor_50 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_50 = 0;
                    SteerConstraint_Count.SteerConstraint_50 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_50 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_50 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_50 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_50 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_50: {0}", TransAccelFactor_Count.TransAccelFactor_50);
                Console.WriteLine("SteerConstraint_50: {0}", SteerConstraint_Count.SteerConstraint_50);
                Console.WriteLine("DriftEscapeForce_50: {0}", DriftEscapeForce_Count.DriftEscapeForce_50);
                Console.WriteLine("NormalBoosterTime_50: {0}", NormalBoosterTime_Count.NormalBoosterTime_50);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_50;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_50;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_50;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_50;
            }
            else if (KartSN_Count.KartSN_51 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_51 = 0;
                    TransAccelFactor_Count.TransAccelFactor_51 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_51 = 0;
                    SteerConstraint_Count.SteerConstraint_51 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_51 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_51 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_51 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_51 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_51: {0}", TransAccelFactor_Count.TransAccelFactor_51);
                Console.WriteLine("SteerConstraint_51: {0}", SteerConstraint_Count.SteerConstraint_51);
                Console.WriteLine("DriftEscapeForce_51: {0}", DriftEscapeForce_Count.DriftEscapeForce_51);
                Console.WriteLine("NormalBoosterTime_51: {0}", NormalBoosterTime_Count.NormalBoosterTime_51);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_51;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_51;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_51;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_51;
            }
            else if (KartSN_Count.KartSN_52 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_52 = 0;
                    TransAccelFactor_Count.TransAccelFactor_52 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_52 = 0;
                    SteerConstraint_Count.SteerConstraint_52 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_52 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_52 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_52 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_52 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_52: {0}", TransAccelFactor_Count.TransAccelFactor_52);
                Console.WriteLine("SteerConstraint_52: {0}", SteerConstraint_Count.SteerConstraint_52);
                Console.WriteLine("DriftEscapeForce_52: {0}", DriftEscapeForce_Count.DriftEscapeForce_52);
                Console.WriteLine("NormalBoosterTime_52: {0}", NormalBoosterTime_Count.NormalBoosterTime_52);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_52;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_52;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_52;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_52;
            }
            else if (KartSN_Count.KartSN_53 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_53 = 0;
                    TransAccelFactor_Count.TransAccelFactor_53 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_53 = 0;
                    SteerConstraint_Count.SteerConstraint_53 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_53 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_53 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_53 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_53 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_53: {0}", TransAccelFactor_Count.TransAccelFactor_53);
                Console.WriteLine("SteerConstraint_53: {0}", SteerConstraint_Count.SteerConstraint_53);
                Console.WriteLine("DriftEscapeForce_53: {0}", DriftEscapeForce_Count.DriftEscapeForce_53);
                Console.WriteLine("NormalBoosterTime_53: {0}", NormalBoosterTime_Count.NormalBoosterTime_53);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_53;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_53;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_53;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_53;
            }
            else if (KartSN_Count.KartSN_54 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_54 = 0;
                    TransAccelFactor_Count.TransAccelFactor_54 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_54 = 0;
                    SteerConstraint_Count.SteerConstraint_54 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_54 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_54 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_54 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_54 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_54: {0}", TransAccelFactor_Count.TransAccelFactor_54);
                Console.WriteLine("SteerConstraint_54: {0}", SteerConstraint_Count.SteerConstraint_54);
                Console.WriteLine("DriftEscapeForce_54: {0}", DriftEscapeForce_Count.DriftEscapeForce_54);
                Console.WriteLine("NormalBoosterTime_54: {0}", NormalBoosterTime_Count.NormalBoosterTime_54);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_54;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_54;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_54;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_54;
            }
            else if (KartSN_Count.KartSN_55 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_55 = 0;
                    TransAccelFactor_Count.TransAccelFactor_55 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_55 = 0;
                    SteerConstraint_Count.SteerConstraint_55 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_55 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_55 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_55 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_55 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_55: {0}", TransAccelFactor_Count.TransAccelFactor_55);
                Console.WriteLine("SteerConstraint_55: {0}", SteerConstraint_Count.SteerConstraint_55);
                Console.WriteLine("DriftEscapeForce_55: {0}", DriftEscapeForce_Count.DriftEscapeForce_55);
                Console.WriteLine("NormalBoosterTime_55: {0}", NormalBoosterTime_Count.NormalBoosterTime_55);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_55;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_55;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_55;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_55;
            }
            else if (KartSN_Count.KartSN_56 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_56 = 0;
                    TransAccelFactor_Count.TransAccelFactor_56 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_56 = 0;
                    SteerConstraint_Count.SteerConstraint_56 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_56 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_56 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_56 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_56 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_56: {0}", TransAccelFactor_Count.TransAccelFactor_56);
                Console.WriteLine("SteerConstraint_56: {0}", SteerConstraint_Count.SteerConstraint_56);
                Console.WriteLine("DriftEscapeForce_56: {0}", DriftEscapeForce_Count.DriftEscapeForce_56);
                Console.WriteLine("NormalBoosterTime_56: {0}", NormalBoosterTime_Count.NormalBoosterTime_56);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_56;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_56;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_56;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_56;
            }
            else if (KartSN_Count.KartSN_57 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_57 = 0;
                    TransAccelFactor_Count.TransAccelFactor_57 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_57 = 0;
                    SteerConstraint_Count.SteerConstraint_57 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_57 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_57 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_57 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_57 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_57: {0}", TransAccelFactor_Count.TransAccelFactor_57);
                Console.WriteLine("SteerConstraint_57: {0}", SteerConstraint_Count.SteerConstraint_57);
                Console.WriteLine("DriftEscapeForce_57: {0}", DriftEscapeForce_Count.DriftEscapeForce_57);
                Console.WriteLine("NormalBoosterTime_57: {0}", NormalBoosterTime_Count.NormalBoosterTime_57);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_57;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_57;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_57;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_57;
            }
            else if (KartSN_Count.KartSN_58 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_58 = 0;
                    TransAccelFactor_Count.TransAccelFactor_58 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_58 = 0;
                    SteerConstraint_Count.SteerConstraint_58 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_58 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_58 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_58 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_58 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_58: {0}", TransAccelFactor_Count.TransAccelFactor_58);
                Console.WriteLine("SteerConstraint_58: {0}", SteerConstraint_Count.SteerConstraint_58);
                Console.WriteLine("DriftEscapeForce_58: {0}", DriftEscapeForce_Count.DriftEscapeForce_58);
                Console.WriteLine("NormalBoosterTime_58: {0}", NormalBoosterTime_Count.NormalBoosterTime_58);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_58;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_58;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_58;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_58;
            }
            else if (KartSN_Count.KartSN_59 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_59 = 0;
                    TransAccelFactor_Count.TransAccelFactor_59 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_59 = 0;
                    SteerConstraint_Count.SteerConstraint_59 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_59 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_59 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_59 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_59 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_59: {0}", TransAccelFactor_Count.TransAccelFactor_59);
                Console.WriteLine("SteerConstraint_59: {0}", SteerConstraint_Count.SteerConstraint_59);
                Console.WriteLine("DriftEscapeForce_59: {0}", DriftEscapeForce_Count.DriftEscapeForce_59);
                Console.WriteLine("NormalBoosterTime_59: {0}", NormalBoosterTime_Count.NormalBoosterTime_59);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_59;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_59;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_59;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_59;
            }
            else if (KartSN_Count.KartSN_60 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_60 = 0;
                    TransAccelFactor_Count.TransAccelFactor_60 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_60 = 0;
                    SteerConstraint_Count.SteerConstraint_60 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_60 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_60 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_60 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_60 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_60: {0}", TransAccelFactor_Count.TransAccelFactor_60);
                Console.WriteLine("SteerConstraint_60: {0}", SteerConstraint_Count.SteerConstraint_60);
                Console.WriteLine("DriftEscapeForce_60: {0}", DriftEscapeForce_Count.DriftEscapeForce_60);
                Console.WriteLine("NormalBoosterTime_60: {0}", NormalBoosterTime_Count.NormalBoosterTime_60);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_60;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_60;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_60;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_60;
            }
            else if (KartSN_Count.KartSN_61 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_61 = 0;
                    TransAccelFactor_Count.TransAccelFactor_61 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_61 = 0;
                    SteerConstraint_Count.SteerConstraint_61 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_61 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_61 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_61 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_61 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_61: {0}", TransAccelFactor_Count.TransAccelFactor_61);
                Console.WriteLine("SteerConstraint_61: {0}", SteerConstraint_Count.SteerConstraint_61);
                Console.WriteLine("DriftEscapeForce_61: {0}", DriftEscapeForce_Count.DriftEscapeForce_61);
                Console.WriteLine("NormalBoosterTime_61: {0}", NormalBoosterTime_Count.NormalBoosterTime_61);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_61;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_61;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_61;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_61;
            }
            else if (KartSN_Count.KartSN_62 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_62 = 0;
                    TransAccelFactor_Count.TransAccelFactor_62 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_62 = 0;
                    SteerConstraint_Count.SteerConstraint_62 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_62 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_62 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_62 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_62 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_62: {0}", TransAccelFactor_Count.TransAccelFactor_62);
                Console.WriteLine("SteerConstraint_62: {0}", SteerConstraint_Count.SteerConstraint_62);
                Console.WriteLine("DriftEscapeForce_62: {0}", DriftEscapeForce_Count.DriftEscapeForce_62);
                Console.WriteLine("NormalBoosterTime_62: {0}", NormalBoosterTime_Count.NormalBoosterTime_62);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_62;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_62;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_62;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_62;
            }
            else if (KartSN_Count.KartSN_63 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_63 = 0;
                    TransAccelFactor_Count.TransAccelFactor_63 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_63 = 0;
                    SteerConstraint_Count.SteerConstraint_63 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_63 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_63 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_63 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_63 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_63: {0}", TransAccelFactor_Count.TransAccelFactor_63);
                Console.WriteLine("SteerConstraint_63: {0}", SteerConstraint_Count.SteerConstraint_63);
                Console.WriteLine("DriftEscapeForce_63: {0}", DriftEscapeForce_Count.DriftEscapeForce_63);
                Console.WriteLine("NormalBoosterTime_63: {0}", NormalBoosterTime_Count.NormalBoosterTime_63);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_63;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_63;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_63;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_63;
            }
            else if (KartSN_Count.KartSN_64 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_64 = 0;
                    TransAccelFactor_Count.TransAccelFactor_64 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_64 = 0;
                    SteerConstraint_Count.SteerConstraint_64 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_64 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_64 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_64 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_64 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_64: {0}", TransAccelFactor_Count.TransAccelFactor_64);
                Console.WriteLine("SteerConstraint_64: {0}", SteerConstraint_Count.SteerConstraint_64);
                Console.WriteLine("DriftEscapeForce_64: {0}", DriftEscapeForce_Count.DriftEscapeForce_64);
                Console.WriteLine("NormalBoosterTime_64: {0}", NormalBoosterTime_Count.NormalBoosterTime_64);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_64;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_64;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_64;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_64;
            }
            else if (KartSN_Count.KartSN_65 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_65 = 0;
                    TransAccelFactor_Count.TransAccelFactor_65 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_65 = 0;
                    SteerConstraint_Count.SteerConstraint_65 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_65 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_65 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_65 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_65 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_65: {0}", TransAccelFactor_Count.TransAccelFactor_65);
                Console.WriteLine("SteerConstraint_65: {0}", SteerConstraint_Count.SteerConstraint_65);
                Console.WriteLine("DriftEscapeForce_65: {0}", DriftEscapeForce_Count.DriftEscapeForce_65);
                Console.WriteLine("NormalBoosterTime_65: {0}", NormalBoosterTime_Count.NormalBoosterTime_65);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_65;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_65;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_65;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_65;
            }
            else if (KartSN_Count.KartSN_66 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_66 = 0;
                    TransAccelFactor_Count.TransAccelFactor_66 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_66 = 0;
                    SteerConstraint_Count.SteerConstraint_66 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_66 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_66 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_66 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_66 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_66: {0}", TransAccelFactor_Count.TransAccelFactor_66);
                Console.WriteLine("SteerConstraint_66: {0}", SteerConstraint_Count.SteerConstraint_66);
                Console.WriteLine("DriftEscapeForce_66: {0}", DriftEscapeForce_Count.DriftEscapeForce_66);
                Console.WriteLine("NormalBoosterTime_66: {0}", NormalBoosterTime_Count.NormalBoosterTime_66);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_66;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_66;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_66;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_66;
            }
            else if (KartSN_Count.KartSN_67 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_67 = 0;
                    TransAccelFactor_Count.TransAccelFactor_67 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_67 = 0;
                    SteerConstraint_Count.SteerConstraint_67 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_67 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_67 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_67 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_67 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_67: {0}", TransAccelFactor_Count.TransAccelFactor_67);
                Console.WriteLine("SteerConstraint_67: {0}", SteerConstraint_Count.SteerConstraint_67);
                Console.WriteLine("DriftEscapeForce_67: {0}", DriftEscapeForce_Count.DriftEscapeForce_67);
                Console.WriteLine("NormalBoosterTime_67: {0}", NormalBoosterTime_Count.NormalBoosterTime_67);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_67;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_67;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_67;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_67;
            }
            else if (KartSN_Count.KartSN_68 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_68 = 0;
                    TransAccelFactor_Count.TransAccelFactor_68 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_68 = 0;
                    SteerConstraint_Count.SteerConstraint_68 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_68 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_68 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_68 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_68 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_68: {0}", TransAccelFactor_Count.TransAccelFactor_68);
                Console.WriteLine("SteerConstraint_68: {0}", SteerConstraint_Count.SteerConstraint_68);
                Console.WriteLine("DriftEscapeForce_68: {0}", DriftEscapeForce_Count.DriftEscapeForce_68);
                Console.WriteLine("NormalBoosterTime_68: {0}", NormalBoosterTime_Count.NormalBoosterTime_68);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_68;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_68;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_68;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_68;
            }
            else if (KartSN_Count.KartSN_69 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_69 = 0;
                    TransAccelFactor_Count.TransAccelFactor_69 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_69 = 0;
                    SteerConstraint_Count.SteerConstraint_69 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_69 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_69 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_69 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_69 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_69: {0}", TransAccelFactor_Count.TransAccelFactor_69);
                Console.WriteLine("SteerConstraint_69: {0}", SteerConstraint_Count.SteerConstraint_69);
                Console.WriteLine("DriftEscapeForce_69: {0}", DriftEscapeForce_Count.DriftEscapeForce_69);
                Console.WriteLine("NormalBoosterTime_69: {0}", NormalBoosterTime_Count.NormalBoosterTime_69);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_69;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_69;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_69;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_69;
            }
            else if (KartSN_Count.KartSN_70 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_70 = 0;
                    TransAccelFactor_Count.TransAccelFactor_70 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_70 = 0;
                    SteerConstraint_Count.SteerConstraint_70 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_70 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_70 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_70 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_70 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_70: {0}", TransAccelFactor_Count.TransAccelFactor_70);
                Console.WriteLine("SteerConstraint_70: {0}", SteerConstraint_Count.SteerConstraint_70);
                Console.WriteLine("DriftEscapeForce_70: {0}", DriftEscapeForce_Count.DriftEscapeForce_70);
                Console.WriteLine("NormalBoosterTime_70: {0}", NormalBoosterTime_Count.NormalBoosterTime_70);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_70;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_70;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_70;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_70;
            }
            else if (KartSN_Count.KartSN_71 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_71 = 0;
                    TransAccelFactor_Count.TransAccelFactor_71 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_71 = 0;
                    SteerConstraint_Count.SteerConstraint_71 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_71 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_71 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_71 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_71 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_71: {0}", TransAccelFactor_Count.TransAccelFactor_71);
                Console.WriteLine("SteerConstraint_71: {0}", SteerConstraint_Count.SteerConstraint_71);
                Console.WriteLine("DriftEscapeForce_71: {0}", DriftEscapeForce_Count.DriftEscapeForce_71);
                Console.WriteLine("NormalBoosterTime_71: {0}", NormalBoosterTime_Count.NormalBoosterTime_71);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_71;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_71;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_71;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_71;
            }
            else if (KartSN_Count.KartSN_72 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_72 = 0;
                    TransAccelFactor_Count.TransAccelFactor_72 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_72 = 0;
                    SteerConstraint_Count.SteerConstraint_72 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_72 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_72 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_72 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_72 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_72: {0}", TransAccelFactor_Count.TransAccelFactor_72);
                Console.WriteLine("SteerConstraint_72: {0}", SteerConstraint_Count.SteerConstraint_72);
                Console.WriteLine("DriftEscapeForce_72: {0}", DriftEscapeForce_Count.DriftEscapeForce_72);
                Console.WriteLine("NormalBoosterTime_72: {0}", NormalBoosterTime_Count.NormalBoosterTime_72);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_72;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_72;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_72;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_72;
            }
            else if (KartSN_Count.KartSN_73 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_73 = 0;
                    TransAccelFactor_Count.TransAccelFactor_73 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_73 = 0;
                    SteerConstraint_Count.SteerConstraint_73 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_73 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_73 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_73 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_73 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_73: {0}", TransAccelFactor_Count.TransAccelFactor_73);
                Console.WriteLine("SteerConstraint_73: {0}", SteerConstraint_Count.SteerConstraint_73);
                Console.WriteLine("DriftEscapeForce_73: {0}", DriftEscapeForce_Count.DriftEscapeForce_73);
                Console.WriteLine("NormalBoosterTime_73: {0}", NormalBoosterTime_Count.NormalBoosterTime_73);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_73;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_73;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_73;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_73;
            }
            else if (KartSN_Count.KartSN_74 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_74 = 0;
                    TransAccelFactor_Count.TransAccelFactor_74 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_74 = 0;
                    SteerConstraint_Count.SteerConstraint_74 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_74 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_74 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_74 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_74 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_74: {0}", TransAccelFactor_Count.TransAccelFactor_74);
                Console.WriteLine("SteerConstraint_74: {0}", SteerConstraint_Count.SteerConstraint_74);
                Console.WriteLine("DriftEscapeForce_74: {0}", DriftEscapeForce_Count.DriftEscapeForce_74);
                Console.WriteLine("NormalBoosterTime_74: {0}", NormalBoosterTime_Count.NormalBoosterTime_74);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_74;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_74;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_74;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_74;
            }
            else if (KartSN_Count.KartSN_75 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_75 = 0;
                    TransAccelFactor_Count.TransAccelFactor_75 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_75 = 0;
                    SteerConstraint_Count.SteerConstraint_75 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_75 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_75 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_75 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_75 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_75: {0}", TransAccelFactor_Count.TransAccelFactor_75);
                Console.WriteLine("SteerConstraint_75: {0}", SteerConstraint_Count.SteerConstraint_75);
                Console.WriteLine("DriftEscapeForce_75: {0}", DriftEscapeForce_Count.DriftEscapeForce_75);
                Console.WriteLine("NormalBoosterTime_75: {0}", NormalBoosterTime_Count.NormalBoosterTime_75);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_75;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_75;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_75;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_75;
            }
            else if (KartSN_Count.KartSN_76 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_76 = 0;
                    TransAccelFactor_Count.TransAccelFactor_76 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_76 = 0;
                    SteerConstraint_Count.SteerConstraint_76 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_76 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_76 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_76 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_76 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_76: {0}", TransAccelFactor_Count.TransAccelFactor_76);
                Console.WriteLine("SteerConstraint_76: {0}", SteerConstraint_Count.SteerConstraint_76);
                Console.WriteLine("DriftEscapeForce_76: {0}", DriftEscapeForce_Count.DriftEscapeForce_76);
                Console.WriteLine("NormalBoosterTime_76: {0}", NormalBoosterTime_Count.NormalBoosterTime_76);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_76;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_76;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_76;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_76;
            }
            else if (KartSN_Count.KartSN_77 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_77 = 0;
                    TransAccelFactor_Count.TransAccelFactor_77 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_77 = 0;
                    SteerConstraint_Count.SteerConstraint_77 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_77 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_77 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_77 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_77 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_77: {0}", TransAccelFactor_Count.TransAccelFactor_77);
                Console.WriteLine("SteerConstraint_77: {0}", SteerConstraint_Count.SteerConstraint_77);
                Console.WriteLine("DriftEscapeForce_77: {0}", DriftEscapeForce_Count.DriftEscapeForce_77);
                Console.WriteLine("NormalBoosterTime_77: {0}", NormalBoosterTime_Count.NormalBoosterTime_77);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_77;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_77;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_77;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_77;
            }
            else if (KartSN_Count.KartSN_78 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_78 = 0;
                    TransAccelFactor_Count.TransAccelFactor_78 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_78 = 0;
                    SteerConstraint_Count.SteerConstraint_78 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_78 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_78 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_78 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_78 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_78: {0}", TransAccelFactor_Count.TransAccelFactor_78);
                Console.WriteLine("SteerConstraint_78: {0}", SteerConstraint_Count.SteerConstraint_78);
                Console.WriteLine("DriftEscapeForce_78: {0}", DriftEscapeForce_Count.DriftEscapeForce_78);
                Console.WriteLine("NormalBoosterTime_78: {0}", NormalBoosterTime_Count.NormalBoosterTime_78);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_78;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_78;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_78;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_78;
            }
            else if (KartSN_Count.KartSN_79 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_79 = 0;
                    TransAccelFactor_Count.TransAccelFactor_79 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_79 = 0;
                    SteerConstraint_Count.SteerConstraint_79 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_79 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_79 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_79 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_79 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_79: {0}", TransAccelFactor_Count.TransAccelFactor_79);
                Console.WriteLine("SteerConstraint_79: {0}", SteerConstraint_Count.SteerConstraint_79);
                Console.WriteLine("DriftEscapeForce_79: {0}", DriftEscapeForce_Count.DriftEscapeForce_79);
                Console.WriteLine("NormalBoosterTime_79: {0}", NormalBoosterTime_Count.NormalBoosterTime_79);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_79;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_79;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_79;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_79;
            }
            else if (KartSN_Count.KartSN_80 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_80 = 0;
                    TransAccelFactor_Count.TransAccelFactor_80 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_80 = 0;
                    SteerConstraint_Count.SteerConstraint_80 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_80 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_80 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_80 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_80 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_80: {0}", TransAccelFactor_Count.TransAccelFactor_80);
                Console.WriteLine("SteerConstraint_80: {0}", SteerConstraint_Count.SteerConstraint_80);
                Console.WriteLine("DriftEscapeForce_80: {0}", DriftEscapeForce_Count.DriftEscapeForce_80);
                Console.WriteLine("NormalBoosterTime_80: {0}", NormalBoosterTime_Count.NormalBoosterTime_80);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_80;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_80;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_80;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_80;
            }
            else if (KartSN_Count.KartSN_81 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_81 = 0;
                    TransAccelFactor_Count.TransAccelFactor_81 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_81 = 0;
                    SteerConstraint_Count.SteerConstraint_81 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_81 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_81 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_81 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_81 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_81: {0}", TransAccelFactor_Count.TransAccelFactor_81);
                Console.WriteLine("SteerConstraint_81: {0}", SteerConstraint_Count.SteerConstraint_81);
                Console.WriteLine("DriftEscapeForce_81: {0}", DriftEscapeForce_Count.DriftEscapeForce_81);
                Console.WriteLine("NormalBoosterTime_81: {0}", NormalBoosterTime_Count.NormalBoosterTime_81);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_81;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_81;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_81;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_81;
            }
            else if (KartSN_Count.KartSN_82 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_82 = 0;
                    TransAccelFactor_Count.TransAccelFactor_82 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_82 = 0;
                    SteerConstraint_Count.SteerConstraint_82 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_82 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_82 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_82 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_82 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_82: {0}", TransAccelFactor_Count.TransAccelFactor_82);
                Console.WriteLine("SteerConstraint_82: {0}", SteerConstraint_Count.SteerConstraint_82);
                Console.WriteLine("DriftEscapeForce_82: {0}", DriftEscapeForce_Count.DriftEscapeForce_82);
                Console.WriteLine("NormalBoosterTime_82: {0}", NormalBoosterTime_Count.NormalBoosterTime_82);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_82;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_82;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_82;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_82;
            }
            else if (KartSN_Count.KartSN_83 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_83 = 0;
                    TransAccelFactor_Count.TransAccelFactor_83 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_83 = 0;
                    SteerConstraint_Count.SteerConstraint_83 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_83 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_83 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_83 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_83 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_83: {0}", TransAccelFactor_Count.TransAccelFactor_83);
                Console.WriteLine("SteerConstraint_83: {0}", SteerConstraint_Count.SteerConstraint_83);
                Console.WriteLine("DriftEscapeForce_83: {0}", DriftEscapeForce_Count.DriftEscapeForce_83);
                Console.WriteLine("NormalBoosterTime_83: {0}", NormalBoosterTime_Count.NormalBoosterTime_83);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_83;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_83;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_83;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_83;
            }
            else if (KartSN_Count.KartSN_84 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_84 = 0;
                    TransAccelFactor_Count.TransAccelFactor_84 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_84 = 0;
                    SteerConstraint_Count.SteerConstraint_84 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_84 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_84 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_84 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_84 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_84: {0}", TransAccelFactor_Count.TransAccelFactor_84);
                Console.WriteLine("SteerConstraint_84: {0}", SteerConstraint_Count.SteerConstraint_84);
                Console.WriteLine("DriftEscapeForce_84: {0}", DriftEscapeForce_Count.DriftEscapeForce_84);
                Console.WriteLine("NormalBoosterTime_84: {0}", NormalBoosterTime_Count.NormalBoosterTime_84);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_84;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_84;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_84;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_84;
            }
            else if (KartSN_Count.KartSN_85 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_85 = 0;
                    TransAccelFactor_Count.TransAccelFactor_85 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_85 = 0;
                    SteerConstraint_Count.SteerConstraint_85 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_85 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_85 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_85 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_85 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_85: {0}", TransAccelFactor_Count.TransAccelFactor_85);
                Console.WriteLine("SteerConstraint_85: {0}", SteerConstraint_Count.SteerConstraint_85);
                Console.WriteLine("DriftEscapeForce_85: {0}", DriftEscapeForce_Count.DriftEscapeForce_85);
                Console.WriteLine("NormalBoosterTime_85: {0}", NormalBoosterTime_Count.NormalBoosterTime_85);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_85;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_85;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_85;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_85;
            }
            else if (KartSN_Count.KartSN_86 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_86 = 0;
                    TransAccelFactor_Count.TransAccelFactor_86 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_86 = 0;
                    SteerConstraint_Count.SteerConstraint_86 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_86 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_86 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_86 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_86 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_86: {0}", TransAccelFactor_Count.TransAccelFactor_86);
                Console.WriteLine("SteerConstraint_86: {0}", SteerConstraint_Count.SteerConstraint_86);
                Console.WriteLine("DriftEscapeForce_86: {0}", DriftEscapeForce_Count.DriftEscapeForce_86);
                Console.WriteLine("NormalBoosterTime_86: {0}", NormalBoosterTime_Count.NormalBoosterTime_86);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_86;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_86;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_86;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_86;
            }
            else if (KartSN_Count.KartSN_87 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_87 = 0;
                    TransAccelFactor_Count.TransAccelFactor_87 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_87 = 0;
                    SteerConstraint_Count.SteerConstraint_87 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_87 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_87 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_87 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_87 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_87: {0}", TransAccelFactor_Count.TransAccelFactor_87);
                Console.WriteLine("SteerConstraint_87: {0}", SteerConstraint_Count.SteerConstraint_87);
                Console.WriteLine("DriftEscapeForce_87: {0}", DriftEscapeForce_Count.DriftEscapeForce_87);
                Console.WriteLine("NormalBoosterTime_87: {0}", NormalBoosterTime_Count.NormalBoosterTime_87);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_87;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_87;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_87;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_87;
            }
            else if (KartSN_Count.KartSN_88 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_88 = 0;
                    TransAccelFactor_Count.TransAccelFactor_88 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_88 = 0;
                    SteerConstraint_Count.SteerConstraint_88 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_88 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_88 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_88 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_88 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_88: {0}", TransAccelFactor_Count.TransAccelFactor_88);
                Console.WriteLine("SteerConstraint_88: {0}", SteerConstraint_Count.SteerConstraint_88);
                Console.WriteLine("DriftEscapeForce_88: {0}", DriftEscapeForce_Count.DriftEscapeForce_88);
                Console.WriteLine("NormalBoosterTime_88: {0}", NormalBoosterTime_Count.NormalBoosterTime_88);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_88;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_88;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_88;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_88;
            }
            else if (KartSN_Count.KartSN_89 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_89 = 0;
                    TransAccelFactor_Count.TransAccelFactor_89 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_89 = 0;
                    SteerConstraint_Count.SteerConstraint_89 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_89 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_89 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_89 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_89 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_89: {0}", TransAccelFactor_Count.TransAccelFactor_89);
                Console.WriteLine("SteerConstraint_89: {0}", SteerConstraint_Count.SteerConstraint_89);
                Console.WriteLine("DriftEscapeForce_89: {0}", DriftEscapeForce_Count.DriftEscapeForce_89);
                Console.WriteLine("NormalBoosterTime_89: {0}", NormalBoosterTime_Count.NormalBoosterTime_89);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_89;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_89;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_89;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_89;
            }
            else if (KartSN_Count.KartSN_90 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_90 = 0;
                    TransAccelFactor_Count.TransAccelFactor_90 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_90 = 0;
                    SteerConstraint_Count.SteerConstraint_90 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_90 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_90 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_90 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_90 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_90: {0}", TransAccelFactor_Count.TransAccelFactor_90);
                Console.WriteLine("SteerConstraint_90: {0}", SteerConstraint_Count.SteerConstraint_90);
                Console.WriteLine("DriftEscapeForce_90: {0}", DriftEscapeForce_Count.DriftEscapeForce_90);
                Console.WriteLine("NormalBoosterTime_90: {0}", NormalBoosterTime_Count.NormalBoosterTime_90);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_90;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_90;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_90;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_90;
            }
            else if (KartSN_Count.KartSN_91 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_91 = 0;
                    TransAccelFactor_Count.TransAccelFactor_91 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_91 = 0;
                    SteerConstraint_Count.SteerConstraint_91 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_91 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_91 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_91 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_91 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_91: {0}", TransAccelFactor_Count.TransAccelFactor_91);
                Console.WriteLine("SteerConstraint_91: {0}", SteerConstraint_Count.SteerConstraint_91);
                Console.WriteLine("DriftEscapeForce_91: {0}", DriftEscapeForce_Count.DriftEscapeForce_91);
                Console.WriteLine("NormalBoosterTime_91: {0}", NormalBoosterTime_Count.NormalBoosterTime_91);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_91;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_91;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_91;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_91;
            }
            else if (KartSN_Count.KartSN_92 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_92 = 0;
                    TransAccelFactor_Count.TransAccelFactor_92 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_92 = 0;
                    SteerConstraint_Count.SteerConstraint_92 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_92 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_92 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_92 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_92 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_92: {0}", TransAccelFactor_Count.TransAccelFactor_92);
                Console.WriteLine("SteerConstraint_92: {0}", SteerConstraint_Count.SteerConstraint_92);
                Console.WriteLine("DriftEscapeForce_92: {0}", DriftEscapeForce_Count.DriftEscapeForce_92);
                Console.WriteLine("NormalBoosterTime_92: {0}", NormalBoosterTime_Count.NormalBoosterTime_92);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_92;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_92;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_92;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_92;
            }
            else if (KartSN_Count.KartSN_93 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_93 = 0;
                    TransAccelFactor_Count.TransAccelFactor_93 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_93 = 0;
                    SteerConstraint_Count.SteerConstraint_93 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_93 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_93 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_93 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_93 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_93: {0}", TransAccelFactor_Count.TransAccelFactor_93);
                Console.WriteLine("SteerConstraint_93: {0}", SteerConstraint_Count.SteerConstraint_93);
                Console.WriteLine("DriftEscapeForce_93: {0}", DriftEscapeForce_Count.DriftEscapeForce_93);
                Console.WriteLine("NormalBoosterTime_93: {0}", NormalBoosterTime_Count.NormalBoosterTime_93);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_93;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_93;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_93;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_93;
            }
            else if (KartSN_Count.KartSN_94 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_94 = 0;
                    TransAccelFactor_Count.TransAccelFactor_94 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_94 = 0;
                    SteerConstraint_Count.SteerConstraint_94 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_94 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_94 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_94 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_94 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_94: {0}", TransAccelFactor_Count.TransAccelFactor_94);
                Console.WriteLine("SteerConstraint_94: {0}", SteerConstraint_Count.SteerConstraint_94);
                Console.WriteLine("DriftEscapeForce_94: {0}", DriftEscapeForce_Count.DriftEscapeForce_94);
                Console.WriteLine("NormalBoosterTime_94: {0}", NormalBoosterTime_Count.NormalBoosterTime_94);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_94;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_94;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_94;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_94;
            }
            else if (KartSN_Count.KartSN_95 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_95 = 0;
                    TransAccelFactor_Count.TransAccelFactor_95 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_95 = 0;
                    SteerConstraint_Count.SteerConstraint_95 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_95 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_95 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_95 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_95 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_95: {0}", TransAccelFactor_Count.TransAccelFactor_95);
                Console.WriteLine("SteerConstraint_95: {0}", SteerConstraint_Count.SteerConstraint_95);
                Console.WriteLine("DriftEscapeForce_95: {0}", DriftEscapeForce_Count.DriftEscapeForce_95);
                Console.WriteLine("NormalBoosterTime_95: {0}", NormalBoosterTime_Count.NormalBoosterTime_95);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_95;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_95;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_95;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_95;
            }
            else if (KartSN_Count.KartSN_96 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_96 = 0;
                    TransAccelFactor_Count.TransAccelFactor_96 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_96 = 0;
                    SteerConstraint_Count.SteerConstraint_96 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_96 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_96 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_96 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_96 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_96: {0}", TransAccelFactor_Count.TransAccelFactor_96);
                Console.WriteLine("SteerConstraint_96: {0}", SteerConstraint_Count.SteerConstraint_96);
                Console.WriteLine("DriftEscapeForce_96: {0}", DriftEscapeForce_Count.DriftEscapeForce_96);
                Console.WriteLine("NormalBoosterTime_96: {0}", NormalBoosterTime_Count.NormalBoosterTime_96);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_96;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_96;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_96;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_96;
            }
            else if (KartSN_Count.KartSN_97 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_97 = 0;
                    TransAccelFactor_Count.TransAccelFactor_97 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_97 = 0;
                    SteerConstraint_Count.SteerConstraint_97 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_97 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_97 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_97 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_97 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_97: {0}", TransAccelFactor_Count.TransAccelFactor_97);
                Console.WriteLine("SteerConstraint_97: {0}", SteerConstraint_Count.SteerConstraint_97);
                Console.WriteLine("DriftEscapeForce_97: {0}", DriftEscapeForce_Count.DriftEscapeForce_97);
                Console.WriteLine("NormalBoosterTime_97: {0}", NormalBoosterTime_Count.NormalBoosterTime_97);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_97;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_97;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_97;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_97;
            }
            else if (KartSN_Count.KartSN_98 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_98 = 0;
                    TransAccelFactor_Count.TransAccelFactor_98 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_98 = 0;
                    SteerConstraint_Count.SteerConstraint_98 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_98 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_98 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_98 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_98 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_98: {0}", TransAccelFactor_Count.TransAccelFactor_98);
                Console.WriteLine("SteerConstraint_98: {0}", SteerConstraint_Count.SteerConstraint_98);
                Console.WriteLine("DriftEscapeForce_98: {0}", DriftEscapeForce_Count.DriftEscapeForce_98);
                Console.WriteLine("NormalBoosterTime_98: {0}", NormalBoosterTime_Count.NormalBoosterTime_98);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_98;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_98;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_98;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_98;
            }
            else if (KartSN_Count.KartSN_99 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_99 = 0;
                    TransAccelFactor_Count.TransAccelFactor_99 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_99 = 0;
                    SteerConstraint_Count.SteerConstraint_99 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_99 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_99 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_99 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_99 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_99: {0}", TransAccelFactor_Count.TransAccelFactor_99);
                Console.WriteLine("SteerConstraint_99: {0}", SteerConstraint_Count.SteerConstraint_99);
                Console.WriteLine("DriftEscapeForce_99: {0}", DriftEscapeForce_Count.DriftEscapeForce_99);
                Console.WriteLine("NormalBoosterTime_99: {0}", NormalBoosterTime_Count.NormalBoosterTime_99);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_99;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_99;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_99;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_99;
            }
            else if (KartSN_Count.KartSN_100 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_100 = 0;
                    TransAccelFactor_Count.TransAccelFactor_100 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_100 = 0;
                    SteerConstraint_Count.SteerConstraint_100 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_100 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_100 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_100 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_100 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_100: {0}", TransAccelFactor_Count.TransAccelFactor_100);
                Console.WriteLine("SteerConstraint_100: {0}", SteerConstraint_Count.SteerConstraint_100);
                Console.WriteLine("DriftEscapeForce_100: {0}", DriftEscapeForce_Count.DriftEscapeForce_100);
                Console.WriteLine("NormalBoosterTime_100: {0}", NormalBoosterTime_Count.NormalBoosterTime_100);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_100;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_100;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_100;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_100;
            }
            else if (KartSN_Count.KartSN_101 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_101 = 0;
                    TransAccelFactor_Count.TransAccelFactor_101 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_101 = 0;
                    SteerConstraint_Count.SteerConstraint_101 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_101 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_101 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_101 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_101 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_101: {0}", TransAccelFactor_Count.TransAccelFactor_101);
                Console.WriteLine("SteerConstraint_101: {0}", SteerConstraint_Count.SteerConstraint_101);
                Console.WriteLine("DriftEscapeForce_101: {0}", DriftEscapeForce_Count.DriftEscapeForce_101);
                Console.WriteLine("NormalBoosterTime_101: {0}", NormalBoosterTime_Count.NormalBoosterTime_101);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_101;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_101;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_101;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_101;
            }
            else if (KartSN_Count.KartSN_102 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_102 = 0;
                    TransAccelFactor_Count.TransAccelFactor_102 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_102 = 0;
                    SteerConstraint_Count.SteerConstraint_102 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_102 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_102 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_102 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_102 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_102: {0}", TransAccelFactor_Count.TransAccelFactor_102);
                Console.WriteLine("SteerConstraint_102: {0}", SteerConstraint_Count.SteerConstraint_102);
                Console.WriteLine("DriftEscapeForce_102: {0}", DriftEscapeForce_Count.DriftEscapeForce_102);
                Console.WriteLine("NormalBoosterTime_102: {0}", NormalBoosterTime_Count.NormalBoosterTime_102);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_102;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_102;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_102;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_102;
            }
            else if (KartSN_Count.KartSN_103 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_103 = 0;
                    TransAccelFactor_Count.TransAccelFactor_103 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_103 = 0;
                    SteerConstraint_Count.SteerConstraint_103 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_103 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_103 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_103 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_103 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_103: {0}", TransAccelFactor_Count.TransAccelFactor_103);
                Console.WriteLine("SteerConstraint_103: {0}", SteerConstraint_Count.SteerConstraint_103);
                Console.WriteLine("DriftEscapeForce_103: {0}", DriftEscapeForce_Count.DriftEscapeForce_103);
                Console.WriteLine("NormalBoosterTime_103: {0}", NormalBoosterTime_Count.NormalBoosterTime_103);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_103;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_103;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_103;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_103;
            }
            else if (KartSN_Count.KartSN_104 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_104 = 0;
                    TransAccelFactor_Count.TransAccelFactor_104 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_104 = 0;
                    SteerConstraint_Count.SteerConstraint_104 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_104 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_104 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_104 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_104 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_104: {0}", TransAccelFactor_Count.TransAccelFactor_104);
                Console.WriteLine("SteerConstraint_104: {0}", SteerConstraint_Count.SteerConstraint_104);
                Console.WriteLine("DriftEscapeForce_104: {0}", DriftEscapeForce_Count.DriftEscapeForce_104);
                Console.WriteLine("NormalBoosterTime_104: {0}", NormalBoosterTime_Count.NormalBoosterTime_104);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_104;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_104;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_104;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_104;
            }
            else if (KartSN_Count.KartSN_105 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_105 = 0;
                    TransAccelFactor_Count.TransAccelFactor_105 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_105 = 0;
                    SteerConstraint_Count.SteerConstraint_105 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_105 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_105 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_105 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_105 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_105: {0}", TransAccelFactor_Count.TransAccelFactor_105);
                Console.WriteLine("SteerConstraint_105: {0}", SteerConstraint_Count.SteerConstraint_105);
                Console.WriteLine("DriftEscapeForce_105: {0}", DriftEscapeForce_Count.DriftEscapeForce_105);
                Console.WriteLine("NormalBoosterTime_105: {0}", NormalBoosterTime_Count.NormalBoosterTime_105);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_105;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_105;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_105;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_105;
            }
            else if (KartSN_Count.KartSN_106 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_106 = 0;
                    TransAccelFactor_Count.TransAccelFactor_106 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_106 = 0;
                    SteerConstraint_Count.SteerConstraint_106 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_106 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_106 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_106 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_106 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_106: {0}", TransAccelFactor_Count.TransAccelFactor_106);
                Console.WriteLine("SteerConstraint_106: {0}", SteerConstraint_Count.SteerConstraint_106);
                Console.WriteLine("DriftEscapeForce_106: {0}", DriftEscapeForce_Count.DriftEscapeForce_106);
                Console.WriteLine("NormalBoosterTime_106: {0}", NormalBoosterTime_Count.NormalBoosterTime_106);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_106;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_106;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_106;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_106;
            }
            else if (KartSN_Count.KartSN_107 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_107 = 0;
                    TransAccelFactor_Count.TransAccelFactor_107 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_107 = 0;
                    SteerConstraint_Count.SteerConstraint_107 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_107 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_107 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_107 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_107 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_107: {0}", TransAccelFactor_Count.TransAccelFactor_107);
                Console.WriteLine("SteerConstraint_107: {0}", SteerConstraint_Count.SteerConstraint_107);
                Console.WriteLine("DriftEscapeForce_107: {0}", DriftEscapeForce_Count.DriftEscapeForce_107);
                Console.WriteLine("NormalBoosterTime_107: {0}", NormalBoosterTime_Count.NormalBoosterTime_107);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_107;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_107;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_107;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_107;
            }
            else if (KartSN_Count.KartSN_108 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_108 = 0;
                    TransAccelFactor_Count.TransAccelFactor_108 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_108 = 0;
                    SteerConstraint_Count.SteerConstraint_108 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_108 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_108 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_108 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_108 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_108: {0}", TransAccelFactor_Count.TransAccelFactor_108);
                Console.WriteLine("SteerConstraint_108: {0}", SteerConstraint_Count.SteerConstraint_108);
                Console.WriteLine("DriftEscapeForce_108: {0}", DriftEscapeForce_Count.DriftEscapeForce_108);
                Console.WriteLine("NormalBoosterTime_108: {0}", NormalBoosterTime_Count.NormalBoosterTime_108);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_108;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_108;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_108;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_108;
            }
            else if (KartSN_Count.KartSN_109 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_109 = 0;
                    TransAccelFactor_Count.TransAccelFactor_109 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_109 = 0;
                    SteerConstraint_Count.SteerConstraint_109 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_109 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_109 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_109 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_109 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_109: {0}", TransAccelFactor_Count.TransAccelFactor_109);
                Console.WriteLine("SteerConstraint_109: {0}", SteerConstraint_Count.SteerConstraint_109);
                Console.WriteLine("DriftEscapeForce_109: {0}", DriftEscapeForce_Count.DriftEscapeForce_109);
                Console.WriteLine("NormalBoosterTime_109: {0}", NormalBoosterTime_Count.NormalBoosterTime_109);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_109;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_109;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_109;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_109;
            }
            else if (KartSN_Count.KartSN_110 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_110 = 0;
                    TransAccelFactor_Count.TransAccelFactor_110 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_110 = 0;
                    SteerConstraint_Count.SteerConstraint_110 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_110 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_110 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_110 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_110 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_110: {0}", TransAccelFactor_Count.TransAccelFactor_110);
                Console.WriteLine("SteerConstraint_110: {0}", SteerConstraint_Count.SteerConstraint_110);
                Console.WriteLine("DriftEscapeForce_110: {0}", DriftEscapeForce_Count.DriftEscapeForce_110);
                Console.WriteLine("NormalBoosterTime_110: {0}", NormalBoosterTime_Count.NormalBoosterTime_110);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_110;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_110;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_110;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_110;
            }
            else if (KartSN_Count.KartSN_111 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_111 = 0;
                    TransAccelFactor_Count.TransAccelFactor_111 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_111 = 0;
                    SteerConstraint_Count.SteerConstraint_111 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_111 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_111 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_111 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_111 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_111: {0}", TransAccelFactor_Count.TransAccelFactor_111);
                Console.WriteLine("SteerConstraint_111: {0}", SteerConstraint_Count.SteerConstraint_111);
                Console.WriteLine("DriftEscapeForce_111: {0}", DriftEscapeForce_Count.DriftEscapeForce_111);
                Console.WriteLine("NormalBoosterTime_111: {0}", NormalBoosterTime_Count.NormalBoosterTime_111);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_111;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_111;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_111;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_111;
            }
            else if (KartSN_Count.KartSN_112 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_112 = 0;
                    TransAccelFactor_Count.TransAccelFactor_112 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_112 = 0;
                    SteerConstraint_Count.SteerConstraint_112 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_112 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_112 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_112 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_112 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_112: {0}", TransAccelFactor_Count.TransAccelFactor_112);
                Console.WriteLine("SteerConstraint_112: {0}", SteerConstraint_Count.SteerConstraint_112);
                Console.WriteLine("DriftEscapeForce_112: {0}", DriftEscapeForce_Count.DriftEscapeForce_112);
                Console.WriteLine("NormalBoosterTime_112: {0}", NormalBoosterTime_Count.NormalBoosterTime_112);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_112;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_112;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_112;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_112;
            }
            else if (KartSN_Count.KartSN_113 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_113 = 0;
                    TransAccelFactor_Count.TransAccelFactor_113 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_113 = 0;
                    SteerConstraint_Count.SteerConstraint_113 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_113 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_113 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_113 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_113 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_113: {0}", TransAccelFactor_Count.TransAccelFactor_113);
                Console.WriteLine("SteerConstraint_113: {0}", SteerConstraint_Count.SteerConstraint_113);
                Console.WriteLine("DriftEscapeForce_113: {0}", DriftEscapeForce_Count.DriftEscapeForce_113);
                Console.WriteLine("NormalBoosterTime_113: {0}", NormalBoosterTime_Count.NormalBoosterTime_113);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_113;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_113;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_113;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_113;
            }
            else if (KartSN_Count.KartSN_114 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_114 = 0;
                    TransAccelFactor_Count.TransAccelFactor_114 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_114 = 0;
                    SteerConstraint_Count.SteerConstraint_114 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_114 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_114 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_114 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_114 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_114: {0}", TransAccelFactor_Count.TransAccelFactor_114);
                Console.WriteLine("SteerConstraint_114: {0}", SteerConstraint_Count.SteerConstraint_114);
                Console.WriteLine("DriftEscapeForce_114: {0}", DriftEscapeForce_Count.DriftEscapeForce_114);
                Console.WriteLine("NormalBoosterTime_114: {0}", NormalBoosterTime_Count.NormalBoosterTime_114);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_114;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_114;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_114;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_114;
            }
            else if (KartSN_Count.KartSN_115 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_115 = 0;
                    TransAccelFactor_Count.TransAccelFactor_115 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_115 = 0;
                    SteerConstraint_Count.SteerConstraint_115 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_115 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_115 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_115 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_115 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_115: {0}", TransAccelFactor_Count.TransAccelFactor_115);
                Console.WriteLine("SteerConstraint_115: {0}", SteerConstraint_Count.SteerConstraint_115);
                Console.WriteLine("DriftEscapeForce_115: {0}", DriftEscapeForce_Count.DriftEscapeForce_115);
                Console.WriteLine("NormalBoosterTime_115: {0}", NormalBoosterTime_Count.NormalBoosterTime_115);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_115;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_115;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_115;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_115;
            }
            else if (KartSN_Count.KartSN_116 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_116 = 0;
                    TransAccelFactor_Count.TransAccelFactor_116 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_116 = 0;
                    SteerConstraint_Count.SteerConstraint_116 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_116 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_116 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_116 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_116 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_116: {0}", TransAccelFactor_Count.TransAccelFactor_116);
                Console.WriteLine("SteerConstraint_116: {0}", SteerConstraint_Count.SteerConstraint_116);
                Console.WriteLine("DriftEscapeForce_116: {0}", DriftEscapeForce_Count.DriftEscapeForce_116);
                Console.WriteLine("NormalBoosterTime_116: {0}", NormalBoosterTime_Count.NormalBoosterTime_116);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_116;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_116;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_116;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_116;
            }
            else if (KartSN_Count.KartSN_117 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_117 = 0;
                    TransAccelFactor_Count.TransAccelFactor_117 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_117 = 0;
                    SteerConstraint_Count.SteerConstraint_117 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_117 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_117 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_117 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_117 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_117: {0}", TransAccelFactor_Count.TransAccelFactor_117);
                Console.WriteLine("SteerConstraint_117: {0}", SteerConstraint_Count.SteerConstraint_117);
                Console.WriteLine("DriftEscapeForce_117: {0}", DriftEscapeForce_Count.DriftEscapeForce_117);
                Console.WriteLine("NormalBoosterTime_117: {0}", NormalBoosterTime_Count.NormalBoosterTime_117);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_117;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_117;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_117;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_117;
            }
            else if (KartSN_Count.KartSN_118 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_118 = 0;
                    TransAccelFactor_Count.TransAccelFactor_118 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_118 = 0;
                    SteerConstraint_Count.SteerConstraint_118 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_118 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_118 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_118 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_118 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_118: {0}", TransAccelFactor_Count.TransAccelFactor_118);
                Console.WriteLine("SteerConstraint_118: {0}", SteerConstraint_Count.SteerConstraint_118);
                Console.WriteLine("DriftEscapeForce_118: {0}", DriftEscapeForce_Count.DriftEscapeForce_118);
                Console.WriteLine("NormalBoosterTime_118: {0}", NormalBoosterTime_Count.NormalBoosterTime_118);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_118;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_118;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_118;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_118;
            }
            else if (KartSN_Count.KartSN_119 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_119 = 0;
                    TransAccelFactor_Count.TransAccelFactor_119 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_119 = 0;
                    SteerConstraint_Count.SteerConstraint_119 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_119 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_119 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_119 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_119 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_119: {0}", TransAccelFactor_Count.TransAccelFactor_119);
                Console.WriteLine("SteerConstraint_119: {0}", SteerConstraint_Count.SteerConstraint_119);
                Console.WriteLine("DriftEscapeForce_119: {0}", DriftEscapeForce_Count.DriftEscapeForce_119);
                Console.WriteLine("NormalBoosterTime_119: {0}", NormalBoosterTime_Count.NormalBoosterTime_119);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_119;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_119;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_119;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_119;
            }
            else if (KartSN_Count.KartSN_120 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_120 = 0;
                    TransAccelFactor_Count.TransAccelFactor_120 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_120 = 0;
                    SteerConstraint_Count.SteerConstraint_120 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_120 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_120 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_120 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_120 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_120: {0}", TransAccelFactor_Count.TransAccelFactor_120);
                Console.WriteLine("SteerConstraint_120: {0}", SteerConstraint_Count.SteerConstraint_120);
                Console.WriteLine("DriftEscapeForce_120: {0}", DriftEscapeForce_Count.DriftEscapeForce_120);
                Console.WriteLine("NormalBoosterTime_120: {0}", NormalBoosterTime_Count.NormalBoosterTime_120);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_120;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_120;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_120;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_120;
            }
            else if (KartSN_Count.KartSN_121 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_121 = 0;
                    TransAccelFactor_Count.TransAccelFactor_121 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_121 = 0;
                    SteerConstraint_Count.SteerConstraint_121 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_121 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_121 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_121 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_121 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_121: {0}", TransAccelFactor_Count.TransAccelFactor_121);
                Console.WriteLine("SteerConstraint_121: {0}", SteerConstraint_Count.SteerConstraint_121);
                Console.WriteLine("DriftEscapeForce_121: {0}", DriftEscapeForce_Count.DriftEscapeForce_121);
                Console.WriteLine("NormalBoosterTime_121: {0}", NormalBoosterTime_Count.NormalBoosterTime_121);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_121;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_121;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_121;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_121;
            }
            else if (KartSN_Count.KartSN_122 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_122 = 0;
                    TransAccelFactor_Count.TransAccelFactor_122 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_122 = 0;
                    SteerConstraint_Count.SteerConstraint_122 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_122 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_122 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_122 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_122 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_122: {0}", TransAccelFactor_Count.TransAccelFactor_122);
                Console.WriteLine("SteerConstraint_122: {0}", SteerConstraint_Count.SteerConstraint_122);
                Console.WriteLine("DriftEscapeForce_122: {0}", DriftEscapeForce_Count.DriftEscapeForce_122);
                Console.WriteLine("NormalBoosterTime_122: {0}", NormalBoosterTime_Count.NormalBoosterTime_122);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_122;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_122;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_122;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_122;
            }
            else if (KartSN_Count.KartSN_123 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_123 = 0;
                    TransAccelFactor_Count.TransAccelFactor_123 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_123 = 0;
                    SteerConstraint_Count.SteerConstraint_123 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_123 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_123 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_123 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_123 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_123: {0}", TransAccelFactor_Count.TransAccelFactor_123);
                Console.WriteLine("SteerConstraint_123: {0}", SteerConstraint_Count.SteerConstraint_123);
                Console.WriteLine("DriftEscapeForce_123: {0}", DriftEscapeForce_Count.DriftEscapeForce_123);
                Console.WriteLine("NormalBoosterTime_123: {0}", NormalBoosterTime_Count.NormalBoosterTime_123);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_123;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_123;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_123;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_123;
            }
            else if (KartSN_Count.KartSN_124 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_124 = 0;
                    TransAccelFactor_Count.TransAccelFactor_124 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_124 = 0;
                    SteerConstraint_Count.SteerConstraint_124 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_124 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_124 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_124 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_124 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_124: {0}", TransAccelFactor_Count.TransAccelFactor_124);
                Console.WriteLine("SteerConstraint_124: {0}", SteerConstraint_Count.SteerConstraint_124);
                Console.WriteLine("DriftEscapeForce_124: {0}", DriftEscapeForce_Count.DriftEscapeForce_124);
                Console.WriteLine("NormalBoosterTime_124: {0}", NormalBoosterTime_Count.NormalBoosterTime_124);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_124;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_124;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_124;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_124;
            }
            else if (KartSN_Count.KartSN_125 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_125 = 0;
                    TransAccelFactor_Count.TransAccelFactor_125 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_125 = 0;
                    SteerConstraint_Count.SteerConstraint_125 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_125 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_125 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_125 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_125 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_125: {0}", TransAccelFactor_Count.TransAccelFactor_125);
                Console.WriteLine("SteerConstraint_125: {0}", SteerConstraint_Count.SteerConstraint_125);
                Console.WriteLine("DriftEscapeForce_125: {0}", DriftEscapeForce_Count.DriftEscapeForce_125);
                Console.WriteLine("NormalBoosterTime_125: {0}", NormalBoosterTime_Count.NormalBoosterTime_125);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_125;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_125;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_125;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_125;
            }
            else if (KartSN_Count.KartSN_126 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_126 = 0;
                    TransAccelFactor_Count.TransAccelFactor_126 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_126 = 0;
                    SteerConstraint_Count.SteerConstraint_126 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_126 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_126 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_126 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_126 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_126: {0}", TransAccelFactor_Count.TransAccelFactor_126);
                Console.WriteLine("SteerConstraint_126: {0}", SteerConstraint_Count.SteerConstraint_126);
                Console.WriteLine("DriftEscapeForce_126: {0}", DriftEscapeForce_Count.DriftEscapeForce_126);
                Console.WriteLine("NormalBoosterTime_126: {0}", NormalBoosterTime_Count.NormalBoosterTime_126);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_126;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_126;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_126;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_126;
            }
            else if (KartSN_Count.KartSN_127 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_127 = 0;
                    TransAccelFactor_Count.TransAccelFactor_127 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_127 = 0;
                    SteerConstraint_Count.SteerConstraint_127 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_127 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_127 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_127 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_127 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_127: {0}", TransAccelFactor_Count.TransAccelFactor_127);
                Console.WriteLine("SteerConstraint_127: {0}", SteerConstraint_Count.SteerConstraint_127);
                Console.WriteLine("DriftEscapeForce_127: {0}", DriftEscapeForce_Count.DriftEscapeForce_127);
                Console.WriteLine("NormalBoosterTime_127: {0}", NormalBoosterTime_Count.NormalBoosterTime_127);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_127;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_127;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_127;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_127;
            }
            else if (KartSN_Count.KartSN_128 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_128 = 0;
                    TransAccelFactor_Count.TransAccelFactor_128 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_128 = 0;
                    SteerConstraint_Count.SteerConstraint_128 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_128 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_128 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_128 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_128 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_128: {0}", TransAccelFactor_Count.TransAccelFactor_128);
                Console.WriteLine("SteerConstraint_128: {0}", SteerConstraint_Count.SteerConstraint_128);
                Console.WriteLine("DriftEscapeForce_128: {0}", DriftEscapeForce_Count.DriftEscapeForce_128);
                Console.WriteLine("NormalBoosterTime_128: {0}", NormalBoosterTime_Count.NormalBoosterTime_128);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_128;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_128;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_128;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_128;
            }
            else if (KartSN_Count.KartSN_129 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_129 = 0;
                    TransAccelFactor_Count.TransAccelFactor_129 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_129 = 0;
                    SteerConstraint_Count.SteerConstraint_129 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_129 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_129 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_129 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_129 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_129: {0}", TransAccelFactor_Count.TransAccelFactor_129);
                Console.WriteLine("SteerConstraint_129: {0}", SteerConstraint_Count.SteerConstraint_129);
                Console.WriteLine("DriftEscapeForce_129: {0}", DriftEscapeForce_Count.DriftEscapeForce_129);
                Console.WriteLine("NormalBoosterTime_129: {0}", NormalBoosterTime_Count.NormalBoosterTime_129);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_129;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_129;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_129;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_129;
            }
            else if (KartSN_Count.KartSN_130 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_130 = 0;
                    TransAccelFactor_Count.TransAccelFactor_130 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_130 = 0;
                    SteerConstraint_Count.SteerConstraint_130 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_130 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_130 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_130 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_130 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_130: {0}", TransAccelFactor_Count.TransAccelFactor_130);
                Console.WriteLine("SteerConstraint_130: {0}", SteerConstraint_Count.SteerConstraint_130);
                Console.WriteLine("DriftEscapeForce_130: {0}", DriftEscapeForce_Count.DriftEscapeForce_130);
                Console.WriteLine("NormalBoosterTime_130: {0}", NormalBoosterTime_Count.NormalBoosterTime_130);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_130;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_130;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_130;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_130;
            }
            else if (KartSN_Count.KartSN_131 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_131 = 0;
                    TransAccelFactor_Count.TransAccelFactor_131 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_131 = 0;
                    SteerConstraint_Count.SteerConstraint_131 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_131 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_131 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_131 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_131 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_131: {0}", TransAccelFactor_Count.TransAccelFactor_131);
                Console.WriteLine("SteerConstraint_131: {0}", SteerConstraint_Count.SteerConstraint_131);
                Console.WriteLine("DriftEscapeForce_131: {0}", DriftEscapeForce_Count.DriftEscapeForce_131);
                Console.WriteLine("NormalBoosterTime_131: {0}", NormalBoosterTime_Count.NormalBoosterTime_131);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_131;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_131;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_131;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_131;
            }
            else if (KartSN_Count.KartSN_132 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_132 = 0;
                    TransAccelFactor_Count.TransAccelFactor_132 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_132 = 0;
                    SteerConstraint_Count.SteerConstraint_132 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_132 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_132 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_132 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_132 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_132: {0}", TransAccelFactor_Count.TransAccelFactor_132);
                Console.WriteLine("SteerConstraint_132: {0}", SteerConstraint_Count.SteerConstraint_132);
                Console.WriteLine("DriftEscapeForce_132: {0}", DriftEscapeForce_Count.DriftEscapeForce_132);
                Console.WriteLine("NormalBoosterTime_132: {0}", NormalBoosterTime_Count.NormalBoosterTime_132);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_132;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_132;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_132;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_132;
            }
            else if (KartSN_Count.KartSN_133 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_133 = 0;
                    TransAccelFactor_Count.TransAccelFactor_133 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_133 = 0;
                    SteerConstraint_Count.SteerConstraint_133 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_133 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_133 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_133 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_133 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_133: {0}", TransAccelFactor_Count.TransAccelFactor_133);
                Console.WriteLine("SteerConstraint_133: {0}", SteerConstraint_Count.SteerConstraint_133);
                Console.WriteLine("DriftEscapeForce_133: {0}", DriftEscapeForce_Count.DriftEscapeForce_133);
                Console.WriteLine("NormalBoosterTime_133: {0}", NormalBoosterTime_Count.NormalBoosterTime_133);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_133;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_133;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_133;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_133;
            }
            else if (KartSN_Count.KartSN_134 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_134 = 0;
                    TransAccelFactor_Count.TransAccelFactor_134 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_134 = 0;
                    SteerConstraint_Count.SteerConstraint_134 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_134 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_134 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_134 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_134 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_134: {0}", TransAccelFactor_Count.TransAccelFactor_134);
                Console.WriteLine("SteerConstraint_134: {0}", SteerConstraint_Count.SteerConstraint_134);
                Console.WriteLine("DriftEscapeForce_134: {0}", DriftEscapeForce_Count.DriftEscapeForce_134);
                Console.WriteLine("NormalBoosterTime_134: {0}", NormalBoosterTime_Count.NormalBoosterTime_134);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_134;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_134;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_134;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_134;
            }
            else if (KartSN_Count.KartSN_135 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_135 = 0;
                    TransAccelFactor_Count.TransAccelFactor_135 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_135 = 0;
                    SteerConstraint_Count.SteerConstraint_135 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_135 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_135 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_135 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_135 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_135: {0}", TransAccelFactor_Count.TransAccelFactor_135);
                Console.WriteLine("SteerConstraint_135: {0}", SteerConstraint_Count.SteerConstraint_135);
                Console.WriteLine("DriftEscapeForce_135: {0}", DriftEscapeForce_Count.DriftEscapeForce_135);
                Console.WriteLine("NormalBoosterTime_135: {0}", NormalBoosterTime_Count.NormalBoosterTime_135);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_135;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_135;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_135;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_135;
            }
            else if (KartSN_Count.KartSN_136 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_136 = 0;
                    TransAccelFactor_Count.TransAccelFactor_136 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_136 = 0;
                    SteerConstraint_Count.SteerConstraint_136 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_136 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_136 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_136 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_136 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_136: {0}", TransAccelFactor_Count.TransAccelFactor_136);
                Console.WriteLine("SteerConstraint_136: {0}", SteerConstraint_Count.SteerConstraint_136);
                Console.WriteLine("DriftEscapeForce_136: {0}", DriftEscapeForce_Count.DriftEscapeForce_136);
                Console.WriteLine("NormalBoosterTime_136: {0}", NormalBoosterTime_Count.NormalBoosterTime_136);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_136;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_136;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_136;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_136;
            }
            else if (KartSN_Count.KartSN_137 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_137 = 0;
                    TransAccelFactor_Count.TransAccelFactor_137 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_137 = 0;
                    SteerConstraint_Count.SteerConstraint_137 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_137 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_137 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_137 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_137 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_137: {0}", TransAccelFactor_Count.TransAccelFactor_137);
                Console.WriteLine("SteerConstraint_137: {0}", SteerConstraint_Count.SteerConstraint_137);
                Console.WriteLine("DriftEscapeForce_137: {0}", DriftEscapeForce_Count.DriftEscapeForce_137);
                Console.WriteLine("NormalBoosterTime_137: {0}", NormalBoosterTime_Count.NormalBoosterTime_137);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_137;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_137;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_137;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_137;
            }
            else if (KartSN_Count.KartSN_138 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_138 = 0;
                    TransAccelFactor_Count.TransAccelFactor_138 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_138 = 0;
                    SteerConstraint_Count.SteerConstraint_138 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_138 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_138 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_138 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_138 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_138: {0}", TransAccelFactor_Count.TransAccelFactor_138);
                Console.WriteLine("SteerConstraint_138: {0}", SteerConstraint_Count.SteerConstraint_138);
                Console.WriteLine("DriftEscapeForce_138: {0}", DriftEscapeForce_Count.DriftEscapeForce_138);
                Console.WriteLine("NormalBoosterTime_138: {0}", NormalBoosterTime_Count.NormalBoosterTime_138);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_138;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_138;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_138;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_138;
            }
            else if (KartSN_Count.KartSN_139 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_139 = 0;
                    TransAccelFactor_Count.TransAccelFactor_139 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_139 = 0;
                    SteerConstraint_Count.SteerConstraint_139 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_139 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_139 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_139 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_139 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_139: {0}", TransAccelFactor_Count.TransAccelFactor_139);
                Console.WriteLine("SteerConstraint_139: {0}", SteerConstraint_Count.SteerConstraint_139);
                Console.WriteLine("DriftEscapeForce_139: {0}", DriftEscapeForce_Count.DriftEscapeForce_139);
                Console.WriteLine("NormalBoosterTime_139: {0}", NormalBoosterTime_Count.NormalBoosterTime_139);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_139;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_139;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_139;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_139;
            }
            else if (KartSN_Count.KartSN_140 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_140 = 0;
                    TransAccelFactor_Count.TransAccelFactor_140 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_140 = 0;
                    SteerConstraint_Count.SteerConstraint_140 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_140 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_140 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_140 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_140 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_140: {0}", TransAccelFactor_Count.TransAccelFactor_140);
                Console.WriteLine("SteerConstraint_140: {0}", SteerConstraint_Count.SteerConstraint_140);
                Console.WriteLine("DriftEscapeForce_140: {0}", DriftEscapeForce_Count.DriftEscapeForce_140);
                Console.WriteLine("NormalBoosterTime_140: {0}", NormalBoosterTime_Count.NormalBoosterTime_140);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_140;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_140;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_140;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_140;
            }
            else if (KartSN_Count.KartSN_141 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_141 = 0;
                    TransAccelFactor_Count.TransAccelFactor_141 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_141 = 0;
                    SteerConstraint_Count.SteerConstraint_141 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_141 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_141 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_141 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_141 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_141: {0}", TransAccelFactor_Count.TransAccelFactor_141);
                Console.WriteLine("SteerConstraint_141: {0}", SteerConstraint_Count.SteerConstraint_141);
                Console.WriteLine("DriftEscapeForce_141: {0}", DriftEscapeForce_Count.DriftEscapeForce_141);
                Console.WriteLine("NormalBoosterTime_141: {0}", NormalBoosterTime_Count.NormalBoosterTime_141);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_141;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_141;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_141;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_141;
            }
            else if (KartSN_Count.KartSN_142 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_142 = 0;
                    TransAccelFactor_Count.TransAccelFactor_142 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_142 = 0;
                    SteerConstraint_Count.SteerConstraint_142 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_142 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_142 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_142 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_142 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_142: {0}", TransAccelFactor_Count.TransAccelFactor_142);
                Console.WriteLine("SteerConstraint_142: {0}", SteerConstraint_Count.SteerConstraint_142);
                Console.WriteLine("DriftEscapeForce_142: {0}", DriftEscapeForce_Count.DriftEscapeForce_142);
                Console.WriteLine("NormalBoosterTime_142: {0}", NormalBoosterTime_Count.NormalBoosterTime_142);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_142;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_142;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_142;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_142;
            }
            else if (KartSN_Count.KartSN_143 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_143 = 0;
                    TransAccelFactor_Count.TransAccelFactor_143 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_143 = 0;
                    SteerConstraint_Count.SteerConstraint_143 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_143 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_143 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_143 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_143 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_143: {0}", TransAccelFactor_Count.TransAccelFactor_143);
                Console.WriteLine("SteerConstraint_143: {0}", SteerConstraint_Count.SteerConstraint_143);
                Console.WriteLine("DriftEscapeForce_143: {0}", DriftEscapeForce_Count.DriftEscapeForce_143);
                Console.WriteLine("NormalBoosterTime_143: {0}", NormalBoosterTime_Count.NormalBoosterTime_143);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_143;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_143;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_143;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_143;
            }
            else if (KartSN_Count.KartSN_144 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_144 = 0;
                    TransAccelFactor_Count.TransAccelFactor_144 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_144 = 0;
                    SteerConstraint_Count.SteerConstraint_144 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_144 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_144 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_144 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_144 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_144: {0}", TransAccelFactor_Count.TransAccelFactor_144);
                Console.WriteLine("SteerConstraint_144: {0}", SteerConstraint_Count.SteerConstraint_144);
                Console.WriteLine("DriftEscapeForce_144: {0}", DriftEscapeForce_Count.DriftEscapeForce_144);
                Console.WriteLine("NormalBoosterTime_144: {0}", NormalBoosterTime_Count.NormalBoosterTime_144);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_144;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_144;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_144;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_144;
            }
            else if (KartSN_Count.KartSN_145 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_145 = 0;
                    TransAccelFactor_Count.TransAccelFactor_145 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_145 = 0;
                    SteerConstraint_Count.SteerConstraint_145 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_145 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_145 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_145 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_145 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_145: {0}", TransAccelFactor_Count.TransAccelFactor_145);
                Console.WriteLine("SteerConstraint_145: {0}", SteerConstraint_Count.SteerConstraint_145);
                Console.WriteLine("DriftEscapeForce_145: {0}", DriftEscapeForce_Count.DriftEscapeForce_145);
                Console.WriteLine("NormalBoosterTime_145: {0}", NormalBoosterTime_Count.NormalBoosterTime_145);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_145;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_145;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_145;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_145;
            }
            else if (KartSN_Count.KartSN_146 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_146 = 0;
                    TransAccelFactor_Count.TransAccelFactor_146 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_146 = 0;
                    SteerConstraint_Count.SteerConstraint_146 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_146 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_146 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_146 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_146 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_146: {0}", TransAccelFactor_Count.TransAccelFactor_146);
                Console.WriteLine("SteerConstraint_146: {0}", SteerConstraint_Count.SteerConstraint_146);
                Console.WriteLine("DriftEscapeForce_146: {0}", DriftEscapeForce_Count.DriftEscapeForce_146);
                Console.WriteLine("NormalBoosterTime_146: {0}", NormalBoosterTime_Count.NormalBoosterTime_146);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_146;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_146;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_146;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_146;
            }
            else if (KartSN_Count.KartSN_147 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_147 = 0;
                    TransAccelFactor_Count.TransAccelFactor_147 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_147 = 0;
                    SteerConstraint_Count.SteerConstraint_147 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_147 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_147 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_147 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_147 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_147: {0}", TransAccelFactor_Count.TransAccelFactor_147);
                Console.WriteLine("SteerConstraint_147: {0}", SteerConstraint_Count.SteerConstraint_147);
                Console.WriteLine("DriftEscapeForce_147: {0}", DriftEscapeForce_Count.DriftEscapeForce_147);
                Console.WriteLine("NormalBoosterTime_147: {0}", NormalBoosterTime_Count.NormalBoosterTime_147);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_147;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_147;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_147;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_147;
            }
            else if (KartSN_Count.KartSN_148 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_148 = 0;
                    TransAccelFactor_Count.TransAccelFactor_148 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_148 = 0;
                    SteerConstraint_Count.SteerConstraint_148 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_148 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_148 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_148 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_148 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_148: {0}", TransAccelFactor_Count.TransAccelFactor_148);
                Console.WriteLine("SteerConstraint_148: {0}", SteerConstraint_Count.SteerConstraint_148);
                Console.WriteLine("DriftEscapeForce_148: {0}", DriftEscapeForce_Count.DriftEscapeForce_148);
                Console.WriteLine("NormalBoosterTime_148: {0}", NormalBoosterTime_Count.NormalBoosterTime_148);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_148;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_148;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_148;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_148;
            }
            else if (KartSN_Count.KartSN_149 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_149 = 0;
                    TransAccelFactor_Count.TransAccelFactor_149 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_149 = 0;
                    SteerConstraint_Count.SteerConstraint_149 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_149 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_149 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_149 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_149 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_149: {0}", TransAccelFactor_Count.TransAccelFactor_149);
                Console.WriteLine("SteerConstraint_149: {0}", SteerConstraint_Count.SteerConstraint_149);
                Console.WriteLine("DriftEscapeForce_149: {0}", DriftEscapeForce_Count.DriftEscapeForce_149);
                Console.WriteLine("NormalBoosterTime_149: {0}", NormalBoosterTime_Count.NormalBoosterTime_149);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_149;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_149;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_149;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_149;
            }
            else if (KartSN_Count.KartSN_150 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_150 = 0;
                    TransAccelFactor_Count.TransAccelFactor_150 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_150 = 0;
                    SteerConstraint_Count.SteerConstraint_150 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_150 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_150 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_150 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_150 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_150: {0}", TransAccelFactor_Count.TransAccelFactor_150);
                Console.WriteLine("SteerConstraint_150: {0}", SteerConstraint_Count.SteerConstraint_150);
                Console.WriteLine("DriftEscapeForce_150: {0}", DriftEscapeForce_Count.DriftEscapeForce_150);
                Console.WriteLine("NormalBoosterTime_150: {0}", NormalBoosterTime_Count.NormalBoosterTime_150);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_150;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_150;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_150;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_150;
            }
            else if (KartSN_Count.KartSN_151 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_151 = 0;
                    TransAccelFactor_Count.TransAccelFactor_151 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_151 = 0;
                    SteerConstraint_Count.SteerConstraint_151 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_151 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_151 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_151 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_151 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_151: {0}", TransAccelFactor_Count.TransAccelFactor_151);
                Console.WriteLine("SteerConstraint_151: {0}", SteerConstraint_Count.SteerConstraint_151);
                Console.WriteLine("DriftEscapeForce_151: {0}", DriftEscapeForce_Count.DriftEscapeForce_151);
                Console.WriteLine("NormalBoosterTime_151: {0}", NormalBoosterTime_Count.NormalBoosterTime_151);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_151;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_151;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_151;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_151;
            }
            else if (KartSN_Count.KartSN_152 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_152 = 0;
                    TransAccelFactor_Count.TransAccelFactor_152 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_152 = 0;
                    SteerConstraint_Count.SteerConstraint_152 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_152 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_152 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_152 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_152 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_152: {0}", TransAccelFactor_Count.TransAccelFactor_152);
                Console.WriteLine("SteerConstraint_152: {0}", SteerConstraint_Count.SteerConstraint_152);
                Console.WriteLine("DriftEscapeForce_152: {0}", DriftEscapeForce_Count.DriftEscapeForce_152);
                Console.WriteLine("NormalBoosterTime_152: {0}", NormalBoosterTime_Count.NormalBoosterTime_152);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_152;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_152;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_152;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_152;
            }
            else if (KartSN_Count.KartSN_153 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_153 = 0;
                    TransAccelFactor_Count.TransAccelFactor_153 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_153 = 0;
                    SteerConstraint_Count.SteerConstraint_153 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_153 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_153 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_153 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_153 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_153: {0}", TransAccelFactor_Count.TransAccelFactor_153);
                Console.WriteLine("SteerConstraint_153: {0}", SteerConstraint_Count.SteerConstraint_153);
                Console.WriteLine("DriftEscapeForce_153: {0}", DriftEscapeForce_Count.DriftEscapeForce_153);
                Console.WriteLine("NormalBoosterTime_153: {0}", NormalBoosterTime_Count.NormalBoosterTime_153);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_153;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_153;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_153;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_153;
            }
            else if (KartSN_Count.KartSN_154 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_154 = 0;
                    TransAccelFactor_Count.TransAccelFactor_154 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_154 = 0;
                    SteerConstraint_Count.SteerConstraint_154 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_154 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_154 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_154 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_154 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_154: {0}", TransAccelFactor_Count.TransAccelFactor_154);
                Console.WriteLine("SteerConstraint_154: {0}", SteerConstraint_Count.SteerConstraint_154);
                Console.WriteLine("DriftEscapeForce_154: {0}", DriftEscapeForce_Count.DriftEscapeForce_154);
                Console.WriteLine("NormalBoosterTime_154: {0}", NormalBoosterTime_Count.NormalBoosterTime_154);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_154;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_154;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_154;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_154;
            }
            else if (KartSN_Count.KartSN_155 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_155 = 0;
                    TransAccelFactor_Count.TransAccelFactor_155 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_155 = 0;
                    SteerConstraint_Count.SteerConstraint_155 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_155 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_155 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_155 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_155 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_155: {0}", TransAccelFactor_Count.TransAccelFactor_155);
                Console.WriteLine("SteerConstraint_155: {0}", SteerConstraint_Count.SteerConstraint_155);
                Console.WriteLine("DriftEscapeForce_155: {0}", DriftEscapeForce_Count.DriftEscapeForce_155);
                Console.WriteLine("NormalBoosterTime_155: {0}", NormalBoosterTime_Count.NormalBoosterTime_155);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_155;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_155;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_155;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_155;
            }
            else if (KartSN_Count.KartSN_156 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_156 = 0;
                    TransAccelFactor_Count.TransAccelFactor_156 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_156 = 0;
                    SteerConstraint_Count.SteerConstraint_156 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_156 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_156 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_156 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_156 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_156: {0}", TransAccelFactor_Count.TransAccelFactor_156);
                Console.WriteLine("SteerConstraint_156: {0}", SteerConstraint_Count.SteerConstraint_156);
                Console.WriteLine("DriftEscapeForce_156: {0}", DriftEscapeForce_Count.DriftEscapeForce_156);
                Console.WriteLine("NormalBoosterTime_156: {0}", NormalBoosterTime_Count.NormalBoosterTime_156);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_156;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_156;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_156;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_156;
            }
            else if (KartSN_Count.KartSN_157 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_157 = 0;
                    TransAccelFactor_Count.TransAccelFactor_157 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_157 = 0;
                    SteerConstraint_Count.SteerConstraint_157 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_157 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_157 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_157 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_157 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_157: {0}", TransAccelFactor_Count.TransAccelFactor_157);
                Console.WriteLine("SteerConstraint_157: {0}", SteerConstraint_Count.SteerConstraint_157);
                Console.WriteLine("DriftEscapeForce_157: {0}", DriftEscapeForce_Count.DriftEscapeForce_157);
                Console.WriteLine("NormalBoosterTime_157: {0}", NormalBoosterTime_Count.NormalBoosterTime_157);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_157;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_157;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_157;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_157;
            }
            else if (KartSN_Count.KartSN_158 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_158 = 0;
                    TransAccelFactor_Count.TransAccelFactor_158 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_158 = 0;
                    SteerConstraint_Count.SteerConstraint_158 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_158 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_158 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_158 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_158 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_158: {0}", TransAccelFactor_Count.TransAccelFactor_158);
                Console.WriteLine("SteerConstraint_158: {0}", SteerConstraint_Count.SteerConstraint_158);
                Console.WriteLine("DriftEscapeForce_158: {0}", DriftEscapeForce_Count.DriftEscapeForce_158);
                Console.WriteLine("NormalBoosterTime_158: {0}", NormalBoosterTime_Count.NormalBoosterTime_158);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_158;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_158;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_158;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_158;
            }
            else if (KartSN_Count.KartSN_159 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_159 = 0;
                    TransAccelFactor_Count.TransAccelFactor_159 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_159 = 0;
                    SteerConstraint_Count.SteerConstraint_159 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_159 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_159 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_159 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_159 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_159: {0}", TransAccelFactor_Count.TransAccelFactor_159);
                Console.WriteLine("SteerConstraint_159: {0}", SteerConstraint_Count.SteerConstraint_159);
                Console.WriteLine("DriftEscapeForce_159: {0}", DriftEscapeForce_Count.DriftEscapeForce_159);
                Console.WriteLine("NormalBoosterTime_159: {0}", NormalBoosterTime_Count.NormalBoosterTime_159);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_159;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_159;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_159;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_159;
            }
            else if (KartSN_Count.KartSN_160 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_160 = 0;
                    TransAccelFactor_Count.TransAccelFactor_160 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_160 = 0;
                    SteerConstraint_Count.SteerConstraint_160 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_160 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_160 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_160 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_160 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_160: {0}", TransAccelFactor_Count.TransAccelFactor_160);
                Console.WriteLine("SteerConstraint_160: {0}", SteerConstraint_Count.SteerConstraint_160);
                Console.WriteLine("DriftEscapeForce_160: {0}", DriftEscapeForce_Count.DriftEscapeForce_160);
                Console.WriteLine("NormalBoosterTime_160: {0}", NormalBoosterTime_Count.NormalBoosterTime_160);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_160;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_160;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_160;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_160;
            }
            else if (KartSN_Count.KartSN_161 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_161 = 0;
                    TransAccelFactor_Count.TransAccelFactor_161 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_161 = 0;
                    SteerConstraint_Count.SteerConstraint_161 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_161 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_161 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_161 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_161 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_161: {0}", TransAccelFactor_Count.TransAccelFactor_161);
                Console.WriteLine("SteerConstraint_161: {0}", SteerConstraint_Count.SteerConstraint_161);
                Console.WriteLine("DriftEscapeForce_161: {0}", DriftEscapeForce_Count.DriftEscapeForce_161);
                Console.WriteLine("NormalBoosterTime_161: {0}", NormalBoosterTime_Count.NormalBoosterTime_161);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_161;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_161;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_161;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_161;
            }
            else if (KartSN_Count.KartSN_162 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_162 = 0;
                    TransAccelFactor_Count.TransAccelFactor_162 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_162 = 0;
                    SteerConstraint_Count.SteerConstraint_162 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_162 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_162 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_162 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_162 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_162: {0}", TransAccelFactor_Count.TransAccelFactor_162);
                Console.WriteLine("SteerConstraint_162: {0}", SteerConstraint_Count.SteerConstraint_162);
                Console.WriteLine("DriftEscapeForce_162: {0}", DriftEscapeForce_Count.DriftEscapeForce_162);
                Console.WriteLine("NormalBoosterTime_162: {0}", NormalBoosterTime_Count.NormalBoosterTime_162);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_162;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_162;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_162;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_162;
            }
            else if (KartSN_Count.KartSN_163 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_163 = 0;
                    TransAccelFactor_Count.TransAccelFactor_163 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_163 = 0;
                    SteerConstraint_Count.SteerConstraint_163 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_163 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_163 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_163 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_163 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_163: {0}", TransAccelFactor_Count.TransAccelFactor_163);
                Console.WriteLine("SteerConstraint_163: {0}", SteerConstraint_Count.SteerConstraint_163);
                Console.WriteLine("DriftEscapeForce_163: {0}", DriftEscapeForce_Count.DriftEscapeForce_163);
                Console.WriteLine("NormalBoosterTime_163: {0}", NormalBoosterTime_Count.NormalBoosterTime_163);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_163;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_163;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_163;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_163;
            }
            else if (KartSN_Count.KartSN_164 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_164 = 0;
                    TransAccelFactor_Count.TransAccelFactor_164 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_164 = 0;
                    SteerConstraint_Count.SteerConstraint_164 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_164 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_164 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_164 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_164 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_164: {0}", TransAccelFactor_Count.TransAccelFactor_164);
                Console.WriteLine("SteerConstraint_164: {0}", SteerConstraint_Count.SteerConstraint_164);
                Console.WriteLine("DriftEscapeForce_164: {0}", DriftEscapeForce_Count.DriftEscapeForce_164);
                Console.WriteLine("NormalBoosterTime_164: {0}", NormalBoosterTime_Count.NormalBoosterTime_164);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_164;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_164;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_164;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_164;
            }
            else if (KartSN_Count.KartSN_165 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_165 = 0;
                    TransAccelFactor_Count.TransAccelFactor_165 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_165 = 0;
                    SteerConstraint_Count.SteerConstraint_165 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_165 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_165 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_165 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_165 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_165: {0}", TransAccelFactor_Count.TransAccelFactor_165);
                Console.WriteLine("SteerConstraint_165: {0}", SteerConstraint_Count.SteerConstraint_165);
                Console.WriteLine("DriftEscapeForce_165: {0}", DriftEscapeForce_Count.DriftEscapeForce_165);
                Console.WriteLine("NormalBoosterTime_165: {0}", NormalBoosterTime_Count.NormalBoosterTime_165);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_165;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_165;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_165;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_165;
            }
            else if (KartSN_Count.KartSN_166 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_166 = 0;
                    TransAccelFactor_Count.TransAccelFactor_166 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_166 = 0;
                    SteerConstraint_Count.SteerConstraint_166 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_166 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_166 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_166 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_166 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_166: {0}", TransAccelFactor_Count.TransAccelFactor_166);
                Console.WriteLine("SteerConstraint_166: {0}", SteerConstraint_Count.SteerConstraint_166);
                Console.WriteLine("DriftEscapeForce_166: {0}", DriftEscapeForce_Count.DriftEscapeForce_166);
                Console.WriteLine("NormalBoosterTime_166: {0}", NormalBoosterTime_Count.NormalBoosterTime_166);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_166;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_166;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_166;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_166;
            }
            else if (KartSN_Count.KartSN_167 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_167 = 0;
                    TransAccelFactor_Count.TransAccelFactor_167 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_167 = 0;
                    SteerConstraint_Count.SteerConstraint_167 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_167 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_167 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_167 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_167 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_167: {0}", TransAccelFactor_Count.TransAccelFactor_167);
                Console.WriteLine("SteerConstraint_167: {0}", SteerConstraint_Count.SteerConstraint_167);
                Console.WriteLine("DriftEscapeForce_167: {0}", DriftEscapeForce_Count.DriftEscapeForce_167);
                Console.WriteLine("NormalBoosterTime_167: {0}", NormalBoosterTime_Count.NormalBoosterTime_167);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_167;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_167;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_167;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_167;
            }
            else if (KartSN_Count.KartSN_168 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_168 = 0;
                    TransAccelFactor_Count.TransAccelFactor_168 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_168 = 0;
                    SteerConstraint_Count.SteerConstraint_168 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_168 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_168 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_168 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_168 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_168: {0}", TransAccelFactor_Count.TransAccelFactor_168);
                Console.WriteLine("SteerConstraint_168: {0}", SteerConstraint_Count.SteerConstraint_168);
                Console.WriteLine("DriftEscapeForce_168: {0}", DriftEscapeForce_Count.DriftEscapeForce_168);
                Console.WriteLine("NormalBoosterTime_168: {0}", NormalBoosterTime_Count.NormalBoosterTime_168);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_168;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_168;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_168;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_168;
            }
            else if (KartSN_Count.KartSN_169 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_169 = 0;
                    TransAccelFactor_Count.TransAccelFactor_169 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_169 = 0;
                    SteerConstraint_Count.SteerConstraint_169 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_169 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_169 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_169 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_169 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_169: {0}", TransAccelFactor_Count.TransAccelFactor_169);
                Console.WriteLine("SteerConstraint_169: {0}", SteerConstraint_Count.SteerConstraint_169);
                Console.WriteLine("DriftEscapeForce_169: {0}", DriftEscapeForce_Count.DriftEscapeForce_169);
                Console.WriteLine("NormalBoosterTime_169: {0}", NormalBoosterTime_Count.NormalBoosterTime_169);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_169;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_169;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_169;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_169;
            }
            else if (KartSN_Count.KartSN_170 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_170 = 0;
                    TransAccelFactor_Count.TransAccelFactor_170 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_170 = 0;
                    SteerConstraint_Count.SteerConstraint_170 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_170 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_170 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_170 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_170 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_170: {0}", TransAccelFactor_Count.TransAccelFactor_170);
                Console.WriteLine("SteerConstraint_170: {0}", SteerConstraint_Count.SteerConstraint_170);
                Console.WriteLine("DriftEscapeForce_170: {0}", DriftEscapeForce_Count.DriftEscapeForce_170);
                Console.WriteLine("NormalBoosterTime_170: {0}", NormalBoosterTime_Count.NormalBoosterTime_170);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_170;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_170;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_170;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_170;
            }
            else if (KartSN_Count.KartSN_171 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_171 = 0;
                    TransAccelFactor_Count.TransAccelFactor_171 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_171 = 0;
                    SteerConstraint_Count.SteerConstraint_171 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_171 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_171 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_171 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_171 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_171: {0}", TransAccelFactor_Count.TransAccelFactor_171);
                Console.WriteLine("SteerConstraint_171: {0}", SteerConstraint_Count.SteerConstraint_171);
                Console.WriteLine("DriftEscapeForce_171: {0}", DriftEscapeForce_Count.DriftEscapeForce_171);
                Console.WriteLine("NormalBoosterTime_171: {0}", NormalBoosterTime_Count.NormalBoosterTime_171);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_171;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_171;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_171;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_171;
            }
            else if (KartSN_Count.KartSN_172 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_172 = 0;
                    TransAccelFactor_Count.TransAccelFactor_172 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_172 = 0;
                    SteerConstraint_Count.SteerConstraint_172 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_172 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_172 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_172 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_172 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_172: {0}", TransAccelFactor_Count.TransAccelFactor_172);
                Console.WriteLine("SteerConstraint_172: {0}", SteerConstraint_Count.SteerConstraint_172);
                Console.WriteLine("DriftEscapeForce_172: {0}", DriftEscapeForce_Count.DriftEscapeForce_172);
                Console.WriteLine("NormalBoosterTime_172: {0}", NormalBoosterTime_Count.NormalBoosterTime_172);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_172;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_172;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_172;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_172;
            }
            else if (KartSN_Count.KartSN_173 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_173 = 0;
                    TransAccelFactor_Count.TransAccelFactor_173 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_173 = 0;
                    SteerConstraint_Count.SteerConstraint_173 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_173 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_173 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_173 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_173 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_173: {0}", TransAccelFactor_Count.TransAccelFactor_173);
                Console.WriteLine("SteerConstraint_173: {0}", SteerConstraint_Count.SteerConstraint_173);
                Console.WriteLine("DriftEscapeForce_173: {0}", DriftEscapeForce_Count.DriftEscapeForce_173);
                Console.WriteLine("NormalBoosterTime_173: {0}", NormalBoosterTime_Count.NormalBoosterTime_173);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_173;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_173;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_173;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_173;
            }
            else if (KartSN_Count.KartSN_174 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_174 = 0;
                    TransAccelFactor_Count.TransAccelFactor_174 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_174 = 0;
                    SteerConstraint_Count.SteerConstraint_174 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_174 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_174 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_174 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_174 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_174: {0}", TransAccelFactor_Count.TransAccelFactor_174);
                Console.WriteLine("SteerConstraint_174: {0}", SteerConstraint_Count.SteerConstraint_174);
                Console.WriteLine("DriftEscapeForce_174: {0}", DriftEscapeForce_Count.DriftEscapeForce_174);
                Console.WriteLine("NormalBoosterTime_174: {0}", NormalBoosterTime_Count.NormalBoosterTime_174);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_174;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_174;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_174;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_174;
            }
            else if (KartSN_Count.KartSN_175 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_175 = 0;
                    TransAccelFactor_Count.TransAccelFactor_175 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_175 = 0;
                    SteerConstraint_Count.SteerConstraint_175 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_175 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_175 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_175 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_175 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_175: {0}", TransAccelFactor_Count.TransAccelFactor_175);
                Console.WriteLine("SteerConstraint_175: {0}", SteerConstraint_Count.SteerConstraint_175);
                Console.WriteLine("DriftEscapeForce_175: {0}", DriftEscapeForce_Count.DriftEscapeForce_175);
                Console.WriteLine("NormalBoosterTime_175: {0}", NormalBoosterTime_Count.NormalBoosterTime_175);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_175;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_175;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_175;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_175;
            }
            else if (KartSN_Count.KartSN_176 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_176 = 0;
                    TransAccelFactor_Count.TransAccelFactor_176 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_176 = 0;
                    SteerConstraint_Count.SteerConstraint_176 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_176 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_176 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_176 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_176 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_176: {0}", TransAccelFactor_Count.TransAccelFactor_176);
                Console.WriteLine("SteerConstraint_176: {0}", SteerConstraint_Count.SteerConstraint_176);
                Console.WriteLine("DriftEscapeForce_176: {0}", DriftEscapeForce_Count.DriftEscapeForce_176);
                Console.WriteLine("NormalBoosterTime_176: {0}", NormalBoosterTime_Count.NormalBoosterTime_176);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_176;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_176;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_176;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_176;
            }
            else if (KartSN_Count.KartSN_177 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_177 = 0;
                    TransAccelFactor_Count.TransAccelFactor_177 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_177 = 0;
                    SteerConstraint_Count.SteerConstraint_177 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_177 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_177 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_177 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_177 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_177: {0}", TransAccelFactor_Count.TransAccelFactor_177);
                Console.WriteLine("SteerConstraint_177: {0}", SteerConstraint_Count.SteerConstraint_177);
                Console.WriteLine("DriftEscapeForce_177: {0}", DriftEscapeForce_Count.DriftEscapeForce_177);
                Console.WriteLine("NormalBoosterTime_177: {0}", NormalBoosterTime_Count.NormalBoosterTime_177);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_177;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_177;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_177;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_177;
            }
            else if (KartSN_Count.KartSN_178 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_178 = 0;
                    TransAccelFactor_Count.TransAccelFactor_178 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_178 = 0;
                    SteerConstraint_Count.SteerConstraint_178 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_178 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_178 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_178 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_178 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_178: {0}", TransAccelFactor_Count.TransAccelFactor_178);
                Console.WriteLine("SteerConstraint_178: {0}", SteerConstraint_Count.SteerConstraint_178);
                Console.WriteLine("DriftEscapeForce_178: {0}", DriftEscapeForce_Count.DriftEscapeForce_178);
                Console.WriteLine("NormalBoosterTime_178: {0}", NormalBoosterTime_Count.NormalBoosterTime_178);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_178;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_178;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_178;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_178;
            }
            else if (KartSN_Count.KartSN_179 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_179 = 0;
                    TransAccelFactor_Count.TransAccelFactor_179 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_179 = 0;
                    SteerConstraint_Count.SteerConstraint_179 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_179 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_179 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_179 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_179 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_179: {0}", TransAccelFactor_Count.TransAccelFactor_179);
                Console.WriteLine("SteerConstraint_179: {0}", SteerConstraint_Count.SteerConstraint_179);
                Console.WriteLine("DriftEscapeForce_179: {0}", DriftEscapeForce_Count.DriftEscapeForce_179);
                Console.WriteLine("NormalBoosterTime_179: {0}", NormalBoosterTime_Count.NormalBoosterTime_179);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_179;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_179;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_179;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_179;
            }
            else if (KartSN_Count.KartSN_180 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_180 = 0;
                    TransAccelFactor_Count.TransAccelFactor_180 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_180 = 0;
                    SteerConstraint_Count.SteerConstraint_180 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_180 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_180 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_180 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_180 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_180: {0}", TransAccelFactor_Count.TransAccelFactor_180);
                Console.WriteLine("SteerConstraint_180: {0}", SteerConstraint_Count.SteerConstraint_180);
                Console.WriteLine("DriftEscapeForce_180: {0}", DriftEscapeForce_Count.DriftEscapeForce_180);
                Console.WriteLine("NormalBoosterTime_180: {0}", NormalBoosterTime_Count.NormalBoosterTime_180);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_180;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_180;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_180;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_180;
            }
            else if (KartSN_Count.KartSN_181 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_181 = 0;
                    TransAccelFactor_Count.TransAccelFactor_181 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_181 = 0;
                    SteerConstraint_Count.SteerConstraint_181 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_181 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_181 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_181 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_181 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_181: {0}", TransAccelFactor_Count.TransAccelFactor_181);
                Console.WriteLine("SteerConstraint_181: {0}", SteerConstraint_Count.SteerConstraint_181);
                Console.WriteLine("DriftEscapeForce_181: {0}", DriftEscapeForce_Count.DriftEscapeForce_181);
                Console.WriteLine("NormalBoosterTime_181: {0}", NormalBoosterTime_Count.NormalBoosterTime_181);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_181;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_181;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_181;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_181;
            }
            else if (KartSN_Count.KartSN_182 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_182 = 0;
                    TransAccelFactor_Count.TransAccelFactor_182 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_182 = 0;
                    SteerConstraint_Count.SteerConstraint_182 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_182 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_182 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_182 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_182 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_182: {0}", TransAccelFactor_Count.TransAccelFactor_182);
                Console.WriteLine("SteerConstraint_182: {0}", SteerConstraint_Count.SteerConstraint_182);
                Console.WriteLine("DriftEscapeForce_182: {0}", DriftEscapeForce_Count.DriftEscapeForce_182);
                Console.WriteLine("NormalBoosterTime_182: {0}", NormalBoosterTime_Count.NormalBoosterTime_182);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_182;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_182;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_182;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_182;
            }
            else if (KartSN_Count.KartSN_183 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_183 = 0;
                    TransAccelFactor_Count.TransAccelFactor_183 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_183 = 0;
                    SteerConstraint_Count.SteerConstraint_183 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_183 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_183 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_183 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_183 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_183: {0}", TransAccelFactor_Count.TransAccelFactor_183);
                Console.WriteLine("SteerConstraint_183: {0}", SteerConstraint_Count.SteerConstraint_183);
                Console.WriteLine("DriftEscapeForce_183: {0}", DriftEscapeForce_Count.DriftEscapeForce_183);
                Console.WriteLine("NormalBoosterTime_183: {0}", NormalBoosterTime_Count.NormalBoosterTime_183);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_183;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_183;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_183;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_183;
            }
            else if (KartSN_Count.KartSN_184 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_184 = 0;
                    TransAccelFactor_Count.TransAccelFactor_184 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_184 = 0;
                    SteerConstraint_Count.SteerConstraint_184 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_184 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_184 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_184 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_184 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_184: {0}", TransAccelFactor_Count.TransAccelFactor_184);
                Console.WriteLine("SteerConstraint_184: {0}", SteerConstraint_Count.SteerConstraint_184);
                Console.WriteLine("DriftEscapeForce_184: {0}", DriftEscapeForce_Count.DriftEscapeForce_184);
                Console.WriteLine("NormalBoosterTime_184: {0}", NormalBoosterTime_Count.NormalBoosterTime_184);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_184;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_184;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_184;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_184;
            }
            else if (KartSN_Count.KartSN_185 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_185 = 0;
                    TransAccelFactor_Count.TransAccelFactor_185 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_185 = 0;
                    SteerConstraint_Count.SteerConstraint_185 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_185 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_185 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_185 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_185 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_185: {0}", TransAccelFactor_Count.TransAccelFactor_185);
                Console.WriteLine("SteerConstraint_185: {0}", SteerConstraint_Count.SteerConstraint_185);
                Console.WriteLine("DriftEscapeForce_185: {0}", DriftEscapeForce_Count.DriftEscapeForce_185);
                Console.WriteLine("NormalBoosterTime_185: {0}", NormalBoosterTime_Count.NormalBoosterTime_185);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_185;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_185;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_185;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_185;
            }
            else if (KartSN_Count.KartSN_186 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_186 = 0;
                    TransAccelFactor_Count.TransAccelFactor_186 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_186 = 0;
                    SteerConstraint_Count.SteerConstraint_186 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_186 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_186 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_186 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_186 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_186: {0}", TransAccelFactor_Count.TransAccelFactor_186);
                Console.WriteLine("SteerConstraint_186: {0}", SteerConstraint_Count.SteerConstraint_186);
                Console.WriteLine("DriftEscapeForce_186: {0}", DriftEscapeForce_Count.DriftEscapeForce_186);
                Console.WriteLine("NormalBoosterTime_186: {0}", NormalBoosterTime_Count.NormalBoosterTime_186);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_186;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_186;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_186;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_186;
            }
            else if (KartSN_Count.KartSN_187 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_187 = 0;
                    TransAccelFactor_Count.TransAccelFactor_187 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_187 = 0;
                    SteerConstraint_Count.SteerConstraint_187 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_187 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_187 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_187 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_187 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_187: {0}", TransAccelFactor_Count.TransAccelFactor_187);
                Console.WriteLine("SteerConstraint_187: {0}", SteerConstraint_Count.SteerConstraint_187);
                Console.WriteLine("DriftEscapeForce_187: {0}", DriftEscapeForce_Count.DriftEscapeForce_187);
                Console.WriteLine("NormalBoosterTime_187: {0}", NormalBoosterTime_Count.NormalBoosterTime_187);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_187;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_187;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_187;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_187;
            }
            else if (KartSN_Count.KartSN_188 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_188 = 0;
                    TransAccelFactor_Count.TransAccelFactor_188 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_188 = 0;
                    SteerConstraint_Count.SteerConstraint_188 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_188 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_188 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_188 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_188 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_188: {0}", TransAccelFactor_Count.TransAccelFactor_188);
                Console.WriteLine("SteerConstraint_188: {0}", SteerConstraint_Count.SteerConstraint_188);
                Console.WriteLine("DriftEscapeForce_188: {0}", DriftEscapeForce_Count.DriftEscapeForce_188);
                Console.WriteLine("NormalBoosterTime_188: {0}", NormalBoosterTime_Count.NormalBoosterTime_188);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_188;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_188;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_188;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_188;
            }
            else if (KartSN_Count.KartSN_189 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_189 = 0;
                    TransAccelFactor_Count.TransAccelFactor_189 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_189 = 0;
                    SteerConstraint_Count.SteerConstraint_189 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_189 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_189 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_189 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_189 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_189: {0}", TransAccelFactor_Count.TransAccelFactor_189);
                Console.WriteLine("SteerConstraint_189: {0}", SteerConstraint_Count.SteerConstraint_189);
                Console.WriteLine("DriftEscapeForce_189: {0}", DriftEscapeForce_Count.DriftEscapeForce_189);
                Console.WriteLine("NormalBoosterTime_189: {0}", NormalBoosterTime_Count.NormalBoosterTime_189);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_189;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_189;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_189;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_189;
            }
            else if (KartSN_Count.KartSN_190 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_190 = 0;
                    TransAccelFactor_Count.TransAccelFactor_190 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_190 = 0;
                    SteerConstraint_Count.SteerConstraint_190 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_190 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_190 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_190 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_190 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_190: {0}", TransAccelFactor_Count.TransAccelFactor_190);
                Console.WriteLine("SteerConstraint_190: {0}", SteerConstraint_Count.SteerConstraint_190);
                Console.WriteLine("DriftEscapeForce_190: {0}", DriftEscapeForce_Count.DriftEscapeForce_190);
                Console.WriteLine("NormalBoosterTime_190: {0}", NormalBoosterTime_Count.NormalBoosterTime_190);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_190;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_190;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_190;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_190;
            }
            else if (KartSN_Count.KartSN_191 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_191 = 0;
                    TransAccelFactor_Count.TransAccelFactor_191 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_191 = 0;
                    SteerConstraint_Count.SteerConstraint_191 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_191 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_191 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_191 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_191 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_191: {0}", TransAccelFactor_Count.TransAccelFactor_191);
                Console.WriteLine("SteerConstraint_191: {0}", SteerConstraint_Count.SteerConstraint_191);
                Console.WriteLine("DriftEscapeForce_191: {0}", DriftEscapeForce_Count.DriftEscapeForce_191);
                Console.WriteLine("NormalBoosterTime_191: {0}", NormalBoosterTime_Count.NormalBoosterTime_191);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_191;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_191;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_191;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_191;
            }
            else if (KartSN_Count.KartSN_192 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_192 = 0;
                    TransAccelFactor_Count.TransAccelFactor_192 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_192 = 0;
                    SteerConstraint_Count.SteerConstraint_192 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_192 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_192 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_192 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_192 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_192: {0}", TransAccelFactor_Count.TransAccelFactor_192);
                Console.WriteLine("SteerConstraint_192: {0}", SteerConstraint_Count.SteerConstraint_192);
                Console.WriteLine("DriftEscapeForce_192: {0}", DriftEscapeForce_Count.DriftEscapeForce_192);
                Console.WriteLine("NormalBoosterTime_192: {0}", NormalBoosterTime_Count.NormalBoosterTime_192);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_192;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_192;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_192;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_192;
            }
            else if (KartSN_Count.KartSN_193 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_193 = 0;
                    TransAccelFactor_Count.TransAccelFactor_193 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_193 = 0;
                    SteerConstraint_Count.SteerConstraint_193 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_193 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_193 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_193 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_193 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_193: {0}", TransAccelFactor_Count.TransAccelFactor_193);
                Console.WriteLine("SteerConstraint_193: {0}", SteerConstraint_Count.SteerConstraint_193);
                Console.WriteLine("DriftEscapeForce_193: {0}", DriftEscapeForce_Count.DriftEscapeForce_193);
                Console.WriteLine("NormalBoosterTime_193: {0}", NormalBoosterTime_Count.NormalBoosterTime_193);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_193;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_193;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_193;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_193;
            }
            else if (KartSN_Count.KartSN_194 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_194 = 0;
                    TransAccelFactor_Count.TransAccelFactor_194 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_194 = 0;
                    SteerConstraint_Count.SteerConstraint_194 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_194 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_194 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_194 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_194 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_194: {0}", TransAccelFactor_Count.TransAccelFactor_194);
                Console.WriteLine("SteerConstraint_194: {0}", SteerConstraint_Count.SteerConstraint_194);
                Console.WriteLine("DriftEscapeForce_194: {0}", DriftEscapeForce_Count.DriftEscapeForce_194);
                Console.WriteLine("NormalBoosterTime_194: {0}", NormalBoosterTime_Count.NormalBoosterTime_194);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_194;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_194;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_194;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_194;
            }
            else if (KartSN_Count.KartSN_195 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_195 = 0;
                    TransAccelFactor_Count.TransAccelFactor_195 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_195 = 0;
                    SteerConstraint_Count.SteerConstraint_195 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_195 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_195 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_195 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_195 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_195: {0}", TransAccelFactor_Count.TransAccelFactor_195);
                Console.WriteLine("SteerConstraint_195: {0}", SteerConstraint_Count.SteerConstraint_195);
                Console.WriteLine("DriftEscapeForce_195: {0}", DriftEscapeForce_Count.DriftEscapeForce_195);
                Console.WriteLine("NormalBoosterTime_195: {0}", NormalBoosterTime_Count.NormalBoosterTime_195);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_195;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_195;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_195;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_195;
            }
            else if (KartSN_Count.KartSN_196 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_196 = 0;
                    TransAccelFactor_Count.TransAccelFactor_196 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_196 = 0;
                    SteerConstraint_Count.SteerConstraint_196 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_196 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_196 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_196 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_196 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_196: {0}", TransAccelFactor_Count.TransAccelFactor_196);
                Console.WriteLine("SteerConstraint_196: {0}", SteerConstraint_Count.SteerConstraint_196);
                Console.WriteLine("DriftEscapeForce_196: {0}", DriftEscapeForce_Count.DriftEscapeForce_196);
                Console.WriteLine("NormalBoosterTime_196: {0}", NormalBoosterTime_Count.NormalBoosterTime_196);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_196;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_196;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_196;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_196;
            }
            else if (KartSN_Count.KartSN_197 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_197 = 0;
                    TransAccelFactor_Count.TransAccelFactor_197 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_197 = 0;
                    SteerConstraint_Count.SteerConstraint_197 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_197 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_197 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_197 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_197 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_197: {0}", TransAccelFactor_Count.TransAccelFactor_197);
                Console.WriteLine("SteerConstraint_197: {0}", SteerConstraint_Count.SteerConstraint_197);
                Console.WriteLine("DriftEscapeForce_197: {0}", DriftEscapeForce_Count.DriftEscapeForce_197);
                Console.WriteLine("NormalBoosterTime_197: {0}", NormalBoosterTime_Count.NormalBoosterTime_197);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_197;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_197;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_197;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_197;
            }
            else if (KartSN_Count.KartSN_198 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_198 = 0;
                    TransAccelFactor_Count.TransAccelFactor_198 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_198 = 0;
                    SteerConstraint_Count.SteerConstraint_198 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_198 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_198 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_198 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_198 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_198: {0}", TransAccelFactor_Count.TransAccelFactor_198);
                Console.WriteLine("SteerConstraint_198: {0}", SteerConstraint_Count.SteerConstraint_198);
                Console.WriteLine("DriftEscapeForce_198: {0}", DriftEscapeForce_Count.DriftEscapeForce_198);
                Console.WriteLine("NormalBoosterTime_198: {0}", NormalBoosterTime_Count.NormalBoosterTime_198);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_198;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_198;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_198;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_198;
            }
            else if (KartSN_Count.KartSN_199 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_199 = 0;
                    TransAccelFactor_Count.TransAccelFactor_199 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_199 = 0;
                    SteerConstraint_Count.SteerConstraint_199 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_199 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_199 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_199 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_199 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_199: {0}", TransAccelFactor_Count.TransAccelFactor_199);
                Console.WriteLine("SteerConstraint_199: {0}", SteerConstraint_Count.SteerConstraint_199);
                Console.WriteLine("DriftEscapeForce_199: {0}", DriftEscapeForce_Count.DriftEscapeForce_199);
                Console.WriteLine("NormalBoosterTime_199: {0}", NormalBoosterTime_Count.NormalBoosterTime_199);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_199;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_199;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_199;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_199;
            }
            else if (KartSN_Count.KartSN_200 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_200 = 0;
                    TransAccelFactor_Count.TransAccelFactor_200 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_200 = 0;
                    SteerConstraint_Count.SteerConstraint_200 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_200 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_200 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_200 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_200 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_200: {0}", TransAccelFactor_Count.TransAccelFactor_200);
                Console.WriteLine("SteerConstraint_200: {0}", SteerConstraint_Count.SteerConstraint_200);
                Console.WriteLine("DriftEscapeForce_200: {0}", DriftEscapeForce_Count.DriftEscapeForce_200);
                Console.WriteLine("NormalBoosterTime_200: {0}", NormalBoosterTime_Count.NormalBoosterTime_200);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_200;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_200;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_200;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_200;
            }
            else if (KartSN_Count.KartSN_201 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_201 = 0;
                    TransAccelFactor_Count.TransAccelFactor_201 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_201 = 0;
                    SteerConstraint_Count.SteerConstraint_201 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_201 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_201 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_201 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_201 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_201: {0}", TransAccelFactor_Count.TransAccelFactor_201);
                Console.WriteLine("SteerConstraint_201: {0}", SteerConstraint_Count.SteerConstraint_201);
                Console.WriteLine("DriftEscapeForce_201: {0}", DriftEscapeForce_Count.DriftEscapeForce_201);
                Console.WriteLine("NormalBoosterTime_201: {0}", NormalBoosterTime_Count.NormalBoosterTime_201);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_201;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_201;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_201;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_201;
            }
            else if (KartSN_Count.KartSN_202 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_202 = 0;
                    TransAccelFactor_Count.TransAccelFactor_202 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_202 = 0;
                    SteerConstraint_Count.SteerConstraint_202 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_202 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_202 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_202 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_202 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_202: {0}", TransAccelFactor_Count.TransAccelFactor_202);
                Console.WriteLine("SteerConstraint_202: {0}", SteerConstraint_Count.SteerConstraint_202);
                Console.WriteLine("DriftEscapeForce_202: {0}", DriftEscapeForce_Count.DriftEscapeForce_202);
                Console.WriteLine("NormalBoosterTime_202: {0}", NormalBoosterTime_Count.NormalBoosterTime_202);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_202;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_202;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_202;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_202;
            }
            else if (KartSN_Count.KartSN_203 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_203 = 0;
                    TransAccelFactor_Count.TransAccelFactor_203 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_203 = 0;
                    SteerConstraint_Count.SteerConstraint_203 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_203 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_203 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_203 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_203 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_203: {0}", TransAccelFactor_Count.TransAccelFactor_203);
                Console.WriteLine("SteerConstraint_203: {0}", SteerConstraint_Count.SteerConstraint_203);
                Console.WriteLine("DriftEscapeForce_203: {0}", DriftEscapeForce_Count.DriftEscapeForce_203);
                Console.WriteLine("NormalBoosterTime_203: {0}", NormalBoosterTime_Count.NormalBoosterTime_203);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_203;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_203;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_203;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_203;
            }
            else if (KartSN_Count.KartSN_204 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_204 = 0;
                    TransAccelFactor_Count.TransAccelFactor_204 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_204 = 0;
                    SteerConstraint_Count.SteerConstraint_204 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_204 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_204 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_204 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_204 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_204: {0}", TransAccelFactor_Count.TransAccelFactor_204);
                Console.WriteLine("SteerConstraint_204: {0}", SteerConstraint_Count.SteerConstraint_204);
                Console.WriteLine("DriftEscapeForce_204: {0}", DriftEscapeForce_Count.DriftEscapeForce_204);
                Console.WriteLine("NormalBoosterTime_204: {0}", NormalBoosterTime_Count.NormalBoosterTime_204);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_204;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_204;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_204;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_204;
            }
            else if (KartSN_Count.KartSN_205 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_205 = 0;
                    TransAccelFactor_Count.TransAccelFactor_205 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_205 = 0;
                    SteerConstraint_Count.SteerConstraint_205 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_205 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_205 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_205 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_205 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_205: {0}", TransAccelFactor_Count.TransAccelFactor_205);
                Console.WriteLine("SteerConstraint_205: {0}", SteerConstraint_Count.SteerConstraint_205);
                Console.WriteLine("DriftEscapeForce_205: {0}", DriftEscapeForce_Count.DriftEscapeForce_205);
                Console.WriteLine("NormalBoosterTime_205: {0}", NormalBoosterTime_Count.NormalBoosterTime_205);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_205;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_205;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_205;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_205;
            }
            else if (KartSN_Count.KartSN_206 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_206 = 0;
                    TransAccelFactor_Count.TransAccelFactor_206 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_206 = 0;
                    SteerConstraint_Count.SteerConstraint_206 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_206 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_206 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_206 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_206 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_206: {0}", TransAccelFactor_Count.TransAccelFactor_206);
                Console.WriteLine("SteerConstraint_206: {0}", SteerConstraint_Count.SteerConstraint_206);
                Console.WriteLine("DriftEscapeForce_206: {0}", DriftEscapeForce_Count.DriftEscapeForce_206);
                Console.WriteLine("NormalBoosterTime_206: {0}", NormalBoosterTime_Count.NormalBoosterTime_206);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_206;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_206;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_206;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_206;
            }
            else if (KartSN_Count.KartSN_207 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_207 = 0;
                    TransAccelFactor_Count.TransAccelFactor_207 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_207 = 0;
                    SteerConstraint_Count.SteerConstraint_207 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_207 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_207 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_207 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_207 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_207: {0}", TransAccelFactor_Count.TransAccelFactor_207);
                Console.WriteLine("SteerConstraint_207: {0}", SteerConstraint_Count.SteerConstraint_207);
                Console.WriteLine("DriftEscapeForce_207: {0}", DriftEscapeForce_Count.DriftEscapeForce_207);
                Console.WriteLine("NormalBoosterTime_207: {0}", NormalBoosterTime_Count.NormalBoosterTime_207);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_207;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_207;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_207;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_207;
            }
            else if (KartSN_Count.KartSN_208 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_208 = 0;
                    TransAccelFactor_Count.TransAccelFactor_208 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_208 = 0;
                    SteerConstraint_Count.SteerConstraint_208 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_208 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_208 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_208 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_208 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_208: {0}", TransAccelFactor_Count.TransAccelFactor_208);
                Console.WriteLine("SteerConstraint_208: {0}", SteerConstraint_Count.SteerConstraint_208);
                Console.WriteLine("DriftEscapeForce_208: {0}", DriftEscapeForce_Count.DriftEscapeForce_208);
                Console.WriteLine("NormalBoosterTime_208: {0}", NormalBoosterTime_Count.NormalBoosterTime_208);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_208;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_208;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_208;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_208;
            }
            else if (KartSN_Count.KartSN_209 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_209 = 0;
                    TransAccelFactor_Count.TransAccelFactor_209 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_209 = 0;
                    SteerConstraint_Count.SteerConstraint_209 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_209 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_209 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_209 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_209 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_209: {0}", TransAccelFactor_Count.TransAccelFactor_209);
                Console.WriteLine("SteerConstraint_209: {0}", SteerConstraint_Count.SteerConstraint_209);
                Console.WriteLine("DriftEscapeForce_209: {0}", DriftEscapeForce_Count.DriftEscapeForce_209);
                Console.WriteLine("NormalBoosterTime_209: {0}", NormalBoosterTime_Count.NormalBoosterTime_209);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_209;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_209;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_209;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_209;
            }
            else if (KartSN_Count.KartSN_210 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_210 = 0;
                    TransAccelFactor_Count.TransAccelFactor_210 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_210 = 0;
                    SteerConstraint_Count.SteerConstraint_210 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_210 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_210 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_210 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_210 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_210: {0}", TransAccelFactor_Count.TransAccelFactor_210);
                Console.WriteLine("SteerConstraint_210: {0}", SteerConstraint_Count.SteerConstraint_210);
                Console.WriteLine("DriftEscapeForce_210: {0}", DriftEscapeForce_Count.DriftEscapeForce_210);
                Console.WriteLine("NormalBoosterTime_210: {0}", NormalBoosterTime_Count.NormalBoosterTime_210);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_210;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_210;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_210;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_210;
            }
            else if (KartSN_Count.KartSN_211 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_211 = 0;
                    TransAccelFactor_Count.TransAccelFactor_211 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_211 = 0;
                    SteerConstraint_Count.SteerConstraint_211 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_211 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_211 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_211 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_211 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_211: {0}", TransAccelFactor_Count.TransAccelFactor_211);
                Console.WriteLine("SteerConstraint_211: {0}", SteerConstraint_Count.SteerConstraint_211);
                Console.WriteLine("DriftEscapeForce_211: {0}", DriftEscapeForce_Count.DriftEscapeForce_211);
                Console.WriteLine("NormalBoosterTime_211: {0}", NormalBoosterTime_Count.NormalBoosterTime_211);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_211;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_211;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_211;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_211;
            }
            else if (KartSN_Count.KartSN_212 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_212 = 0;
                    TransAccelFactor_Count.TransAccelFactor_212 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_212 = 0;
                    SteerConstraint_Count.SteerConstraint_212 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_212 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_212 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_212 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_212 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_212: {0}", TransAccelFactor_Count.TransAccelFactor_212);
                Console.WriteLine("SteerConstraint_212: {0}", SteerConstraint_Count.SteerConstraint_212);
                Console.WriteLine("DriftEscapeForce_212: {0}", DriftEscapeForce_Count.DriftEscapeForce_212);
                Console.WriteLine("NormalBoosterTime_212: {0}", NormalBoosterTime_Count.NormalBoosterTime_212);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_212;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_212;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_212;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_212;
            }
            else if (KartSN_Count.KartSN_213 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_213 = 0;
                    TransAccelFactor_Count.TransAccelFactor_213 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_213 = 0;
                    SteerConstraint_Count.SteerConstraint_213 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_213 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_213 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_213 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_213 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_213: {0}", TransAccelFactor_Count.TransAccelFactor_213);
                Console.WriteLine("SteerConstraint_213: {0}", SteerConstraint_Count.SteerConstraint_213);
                Console.WriteLine("DriftEscapeForce_213: {0}", DriftEscapeForce_Count.DriftEscapeForce_213);
                Console.WriteLine("NormalBoosterTime_213: {0}", NormalBoosterTime_Count.NormalBoosterTime_213);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_213;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_213;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_213;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_213;
            }
            else if (KartSN_Count.KartSN_214 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_214 = 0;
                    TransAccelFactor_Count.TransAccelFactor_214 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_214 = 0;
                    SteerConstraint_Count.SteerConstraint_214 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_214 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_214 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_214 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_214 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_214: {0}", TransAccelFactor_Count.TransAccelFactor_214);
                Console.WriteLine("SteerConstraint_214: {0}", SteerConstraint_Count.SteerConstraint_214);
                Console.WriteLine("DriftEscapeForce_214: {0}", DriftEscapeForce_Count.DriftEscapeForce_214);
                Console.WriteLine("NormalBoosterTime_214: {0}", NormalBoosterTime_Count.NormalBoosterTime_214);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_214;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_214;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_214;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_214;
            }
            else if (KartSN_Count.KartSN_215 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_215 = 0;
                    TransAccelFactor_Count.TransAccelFactor_215 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_215 = 0;
                    SteerConstraint_Count.SteerConstraint_215 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_215 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_215 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_215 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_215 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_215: {0}", TransAccelFactor_Count.TransAccelFactor_215);
                Console.WriteLine("SteerConstraint_215: {0}", SteerConstraint_Count.SteerConstraint_215);
                Console.WriteLine("DriftEscapeForce_215: {0}", DriftEscapeForce_Count.DriftEscapeForce_215);
                Console.WriteLine("NormalBoosterTime_215: {0}", NormalBoosterTime_Count.NormalBoosterTime_215);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_215;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_215;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_215;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_215;
            }
            else if (KartSN_Count.KartSN_216 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_216 = 0;
                    TransAccelFactor_Count.TransAccelFactor_216 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_216 = 0;
                    SteerConstraint_Count.SteerConstraint_216 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_216 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_216 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_216 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_216 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_216: {0}", TransAccelFactor_Count.TransAccelFactor_216);
                Console.WriteLine("SteerConstraint_216: {0}", SteerConstraint_Count.SteerConstraint_216);
                Console.WriteLine("DriftEscapeForce_216: {0}", DriftEscapeForce_Count.DriftEscapeForce_216);
                Console.WriteLine("NormalBoosterTime_216: {0}", NormalBoosterTime_Count.NormalBoosterTime_216);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_216;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_216;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_216;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_216;
            }
            else if (KartSN_Count.KartSN_217 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_217 = 0;
                    TransAccelFactor_Count.TransAccelFactor_217 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_217 = 0;
                    SteerConstraint_Count.SteerConstraint_217 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_217 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_217 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_217 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_217 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_217: {0}", TransAccelFactor_Count.TransAccelFactor_217);
                Console.WriteLine("SteerConstraint_217: {0}", SteerConstraint_Count.SteerConstraint_217);
                Console.WriteLine("DriftEscapeForce_217: {0}", DriftEscapeForce_Count.DriftEscapeForce_217);
                Console.WriteLine("NormalBoosterTime_217: {0}", NormalBoosterTime_Count.NormalBoosterTime_217);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_217;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_217;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_217;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_217;
            }
            else if (KartSN_Count.KartSN_218 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_218 = 0;
                    TransAccelFactor_Count.TransAccelFactor_218 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_218 = 0;
                    SteerConstraint_Count.SteerConstraint_218 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_218 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_218 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_218 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_218 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_218: {0}", TransAccelFactor_Count.TransAccelFactor_218);
                Console.WriteLine("SteerConstraint_218: {0}", SteerConstraint_Count.SteerConstraint_218);
                Console.WriteLine("DriftEscapeForce_218: {0}", DriftEscapeForce_Count.DriftEscapeForce_218);
                Console.WriteLine("NormalBoosterTime_218: {0}", NormalBoosterTime_Count.NormalBoosterTime_218);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_218;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_218;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_218;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_218;
            }
            else if (KartSN_Count.KartSN_219 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_219 = 0;
                    TransAccelFactor_Count.TransAccelFactor_219 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_219 = 0;
                    SteerConstraint_Count.SteerConstraint_219 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_219 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_219 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_219 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_219 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_219: {0}", TransAccelFactor_Count.TransAccelFactor_219);
                Console.WriteLine("SteerConstraint_219: {0}", SteerConstraint_Count.SteerConstraint_219);
                Console.WriteLine("DriftEscapeForce_219: {0}", DriftEscapeForce_Count.DriftEscapeForce_219);
                Console.WriteLine("NormalBoosterTime_219: {0}", NormalBoosterTime_Count.NormalBoosterTime_219);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_219;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_219;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_219;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_219;
            }
            else if (KartSN_Count.KartSN_220 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_220 = 0;
                    TransAccelFactor_Count.TransAccelFactor_220 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_220 = 0;
                    SteerConstraint_Count.SteerConstraint_220 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_220 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_220 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_220 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_220 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_220: {0}", TransAccelFactor_Count.TransAccelFactor_220);
                Console.WriteLine("SteerConstraint_220: {0}", SteerConstraint_Count.SteerConstraint_220);
                Console.WriteLine("DriftEscapeForce_220: {0}", DriftEscapeForce_Count.DriftEscapeForce_220);
                Console.WriteLine("NormalBoosterTime_220: {0}", NormalBoosterTime_Count.NormalBoosterTime_220);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_220;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_220;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_220;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_220;
            }
            else if (KartSN_Count.KartSN_221 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_221 = 0;
                    TransAccelFactor_Count.TransAccelFactor_221 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_221 = 0;
                    SteerConstraint_Count.SteerConstraint_221 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_221 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_221 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_221 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_221 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_221: {0}", TransAccelFactor_Count.TransAccelFactor_221);
                Console.WriteLine("SteerConstraint_221: {0}", SteerConstraint_Count.SteerConstraint_221);
                Console.WriteLine("DriftEscapeForce_221: {0}", DriftEscapeForce_Count.DriftEscapeForce_221);
                Console.WriteLine("NormalBoosterTime_221: {0}", NormalBoosterTime_Count.NormalBoosterTime_221);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_221;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_221;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_221;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_221;
            }
            else if (KartSN_Count.KartSN_222 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_222 = 0;
                    TransAccelFactor_Count.TransAccelFactor_222 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_222 = 0;
                    SteerConstraint_Count.SteerConstraint_222 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_222 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_222 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_222 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_222 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_222: {0}", TransAccelFactor_Count.TransAccelFactor_222);
                Console.WriteLine("SteerConstraint_222: {0}", SteerConstraint_Count.SteerConstraint_222);
                Console.WriteLine("DriftEscapeForce_222: {0}", DriftEscapeForce_Count.DriftEscapeForce_222);
                Console.WriteLine("NormalBoosterTime_222: {0}", NormalBoosterTime_Count.NormalBoosterTime_222);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_222;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_222;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_222;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_222;
            }
            else if (KartSN_Count.KartSN_223 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_223 = 0;
                    TransAccelFactor_Count.TransAccelFactor_223 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_223 = 0;
                    SteerConstraint_Count.SteerConstraint_223 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_223 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_223 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_223 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_223 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_223: {0}", TransAccelFactor_Count.TransAccelFactor_223);
                Console.WriteLine("SteerConstraint_223: {0}", SteerConstraint_Count.SteerConstraint_223);
                Console.WriteLine("DriftEscapeForce_223: {0}", DriftEscapeForce_Count.DriftEscapeForce_223);
                Console.WriteLine("NormalBoosterTime_223: {0}", NormalBoosterTime_Count.NormalBoosterTime_223);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_223;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_223;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_223;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_223;
            }
            else if (KartSN_Count.KartSN_224 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_224 = 0;
                    TransAccelFactor_Count.TransAccelFactor_224 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_224 = 0;
                    SteerConstraint_Count.SteerConstraint_224 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_224 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_224 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_224 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_224 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_224: {0}", TransAccelFactor_Count.TransAccelFactor_224);
                Console.WriteLine("SteerConstraint_224: {0}", SteerConstraint_Count.SteerConstraint_224);
                Console.WriteLine("DriftEscapeForce_224: {0}", DriftEscapeForce_Count.DriftEscapeForce_224);
                Console.WriteLine("NormalBoosterTime_224: {0}", NormalBoosterTime_Count.NormalBoosterTime_224);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_224;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_224;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_224;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_224;
            }
            else if (KartSN_Count.KartSN_225 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_225 = 0;
                    TransAccelFactor_Count.TransAccelFactor_225 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_225 = 0;
                    SteerConstraint_Count.SteerConstraint_225 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_225 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_225 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_225 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_225 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_225: {0}", TransAccelFactor_Count.TransAccelFactor_225);
                Console.WriteLine("SteerConstraint_225: {0}", SteerConstraint_Count.SteerConstraint_225);
                Console.WriteLine("DriftEscapeForce_225: {0}", DriftEscapeForce_Count.DriftEscapeForce_225);
                Console.WriteLine("NormalBoosterTime_225: {0}", NormalBoosterTime_Count.NormalBoosterTime_225);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_225;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_225;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_225;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_225;
            }
            else if (KartSN_Count.KartSN_226 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_226 = 0;
                    TransAccelFactor_Count.TransAccelFactor_226 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_226 = 0;
                    SteerConstraint_Count.SteerConstraint_226 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_226 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_226 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_226 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_226 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_226: {0}", TransAccelFactor_Count.TransAccelFactor_226);
                Console.WriteLine("SteerConstraint_226: {0}", SteerConstraint_Count.SteerConstraint_226);
                Console.WriteLine("DriftEscapeForce_226: {0}", DriftEscapeForce_Count.DriftEscapeForce_226);
                Console.WriteLine("NormalBoosterTime_226: {0}", NormalBoosterTime_Count.NormalBoosterTime_226);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_226;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_226;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_226;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_226;
            }
            else if (KartSN_Count.KartSN_227 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_227 = 0;
                    TransAccelFactor_Count.TransAccelFactor_227 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_227 = 0;
                    SteerConstraint_Count.SteerConstraint_227 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_227 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_227 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_227 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_227 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_227: {0}", TransAccelFactor_Count.TransAccelFactor_227);
                Console.WriteLine("SteerConstraint_227: {0}", SteerConstraint_Count.SteerConstraint_227);
                Console.WriteLine("DriftEscapeForce_227: {0}", DriftEscapeForce_Count.DriftEscapeForce_227);
                Console.WriteLine("NormalBoosterTime_227: {0}", NormalBoosterTime_Count.NormalBoosterTime_227);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_227;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_227;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_227;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_227;
            }
            else if (KartSN_Count.KartSN_228 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_228 = 0;
                    TransAccelFactor_Count.TransAccelFactor_228 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_228 = 0;
                    SteerConstraint_Count.SteerConstraint_228 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_228 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_228 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_228 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_228 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_228: {0}", TransAccelFactor_Count.TransAccelFactor_228);
                Console.WriteLine("SteerConstraint_228: {0}", SteerConstraint_Count.SteerConstraint_228);
                Console.WriteLine("DriftEscapeForce_228: {0}", DriftEscapeForce_Count.DriftEscapeForce_228);
                Console.WriteLine("NormalBoosterTime_228: {0}", NormalBoosterTime_Count.NormalBoosterTime_228);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_228;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_228;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_228;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_228;
            }
            else if (KartSN_Count.KartSN_229 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_229 = 0;
                    TransAccelFactor_Count.TransAccelFactor_229 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_229 = 0;
                    SteerConstraint_Count.SteerConstraint_229 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_229 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_229 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_229 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_229 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_229: {0}", TransAccelFactor_Count.TransAccelFactor_229);
                Console.WriteLine("SteerConstraint_229: {0}", SteerConstraint_Count.SteerConstraint_229);
                Console.WriteLine("DriftEscapeForce_229: {0}", DriftEscapeForce_Count.DriftEscapeForce_229);
                Console.WriteLine("NormalBoosterTime_229: {0}", NormalBoosterTime_Count.NormalBoosterTime_229);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_229;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_229;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_229;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_229;
            }
            else if (KartSN_Count.KartSN_230 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_230 = 0;
                    TransAccelFactor_Count.TransAccelFactor_230 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_230 = 0;
                    SteerConstraint_Count.SteerConstraint_230 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_230 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_230 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_230 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_230 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_230: {0}", TransAccelFactor_Count.TransAccelFactor_230);
                Console.WriteLine("SteerConstraint_230: {0}", SteerConstraint_Count.SteerConstraint_230);
                Console.WriteLine("DriftEscapeForce_230: {0}", DriftEscapeForce_Count.DriftEscapeForce_230);
                Console.WriteLine("NormalBoosterTime_230: {0}", NormalBoosterTime_Count.NormalBoosterTime_230);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_230;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_230;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_230;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_230;
            }
            else if (KartSN_Count.KartSN_231 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_231 = 0;
                    TransAccelFactor_Count.TransAccelFactor_231 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_231 = 0;
                    SteerConstraint_Count.SteerConstraint_231 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_231 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_231 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_231 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_231 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_231: {0}", TransAccelFactor_Count.TransAccelFactor_231);
                Console.WriteLine("SteerConstraint_231: {0}", SteerConstraint_Count.SteerConstraint_231);
                Console.WriteLine("DriftEscapeForce_231: {0}", DriftEscapeForce_Count.DriftEscapeForce_231);
                Console.WriteLine("NormalBoosterTime_231: {0}", NormalBoosterTime_Count.NormalBoosterTime_231);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_231;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_231;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_231;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_231;
            }
            else if (KartSN_Count.KartSN_232 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_232 = 0;
                    TransAccelFactor_Count.TransAccelFactor_232 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_232 = 0;
                    SteerConstraint_Count.SteerConstraint_232 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_232 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_232 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_232 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_232 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_232: {0}", TransAccelFactor_Count.TransAccelFactor_232);
                Console.WriteLine("SteerConstraint_232: {0}", SteerConstraint_Count.SteerConstraint_232);
                Console.WriteLine("DriftEscapeForce_232: {0}", DriftEscapeForce_Count.DriftEscapeForce_232);
                Console.WriteLine("NormalBoosterTime_232: {0}", NormalBoosterTime_Count.NormalBoosterTime_232);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_232;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_232;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_232;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_232;
            }
            else if (KartSN_Count.KartSN_233 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_233 = 0;
                    TransAccelFactor_Count.TransAccelFactor_233 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_233 = 0;
                    SteerConstraint_Count.SteerConstraint_233 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_233 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_233 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_233 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_233 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_233: {0}", TransAccelFactor_Count.TransAccelFactor_233);
                Console.WriteLine("SteerConstraint_233: {0}", SteerConstraint_Count.SteerConstraint_233);
                Console.WriteLine("DriftEscapeForce_233: {0}", DriftEscapeForce_Count.DriftEscapeForce_233);
                Console.WriteLine("NormalBoosterTime_233: {0}", NormalBoosterTime_Count.NormalBoosterTime_233);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_233;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_233;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_233;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_233;
            }
            else if (KartSN_Count.KartSN_234 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_234 = 0;
                    TransAccelFactor_Count.TransAccelFactor_234 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_234 = 0;
                    SteerConstraint_Count.SteerConstraint_234 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_234 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_234 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_234 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_234 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_234: {0}", TransAccelFactor_Count.TransAccelFactor_234);
                Console.WriteLine("SteerConstraint_234: {0}", SteerConstraint_Count.SteerConstraint_234);
                Console.WriteLine("DriftEscapeForce_234: {0}", DriftEscapeForce_Count.DriftEscapeForce_234);
                Console.WriteLine("NormalBoosterTime_234: {0}", NormalBoosterTime_Count.NormalBoosterTime_234);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_234;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_234;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_234;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_234;
            }
            else if (KartSN_Count.KartSN_235 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_235 = 0;
                    TransAccelFactor_Count.TransAccelFactor_235 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_235 = 0;
                    SteerConstraint_Count.SteerConstraint_235 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_235 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_235 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_235 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_235 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_235: {0}", TransAccelFactor_Count.TransAccelFactor_235);
                Console.WriteLine("SteerConstraint_235: {0}", SteerConstraint_Count.SteerConstraint_235);
                Console.WriteLine("DriftEscapeForce_235: {0}", DriftEscapeForce_Count.DriftEscapeForce_235);
                Console.WriteLine("NormalBoosterTime_235: {0}", NormalBoosterTime_Count.NormalBoosterTime_235);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_235;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_235;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_235;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_235;
            }
            else if (KartSN_Count.KartSN_236 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_236 = 0;
                    TransAccelFactor_Count.TransAccelFactor_236 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_236 = 0;
                    SteerConstraint_Count.SteerConstraint_236 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_236 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_236 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_236 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_236 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_236: {0}", TransAccelFactor_Count.TransAccelFactor_236);
                Console.WriteLine("SteerConstraint_236: {0}", SteerConstraint_Count.SteerConstraint_236);
                Console.WriteLine("DriftEscapeForce_236: {0}", DriftEscapeForce_Count.DriftEscapeForce_236);
                Console.WriteLine("NormalBoosterTime_236: {0}", NormalBoosterTime_Count.NormalBoosterTime_236);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_236;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_236;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_236;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_236;
            }
            else if (KartSN_Count.KartSN_237 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_237 = 0;
                    TransAccelFactor_Count.TransAccelFactor_237 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_237 = 0;
                    SteerConstraint_Count.SteerConstraint_237 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_237 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_237 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_237 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_237 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_237: {0}", TransAccelFactor_Count.TransAccelFactor_237);
                Console.WriteLine("SteerConstraint_237: {0}", SteerConstraint_Count.SteerConstraint_237);
                Console.WriteLine("DriftEscapeForce_237: {0}", DriftEscapeForce_Count.DriftEscapeForce_237);
                Console.WriteLine("NormalBoosterTime_237: {0}", NormalBoosterTime_Count.NormalBoosterTime_237);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_237;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_237;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_237;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_237;
            }
            else if (KartSN_Count.KartSN_238 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_238 = 0;
                    TransAccelFactor_Count.TransAccelFactor_238 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_238 = 0;
                    SteerConstraint_Count.SteerConstraint_238 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_238 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_238 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_238 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_238 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_238: {0}", TransAccelFactor_Count.TransAccelFactor_238);
                Console.WriteLine("SteerConstraint_238: {0}", SteerConstraint_Count.SteerConstraint_238);
                Console.WriteLine("DriftEscapeForce_238: {0}", DriftEscapeForce_Count.DriftEscapeForce_238);
                Console.WriteLine("NormalBoosterTime_238: {0}", NormalBoosterTime_Count.NormalBoosterTime_238);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_238;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_238;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_238;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_238;
            }
            else if (KartSN_Count.KartSN_239 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_239 = 0;
                    TransAccelFactor_Count.TransAccelFactor_239 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_239 = 0;
                    SteerConstraint_Count.SteerConstraint_239 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_239 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_239 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_239 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_239 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_239: {0}", TransAccelFactor_Count.TransAccelFactor_239);
                Console.WriteLine("SteerConstraint_239: {0}", SteerConstraint_Count.SteerConstraint_239);
                Console.WriteLine("DriftEscapeForce_239: {0}", DriftEscapeForce_Count.DriftEscapeForce_239);
                Console.WriteLine("NormalBoosterTime_239: {0}", NormalBoosterTime_Count.NormalBoosterTime_239);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_239;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_239;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_239;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_239;
            }
            else if (KartSN_Count.KartSN_240 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_240 = 0;
                    TransAccelFactor_Count.TransAccelFactor_240 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_240 = 0;
                    SteerConstraint_Count.SteerConstraint_240 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_240 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_240 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_240 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_240 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_240: {0}", TransAccelFactor_Count.TransAccelFactor_240);
                Console.WriteLine("SteerConstraint_240: {0}", SteerConstraint_Count.SteerConstraint_240);
                Console.WriteLine("DriftEscapeForce_240: {0}", DriftEscapeForce_Count.DriftEscapeForce_240);
                Console.WriteLine("NormalBoosterTime_240: {0}", NormalBoosterTime_Count.NormalBoosterTime_240);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_240;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_240;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_240;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_240;
            }
            else if (KartSN_Count.KartSN_241 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_241 = 0;
                    TransAccelFactor_Count.TransAccelFactor_241 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_241 = 0;
                    SteerConstraint_Count.SteerConstraint_241 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_241 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_241 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_241 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_241 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_241: {0}", TransAccelFactor_Count.TransAccelFactor_241);
                Console.WriteLine("SteerConstraint_241: {0}", SteerConstraint_Count.SteerConstraint_241);
                Console.WriteLine("DriftEscapeForce_241: {0}", DriftEscapeForce_Count.DriftEscapeForce_241);
                Console.WriteLine("NormalBoosterTime_241: {0}", NormalBoosterTime_Count.NormalBoosterTime_241);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_241;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_241;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_241;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_241;
            }
            else if (KartSN_Count.KartSN_242 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_242 = 0;
                    TransAccelFactor_Count.TransAccelFactor_242 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_242 = 0;
                    SteerConstraint_Count.SteerConstraint_242 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_242 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_242 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_242 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_242 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_242: {0}", TransAccelFactor_Count.TransAccelFactor_242);
                Console.WriteLine("SteerConstraint_242: {0}", SteerConstraint_Count.SteerConstraint_242);
                Console.WriteLine("DriftEscapeForce_242: {0}", DriftEscapeForce_Count.DriftEscapeForce_242);
                Console.WriteLine("NormalBoosterTime_242: {0}", NormalBoosterTime_Count.NormalBoosterTime_242);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_242;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_242;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_242;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_242;
            }
            else if (KartSN_Count.KartSN_243 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_243 = 0;
                    TransAccelFactor_Count.TransAccelFactor_243 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_243 = 0;
                    SteerConstraint_Count.SteerConstraint_243 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_243 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_243 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_243 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_243 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_243: {0}", TransAccelFactor_Count.TransAccelFactor_243);
                Console.WriteLine("SteerConstraint_243: {0}", SteerConstraint_Count.SteerConstraint_243);
                Console.WriteLine("DriftEscapeForce_243: {0}", DriftEscapeForce_Count.DriftEscapeForce_243);
                Console.WriteLine("NormalBoosterTime_243: {0}", NormalBoosterTime_Count.NormalBoosterTime_243);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_243;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_243;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_243;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_243;
            }
            else if (KartSN_Count.KartSN_244 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_244 = 0;
                    TransAccelFactor_Count.TransAccelFactor_244 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_244 = 0;
                    SteerConstraint_Count.SteerConstraint_244 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_244 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_244 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_244 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_244 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_244: {0}", TransAccelFactor_Count.TransAccelFactor_244);
                Console.WriteLine("SteerConstraint_244: {0}", SteerConstraint_Count.SteerConstraint_244);
                Console.WriteLine("DriftEscapeForce_244: {0}", DriftEscapeForce_Count.DriftEscapeForce_244);
                Console.WriteLine("NormalBoosterTime_244: {0}", NormalBoosterTime_Count.NormalBoosterTime_244);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_244;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_244;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_244;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_244;
            }
            else if (KartSN_Count.KartSN_245 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_245 = 0;
                    TransAccelFactor_Count.TransAccelFactor_245 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_245 = 0;
                    SteerConstraint_Count.SteerConstraint_245 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_245 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_245 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_245 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_245 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_245: {0}", TransAccelFactor_Count.TransAccelFactor_245);
                Console.WriteLine("SteerConstraint_245: {0}", SteerConstraint_Count.SteerConstraint_245);
                Console.WriteLine("DriftEscapeForce_245: {0}", DriftEscapeForce_Count.DriftEscapeForce_245);
                Console.WriteLine("NormalBoosterTime_245: {0}", NormalBoosterTime_Count.NormalBoosterTime_245);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_245;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_245;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_245;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_245;
            }
            else if (KartSN_Count.KartSN_246 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_246 = 0;
                    TransAccelFactor_Count.TransAccelFactor_246 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_246 = 0;
                    SteerConstraint_Count.SteerConstraint_246 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_246 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_246 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_246 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_246 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_246: {0}", TransAccelFactor_Count.TransAccelFactor_246);
                Console.WriteLine("SteerConstraint_246: {0}", SteerConstraint_Count.SteerConstraint_246);
                Console.WriteLine("DriftEscapeForce_246: {0}", DriftEscapeForce_Count.DriftEscapeForce_246);
                Console.WriteLine("NormalBoosterTime_246: {0}", NormalBoosterTime_Count.NormalBoosterTime_246);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_246;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_246;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_246;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_246;
            }
            else if (KartSN_Count.KartSN_247 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_247 = 0;
                    TransAccelFactor_Count.TransAccelFactor_247 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_247 = 0;
                    SteerConstraint_Count.SteerConstraint_247 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_247 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_247 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_247 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_247 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_247: {0}", TransAccelFactor_Count.TransAccelFactor_247);
                Console.WriteLine("SteerConstraint_247: {0}", SteerConstraint_Count.SteerConstraint_247);
                Console.WriteLine("DriftEscapeForce_247: {0}", DriftEscapeForce_Count.DriftEscapeForce_247);
                Console.WriteLine("NormalBoosterTime_247: {0}", NormalBoosterTime_Count.NormalBoosterTime_247);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_247;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_247;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_247;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_247;
            }
            else if (KartSN_Count.KartSN_248 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_248 = 0;
                    TransAccelFactor_Count.TransAccelFactor_248 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_248 = 0;
                    SteerConstraint_Count.SteerConstraint_248 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_248 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_248 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_248 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_248 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_248: {0}", TransAccelFactor_Count.TransAccelFactor_248);
                Console.WriteLine("SteerConstraint_248: {0}", SteerConstraint_Count.SteerConstraint_248);
                Console.WriteLine("DriftEscapeForce_248: {0}", DriftEscapeForce_Count.DriftEscapeForce_248);
                Console.WriteLine("NormalBoosterTime_248: {0}", NormalBoosterTime_Count.NormalBoosterTime_248);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_248;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_248;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_248;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_248;
            }
            else if (KartSN_Count.KartSN_249 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_249 = 0;
                    TransAccelFactor_Count.TransAccelFactor_249 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_249 = 0;
                    SteerConstraint_Count.SteerConstraint_249 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_249 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_249 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_249 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_249 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_249: {0}", TransAccelFactor_Count.TransAccelFactor_249);
                Console.WriteLine("SteerConstraint_249: {0}", SteerConstraint_Count.SteerConstraint_249);
                Console.WriteLine("DriftEscapeForce_249: {0}", DriftEscapeForce_Count.DriftEscapeForce_249);
                Console.WriteLine("NormalBoosterTime_249: {0}", NormalBoosterTime_Count.NormalBoosterTime_249);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_249;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_249;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_249;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_249;
            }
            else if (KartSN_Count.KartSN_250 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_250 = 0;
                    TransAccelFactor_Count.TransAccelFactor_250 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_250 = 0;
                    SteerConstraint_Count.SteerConstraint_250 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_250 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_250 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_250 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_250 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_250: {0}", TransAccelFactor_Count.TransAccelFactor_250);
                Console.WriteLine("SteerConstraint_250: {0}", SteerConstraint_Count.SteerConstraint_250);
                Console.WriteLine("DriftEscapeForce_250: {0}", DriftEscapeForce_Count.DriftEscapeForce_250);
                Console.WriteLine("NormalBoosterTime_250: {0}", NormalBoosterTime_Count.NormalBoosterTime_250);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_250;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_250;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_250;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_250;
            }
            else if (KartSN_Count.KartSN_251 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_251 = 0;
                    TransAccelFactor_Count.TransAccelFactor_251 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_251 = 0;
                    SteerConstraint_Count.SteerConstraint_251 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_251 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_251 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_251 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_251 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_251: {0}", TransAccelFactor_Count.TransAccelFactor_251);
                Console.WriteLine("SteerConstraint_251: {0}", SteerConstraint_Count.SteerConstraint_251);
                Console.WriteLine("DriftEscapeForce_251: {0}", DriftEscapeForce_Count.DriftEscapeForce_251);
                Console.WriteLine("NormalBoosterTime_251: {0}", NormalBoosterTime_Count.NormalBoosterTime_251);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_251;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_251;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_251;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_251;
            }
            else if (KartSN_Count.KartSN_252 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_252 = 0;
                    TransAccelFactor_Count.TransAccelFactor_252 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_252 = 0;
                    SteerConstraint_Count.SteerConstraint_252 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_252 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_252 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_252 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_252 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_252: {0}", TransAccelFactor_Count.TransAccelFactor_252);
                Console.WriteLine("SteerConstraint_252: {0}", SteerConstraint_Count.SteerConstraint_252);
                Console.WriteLine("DriftEscapeForce_252: {0}", DriftEscapeForce_Count.DriftEscapeForce_252);
                Console.WriteLine("NormalBoosterTime_252: {0}", NormalBoosterTime_Count.NormalBoosterTime_252);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_252;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_252;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_252;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_252;
            }
            else if (KartSN_Count.KartSN_253 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_253 = 0;
                    TransAccelFactor_Count.TransAccelFactor_253 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_253 = 0;
                    SteerConstraint_Count.SteerConstraint_253 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_253 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_253 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_253 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_253 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_253: {0}", TransAccelFactor_Count.TransAccelFactor_253);
                Console.WriteLine("SteerConstraint_253: {0}", SteerConstraint_Count.SteerConstraint_253);
                Console.WriteLine("DriftEscapeForce_253: {0}", DriftEscapeForce_Count.DriftEscapeForce_253);
                Console.WriteLine("NormalBoosterTime_253: {0}", NormalBoosterTime_Count.NormalBoosterTime_253);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_253;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_253;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_253;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_253;
            }
            else if (KartSN_Count.KartSN_254 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_254 = 0;
                    TransAccelFactor_Count.TransAccelFactor_254 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_254 = 0;
                    SteerConstraint_Count.SteerConstraint_254 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_254 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_254 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_254 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_254 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_254: {0}", TransAccelFactor_Count.TransAccelFactor_254);
                Console.WriteLine("SteerConstraint_254: {0}", SteerConstraint_Count.SteerConstraint_254);
                Console.WriteLine("DriftEscapeForce_254: {0}", DriftEscapeForce_Count.DriftEscapeForce_254);
                Console.WriteLine("NormalBoosterTime_254: {0}", NormalBoosterTime_Count.NormalBoosterTime_254);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_254;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_254;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_254;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_254;
            }
            else if (KartSN_Count.KartSN_255 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_255 = 0;
                    TransAccelFactor_Count.TransAccelFactor_255 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_255 = 0;
                    SteerConstraint_Count.SteerConstraint_255 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_255 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_255 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_255 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_255 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_255: {0}", TransAccelFactor_Count.TransAccelFactor_255);
                Console.WriteLine("SteerConstraint_255: {0}", SteerConstraint_Count.SteerConstraint_255);
                Console.WriteLine("DriftEscapeForce_255: {0}", DriftEscapeForce_Count.DriftEscapeForce_255);
                Console.WriteLine("NormalBoosterTime_255: {0}", NormalBoosterTime_Count.NormalBoosterTime_255);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_255;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_255;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_255;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_255;
            }
            else if (KartSN_Count.KartSN_256 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_256 = 0;
                    TransAccelFactor_Count.TransAccelFactor_256 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_256 = 0;
                    SteerConstraint_Count.SteerConstraint_256 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_256 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_256 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_256 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_256 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_256: {0}", TransAccelFactor_Count.TransAccelFactor_256);
                Console.WriteLine("SteerConstraint_256: {0}", SteerConstraint_Count.SteerConstraint_256);
                Console.WriteLine("DriftEscapeForce_256: {0}", DriftEscapeForce_Count.DriftEscapeForce_256);
                Console.WriteLine("NormalBoosterTime_256: {0}", NormalBoosterTime_Count.NormalBoosterTime_256);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_256;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_256;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_256;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_256;
            }
            else if (KartSN_Count.KartSN_257 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_257 = 0;
                    TransAccelFactor_Count.TransAccelFactor_257 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_257 = 0;
                    SteerConstraint_Count.SteerConstraint_257 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_257 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_257 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_257 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_257 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_257: {0}", TransAccelFactor_Count.TransAccelFactor_257);
                Console.WriteLine("SteerConstraint_257: {0}", SteerConstraint_Count.SteerConstraint_257);
                Console.WriteLine("DriftEscapeForce_257: {0}", DriftEscapeForce_Count.DriftEscapeForce_257);
                Console.WriteLine("NormalBoosterTime_257: {0}", NormalBoosterTime_Count.NormalBoosterTime_257);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_257;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_257;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_257;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_257;
            }
            else if (KartSN_Count.KartSN_258 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_258 = 0;
                    TransAccelFactor_Count.TransAccelFactor_258 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_258 = 0;
                    SteerConstraint_Count.SteerConstraint_258 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_258 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_258 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_258 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_258 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_258: {0}", TransAccelFactor_Count.TransAccelFactor_258);
                Console.WriteLine("SteerConstraint_258: {0}", SteerConstraint_Count.SteerConstraint_258);
                Console.WriteLine("DriftEscapeForce_258: {0}", DriftEscapeForce_Count.DriftEscapeForce_258);
                Console.WriteLine("NormalBoosterTime_258: {0}", NormalBoosterTime_Count.NormalBoosterTime_258);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_258;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_258;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_258;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_258;
            }
            else if (KartSN_Count.KartSN_259 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_259 = 0;
                    TransAccelFactor_Count.TransAccelFactor_259 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_259 = 0;
                    SteerConstraint_Count.SteerConstraint_259 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_259 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_259 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_259 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_259 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_259: {0}", TransAccelFactor_Count.TransAccelFactor_259);
                Console.WriteLine("SteerConstraint_259: {0}", SteerConstraint_Count.SteerConstraint_259);
                Console.WriteLine("DriftEscapeForce_259: {0}", DriftEscapeForce_Count.DriftEscapeForce_259);
                Console.WriteLine("NormalBoosterTime_259: {0}", NormalBoosterTime_Count.NormalBoosterTime_259);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_259;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_259;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_259;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_259;
            }
            else if (KartSN_Count.KartSN_260 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_260 = 0;
                    TransAccelFactor_Count.TransAccelFactor_260 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_260 = 0;
                    SteerConstraint_Count.SteerConstraint_260 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_260 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_260 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_260 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_260 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_260: {0}", TransAccelFactor_Count.TransAccelFactor_260);
                Console.WriteLine("SteerConstraint_260: {0}", SteerConstraint_Count.SteerConstraint_260);
                Console.WriteLine("DriftEscapeForce_260: {0}", DriftEscapeForce_Count.DriftEscapeForce_260);
                Console.WriteLine("NormalBoosterTime_260: {0}", NormalBoosterTime_Count.NormalBoosterTime_260);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_260;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_260;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_260;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_260;
            }
            else if (KartSN_Count.KartSN_261 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_261 = 0;
                    TransAccelFactor_Count.TransAccelFactor_261 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_261 = 0;
                    SteerConstraint_Count.SteerConstraint_261 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_261 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_261 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_261 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_261 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_261: {0}", TransAccelFactor_Count.TransAccelFactor_261);
                Console.WriteLine("SteerConstraint_261: {0}", SteerConstraint_Count.SteerConstraint_261);
                Console.WriteLine("DriftEscapeForce_261: {0}", DriftEscapeForce_Count.DriftEscapeForce_261);
                Console.WriteLine("NormalBoosterTime_261: {0}", NormalBoosterTime_Count.NormalBoosterTime_261);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_261;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_261;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_261;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_261;
            }
            else if (KartSN_Count.KartSN_262 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_262 = 0;
                    TransAccelFactor_Count.TransAccelFactor_262 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_262 = 0;
                    SteerConstraint_Count.SteerConstraint_262 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_262 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_262 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_262 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_262 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_262: {0}", TransAccelFactor_Count.TransAccelFactor_262);
                Console.WriteLine("SteerConstraint_262: {0}", SteerConstraint_Count.SteerConstraint_262);
                Console.WriteLine("DriftEscapeForce_262: {0}", DriftEscapeForce_Count.DriftEscapeForce_262);
                Console.WriteLine("NormalBoosterTime_262: {0}", NormalBoosterTime_Count.NormalBoosterTime_262);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_262;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_262;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_262;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_262;
            }
            else if (KartSN_Count.KartSN_263 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_263 = 0;
                    TransAccelFactor_Count.TransAccelFactor_263 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_263 = 0;
                    SteerConstraint_Count.SteerConstraint_263 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_263 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_263 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_263 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_263 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_263: {0}", TransAccelFactor_Count.TransAccelFactor_263);
                Console.WriteLine("SteerConstraint_263: {0}", SteerConstraint_Count.SteerConstraint_263);
                Console.WriteLine("DriftEscapeForce_263: {0}", DriftEscapeForce_Count.DriftEscapeForce_263);
                Console.WriteLine("NormalBoosterTime_263: {0}", NormalBoosterTime_Count.NormalBoosterTime_263);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_263;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_263;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_263;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_263;
            }
            else if (KartSN_Count.KartSN_264 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_264 = 0;
                    TransAccelFactor_Count.TransAccelFactor_264 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_264 = 0;
                    SteerConstraint_Count.SteerConstraint_264 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_264 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_264 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_264 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_264 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_264: {0}", TransAccelFactor_Count.TransAccelFactor_264);
                Console.WriteLine("SteerConstraint_264: {0}", SteerConstraint_Count.SteerConstraint_264);
                Console.WriteLine("DriftEscapeForce_264: {0}", DriftEscapeForce_Count.DriftEscapeForce_264);
                Console.WriteLine("NormalBoosterTime_264: {0}", NormalBoosterTime_Count.NormalBoosterTime_264);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_264;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_264;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_264;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_264;
            }
            else if (KartSN_Count.KartSN_265 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_265 = 0;
                    TransAccelFactor_Count.TransAccelFactor_265 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_265 = 0;
                    SteerConstraint_Count.SteerConstraint_265 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_265 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_265 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_265 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_265 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_265: {0}", TransAccelFactor_Count.TransAccelFactor_265);
                Console.WriteLine("SteerConstraint_265: {0}", SteerConstraint_Count.SteerConstraint_265);
                Console.WriteLine("DriftEscapeForce_265: {0}", DriftEscapeForce_Count.DriftEscapeForce_265);
                Console.WriteLine("NormalBoosterTime_265: {0}", NormalBoosterTime_Count.NormalBoosterTime_265);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_265;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_265;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_265;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_265;
            }
            else if (KartSN_Count.KartSN_266 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_266 = 0;
                    TransAccelFactor_Count.TransAccelFactor_266 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_266 = 0;
                    SteerConstraint_Count.SteerConstraint_266 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_266 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_266 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_266 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_266 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_266: {0}", TransAccelFactor_Count.TransAccelFactor_266);
                Console.WriteLine("SteerConstraint_266: {0}", SteerConstraint_Count.SteerConstraint_266);
                Console.WriteLine("DriftEscapeForce_266: {0}", DriftEscapeForce_Count.DriftEscapeForce_266);
                Console.WriteLine("NormalBoosterTime_266: {0}", NormalBoosterTime_Count.NormalBoosterTime_266);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_266;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_266;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_266;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_266;
            }
            else if (KartSN_Count.KartSN_267 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_267 = 0;
                    TransAccelFactor_Count.TransAccelFactor_267 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_267 = 0;
                    SteerConstraint_Count.SteerConstraint_267 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_267 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_267 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_267 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_267 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_267: {0}", TransAccelFactor_Count.TransAccelFactor_267);
                Console.WriteLine("SteerConstraint_267: {0}", SteerConstraint_Count.SteerConstraint_267);
                Console.WriteLine("DriftEscapeForce_267: {0}", DriftEscapeForce_Count.DriftEscapeForce_267);
                Console.WriteLine("NormalBoosterTime_267: {0}", NormalBoosterTime_Count.NormalBoosterTime_267);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_267;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_267;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_267;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_267;
            }
            else if (KartSN_Count.KartSN_268 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_268 = 0;
                    TransAccelFactor_Count.TransAccelFactor_268 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_268 = 0;
                    SteerConstraint_Count.SteerConstraint_268 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_268 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_268 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_268 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_268 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_268: {0}", TransAccelFactor_Count.TransAccelFactor_268);
                Console.WriteLine("SteerConstraint_268: {0}", SteerConstraint_Count.SteerConstraint_268);
                Console.WriteLine("DriftEscapeForce_268: {0}", DriftEscapeForce_Count.DriftEscapeForce_268);
                Console.WriteLine("NormalBoosterTime_268: {0}", NormalBoosterTime_Count.NormalBoosterTime_268);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_268;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_268;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_268;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_268;
            }
            else if (KartSN_Count.KartSN_269 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_269 = 0;
                    TransAccelFactor_Count.TransAccelFactor_269 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_269 = 0;
                    SteerConstraint_Count.SteerConstraint_269 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_269 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_269 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_269 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_269 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_269: {0}", TransAccelFactor_Count.TransAccelFactor_269);
                Console.WriteLine("SteerConstraint_269: {0}", SteerConstraint_Count.SteerConstraint_269);
                Console.WriteLine("DriftEscapeForce_269: {0}", DriftEscapeForce_Count.DriftEscapeForce_269);
                Console.WriteLine("NormalBoosterTime_269: {0}", NormalBoosterTime_Count.NormalBoosterTime_269);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_269;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_269;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_269;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_269;
            }
            else if (KartSN_Count.KartSN_270 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_270 = 0;
                    TransAccelFactor_Count.TransAccelFactor_270 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_270 = 0;
                    SteerConstraint_Count.SteerConstraint_270 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_270 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_270 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_270 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_270 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_270: {0}", TransAccelFactor_Count.TransAccelFactor_270);
                Console.WriteLine("SteerConstraint_270: {0}", SteerConstraint_Count.SteerConstraint_270);
                Console.WriteLine("DriftEscapeForce_270: {0}", DriftEscapeForce_Count.DriftEscapeForce_270);
                Console.WriteLine("NormalBoosterTime_270: {0}", NormalBoosterTime_Count.NormalBoosterTime_270);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_270;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_270;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_270;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_270;
            }
            else if (KartSN_Count.KartSN_271 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_271 = 0;
                    TransAccelFactor_Count.TransAccelFactor_271 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_271 = 0;
                    SteerConstraint_Count.SteerConstraint_271 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_271 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_271 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_271 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_271 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_271: {0}", TransAccelFactor_Count.TransAccelFactor_271);
                Console.WriteLine("SteerConstraint_271: {0}", SteerConstraint_Count.SteerConstraint_271);
                Console.WriteLine("DriftEscapeForce_271: {0}", DriftEscapeForce_Count.DriftEscapeForce_271);
                Console.WriteLine("NormalBoosterTime_271: {0}", NormalBoosterTime_Count.NormalBoosterTime_271);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_271;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_271;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_271;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_271;
            }
            else if (KartSN_Count.KartSN_272 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_272 = 0;
                    TransAccelFactor_Count.TransAccelFactor_272 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_272 = 0;
                    SteerConstraint_Count.SteerConstraint_272 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_272 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_272 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_272 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_272 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_272: {0}", TransAccelFactor_Count.TransAccelFactor_272);
                Console.WriteLine("SteerConstraint_272: {0}", SteerConstraint_Count.SteerConstraint_272);
                Console.WriteLine("DriftEscapeForce_272: {0}", DriftEscapeForce_Count.DriftEscapeForce_272);
                Console.WriteLine("NormalBoosterTime_272: {0}", NormalBoosterTime_Count.NormalBoosterTime_272);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_272;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_272;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_272;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_272;
            }
            else if (KartSN_Count.KartSN_273 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_273 = 0;
                    TransAccelFactor_Count.TransAccelFactor_273 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_273 = 0;
                    SteerConstraint_Count.SteerConstraint_273 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_273 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_273 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_273 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_273 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_273: {0}", TransAccelFactor_Count.TransAccelFactor_273);
                Console.WriteLine("SteerConstraint_273: {0}", SteerConstraint_Count.SteerConstraint_273);
                Console.WriteLine("DriftEscapeForce_273: {0}", DriftEscapeForce_Count.DriftEscapeForce_273);
                Console.WriteLine("NormalBoosterTime_273: {0}", NormalBoosterTime_Count.NormalBoosterTime_273);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_273;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_273;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_273;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_273;
            }
            else if (KartSN_Count.KartSN_274 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_274 = 0;
                    TransAccelFactor_Count.TransAccelFactor_274 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_274 = 0;
                    SteerConstraint_Count.SteerConstraint_274 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_274 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_274 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_274 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_274 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_274: {0}", TransAccelFactor_Count.TransAccelFactor_274);
                Console.WriteLine("SteerConstraint_274: {0}", SteerConstraint_Count.SteerConstraint_274);
                Console.WriteLine("DriftEscapeForce_274: {0}", DriftEscapeForce_Count.DriftEscapeForce_274);
                Console.WriteLine("NormalBoosterTime_274: {0}", NormalBoosterTime_Count.NormalBoosterTime_274);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_274;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_274;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_274;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_274;
            }
            else if (KartSN_Count.KartSN_275 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_275 = 0;
                    TransAccelFactor_Count.TransAccelFactor_275 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_275 = 0;
                    SteerConstraint_Count.SteerConstraint_275 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_275 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_275 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_275 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_275 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_275: {0}", TransAccelFactor_Count.TransAccelFactor_275);
                Console.WriteLine("SteerConstraint_275: {0}", SteerConstraint_Count.SteerConstraint_275);
                Console.WriteLine("DriftEscapeForce_275: {0}", DriftEscapeForce_Count.DriftEscapeForce_275);
                Console.WriteLine("NormalBoosterTime_275: {0}", NormalBoosterTime_Count.NormalBoosterTime_275);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_275;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_275;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_275;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_275;
            }
            else if (KartSN_Count.KartSN_276 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_276 = 0;
                    TransAccelFactor_Count.TransAccelFactor_276 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_276 = 0;
                    SteerConstraint_Count.SteerConstraint_276 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_276 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_276 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_276 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_276 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_276: {0}", TransAccelFactor_Count.TransAccelFactor_276);
                Console.WriteLine("SteerConstraint_276: {0}", SteerConstraint_Count.SteerConstraint_276);
                Console.WriteLine("DriftEscapeForce_276: {0}", DriftEscapeForce_Count.DriftEscapeForce_276);
                Console.WriteLine("NormalBoosterTime_276: {0}", NormalBoosterTime_Count.NormalBoosterTime_276);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_276;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_276;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_276;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_276;
            }
            else if (KartSN_Count.KartSN_277 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_277 = 0;
                    TransAccelFactor_Count.TransAccelFactor_277 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_277 = 0;
                    SteerConstraint_Count.SteerConstraint_277 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_277 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_277 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_277 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_277 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_277: {0}", TransAccelFactor_Count.TransAccelFactor_277);
                Console.WriteLine("SteerConstraint_277: {0}", SteerConstraint_Count.SteerConstraint_277);
                Console.WriteLine("DriftEscapeForce_277: {0}", DriftEscapeForce_Count.DriftEscapeForce_277);
                Console.WriteLine("NormalBoosterTime_277: {0}", NormalBoosterTime_Count.NormalBoosterTime_277);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_277;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_277;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_277;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_277;
            }
            else if (KartSN_Count.KartSN_278 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_278 = 0;
                    TransAccelFactor_Count.TransAccelFactor_278 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_278 = 0;
                    SteerConstraint_Count.SteerConstraint_278 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_278 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_278 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_278 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_278 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_278: {0}", TransAccelFactor_Count.TransAccelFactor_278);
                Console.WriteLine("SteerConstraint_278: {0}", SteerConstraint_Count.SteerConstraint_278);
                Console.WriteLine("DriftEscapeForce_278: {0}", DriftEscapeForce_Count.DriftEscapeForce_278);
                Console.WriteLine("NormalBoosterTime_278: {0}", NormalBoosterTime_Count.NormalBoosterTime_278);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_278;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_278;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_278;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_278;
            }
            else if (KartSN_Count.KartSN_279 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_279 = 0;
                    TransAccelFactor_Count.TransAccelFactor_279 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_279 = 0;
                    SteerConstraint_Count.SteerConstraint_279 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_279 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_279 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_279 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_279 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_279: {0}", TransAccelFactor_Count.TransAccelFactor_279);
                Console.WriteLine("SteerConstraint_279: {0}", SteerConstraint_Count.SteerConstraint_279);
                Console.WriteLine("DriftEscapeForce_279: {0}", DriftEscapeForce_Count.DriftEscapeForce_279);
                Console.WriteLine("NormalBoosterTime_279: {0}", NormalBoosterTime_Count.NormalBoosterTime_279);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_279;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_279;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_279;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_279;
            }
            else if (KartSN_Count.KartSN_280 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_280 = 0;
                    TransAccelFactor_Count.TransAccelFactor_280 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_280 = 0;
                    SteerConstraint_Count.SteerConstraint_280 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_280 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_280 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_280 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_280 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_280: {0}", TransAccelFactor_Count.TransAccelFactor_280);
                Console.WriteLine("SteerConstraint_280: {0}", SteerConstraint_Count.SteerConstraint_280);
                Console.WriteLine("DriftEscapeForce_280: {0}", DriftEscapeForce_Count.DriftEscapeForce_280);
                Console.WriteLine("NormalBoosterTime_280: {0}", NormalBoosterTime_Count.NormalBoosterTime_280);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_280;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_280;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_280;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_280;
            }
            else if (KartSN_Count.KartSN_281 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_281 = 0;
                    TransAccelFactor_Count.TransAccelFactor_281 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_281 = 0;
                    SteerConstraint_Count.SteerConstraint_281 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_281 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_281 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_281 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_281 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_281: {0}", TransAccelFactor_Count.TransAccelFactor_281);
                Console.WriteLine("SteerConstraint_281: {0}", SteerConstraint_Count.SteerConstraint_281);
                Console.WriteLine("DriftEscapeForce_281: {0}", DriftEscapeForce_Count.DriftEscapeForce_281);
                Console.WriteLine("NormalBoosterTime_281: {0}", NormalBoosterTime_Count.NormalBoosterTime_281);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_281;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_281;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_281;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_281;
            }
            else if (KartSN_Count.KartSN_282 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_282 = 0;
                    TransAccelFactor_Count.TransAccelFactor_282 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_282 = 0;
                    SteerConstraint_Count.SteerConstraint_282 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_282 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_282 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_282 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_282 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_282: {0}", TransAccelFactor_Count.TransAccelFactor_282);
                Console.WriteLine("SteerConstraint_282: {0}", SteerConstraint_Count.SteerConstraint_282);
                Console.WriteLine("DriftEscapeForce_282: {0}", DriftEscapeForce_Count.DriftEscapeForce_282);
                Console.WriteLine("NormalBoosterTime_282: {0}", NormalBoosterTime_Count.NormalBoosterTime_282);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_282;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_282;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_282;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_282;
            }
            else if (KartSN_Count.KartSN_283 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_283 = 0;
                    TransAccelFactor_Count.TransAccelFactor_283 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_283 = 0;
                    SteerConstraint_Count.SteerConstraint_283 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_283 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_283 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_283 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_283 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_283: {0}", TransAccelFactor_Count.TransAccelFactor_283);
                Console.WriteLine("SteerConstraint_283: {0}", SteerConstraint_Count.SteerConstraint_283);
                Console.WriteLine("DriftEscapeForce_283: {0}", DriftEscapeForce_Count.DriftEscapeForce_283);
                Console.WriteLine("NormalBoosterTime_283: {0}", NormalBoosterTime_Count.NormalBoosterTime_283);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_283;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_283;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_283;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_283;
            }
            else if (KartSN_Count.KartSN_284 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_284 = 0;
                    TransAccelFactor_Count.TransAccelFactor_284 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_284 = 0;
                    SteerConstraint_Count.SteerConstraint_284 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_284 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_284 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_284 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_284 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_284: {0}", TransAccelFactor_Count.TransAccelFactor_284);
                Console.WriteLine("SteerConstraint_284: {0}", SteerConstraint_Count.SteerConstraint_284);
                Console.WriteLine("DriftEscapeForce_284: {0}", DriftEscapeForce_Count.DriftEscapeForce_284);
                Console.WriteLine("NormalBoosterTime_284: {0}", NormalBoosterTime_Count.NormalBoosterTime_284);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_284;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_284;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_284;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_284;
            }
            else if (KartSN_Count.KartSN_285 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_285 = 0;
                    TransAccelFactor_Count.TransAccelFactor_285 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_285 = 0;
                    SteerConstraint_Count.SteerConstraint_285 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_285 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_285 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_285 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_285 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_285: {0}", TransAccelFactor_Count.TransAccelFactor_285);
                Console.WriteLine("SteerConstraint_285: {0}", SteerConstraint_Count.SteerConstraint_285);
                Console.WriteLine("DriftEscapeForce_285: {0}", DriftEscapeForce_Count.DriftEscapeForce_285);
                Console.WriteLine("NormalBoosterTime_285: {0}", NormalBoosterTime_Count.NormalBoosterTime_285);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_285;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_285;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_285;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_285;
            }
            else if (KartSN_Count.KartSN_286 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_286 = 0;
                    TransAccelFactor_Count.TransAccelFactor_286 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_286 = 0;
                    SteerConstraint_Count.SteerConstraint_286 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_286 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_286 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_286 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_286 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_286: {0}", TransAccelFactor_Count.TransAccelFactor_286);
                Console.WriteLine("SteerConstraint_286: {0}", SteerConstraint_Count.SteerConstraint_286);
                Console.WriteLine("DriftEscapeForce_286: {0}", DriftEscapeForce_Count.DriftEscapeForce_286);
                Console.WriteLine("NormalBoosterTime_286: {0}", NormalBoosterTime_Count.NormalBoosterTime_286);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_286;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_286;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_286;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_286;
            }
            else if (KartSN_Count.KartSN_287 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_287 = 0;
                    TransAccelFactor_Count.TransAccelFactor_287 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_287 = 0;
                    SteerConstraint_Count.SteerConstraint_287 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_287 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_287 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_287 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_287 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_287: {0}", TransAccelFactor_Count.TransAccelFactor_287);
                Console.WriteLine("SteerConstraint_287: {0}", SteerConstraint_Count.SteerConstraint_287);
                Console.WriteLine("DriftEscapeForce_287: {0}", DriftEscapeForce_Count.DriftEscapeForce_287);
                Console.WriteLine("NormalBoosterTime_287: {0}", NormalBoosterTime_Count.NormalBoosterTime_287);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_287;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_287;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_287;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_287;
            }
            else if (KartSN_Count.KartSN_288 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_288 = 0;
                    TransAccelFactor_Count.TransAccelFactor_288 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_288 = 0;
                    SteerConstraint_Count.SteerConstraint_288 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_288 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_288 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_288 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_288 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_288: {0}", TransAccelFactor_Count.TransAccelFactor_288);
                Console.WriteLine("SteerConstraint_288: {0}", SteerConstraint_Count.SteerConstraint_288);
                Console.WriteLine("DriftEscapeForce_288: {0}", DriftEscapeForce_Count.DriftEscapeForce_288);
                Console.WriteLine("NormalBoosterTime_288: {0}", NormalBoosterTime_Count.NormalBoosterTime_288);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_288;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_288;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_288;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_288;
            }
            else if (KartSN_Count.KartSN_289 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_289 = 0;
                    TransAccelFactor_Count.TransAccelFactor_289 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_289 = 0;
                    SteerConstraint_Count.SteerConstraint_289 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_289 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_289 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_289 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_289 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_289: {0}", TransAccelFactor_Count.TransAccelFactor_289);
                Console.WriteLine("SteerConstraint_289: {0}", SteerConstraint_Count.SteerConstraint_289);
                Console.WriteLine("DriftEscapeForce_289: {0}", DriftEscapeForce_Count.DriftEscapeForce_289);
                Console.WriteLine("NormalBoosterTime_289: {0}", NormalBoosterTime_Count.NormalBoosterTime_289);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_289;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_289;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_289;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_289;
            }
            else if (KartSN_Count.KartSN_290 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_290 = 0;
                    TransAccelFactor_Count.TransAccelFactor_290 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_290 = 0;
                    SteerConstraint_Count.SteerConstraint_290 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_290 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_290 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_290 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_290 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_290: {0}", TransAccelFactor_Count.TransAccelFactor_290);
                Console.WriteLine("SteerConstraint_290: {0}", SteerConstraint_Count.SteerConstraint_290);
                Console.WriteLine("DriftEscapeForce_290: {0}", DriftEscapeForce_Count.DriftEscapeForce_290);
                Console.WriteLine("NormalBoosterTime_290: {0}", NormalBoosterTime_Count.NormalBoosterTime_290);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_290;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_290;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_290;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_290;
            }
            else if (KartSN_Count.KartSN_291 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_291 = 0;
                    TransAccelFactor_Count.TransAccelFactor_291 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_291 = 0;
                    SteerConstraint_Count.SteerConstraint_291 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_291 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_291 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_291 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_291 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_291: {0}", TransAccelFactor_Count.TransAccelFactor_291);
                Console.WriteLine("SteerConstraint_291: {0}", SteerConstraint_Count.SteerConstraint_291);
                Console.WriteLine("DriftEscapeForce_291: {0}", DriftEscapeForce_Count.DriftEscapeForce_291);
                Console.WriteLine("NormalBoosterTime_291: {0}", NormalBoosterTime_Count.NormalBoosterTime_291);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_291;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_291;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_291;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_291;
            }
            else if (KartSN_Count.KartSN_292 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_292 = 0;
                    TransAccelFactor_Count.TransAccelFactor_292 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_292 = 0;
                    SteerConstraint_Count.SteerConstraint_292 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_292 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_292 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_292 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_292 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_292: {0}", TransAccelFactor_Count.TransAccelFactor_292);
                Console.WriteLine("SteerConstraint_292: {0}", SteerConstraint_Count.SteerConstraint_292);
                Console.WriteLine("DriftEscapeForce_292: {0}", DriftEscapeForce_Count.DriftEscapeForce_292);
                Console.WriteLine("NormalBoosterTime_292: {0}", NormalBoosterTime_Count.NormalBoosterTime_292);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_292;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_292;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_292;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_292;
            }
            else if (KartSN_Count.KartSN_293 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_293 = 0;
                    TransAccelFactor_Count.TransAccelFactor_293 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_293 = 0;
                    SteerConstraint_Count.SteerConstraint_293 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_293 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_293 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_293 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_293 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_293: {0}", TransAccelFactor_Count.TransAccelFactor_293);
                Console.WriteLine("SteerConstraint_293: {0}", SteerConstraint_Count.SteerConstraint_293);
                Console.WriteLine("DriftEscapeForce_293: {0}", DriftEscapeForce_Count.DriftEscapeForce_293);
                Console.WriteLine("NormalBoosterTime_293: {0}", NormalBoosterTime_Count.NormalBoosterTime_293);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_293;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_293;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_293;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_293;
            }
            else if (KartSN_Count.KartSN_294 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_294 = 0;
                    TransAccelFactor_Count.TransAccelFactor_294 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_294 = 0;
                    SteerConstraint_Count.SteerConstraint_294 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_294 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_294 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_294 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_294 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_294: {0}", TransAccelFactor_Count.TransAccelFactor_294);
                Console.WriteLine("SteerConstraint_294: {0}", SteerConstraint_Count.SteerConstraint_294);
                Console.WriteLine("DriftEscapeForce_294: {0}", DriftEscapeForce_Count.DriftEscapeForce_294);
                Console.WriteLine("NormalBoosterTime_294: {0}", NormalBoosterTime_Count.NormalBoosterTime_294);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_294;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_294;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_294;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_294;
            }
            else if (KartSN_Count.KartSN_295 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_295 = 0;
                    TransAccelFactor_Count.TransAccelFactor_295 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_295 = 0;
                    SteerConstraint_Count.SteerConstraint_295 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_295 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_295 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_295 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_295 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_295: {0}", TransAccelFactor_Count.TransAccelFactor_295);
                Console.WriteLine("SteerConstraint_295: {0}", SteerConstraint_Count.SteerConstraint_295);
                Console.WriteLine("DriftEscapeForce_295: {0}", DriftEscapeForce_Count.DriftEscapeForce_295);
                Console.WriteLine("NormalBoosterTime_295: {0}", NormalBoosterTime_Count.NormalBoosterTime_295);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_295;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_295;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_295;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_295;
            }
            else if (KartSN_Count.KartSN_296 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_296 = 0;
                    TransAccelFactor_Count.TransAccelFactor_296 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_296 = 0;
                    SteerConstraint_Count.SteerConstraint_296 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_296 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_296 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_296 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_296 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_296: {0}", TransAccelFactor_Count.TransAccelFactor_296);
                Console.WriteLine("SteerConstraint_296: {0}", SteerConstraint_Count.SteerConstraint_296);
                Console.WriteLine("DriftEscapeForce_296: {0}", DriftEscapeForce_Count.DriftEscapeForce_296);
                Console.WriteLine("NormalBoosterTime_296: {0}", NormalBoosterTime_Count.NormalBoosterTime_296);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_296;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_296;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_296;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_296;
            }
            else if (KartSN_Count.KartSN_297 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_297 = 0;
                    TransAccelFactor_Count.TransAccelFactor_297 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_297 = 0;
                    SteerConstraint_Count.SteerConstraint_297 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_297 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_297 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_297 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_297 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_297: {0}", TransAccelFactor_Count.TransAccelFactor_297);
                Console.WriteLine("SteerConstraint_297: {0}", SteerConstraint_Count.SteerConstraint_297);
                Console.WriteLine("DriftEscapeForce_297: {0}", DriftEscapeForce_Count.DriftEscapeForce_297);
                Console.WriteLine("NormalBoosterTime_297: {0}", NormalBoosterTime_Count.NormalBoosterTime_297);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_297;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_297;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_297;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_297;
            }
            else if (KartSN_Count.KartSN_298 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_298 = 0;
                    TransAccelFactor_Count.TransAccelFactor_298 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_298 = 0;
                    SteerConstraint_Count.SteerConstraint_298 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_298 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_298 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_298 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_298 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_298: {0}", TransAccelFactor_Count.TransAccelFactor_298);
                Console.WriteLine("SteerConstraint_298: {0}", SteerConstraint_Count.SteerConstraint_298);
                Console.WriteLine("DriftEscapeForce_298: {0}", DriftEscapeForce_Count.DriftEscapeForce_298);
                Console.WriteLine("NormalBoosterTime_298: {0}", NormalBoosterTime_Count.NormalBoosterTime_298);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_298;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_298;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_298;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_298;
            }
            else if (KartSN_Count.KartSN_299 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_299 = 0;
                    TransAccelFactor_Count.TransAccelFactor_299 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_299 = 0;
                    SteerConstraint_Count.SteerConstraint_299 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_299 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_299 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_299 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_299 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_299: {0}", TransAccelFactor_Count.TransAccelFactor_299);
                Console.WriteLine("SteerConstraint_299: {0}", SteerConstraint_Count.SteerConstraint_299);
                Console.WriteLine("DriftEscapeForce_299: {0}", DriftEscapeForce_Count.DriftEscapeForce_299);
                Console.WriteLine("NormalBoosterTime_299: {0}", NormalBoosterTime_Count.NormalBoosterTime_299);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_299;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_299;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_299;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_299;
            }
            else if (KartSN_Count.KartSN_300 == Launcher.KartSN)
            {
                if (PartSpec.Item_Cat_Id == 63)
                {
                    TransAccelFactor_Count.TransAccelFactor_300 = 0;
                    TransAccelFactor_Count.TransAccelFactor_300 = PartSpec.TransAccelFactor;
                }
                else if (PartSpec.Item_Cat_Id == 64)
                {
                    SteerConstraint_Count.SteerConstraint_300 = 0;
                    SteerConstraint_Count.SteerConstraint_300 = PartSpec.SteerConstraint;
                }
                else if (PartSpec.Item_Cat_Id == 65)
                {
                    DriftEscapeForce_Count.DriftEscapeForce_300 = 0;
                    DriftEscapeForce_Count.DriftEscapeForce_300 = PartSpec.DriftEscapeForce;
                }
                else if (PartSpec.Item_Cat_Id == 66)
                {
                    NormalBoosterTime_Count.NormalBoosterTime_300 = 0;
                    NormalBoosterTime_Count.NormalBoosterTime_300 = PartSpec.NormalBoosterTime;
                }
                Console.WriteLine("TransAccelFactor_300: {0}", TransAccelFactor_Count.TransAccelFactor_300);
                Console.WriteLine("SteerConstraint_300: {0}", SteerConstraint_Count.SteerConstraint_300);
                Console.WriteLine("DriftEscapeForce_300: {0}", DriftEscapeForce_Count.DriftEscapeForce_300);
                Console.WriteLine("NormalBoosterTime_300: {0}", NormalBoosterTime_Count.NormalBoosterTime_300);
                PartSpec.TransAccelFactor = TransAccelFactor_Count.TransAccelFactor_300;
                PartSpec.SteerConstraint = SteerConstraint_Count.SteerConstraint_300;
                PartSpec.DriftEscapeForce = DriftEscapeForce_Count.DriftEscapeForce_300;
                PartSpec.NormalBoosterTime = NormalBoosterTime_Count.NormalBoosterTime_300;
            }
            else
            {
                PartSpec.TransAccelFactor = 0f;
                PartSpec.SteerConstraint = 0f;
                PartSpec.DriftEscapeForce = 0f;
                PartSpec.NormalBoosterTime = 0f;
                Console.WriteLine("TransAccelFactor: {0}", PartSpec.TransAccelFactor);
                Console.WriteLine("SteerConstraint: {0}", PartSpec.SteerConstraint);
                Console.WriteLine("DriftEscapeForce: {0}", PartSpec.DriftEscapeForce);
                Console.WriteLine("NormalBoosterTime: {0}", PartSpec.NormalBoosterTime);
            }
            Console.WriteLine("-------------------------------------------------------------");
            PartSpec.Item_Cat_Id = 0;
        }
    }
}