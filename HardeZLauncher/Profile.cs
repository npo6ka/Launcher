using System;

namespace Laucher
{
    class Profile
    {
        private String username;
        static private String clientToken;
        private String accessToken;
        private String id;
        private String name;
        private Boolean legacy;

        public Profile()
        {
            this.username = "user" + (new Random()).Next(1000);
            generateClientToken();
            this.accessToken = null;
            this.id = null;
            this.name = null;
            this.legacy = false;
        }

        public String getUsername() 
        {
            return this.username;
        }
        public static String getClientToken()
        {
            if (clientToken != null)
                 return clientToken;
            else return generateClientToken();          
        }
        public String getAccessToken()
        {
            return this.accessToken;
        }
        public String getId()
        {
            return this.id;
        }
        public String getName()
        {
            return this.name;
        }
        public Boolean getLegacy()
        {
            return this.legacy;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }
        private void setClientToken(String Token)
        {
            clientToken = Token;
        }
        public void setAccessToken(String accessToken)
        {
            this.accessToken = accessToken;
        }
        public void setId(String id)
        {
            this.id = id;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setLegacy(Boolean legacy)
        {
            this.legacy = legacy;
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
                clientToken = str.ToLower(); //all random token and this incorrect
            }
            return clientToken;
        }
        //public login

    }
}
