using System;
using System.Collections.Generic;

namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class Disscusion
    {

        SubForum parentSf;
        Message opening;
        private string subject;

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

        public Disscusion(SubForum sf, string subject, Message _opening)
        {
            parentSf = sf;
            this.subject = subject;
            opening = _opening;
        }

        /**
         * 
         * @param subject
         */
        public void createDisscusion(int subject)
        {
            // TODO - implement Disscusion.createDisscusion
            throw new NotImplementedException();
        }

        /**
         * 
         * @param sf
         */
        public void associateToSubForum(int sf)
        {
            // TODO - implement Disscusion.associateToSubForum
            throw new NotImplementedException();
        }

        /**
         * 
         * @param content
         */
        public void getRelevantMessages(int content)
        {
            // TODO - implement Disscusion.getRelevantMessages
            throw new NotImplementedException();
        }

        /**
         * 
         * @param message
         */
        public void addToSearchResult(int message)
        {
            // TODO - implement Disscusion.addToSearchResult
            throw new NotImplementedException();
        }

        /**
         * 
         * @param message
         */
        public void associateWithMessage(int message)
        {
            // TODO - implement Disscusion.associateWithMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param messageId
         */
        public void retriveMessage(int messageId)
        {
            // TODO - implement Disscusion.retriveMessage
            throw new NotImplementedException();
        }

    }
}