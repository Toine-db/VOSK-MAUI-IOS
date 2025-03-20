using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingTestApp.Platforms.iOS
{
    public class TestClass
    {
        public void TestMethod()
        {
            VoskBinding.Vosk.SetLogLevel(1); // not found
            Vosk.SetLogLevel(1); // not found
            //Vosk.vosk_set_log_level(1);
            //VoskBinding.Vosk.vosk_set_log_level(1);
        }
    }
}
