using System;
using System.Text;
using System.Net;
using System.IO;

namespace Laucher
{
    /* more information on http://wiki.vg/Authentication*/
    class MojangRequests
    {
        static String URL_authserver = "https://authserver.mojang.com";
        static String sub_URL_Auth = "/authenticate";
        static String sub_URL_Refresh = "/refresh";
        static String sub_URL_Validate = "/validate";
        static String sub_URL_Signout = "/signout";
        static String sub_URL_Invalidate = "/invalidate";
        static int delay = 5;
        static long lastConnect;

        private static void setTimeConnections()
        {
            lastConnect = DateTime.Now.ToFileTimeUtc();
        }
        private static bool checkTimeConnections()
        {
            return ((lastConnect + delay * 10000000) < DateTime.Now.ToFileTimeUtc());
        }

        private static String[] checkRequest(String postData, String subURL)
        {
            if (checkTimeConnections())
            {
                setTimeConnections();
                return request(postData, subURL);
            }
            else return new String[2] { "NOT", "TimeError" };
        }
        private static String[] request(String postData, String subURL)
        {
            String[] status = new String[2] { "NOT", "unknown" };

            WebRequest request = WebRequest.Create(URL_authserver + subURL);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                status[0] = ((HttpWebResponse)response).StatusDescription;

                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                status[1] = responseFromServer;

                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                status[1] = ex.Message;
            }
            return status;
        }

        /*
         * Authenticates a user using their password.
        */
        public static String[] authenticate(String clientToken, String email, String password)
        {
            string postData = "{ \"agent\": { \"name\": \"Minecraft\", \"version\": 1 }, \"username\": \"" +
                email +
                "\", \"password\": \"" +
                password +
                "\", \"clientToken\": \"" +
                clientToken +
                "\" }";
            return checkRequest(postData, sub_URL_Auth);
        }

        /* 
         * Refreshes a valid accessToken. It can be used to keep a user logged in between gaming sessions and is preferred over storing the user's password in a file.
        */
        public static String[] refresh(String accessToken, String clientToken, String id, String name)
        {
            string postData = "{ \"accessToken\": \"" +
                accessToken +
                "\", \"clientToken\": \"" +
                clientToken +
                "\" }";
            return checkRequest(postData, sub_URL_Refresh);
        }

        /*
         * Checks if an accessToken is usable for authentication with a Minecraft server.
        */
        public static String[] validate(String accessToken, String clientToken)
        {
            string postData = "{ \"accessToken\": \"" +
                accessToken +
                "\", \"clientToken\": \"" +
                clientToken +
                "\" }";
            return checkRequest(postData, sub_URL_Validate);
        }

        /*
         * Checks if an accessToken is usable for authentication with a Minecraft server.
        */
        public static String[] signout(String email, String password)
        {
            string postData = "{ \"username\": \"" +
                email +
                "\", \"password\": \"" +
                password +
                "\" }";
            return checkRequest(postData, sub_URL_Signout);
        }

        /*
         * Invalidates accessTokens using a client/access token pair.
        */
        public static String[] invalidate(String accessToken, String clientToken)
        {
            string postData = "{ \"accessToken\": \"" +
                accessToken +
                "\", \"clientToken\": \"" +
                clientToken +
                "\" }";
            return checkRequest(postData, sub_URL_Invalidate);
        }
    }
}
