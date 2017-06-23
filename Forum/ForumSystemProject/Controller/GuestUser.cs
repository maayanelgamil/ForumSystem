
using System.Collections.Generic;
using System;

namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class GuestUser
    {

        List<UserAccount> userAccount;
        ForumSystem _fs;
        List<Forum> forums;
        public GuestUser(ForumSystem system)
        {
            _fs = system;
        }
    }
}