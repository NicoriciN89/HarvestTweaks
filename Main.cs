#nullable disable
using MelonLoader;

namespace FasterHarvesting {

    internal sealed class Main : MelonMod {

        public override void OnInitializeMelon() {
            LocalizationManager.Load();
            Settings.Initialize();
            LoggerInstance.Msg($"[HarvestTweaks] v{BuildInfo.ModVersion} loaded.");
        }
    }
}
