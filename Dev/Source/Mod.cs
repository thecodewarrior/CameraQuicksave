using Harmony;
using Verse;

namespace CameraQuicksave
{
    public class Mod : Verse.Mod
    {
        public const string Id = "CameraQuicksave";

        public Mod(ModContentPack content) : base(content)
        {
#if DEBUG
            HarmonyInstance.DEBUG = true;
#endif

            HarmonyInstance harmony = HarmonyInstance.Create("the_codewarrior.rimworld.Camera_Quicksave.main");

            harmony.PatchAll();
        }
    }
}