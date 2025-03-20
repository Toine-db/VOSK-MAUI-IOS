using System.Runtime.InteropServices;
using System;
using Foundation;
using ObjCRuntime;
using StoreKit;

namespace VoskBinding
{
    public static class Vosk
    {
        // vosk_api.h method: (\VoskApiTest_0.3.38\VoskApiTest\Vosk\vosk_api.h)
        // void vosk_set_log_level(int log_level);

        [Export("vosk_set_log_level")]
        public static extern void SetLogLevel(int log_level);

        //[DllImport("__Internal")]
        //public static extern void vosk_set_log_level(int log_level);
    }

    public class Dummy
    {
        public static void DummyMethod()
        {
            Vosk.SetLogLevel(1);
            //Vosk.vosk_set_log_level(1);
        }
    }
}
