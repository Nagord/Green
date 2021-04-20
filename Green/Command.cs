using PulsarPluginLoader.Chat.Commands.CommandRouter;

namespace Green
{
    class GreenCommand : PublicCommand
    {
        public override string[] CommandAliases()
        {
            return new string[] { "green" };
        }

        public override string Description()
        {
            return "sets ship alert level to green";
        }

        public override void Execute(string arguments, int SenderID)
        {
            if (Global.CommandEnabled)
            {
                PLEncounterManager.Instance.PlayerShip.AlertLevel = 0;
            }
            else
            {
                PulsarPluginLoader.Utilities.Messaging.Notification("Command disabled by host.", PLServer.Instance.GetPlayerFromPlayerID(SenderID));
            }
        }
    }
}
