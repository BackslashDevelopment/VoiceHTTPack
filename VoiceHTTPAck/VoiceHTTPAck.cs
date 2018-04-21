using System;
using System.Text;

namespace VAPlugin
{
    public class VoiceHTTPAck
    {
        // Displayed in dropdowns and log files.
        public static string VA_DisplayName()
        {
            return "VoiceHTTPAck";
        }

        // Extended display information. Probably name + description + copyright year.
        public static string VA_DisplayInfo()
        {
            return "VoiceHTTPAck";
        }

        // Used by VoiceAttack to identify this plugin.
        public static Guid VA_Id()
        {
            return new Guid("{ae0756cb-ec41-4021-848a-a7a3f1e1a8a5}");
        }

        // Called when a "stop all commands" action is called.
        public static void VA_StopCommand()
        {
        }

        // Called asynchronously once on VoiceAttack load.
        public static void VA_Init1(dynamic vaProxy)
        {
        }

        // Called when VoiceAttack is shutting down.
        public static void VA_Exit1(dynamic vaProxy)
        {
        }

        // Called when a 'Execute External Plugin Function' action is called. Do all your work in this function.
        public static void VA_Invoke1(dynamic vaProxy)
        {
        }
    }
}
