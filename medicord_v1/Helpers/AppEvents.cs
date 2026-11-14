
namespace medicord_v1.Helpers
{
    public static class AppEvents
    {
        public static event Action? ProfileChanged;  
        public static event Action? DataChanged; 

        public static void RaiseProfileChanged() { AvatarCache.Clear(); ProfileChanged?.Invoke(); }
        public static void RaiseDataChanged() => DataChanged?.Invoke();
    }
}