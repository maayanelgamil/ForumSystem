
using System.Collections.Generic;
using System;
namespace ForumSystemProject.Controller
{
    [Serializable()]
    public class SubForumManager
    {

        SubForum subManages;
        List<Complaint> reffered;
        UserAccount relatesTo;
        private double Seniority;
        private double Suspended;
    }
}