using ForumSystemProject.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystemProject.myModel
{
    public class Model : IModel
    {
        IController _controller;

        public Model(IController controller)
        {
            _controller = controller;
        }
        public bool executeNonQuery(string command)
        {
            throw new NotImplementedException();
        }

        public DataTable executeQuery(string query)
        {
            throw new NotImplementedException();
        }
    }
}
