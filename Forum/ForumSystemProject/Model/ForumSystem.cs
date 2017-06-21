
using System;
using System.Collections.Generic;
using System.Data;
using ForumSystemProject.Controller;
using System.Windows;
using System.Data.OleDb;

namespace ForumSystemProject.Model
{
    public class ForumSystem : IModel
    {
        private static ForumSystem _system = null;

        List<Forum> contained;
        List<GuestUser> contains;
        IController _controller;


        private ForumSystem(IController controller)
        {
            _controller = controller;
        }

        public static ForumSystem getInstance(IController controller)
        {
            if (_system == null)
            {
                _system = new ForumSystem(controller);
            }
            return _system;
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
        public void findGuest(int guestId)
        {
            // TODO - implement ForumSystem.findGuest
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param ChoosenRole
         */
        public void getManagerList(int ForumId, int ChoosenRole)
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
        public void newUserAccount(int ForumId, int UserName, int Password, int GuestId)
        {
            // TODO - implement ForumSystem.newUserAccount
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param UserName
         * @param content
         * @param choosenRole
         * @param SubForumMngrId
         */
        public void addComplaint(int ForumId, int UserName, int content, int choosenRole, int SubForumMngrId)
        {
            // TODO - implement ForumSystem.addComplaint
            throw new NotImplementedException();
        }

        /**
         * 
         * @param ForumId
         * @param UserName
         */
        public void checkManagerPolicy(int ForumId, int UserName)
        {
            // TODO - implement ForumSystem.checkManagerPolicy
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
        public void newGroupMessage(int ForumId, int freindsGroupId, int UserName, int title, int data)
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

    }
}