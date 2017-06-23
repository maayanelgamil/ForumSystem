using System;
using System.Collections;

namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class UserAccount
    {

        GroupMessage sends;
        Complaint complains;
        SubForumManager subManage;
        FriendGroup friendIn;
        UserAccount followedBy;
        Message post;
        UserAccount follows;
        public Forum memeberOf;
        GuestUser members;
        public string UserName;
        public string Password;
        private bool Active;

        /**
         * 
         * @param nsme
         * @param password
         */
        public UserAccount(string nsme, string password, Forum forum)
        {
            UserName = nsme;
            Password = password;
            memeberOf = forum;
        }

        /**
         * 
         * @param f
         * @param g
         */
        public void associateWithForumAndGuest(int f, int g)
        {
            // TODO - implement UserAccount.associateWithForumAndGuest
            throw new NotImplementedException();
        }

        public void getFriendsGroups()
        {
            // TODO - implement UserAccount.getFriendsGroups
            throw new NotImplementedException();
        }

    }
}