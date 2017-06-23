
using System;
using System.Collections.Generic;
using System.Data;
using ForumSystemProject.Controller;
using System.Windows;
using System.Data.OleDb;
using ForumSystemProject.myModel;
using ForumSystemProject.View;

namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class ForumSystem : IController
    {
        private static ForumSystem _system = null;

        Dictionary<int, Forum> forumDict;
        List<GuestUser> contains;
        IView _view;
        IModel _model;


        private ForumSystem()
        {
            forumDict = new Dictionary<int, Forum>();
        }

        public static ForumSystem getInstance()
        {
            if (_system == null)
            {
                _system = new ForumSystem();
            }
            return _system;
        }

        public bool isUserExists(string userName)
        {
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         */
        public Forum findForum(int ForumId)
        {
            if (!forumDict.ContainsKey(ForumId))
                return null;
            return forumDict[ForumId];
        }

        /**
         * 
         * @param ForumId
         * @param subForumId
         * @param subject
         * @param UserId
         */
        public bool newDisscussion(int ForumId, int subForumId, int subject, int UserId)
        {
            Forum f = findForum(ForumId);
            if (f == null)
                return false;
            
            SubForum sf = f.findSubForum(subForumId);
            sf.createNewDiscussion(subject);
        }

        /**
         * 
         * @param Forumid
         * @param SubForumId
         * @param subject
         * @param content
         * @param UserName
         */
        public void newOpeningMessage(int Forumid, int SubForumId, int subject, int content, int UserName)
        {
            // TODO - implement ForumSystem.newOpeningMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param guestId
         */
        public void findUser(int userId) //*********************//
        {
            // TODO - implement ForumSystem.findGuest
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param ChoosenRole
         */
        public void getManagerList(int ForumId, int ChosenRole)
        {
            // TODO - implement ForumSystem.getManagerList
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param UserName
         * @param Password
         * @param GuestId
         */
        public bool newUserAccount(int ForumId, int UserName, int Password, string firstName, string lastName, string email)
        {
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param oldManagerId
         * @param newManagerName
         */
        public void replaceManager(int ForumId, int oldManagerId, int newManagerName)
        {
            // TODO - implement ForumSystem.replaceManager
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         */
        public void retriveUsersList(int ForumId)
        {
            // TODO - implement ForumSystem.retriveUsersList
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param UserNames
         */
        public void newFriendsGroup(int ForumId, int UserNames)
        {
            // TODO - implement ForumSystem.newFriendsGroup
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param freindsGroupId
         * @param UserName
         * @param title
         * @param data
         */
        public void newGroupMessage(int ForumId, int friendsGroupId, int UserName, int title, int data)
        {
            // TODO - implement ForumSystem.newGroupMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param UserName
         */
        public void retriveFriendsGroupsList(int ForumId, int UserName)
        {
            // TODO - implement ForumSystem.retriveFriendsGroupsList
            throw new NotImplementedException();
        }

        /**
         * 
         * @param forumId
         * @param content
         */
        public void searchMessage(int forumId, int content)
        {
            // TODO - implement ForumSystem.searchMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param subForumId
         * @param discussionId
         * @param content
         */
        public void addResponseMessage(int ForumId, int subForumId, int discussionId, int content)
        {
            // TODO - implement ForumSystem.addResponseMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumIdm
         * @param SubForumId
         * @param subject
         * @param messageId
         */
        public void retriveMessage(int ForumIdm, int SubForumId, int subject, int messageId)
        {
            // TODO - implement ForumSystem.retriveMessage
            throw new NotImplementedException();
        }

        public DataTable getFirstNameData(string name)
        {
            throw new NotImplementedException();
        }

        public DataTable connect(string name, string password)
        {
            throw new NotImplementedException();
        }

        public bool createNewUser(string mail, string password, string firstName, string lastName, string birthDate, string city, string phone)
        {
            throw new NotImplementedException();
        }

        public DataTable getAreas()
        {
            throw new NotImplementedException();
        }

        public DataTable getAdvertisments(string type, string id)
        {
            throw new NotImplementedException();
        }

        public DataTable getPartnershipsByCity(string type, string city)
        {
            throw new NotImplementedException();
        }

        public DataTable getCitiesPartnerShips(string type)
        {
            throw new NotImplementedException();
        }

        public DataTable getInterestAreas()
        {
            throw new NotImplementedException();
        }

        public void setView(IView view)
        {
            _view = view;
        }

        public void setModel(IModel model)
        {
            _model = model;
        }

        public bool createNewAppartmentPreference(string mail, string profileType, string smoke, string pets, string sqft, string hobbies)
        {
            throw new NotImplementedException();
        }
    }
}