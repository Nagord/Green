using PulsarModLoader;

namespace Green
{
    public class Mod : PulsarMod
    {
        public Mod()
        {
            if (bool.TryParse(PLXMLOptionsIO.Instance.CurrentOptions.GetStringValue("GreenCommandEnabled"), out bool result))
            {
                Global.CommandEnabled = result;
            }
        }

        public override string Version => "1.1.0";

        public override string Author => "Dragon";

        public override string LongDescription => "Allows clients to set alert level to green via command";

        public override string Name => "Green";

        public override string HarmonyIdentifier()
        {
            return "Dragon.Green";
        }
    }
}
