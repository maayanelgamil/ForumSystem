
using System;
using System.Collections.Generic;
using System.Data;
using ForumSystemProject.Controller;
using System.Windows;
using System.Data.OleDb;
using ForumSystemProject.View;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Linq;

namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class ForumSystem : IController
    {
        private static ForumSystem _system = null;

        Dictionary<int, Forum> forumDict = new Dictionary<int, Forum>();
        Dictionary<string, UserAccount> _users = new Dictionary<string, UserAccount>();
        [NonSerialized()]
        IView _view;

        private ForumSystem()
        {
            Forum f1 = new Forum("soccer", 1);
            Forum f2 = new Forum("Barbies", 1);
            Forum f3 = new Forum("Dancing", 1);
            Forum f4 = new Forum("Food", 1);
            UserAccount u1 = new UserAccount("kulik", "1234", f1);
            UserAccount u2 = new UserAccount("maayan", "1234", f2);
            UserAccount u3 = new UserAccount("keren", "1234", f3);
            UserAccount u4 = new UserAccount("ben", "1234", f4);

            forumDict.Add(1, f1);
            forumDict.Add(2, f2);
            forumDict.Add(3, f3);
            forumDict.Add(4, f4);
            _users.Add(u1.UserName, u1);
            _users.Add(u2.UserName, u2);
            _users.Add(u3.UserName, u3);
            _users.Add(u4.UserName, u4);

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
            return _users.ContainsKey(userName);
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
            return true;
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


        public bool createNewAppartmentPreference(string mail, string profileType, string smoke, string pets, string sqft, string hobbies)
        {
            throw new NotImplementedException();
        }

        public static IController deserialize()
        {
            if (File.Exists("forumSystem.txt"))
            {
                try
                {
                    Stream fileStream = File.OpenRead("forumSystem.txt");
                    BinaryFormatter deserializer = new BinaryFormatter();
                    IController _controller = (ForumSystem)deserializer.Deserialize(fileStream);
                    fileStream.Close();
                    return _controller;
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }
            return null;
        }

        UserAccount IController.connect(string userName, string password)
        {
            if (!_users.ContainsKey(userName))
                return null;
            else
            {
                UserAccount u = _users[userName];
                if (u.Password.Equals(password))
                    return u;
            }
            return null;
        }

        public List<Forum> getForums()
        {
            List<Forum> items = new List<Forum>();
            items.AddRange(forumDict.Values);
            return items;
        }
    }
}