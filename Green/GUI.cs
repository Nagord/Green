using static UnityEngine.GUILayout;

namespace Green
{
    class GUI : PulsarModLoader.CustomGUI.ModSettingsMenu
    {
        public override void Draw()
        {
            
            string str = (Global.CommandEnabled ? "Disable" : "Enable") + " Green";
            if(Button(str))
            {
                Global.CommandEnabled = !Global.CommandEnabled;
                PLXMLOptionsIO.Instance.CurrentOptions.SetStringValue("GreenCommandEnabled", Global.CommandEnabled.ToString());
            }
        }

        public override string Name()
        {
            return "Allow/Disallow Green";
        }
    }
}
