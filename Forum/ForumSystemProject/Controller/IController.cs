
using ForumSystemProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystemProject.Controller
{
    public interface IController
    {
        DataTable getFirstNameData(string mail);
        DataTable connect(string mail, string password);
        bool createNewUser(string mail, string password, string firstName, string lastName, string birthDate, string city, string phone);
        bool sendConfirmationMail(string mail, string firstName);
        DataTable getAreas();
        DataTable getAdvertisments(string type, string id);
        DataTable getPartnershipsByCity(string type, string city);
        DataTable getCitiesPartnerShips(string type);
        DataTable getInterestAreas();
        void setView(IView _view);
        void setModel(IModel _model);
        bool createNewAppartmentPreference(string mail, string profileType, string smoke, string pets, string sqft, string hobbies);
    }
}

