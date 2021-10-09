using PulsarModLoader.Chat.Commands.CommandRouter;

namespace Green
{
    class AllowGreenCommand : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[] { "allowgreen" };
        }

        public override string Description()
        {
            return "Allows/Disallows Green command for use.";
        }

        public override void Execute(string arguments)
        {
            Global.CommandEnabled = !Global.CommandEnabled;
            string str = Global.CommandEnabled ? "Enabled" : "Disabled";
            PulsarModLoader.Utilities.Messaging.Notification($"Green command {str}");
            PLXMLOptionsIO.Instance.CurrentOptions.SetStringValue("GreenCommandEnabled", Global.CommandEnabled.ToString());
        }
    }
}
