#nullable disable
using ModSettings;

namespace FasterHarvesting {

    internal class HarvestSettings : JsonModSettings {

        [Section("FH_SEC_BRANCHES", Localize = true)]

        [Name("FH_BRANCH", Localize = true)]
        [Description("FH_DESC_BRANCH", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float branchTime = 0.17f;

        [Section("FH_SEC_LIMBS", Localize = true)]

        [Name("FH_LIMB_A", Localize = true)]
        [Description("FH_DESC_LIMBS", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float limbATime = 1.5f;

        [Name("FH_LIMB_B", Localize = true)]
        [Description("FH_DESC_LIMBS", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float limbBTime = 1.5f;

        [Section("FH_SEC_BIG_LIMBS", Localize = true)]

        [Name("FH_LIMB_A_BIG", Localize = true)]
        [Description("FH_DESC_LIMBS", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float limbABigTime = 1.5f;

        [Name("FH_LIMB_B_BIG", Localize = true)]
        [Description("FH_DESC_LIMBS", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float limbBBigTime = 1.5f;
    }

    internal static class Settings {
        internal static HarvestSettings Instance;

        internal static void Initialize() {
            Instance = new HarvestSettings();
            Instance.AddToModSettings("Harvest Tweaks");
        }
    }
}
