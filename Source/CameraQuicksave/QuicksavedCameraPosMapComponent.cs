using System.Collections.Generic;
using Verse;

namespace CameraQuicksave
{
    public class QuicksavedCameraPosMapComponent : MapComponent
    {
        public RememberedCameraPos savedPosition;

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
            if(savedPosition != null)
                Find.CameraDriver.SetRootPosAndSize(savedPosition.rootPos, savedPosition.rootSize);
            savedPosition = null;
        }
    }
}