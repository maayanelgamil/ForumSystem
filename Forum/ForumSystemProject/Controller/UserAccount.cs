using System;
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
        Forum memeberOf;
        GuestUser members;
        private string UserName;
        private string Password;
        private bool Active;

        /**
         * 
         * @param nsme
         * @param password
         */
        public void createUserAccount(int nsme, int password)
        {
            // TODO - implement UserAccount.createUserAccount
            throw new NotImplementedException();
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