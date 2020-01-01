using System.Collections.Generic;
using RimWorld;
using UnityEngine;
using Verse;
using Verse.Sound;

// based on: https://github.com/UnlimitedHugs/RimworldDefensivePositions/blob/4026cc2f19c918294e8bcca3ebaba6dae4028888/Source/DefensivePositionsManager.cs
namespace CameraQuicksave
{
    public static class HotkeyHandler
    {
        public static void OnGUI() {
            if (Current.ProgramState != ProgramState.Playing || Event.current.type != EventType.KeyDown || Event.current.keyCode == KeyCode.None) return;
            if (Resources.Hotkeys.CQSavePosition.JustPressed) {
                Find.CurrentMap?.GetComponent<QuicksavedCameraPosMapComponent>()?.SavePosition();
                Event.current.Use();
            }
            if (Resources.Hotkeys.CQLoadPosition.JustPressed) {
                Find.CurrentMap?.GetComponent<QuicksavedCameraPosMapComponent>()?.LoadPosition();
                Event.current.Use();
            }
        }
    }
}
