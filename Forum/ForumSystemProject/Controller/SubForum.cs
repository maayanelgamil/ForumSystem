
using System;
using System.Collections.Generic;
namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class SubForum
    {

        Forum master;
        List<SubForumManager> managedBy;
        List<Disscusion> composed;
        private string subject;
        public int subForumId;

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public SubForum(string _subject, int id, Forum _master)
        {
            Subject = _subject;
            subForumId = id;
            master = _master;
            composed = new List<Disscusion>();
        }

        /**
         * 
         * @param subject
         */
        public void findDiscussion(int subject)
        {
            // TODO - implement SubForum.findDiscussion
            throw new NotImplementedException();
        }

        public List<Disscusion> getDiscussions()
        {
            return composed;
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

        public bool createNewDiscussion(string subject, Message opening)
        {
            Disscusion discussion = new Disscusion(this, subject, opening);
            var subjectFound = composed.Find((d) => d.Subject == subject);
            if (subjectFound == null)
            {
                composed.Add(discussion);
                return true;
            }
            else return false;
        }
    }
}