
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
        DataTable getFirstNameData(string mail);
        UserAccount connect(string userName, string password);
        bool newUserAccount(int ForumId, int UserName, int Password, string firstName, string lastName, string email);
        DataTable getAreas();
        DataTable getAdvertisments(string type, string id);
        DataTable getPartnershipsByCity(string type, string city);
        DataTable getCitiesPartnerShips(string type);
        IEnumerable getForums();
        DataTable getInterestAreas();
        void setView(IView _view);
        bool createNewAppartmentPreference(string mail, string profileType, string smoke, string pets, string sqft, string hobbies);
    }
}

