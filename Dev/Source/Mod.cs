using HarmonyLib;
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

            Harmony harmony = new Harmony("the_codewarrior.rimworld.Camera_Quicksave.main");

            harmony.PatchAll();
        }
    }
}
