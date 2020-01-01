using System;
using Harmony;
using Verse;

// based on: https://github.com/UnlimitedHugs/RimworldHugsLib/blob/e965062118f2c93a80469acc0dfe82d4d3171b9e/Source/Patches/UIRoot_Patch.cs
namespace CameraQuicksave.Patch
{
	/// <summary>
	/// Hooks into the flow of the vanilla MonoBehavior.OnGUI()
	/// This allows to take advantage of automatic UI scaling and prevents GUI updates during a loading screen.
	/// </summary>
	[HarmonyPatch(typeof(UIRoot))]
	[HarmonyPatch("UIRootOnGUI")]
	[HarmonyPatch(new Type[0])]
	internal static class UIRoot_Patch {
		[HarmonyPostfix]
		private static void OnGUIHook() {
			HotkeyHandler.OnGUI();
		}
	}
}
