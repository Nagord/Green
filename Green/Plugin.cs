using PulsarPluginLoader;

namespace Green
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0.0";

        public override string Author => "Dragon";

        public override string LongDescription => "Allows clients to set alert level to green via command";

        public override string Name => "Green";

        public override string HarmonyIdentifier()
        {
            return "Dragon.Green";
        }
    }
}
