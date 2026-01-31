using Microsoft.Win32;

namespace Toggler
{
    internal class RegistryFuncs
    {
        private const string AppKey = @"SOFTWARE\Toggler";

        public static void Load(Dictionary<string, ToggleState> toggleStates)
        {
            using var key = Registry.CurrentUser.OpenSubKey(AppKey);
            if (key == null) return;
            foreach (var entry in toggleStates)
            {
                var val = key.GetValue(entry.Key);
                if (val is int i) { entry.Value.StateBool = Convert.ToBoolean(i); }
            }
        }

        public static void Save(Dictionary<string, ToggleState> toggleStates)
        {
            using var key = Registry.CurrentUser.CreateSubKey(AppKey);
            foreach (var entry in toggleStates)
            {
                key.SetValue(entry.Key, entry.Value.StateBool, RegistryValueKind.DWord);
            }
        }
    }
}