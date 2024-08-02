using HarmonyLib;

namespace QuickContinue.Harmony
{
    public class SkipNews
    {
        private static readonly ILogger Logger = new Logger();

        [HarmonyPatch(typeof(XUiC_MainMenu))]
        [HarmonyPatch("Open")]
        public static class XUiCNewsScreenSkip
        {
            public static bool Prefix(XUiC_MainMenu __instance, XUi _xuiInstance)
            {
                Logger.Info("[Quick_Continue] Starting news skipping.");

                _xuiInstance.playerUI.windowManager.Open(XUiC_MainMenu.ID, true);

                Logger.Info("[Quick_Continue] News screen has been skipped.");

                return false;
            }
        }
    }
}