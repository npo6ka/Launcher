using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laucher
{
    public class Account
    {
        enum errorInfo
        {
            notError = 1,
            accTok= -1,
            cliTok= -2,
            identifare= -3,
            username= -4,
            userEmail = -5,
        }

        private String accessToken;
        static private String clientToken;
        private String id;
        private String name;
        private String email;

        public Account ()
        {
            this.accessToken = null;
            generateClientToken();
            this.id = null;
            this.name = null;
            this.email = null;
        }

        public Account(String accessToken, String id, String name, String email)
        {
            this.accessToken = accessToken;
            generateClientToken();
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public static string ClientToken
        {
            get
            {
                return clientToken;
            }

            set
            {
                clientToken = value;
            }
        }
        public string AccessToken
        {
            get
            {
                return accessToken;
            }

            set
            {
                accessToken = value;
            }
        }

        static private String generateClientToken()
        {
            if (clientToken == null)
            {
                //example: 6d03ca0e-bf03-4a12-867c-7c1a6a4086b9
                Random rnd = new Random();
                String str = "";

                for (int i = 0; i < 8; ++i)
                {
                    str += (rnd.Next(1000, 65535)).ToString("X");
                }
                clientToken = str.ToLower(); //all random token and this is incorrect
            }
            return clientToken;
        }

        public int isValid()
        {
            if (accessToken == null)
            {
                return (int)errorInfo.accTok;
            }
            else if (clientToken == null)
            {
                return (int)errorInfo.cliTok;
            }
            else if (id == null)
            {
                return (int)errorInfo.identifare;
            }
            else if (name == null)
            {
                return (int)errorInfo.username;
            }
            else if (email == null)
            {
                return (int)errorInfo.userEmail;
            }
            else return (int)errorInfo.notError;
        }

        public String getInfoAboutError(int error)
        {
            switch (error)
            {
                case (int)errorInfo.notError:
                    return "Errors not found";
                case (int)errorInfo.accTok:
                    return "Incorrect AccessToken";
                case (int)errorInfo.cliTok:
                    return "Incorrect ClientToken";
                case (int)errorInfo.identifare:
                    return "Incorrect Id";
                case (int)errorInfo.username:
                    return "Incorrect name";
                case (int)errorInfo.userEmail:
                    return "Incorrect email";
                default:
                    return "Unknown code error";
            }
        }

        public bool equals(Account acnt)
        {
            if (acnt.AccessToken == this.AccessToken &&
                acnt.Id == this.Id &&
                acnt.Name == this.Name &&
                acnt.Email == this.Email)
            {
                return true;
            }
            else return false;
        }
    }
}
