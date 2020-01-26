using RimWorld;
using Verse;
using Harmony;
using UnityEngine;

namespace CameraQuicksave.Patch
{
    [HarmonyPatch(typeof(PlaySettings), "DoPlaySettingsGlobalControls")]
    // ReSharper disable once InconsistentNaming
    internal static class RimWorld_PlaySettings_DoPlaySettingsGlobalControls
    {
        private static void Postfix(WidgetRow row, bool worldView)
        {
            if (worldView || (row == null)) return;

            var component = Find.CurrentMap?.GetComponent<QuicksavedCameraPosMapComponent>();
            if (component == null) return;

            var activated = component.savedPosition != null;
            var wasActivated = activated;
            
            var langKey = Mod.Id + (activated ? ".Load" : ".Save");
            row.ToggleableIcon(ref activated, Textures.Icon, langKey.Translate(), SoundDefOf.Mouseover_ButtonToggle);

            if (activated != wasActivated)
            {
                if (Input.GetMouseButtonUp(1))
                {
                    component.ClearPosition();
                }
                else if (activated)
                {
                    component.SavePosition();
                }
                else
                {
                    component.LoadPosition();
                    component.ClearPosition();
                }
            }
        }
    }
}
