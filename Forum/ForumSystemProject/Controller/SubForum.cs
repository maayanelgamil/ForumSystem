
using System;
using System.Collections.Generic;
namespace ForumSystemProject.Controller
{
    public class SubForum
    {

        Forum master;
        List<SubForumManager> managedBy;
        List<Disscusion> composed;
        private string Subject;

        /**
         * 
         * @param subject
         */
        public void findDiscussion(int subject)
        {
            // TODO - implement SubForum.findDiscussion
            throw new NotImplementedException();
        }

        /**
         * 
         * @param content
         */
        public void getRelevantMessages(int content)
        {
            // TODO - implement SubForum.getRelevantMessages
            throw new NotImplementedException();
        }

        /**
         * 
         * @param messageList
         */
        public void addToSearchResult(int messageList)
        {
            // TODO - implement SubForum.addToSearchResult
            throw new NotImplementedException();
        }

        /**
         * 
         * @param discussionId
         * @param content
         */
        public void addResponseMessage(int discussionId, int content)
        {
            // TODO - implement SubForum.addResponseMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param subject
         * @param messageId
         */
        public void retriveMessage(int subject, int messageId)
        {
            // TODO - implement SubForum.retriveMessage
            throw new NotImplementedException();
        }
    }
}