#nullable disable
using MelonLoader;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("HarvestTweaks")]
[assembly: AssemblyProduct("HarvestTweaks")]
[assembly: AssemblyCopyright("MIT License")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion(BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(FasterHarvesting.Main), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.ModAuthor)]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonColor(100, 220, 100, 255)]

internal static class BuildInfo {
    internal const string ModName    = "Harvest Tweaks";
    internal const string ModAuthor  = "NnicolaeN";
    internal const string ModVersion = "1.0.1";
}
