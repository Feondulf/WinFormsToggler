namespace Toggler
{
    internal class ToggleFuncs
    {
        public static void Apply(Button button, ToggleState state, string label)
        {
            button.Text = $"{label} ({(state.StateBool ? "On" : "Off")})";
        }

        public static void Apply(CheckBox checkBox, ToggleState state)
        {
            checkBox.Checked = state.StateBool;
        }

        public static void Switch(ToggleState state)
        {
            state.StateBool = !state.StateBool;
        }
    }
}