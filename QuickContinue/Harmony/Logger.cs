namespace QuickContinue.Harmony
{
    public class Logger : ILogger
    {
        public void Info(string message)
        {
#if DEBUG
            Log.Out(message);
#endif
        }
    }
    
    public interface ILogger
    {
        void Info(string message);
    }
}