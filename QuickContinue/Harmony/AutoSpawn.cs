using System;
using HarmonyLib;

namespace QuickContinue.Harmony
{
    public class AutoSpawn
    {
#if AUTO_SPAWN
        private static readonly ILogger Logger = new Logger();

        [HarmonyPatch(typeof(XUiC_SpawnSelectionWindow))]
        [HarmonyPatch("RefreshButtons")]
        [HarmonyPatch(new Type[] { })]
        public class QuickContinue_OnOpen
        {
            public static void Postfix(XUiC_SpawnSelectionWindow __instance)
            {
                Logger.Info("[Quick_Continue] Running if entering game");
                if (!__instance.bEnteringGame) return;

                Logger.Info("[Quick_Continue] Pressing spawn button.");
                __instance.SpawnButtonPressed(__instance.option1Method, __instance.option1Position);
            }
        }
#endif
    }
}