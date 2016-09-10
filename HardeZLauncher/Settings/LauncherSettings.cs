using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    [Serializable]
    public class LauncherSettings
    {
        private StoragePath laucherWorkDir;
        private StoragePath javaPathDir;
        private StoragePath assetsDir;
        private StoragePath libraryDir;
        private StoragePath minecraftJarDir;
        private StoragePath nativeDir;
        private bool chengeDefaultSetings = false;

        public StoragePath LaucherWorkDir
        {
            get
            {
                return laucherWorkDir;
            }

            set
            {
                laucherWorkDir = value;
                if (!chengeDefaultSetings)
                {
                    replaceDefaultSecSettings();
                }
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
                chengeDefaultSetings = true;
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
                chengeDefaultSetings = true;
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
                chengeDefaultSetings = true;
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
                chengeDefaultSetings = true;
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

        public void setDefaultSettings()
        {
            if (LaucherWorkDir == null)
            {
                LaucherWorkDir = new StoragePath(AppDomain.CurrentDomain.BaseDirectory);
            }
            if (javaPathDir == null)
            {
                javaPathDir = new StoragePath(@"C:\Program Files\Java\");
            }
            
            chengeDefaultSetings = false;
        }

        public void replaceDefaultSecSettings()
        {
            AssetsDir       = new StoragePath(LaucherWorkDir.Path + @"assets");
            LibraryDir      = new StoragePath(LaucherWorkDir.Path + @"lib");
            nativeDir       = new StoragePath(LaucherWorkDir.Path + @"native");
            MinecraftJarDir = new StoragePath(LaucherWorkDir.Path + @"versions\1.7.10");
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
