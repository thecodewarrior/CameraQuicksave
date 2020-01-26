using UnityEngine;
using Verse;

namespace CameraQuicksave
{
    [StaticConstructorOnStartup]
    internal static class Textures
    {
        public static readonly Texture2D Icon = ContentFinder<Texture2D>.Get("CameraQuicksave/Icon");
    }
}
