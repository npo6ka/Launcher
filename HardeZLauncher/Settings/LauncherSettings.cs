using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Settings
{
    class LauncherSettings
    {
        private StoragePath laucherWorkDir;
        private StoragePath javaPathDir;
        private StoragePath assetsDir;
        private StoragePath libraryDir;
        private StoragePath minecraftJarDir;
        private StoragePath nativeDir;

        public StoragePath LaucherWorkDir
        {
            get
            {
                return laucherWorkDir;
            }

            set
            {
                laucherWorkDir = value;
            }
        }

        public StoragePath JavaPathDir
        {
            get
            {
                return javaPathDir;
            }

            set
            {
                javaPathDir = value;
            }
        }

        public StoragePath AssetsDir
        {
            get
            {
                return assetsDir;
            }

            set
            {
                assetsDir = value;
            }
        }

        public StoragePath LibraryDir
        {
            get
            {
                return libraryDir;
            }

            set
            {
                libraryDir = value;
            }
        }

        public StoragePath MinecraftJarDir
        {
            get
            {
                return minecraftJarDir;
            }

            set
            {
                minecraftJarDir = value;
            }
        }

        public StoragePath NativeDir
        {
            get
            {
                return nativeDir;
            }

            set
            {
                nativeDir = value;
            }
        }

        public bool isValid()
        {
            return LaucherWorkDir.isValid() &
                JavaPathDir.isValid() &
                AssetsDir.isValid() &
                LibraryDir.isValid() &
                MinecraftJarDir.isValid() &
                NativeDir.isValid();
        }


        /*laucherDir = @"C:\Games\HardeZLauncher";
        gameDir = @"C:\Games\HardeZLauncher\modpacks";
        sapportDir = @"C:\Games\HardeZLauncher\lib";

        assetsDir = @"\assets";
        libDir = @"\lib";
        nativeDir = @"\native";
        mineLaunchDir = @"\versions\1.7.10";

        javaPath = @"C:\Program Files\Java\jre1.8.0_91\bin";

        Xmx = 4096;
        Xms = 512;*/



    }
}
