using HarmonyLib;

namespace Green
{
    class Global
    {
        public static bool CommandEnabled = true;
    }
    [HarmonyPatch(typeof(PLServer), "Start")]
    class loadsettings
    {
        static void Postfix()
        {
            if(bool.TryParse(PLXMLOptionsIO.Instance.CurrentOptions.GetStringValue("GreenCommandEnabled"), out bool result))
            {
                Global.CommandEnabled = result;
            }
        }
    }
}
