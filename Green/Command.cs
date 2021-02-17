using PulsarPluginLoader.Chat.Commands;

namespace Green
{
    class GreenCommand : IChatCommand
    {
        public string[] CommandAliases()
        {
            return new string[] { "green" };
        }

        public string Description()
        {
            return "sets ship alert level to green";
        }

        public bool Execute(string arguments, int SenderID)
        {
            if (Global.CommandEnabled)
            {
                PLEncounterManager.Instance.PlayerShip.AlertLevel = 0;
            }
            else
            {
                PulsarPluginLoader.Utilities.Messaging.Notification("Command disabled by host.", PLServer.Instance.GetPlayerFromPlayerID(SenderID));
            }
            return true;
        }

        public bool PublicCommand()
        {
            return true;
        }

        public string UsageExample()
        {
            return "!green";
        }
    }
}
