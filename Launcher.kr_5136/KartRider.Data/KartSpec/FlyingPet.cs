using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartSpec;

namespace KartRider
{
    public class FlyingPet
    {
        public static float DragFactor;
        public static float ForwardAccelForce;
        public static float DriftEscapeForce;
        public static float CornerDrawFactor;
        public static float NormalBoosterTime;
        public static float ItemBoosterTime;
        public static float TeamBoosterTime;
        public static float StartForwardAccelForceItem;
        public static float StartForwardAccelForceSpeed;

        public static void FlyingPet_Spec()
        {
            if (StartGameData.FlyingPet_id == 1 || StartGameData.FlyingPet_id == 2 || StartGameData.FlyingPet_id == 3 || StartGameData.FlyingPet_id == 4 || StartGameData.FlyingPet_id == 5 || StartGameData.FlyingPet_id == 6)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 7 || StartGameData.FlyingPet_id == 8 || StartGameData.FlyingPet_id == 9 || StartGameData.FlyingPet_id == 10 || StartGameData.FlyingPet_id == 11 || StartGameData.FlyingPet_id == 12)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 13 || StartGameData.FlyingPet_id == 14 || StartGameData.FlyingPet_id == 15 || StartGameData.FlyingPet_id == 16 || StartGameData.FlyingPet_id == 17 || StartGameData.FlyingPet_id == 18)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 19)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 560f;
                FlyingPet.StartForwardAccelForceSpeed = 560f;
            }
            else if (StartGameData.FlyingPet_id == 25)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 3.5f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 26)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0.002f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 27)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 28)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 29)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 30)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 31)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 32)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 33)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 34)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 35)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 36)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 37)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 38)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 39)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 155f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 40)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 41)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 42)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 43)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0.002f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 44)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 3.5f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 45)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 46)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1000f;
                FlyingPet.StartForwardAccelForceSpeed = 1000f;
            }
            else if (StartGameData.FlyingPet_id == 47)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 5.0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 48)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0.002f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 49)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 50)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 51)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 53)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1000f;
                FlyingPet.StartForwardAccelForceSpeed = 1000f;
            }
            else if (StartGameData.FlyingPet_id == 54)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 5.0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 56)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 57)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 58)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 59)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 5.0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 60)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 3.5f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 300f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 61)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 5.0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 62)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 63)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 300f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1000f;
                FlyingPet.StartForwardAccelForceSpeed = 1000f;
            }
            else if (StartGameData.FlyingPet_id == 64)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 3.5f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0.002f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 65)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 66)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 5.0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 67)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 68)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 69)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 5.0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 300f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 71)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 300f;
                FlyingPet.StartForwardAccelForceItem = 1000f;
                FlyingPet.StartForwardAccelForceSpeed = 1000f;
            }
            else if (StartGameData.FlyingPet_id == 72)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1000f;
                FlyingPet.StartForwardAccelForceSpeed = 1000f;
            }
            else if (StartGameData.FlyingPet_id == 73)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 74)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0.002f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 75)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 300f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 76)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 77)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 5.0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 78)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 5.0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 250f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 79)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 1300f;
                FlyingPet.StartForwardAccelForceSpeed = 1300f;
            }
            else if (StartGameData.FlyingPet_id == 80)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 81)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 250f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else if (StartGameData.FlyingPet_id == 82)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 0f;
                FlyingPet.DriftEscapeForce = 100f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 0f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 800f;
                FlyingPet.StartForwardAccelForceSpeed = 800f;
            }
            else if (StartGameData.FlyingPet_id == 83)
            {
                FlyingPet.DragFactor = 0f;
                FlyingPet.ForwardAccelForce = 3.5f;
                FlyingPet.DriftEscapeForce = 0f;
                FlyingPet.CornerDrawFactor = 0f;
                FlyingPet.NormalBoosterTime = 0f;
                FlyingPet.ItemBoosterTime = 300f;
                FlyingPet.TeamBoosterTime = 0f;
                FlyingPet.StartForwardAccelForceItem = 0f;
                FlyingPet.StartForwardAccelForceSpeed = 0f;
            }
            else
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
            if (StartGameData.Kart_id <= 250)
            {
                Kart_01.Kart_250();
            }
            else if (StartGameData.Kart_id <= 500)
            {
                Kart_02.Kart_500();
            }
            else if (StartGameData.Kart_id <= 750)
            {
                Kart_03.Kart_750();
            }
            else if (StartGameData.Kart_id <= 1000)
            {
                Kart_04.Kart_1000();
            }
            else if (StartGameData.Kart_id <= 1250)
            {
                Kart_05.Kart_1250();
            }
            else if (StartGameData.Kart_id <= 1456)
            {
                Kart_06.Kart_1456();
            }
            else
            {
                GameSupport.OnDisconnect();
            }
        }
    }
}