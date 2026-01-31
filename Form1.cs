namespace Toggler
{
    public partial class Win : Form
    {
        private ToggleState Button1Togg = new();
        private ToggleState Button2Togg = new();
        private ToggleState CheckBox1Togg = new();
        private ToggleState CheckBox2Togg = new();

        public Win()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryFuncs.Save(new()
            {
                ["Toggle1"] = Button1Togg,
                ["Toggle2"] = Button2Togg,
                ["Check1"] = CheckBox1Togg,
                ["Check2"] = CheckBox2Togg
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryFuncs.Load(new()
            {
                ["Toggle1"] = Button1Togg,
                ["Toggle2"] = Button2Togg,
                ["Check1"] = CheckBox1Togg,
                ["Check2"] = CheckBox2Togg
            });
            UpdateUI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleFuncs.Switch(Button1Togg);
            UpdateUI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToggleFuncs.Switch(Button2Togg);
            UpdateUI();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            ToggleFuncs.Switch(CheckBox1Togg);
            UpdateUI();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            ToggleFuncs.Switch(CheckBox2Togg);
            UpdateUI();
        }

        private void UpdateUI()
        {
            ToggleFuncs.Apply(button3, Button1Togg, "Toggle 1");
            ToggleFuncs.Apply(button4, Button2Togg, "Toggle 2");
            ToggleFuncs.Apply(checkBox1, CheckBox1Togg);
            ToggleFuncs.Apply(checkBox2, CheckBox2Togg);
        }
    }
}