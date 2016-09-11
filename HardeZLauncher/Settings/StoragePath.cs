using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Launcher
{
    [Serializable]
    public class StoragePath
    {
        String path;

        public StoragePath (String str)
        {
            path = str;
        }

        public String Path
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

        public static int checkPath(String str)
        {
            if (Directory.Exists(str))
            {
                return 2;
            }
            else
            {
                String regexp = @"^([a-zA-Z]:){1,1}(\\[^\t\n\r\f\v<>:" + '"' + @"\/\\|?*]+)+\\?$";
                MatchCollection res = Regex.Matches(str, regexp, RegexOptions.IgnoreCase);
                if (res.Count == 1 && Directory.Exists(str[0].ToString() + ":\\"))
                {
                    return 1;
                }
                return 0;
            }
        }
    }
}
