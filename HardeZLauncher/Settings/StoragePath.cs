using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Settings
{
    [Serializable]
    class StoragePath
    {
        String path;
        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        public bool isValid()
        {
            return Directory.Exists(path);
        }

        public static bool checkPath(String str)
        {
            return Directory.Exists(str);
        }
    }
}
