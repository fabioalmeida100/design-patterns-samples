using Bridge.Platforms.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Live
    {
        protected IPlatform _platform;

        public Live(IPlatform platform)
        {
            _platform = platform;
        }

        public void Broadcast()
        {
            _platform.ConfigureRMTP();
        }
        public void Result()
        {
            Console.WriteLine("Stream is online.\n");
        }
    }
}
