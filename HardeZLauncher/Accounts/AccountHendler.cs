using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class AccountHendler
    {
        static private int checkRequest(String[] str)
        {
            switch (str[0])
            {
                case "OK":
                    return 1;
                case "No Content":
                    return 0;
                case "NOT":
                    switch (str[1])
                    {
                        case "TimeError":
                            return -2;
                        case "unknown":
                            return -3;
                        default:
                            return -1;
                    }
                default:
                    return -5;
            }
        }

        static private String getValue(String response, String value)
        {
            int first = response.IndexOf(value) + value.Length + 1; // get position after the "value"
            first = response.IndexOf("\"", first) + 1; // find next "
            return response.Substring(first, response.IndexOf("\"", first) - first);
        }

        static public int authMojang(Account acnt, String pass)
        {
            String[] str = MojangRequests.authenticate(Account.ClientToken, acnt.Email, pass);
            //String[] str = { "OK", "{\"accessToken\":\"f237b93d2aef459585e7ca0682f0e1ce\",\"clientToken\":\"952984cf356392874ae7d4dfc84f42c\",\"selectedProfile\":{\"id\":\"a73a7cfdc77a47b4967972b259db9b08\",\"name\":\"Qwerwer\"},\"availableProfiles\":[{\"id\":\"a73a7cfdc77a47b4967972b259db9b08\",\"name\":\"Qwerwer\"}]}" };

            int result = checkRequest(str);
            if (result > 0)
            {
                acnt.AccessToken = getValue(str[1], "accessToken");
                acnt.Id = getValue(str[1], "id");
                acnt.Name = getValue(str[1], "name");
            }
            return result;
        }

        static public int refreshMojang(Account acnt)
        {
            String[] str = MojangRequests.refresh(acnt.AccessToken ,Account.ClientToken, acnt.Id, acnt.Name);
            //String[] str = { "OK", "{\"accessToken\":\"5c1da662b2484599a8f5903ea547c119\",\"clientToken\":\"ca5d8019489947a7cc2874cd422ddbc\",\"selectedProfile\":{\"id\":\"a73a7cfdc77a47b4967972b259db9b08\",\"name\":\"Qwerwer\"}}" };
            int result = checkRequest(str);

            if (result > 0)
            {
                acnt.AccessToken = getValue(str[1], "accessToken");
                acnt.Id = getValue(str[1], "id");
                acnt.Name = getValue(str[1], "name");
            }
            return result;
        }

        static public int validateMojang(Account acnt)
        {
            String[] str = MojangRequests.validate(acnt.AccessToken, Account.ClientToken);
            //String[] str = { "No Content", "" };
            return checkRequest(str);
        }

        static public int signoutMojang(Account acnt, String pass)
        {
            String[] str = MojangRequests.signout(acnt.Email, pass);
            //String[] str = { "No Content", "" };
            return checkRequest(str);
        }

        static public int invalidateMojang(Account acnt)
        {
            String[] str = MojangRequests.invalidate(acnt.AccessToken, Account.ClientToken);
            //String[] str = { "No Content", "" };
            return checkRequest(str);
        }
    }
}
