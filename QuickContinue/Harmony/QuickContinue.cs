namespace QuickContinue.Harmony
{
    public class QuickContinue
    {
        public class Init : IModApi
        {
            private readonly ILogger _logger = new Logger();

            public void InitMod(Mod modInstance)
            {
                var type = GetType();
                var id = type.ToString();
                _logger.Info("Loading Patch: " + id);
                var harmony = new HarmonyLib.Harmony(id);
                harmony.PatchAll();
            }
        }
    }
}