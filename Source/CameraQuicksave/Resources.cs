using RimWorld;
using UnityEngine;
using Verse;

namespace CameraQuicksave
{
    /// <summary>
    /// Stores and resolves references to defs and textures used in the code.
    /// </summary>
    public class Resources
    {
        [DefOf]
        public static class Hotkeys {
            public static KeyBindingDef CQSavePosition;
            public static KeyBindingDef CQLoadPosition;
        }
    }
}