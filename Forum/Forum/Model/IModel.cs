using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystemProject.Model
{
    public interface IModel
    {
        DataTable executeQuery(string query);
        bool executeNonQuery(string command);
        bool sendConfirmationMail(string mail, string firstName);
    }
}
