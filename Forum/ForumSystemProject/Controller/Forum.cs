
using System;
using System.Collections;
using System.Collections.Generic;

namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class Forum
    {

        ActionLogger isDocumented;
        List<FriendGroup> friendsGroup;
        public Dictionary<int, SubForum> subForumDict;
        Policy definedBy;
        List<UserAccount> userAccount;
        List<Manager> managedBy;
        private string _subject;
        public int forumID;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public Forum(string subject, int id)
        {
            subForumDict = new Dictionary<int, SubForum>();
            _subject = subject;
            forumID = id;
        }

        /**
         * 
         * @param subForumId
         */
        public SubForum findSubForum(int subForumId)
        {
            // TODO - implement Forum.findSubForum
            if (subForumDict.ContainsKey(subForumId))
                return null;
            return subForumDict[subForumId];
        }

        /**
         * 
         * @param userName
         */
        public void findUserAccount(int userName)
        {
            // TODO - implement Forum.findUserAccount
            throw new NotImplementedException();
        }

        public List<SubForum> getSubforums()
        {
            List<SubForum> subForums = new List<SubForum>();
            subForums.AddRange(subForumDict.Values);
            return subForums;
        }

        /**
         * 
         * @param choosenRole
         */
        public void getManagerList(int choosenRole)
        {
            // TODO - implement Forum.getManagerList
            throw new NotImplementedException();
        }

        /**
         * 
         * @param choosenRole
         * @param subMngrId
         */
        public void findManagerComplained(int choosenRole, int subMngrId)
        {
            // TODO - implement Forum.findManagerComplained
            throw new NotImplementedException();
        }

        public void getManagerList()
        {
            // TODO - implement Forum.getManagerList
            throw new NotImplementedException();
        }

        /**
         * 
         * @param U
         */
        public void checkPolicy(int U)
        {
            // TODO - implement Forum.checkPolicy
            throw new NotImplementedException();
        }

        /**
         * 
         * @param oldManageId
         */
        public void deleteManager(int oldManageId)
        {
            // TODO - implement Forum.deleteManager
            throw new NotImplementedException();
        }

        /**
         * 
         * @param managerId
         */
        public void findManager(int managerId)
        {
            // TODO - implement Forum.findManager
            throw new NotImplementedException();
        }

        public void getUsersList()
        {
            // TODO - implement Forum.getUsersList
            throw new NotImplementedException();
        }

        /**
         * 
         * @param userName
         */
        public void getFriendsGroupsByUser(int userName)
        {
            // TODO - implement Forum.getFriendsGroupsByUser
            throw new NotImplementedException();
        }

        /**
         * 
         * @param friendGroupId
         */
        public void findFriendGroup(int friendGroupId)
        {
            // TODO - implement Forum.findFriendGroup
            throw new NotImplementedException();
        }

        /**
         * 
         * @param content
         */
        public void searchMessage(int content)
        {
            // TODO - implement Forum.searchMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param messageList
         */
        public void addToSearchResult(int messageList)
        {
            // TODO - implement Forum.addToSearchResult
            throw new NotImplementedException();
        }

        /**
         * 
         * @param subForumId
         * @param discussionId
         * @param content
         */
        public void addResponseMessage(int subForumId, int discussionId, int content)
        {
            // TODO - implement Forum.addResponseMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param SubForumId
         * @param subject
         * @param messageId
         */
        public void retriveMessage(int SubForumId, int subject, int messageId)
        {
            // TODO - implement Forum.retriveMessage
            throw new NotImplementedException();
        }

    }
}