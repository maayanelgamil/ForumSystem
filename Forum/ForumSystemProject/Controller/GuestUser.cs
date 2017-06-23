
using System.Collections.Generic;

namespace ForumSystemProject.Controller
{
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