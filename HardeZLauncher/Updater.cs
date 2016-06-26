using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Laucher
{
    

    class Updater
    {
        private enum exc: int
        {
            success = 1,
            argumentNullExc = -1,
            webExc = -2,
            notSupportedExc = -3
        }

        private static String urlUpdateLaucher = "http://hardez.ru/files/launch/";
        private static String fileNameLaunch = "versions.stg";
        private static String urlUpdateModpack = "http://hardez.ru/files/packs/";
        private static String fileNameModpack = "packs.stg";


        private static int getUpdate(String destFolder, String urlUpdate, String fileName)
        {
            try
            {
                WebClient webServer = new WebClient();
                webServer.DownloadFile(urlUpdate + fileName, destFolder + fileName);
                return (int)exc.success;
            }
            catch (ArgumentNullException ex)
            {
                return (int)exc.argumentNullExc;
            }
            catch (WebException ex)
            {
                return (int)exc.webExc;
            }
            catch (NotSupportedException ex)
            {
                return (int)exc.notSupportedExc;
            }
        }

        public static int getUpdateLauncher(String destFolder)
        {
            return getUpdate(destFolder, urlUpdateLaucher, fileNameLaunch);
        }

        public static int getUpdateModpack(String destFolder)
        {
            return getUpdate(destFolder, urlUpdateModpack, fileNameModpack);
        }

        public static String getInfoAboutException(int NumExc)
        {
            switch (NumExc)
            {
                case ((int)exc.argumentNullExc):
                    return "Address or filename = null";
                case ((int)exc.webExc):
                    return "File not found or internet error";
                case ((int)exc.notSupportedExc):
                    return "Call multithread is not supported";
                default:
                    return "Unknown Exceptions";

            }
        }
    }
}
