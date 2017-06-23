
using ForumSystemProject.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ForumSystemProject.Controller
{
    public interface IController
    {
        bool isUserExists(string userName);
        UserAccount connect(string userName, string password);
        void newUserAccount(Forum forum, string UserName, string Password, string firstName, string lastName, string email);
        List<Forum> getForums();
        void setView(IView _view);
        bool createNewAppartmentPreference(string mail, string profileType, string smoke, string pets, string sqft, string hobbies);
    }
}

