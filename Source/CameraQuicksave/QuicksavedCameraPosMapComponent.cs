using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Verse;

namespace CameraQuicksave
{
    public class QuicksavedCameraPosMapComponent : MapComponent
    {
        public RememberedCameraPos savedPosition;

        private static FieldInfo DriverVelocity =
            typeof(CameraDriver).GetField("velocity", BindingFlags.NonPublic | BindingFlags.Instance);

        public QuicksavedCameraPosMapComponent(Map map) : base(map)
        {
        }

        public void SavePosition()
        {
            savedPosition = new RememberedCameraPos(Find.CurrentMap);
            savedPosition.rootPos = map.rememberedCameraPos.rootPos;
            savedPosition.rootSize = map.rememberedCameraPos.rootSize;
        }

        public void LoadPosition()
        {
            if (savedPosition != null)
            {
                DriverVelocity.SetValue(Find.CameraDriver, new Vector3());
                Find.CameraDriver.SetRootPosAndSize(savedPosition.rootPos, savedPosition.rootSize);
            }
        }

        public void ClearPosition()
        {
            savedPosition = null;
        }
    }
}