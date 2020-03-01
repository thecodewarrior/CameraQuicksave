using Verse;
using HarmonyLib;

namespace CameraQuicksave
{
    public class Mod : Verse.Mod
    {
        public const string Id = "CameraQuicksave";

        public Mod(ModContentPack content) : base(content)
        {
            new Harmony("the_codewarrior.rimworld.CameraQuicksave.main").PatchAll();
        }
    }
}
