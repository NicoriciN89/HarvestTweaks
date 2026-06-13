#nullable disable
using HarmonyLib;
using Il2Cpp;

namespace FasterHarvesting.Patches {

    [HarmonyPatch(typeof(Panel_BreakDown), nameof(Panel_BreakDown.Enable))]
    internal static class Panel_BreakDown_Enable_Patch {

        private static void Postfix(Panel_BreakDown __instance, bool enable) {
            if (!enable || __instance.m_BreakDown == null) return;

            switch (__instance.m_BreakDown.gameObject.name) {
                case "INTERACTIVE_BranchA_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.branchTime;
                    break;
                case "INTERACTIVE_LimbA_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.limbATime;
                    break;
                case "INTERACTIVE_LimbB_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.limbBTime;
                    break;
                case "INTERACTIVE_LimbA_Big_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.limbABigTime;
                    break;
                case "INTERACTIVE_LimbB_Big_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.limbBBigTime;
                    break;
            }
        }
    }
}
