
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
    public class ForumSystem : IController
    {
        private static ForumSystem _system = null;

        List<Forum> contained;
        List<GuestUser> contains;
        IView _view;
        IModel _model;


        private ForumSystem()
        { }

        public static ForumSystem getInstance()
        {
            if (_system == null)
            {
                _system = new ForumSystem();
            }
            return _system;
        }

        bool isUserExists(string userName)
        {
             _model.executeNonQuery("select * from Users where userName ='" + userName + "'");
            return true;
        }

        /**
         * 
         * @param ForumId
         */
        public void findForum(int ForumId)
        {
            // TODO - implement ForumSystem.findForum
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param subForumId
         * @param subject
         * @param UserId
         */
        public void newDisscussion(int ForumId, int subForumId, int subject, int UserId)
        {
            // TODO - implement ForumSystem.newDisscussion
            throw new NotImplementedException();
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
            string command = "Insert Into Users values('" + UserName + "', '" + Password + "', '" + firstName + "', '" + lastName + "','"+ email +"',"+ -1 +")";
            return _model.executeNonQuery(command);
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

        /// <summary>
        /// Implements an execution of a non query on the database
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <returns>The requested dataTable if exists otherwise null</returns>
        public DataTable executeQuery(string query)
        {
            string connectionString = ForumSystemProject.Properties.Settings.Default.DBConnectionString;
            OleDbConnection connection = new OleDbConnection(connectionString);
            DataTable dt = null;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter tableAdapter = new OleDbDataAdapter(command);
                dt = new DataTable();
                tableAdapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        /// <summary>
        /// Implements an execution of a query on the database
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns>True if succeeded otherwise false</returns>
        public bool executeNonQuery(string _command)
        {
            string connectionString = ForumSystemProject.Properties.Settings.Default.DBConnectionString;
            OleDbConnection connection = new OleDbConnection(connectionString);
            int numOfAffected = 0;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(_command);
                command.Connection = connection;
                numOfAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            if (numOfAffected != 0)
                return true;
            else
                return false;
        }

        public DataTable getFirstNameData(string mail)
        {
            throw new NotImplementedException();
        }

        public DataTable connect(string name, string password)
        {
            string query = "select * from Users where mail = '" + name + "'" + " and password = '" + password + "'";
            return _model.executeQuery(query);
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