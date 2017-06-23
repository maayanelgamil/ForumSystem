using System;

namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class GroupMessage
    {

        FriendGroup recipients;
        UserAccount sentBy;
        private string Title;

        /**
         * 
         * @param title
         * @param data
         */
        public void createGroupMessage(int title, int data)
        {
            // TODO - implement GroupMessage.createGroupMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param fg
         */
        public void associatewithFriendGroup(int fg)
        {
            // TODO - implement GroupMessage.associatewithFriendGroup
            throw new NotImplementedException();
        }

        /**
         * 
         * @param userName
         */
        public void associateWithUserA(int userName)
        {
            // TODO - implement GroupMessage.associateWithUserA
            throw new NotImplementedException();
        }

    }
}