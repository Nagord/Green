using PulsarPluginLoader.Chat.Commands;

namespace Green
{
    class AllowGreenCommand : IChatCommand
    {
        public string[] CommandAliases()
        {
            return new string[] { "allowgreen" };
        }

        public string Description()
        {
            return "Allows/Disallows Green command for use.";
        }

        public bool Execute(string arguments, int SenderID)
        {
            Global.CommandEnabled = !Global.CommandEnabled;
            string str = Global.CommandEnabled ? "Enabled" : "Disabled";
            PulsarPluginLoader.Utilities.Messaging.Notification($"Green command {str}");
            PLXMLOptionsIO.Instance.CurrentOptions.SetStringValue("GreenCommandEnabled", Global.CommandEnabled.ToString());
            return false;
        }

        public bool PublicCommand()
        {
            return false;
        }

        public string UsageExample()
        {
            return "/allowgreen";
        }
    }
}
