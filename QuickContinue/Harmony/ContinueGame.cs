using HarmonyLib;

namespace QuickContinue.Harmony
{
    public class ContinueGame
    {
        private static readonly ILogger Logger = new Logger();

        [HarmonyPatch(typeof(XUiC_MainMenu))]
        [HarmonyPatch("OnOpen")]
        public static class XUiCMainMenuContinue
        {
            public static void Postfix(XUiC_MainMenu __instance)
            {
                Logger.Info("[Quick_Continue] Pressing continue game button.");

                if (__instance.btnContinueGame != null && __instance.btnContinueGame.IsVisible &&
                    __instance.btnContinueGame.Enabled)
                {
                    __instance.btnContinueGame_OnPressed(__instance, -1);
                    Logger.Info("[Quick_Continue] Successfully triggered btnContinueGame_OnPressed.");
                }
                else
                {
                    Logger.Info("[Quick_Continue] Continue button is not available.");
                }
            }
        }

        [HarmonyPatch(typeof(XUiC_NewContinueGame))]
        [HarmonyPatch("OnOpen")]
        public static class XUiCNewContinueGameStart
        {
            public static void Postfix(XUiC_NewContinueGame __instance)
            {
                Logger.Info("[Quick_Continue] Pressing start button.");

                if (__instance.btnStart != null && __instance.btnStart.IsVisible &&
                    __instance.btnStart.Enabled)
                {
                    __instance.BtnStart_OnPressed(__instance, -1);
                    Logger.Info("[Quick_Continue] Successfully triggered BtnStart_OnPressed.");
                }
                else
                {
                    Logger.Info("[Quick_Continue] Start button is not available.");
                }
            }
        }
    }
}