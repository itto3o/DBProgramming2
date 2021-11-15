using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ConfigManager
    {
        private static ConfigManager instance_ = new ConfigManager();
        private int idx = 0;
        private bool AutoLoad = false;
        public static ConfigManager GetInstance()
        {
            return instance_;
        }
        
        private ConfigManager()
        {
            //initialization
        }
        public bool HasAutoLoad()
        {
            return AutoLoad;
        }

        public int GetRecentlyUsedListIdx()
        {
            return idx;
        }
    }
}
