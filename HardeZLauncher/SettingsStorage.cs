using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace Laucher
{
    [Serializable()]
    class SettingsStorage
    {
        private String laucherDir;
        private String gameDir;
        private String sapportDir;

        public String assetsDir;
        private String libDir;
        private String nativeDir;
        private String mineLaunchDir;

        private String javaPath;

        private int Xmx = 4096;
        private int Xms = 512;

        public Settings ()
        {
            laucherDir = @"C:\Games\HardeZLauncher";
            gameDir = @"C:\Games\HardeZLauncher\modpacks";
            sapportDir = @"C:\Games\HardeZLauncher\lib";

            assetsDir = @"\assets";
            libDir = @"\lib";
            nativeDir = @"\native";
            mineLaunchDir = @"\versions\1.7.10";

            javaPath = @"C:\Program Files\Java\jre1.8.0_91\bin";

            Xmx = 4096;
            Xms = 512;
        }


    }


}
