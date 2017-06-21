
using System;
using System.Collections.Generic;
namespace ForumSystemProject.Controller
{
    public class Message
    {

        Disscusion partOf;
        List<Message> response;
        UserAccount postedBy;
        List<Message> repliesTo;
        private DateTime PublishedDate;
        private string Subject;
        private string Content;

        /**
         * 
         * @param User
         */
        public void createOpeningMessage(int User)
        {
            // TODO - implement Message.createOpeningMessage
            throw new NotImplementedException();
        }

        /**
         * 
         * @param d
         */
        public void associateWithDisscusion(int d)
        {
            // TODO - implement Message.associateWithDisscusion
            throw new NotImplementedException();
        }

        /**
         * 
         * @param message
         */
        public void associateWithMessage(int message)
        {
            // TODO - implement Message.associateWithMessage
            throw new NotImplementedException();
        }

        public void operation()
        {
            // TODO - implement Message.operation
            throw new NotImplementedException();
        }

    }
}