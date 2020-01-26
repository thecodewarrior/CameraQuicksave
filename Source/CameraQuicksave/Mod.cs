using Harmony;
using Verse;

namespace CameraQuicksave
{
    [StaticConstructorOnStartup]
    public class Mod
    {
        public const string Id = "CameraQuicksave";
        public const string Name = "Camera Quicksave";
        public const string Version = "1.1";
            
        static Mod()
        {
            HarmonyInstance.Create(Id).PatchAll();
        }
    }
}