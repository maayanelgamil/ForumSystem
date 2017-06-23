using ForumSystemProject.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ForumSystemProject.myModel
{
    public class Model : IModel
    {
        IController _controller;

        public Model(IController controller)
        {
            _controller = controller;
        }

        public void serialize()
        {
            try
            {
                Stream TestFileStream = File.Create("forumSystem.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(TestFileStream, _controller);
                TestFileStream.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool deserialize()
        {
            if (File.Exists("forumSystem.txt"))
            {
                try
                {
                    Stream fileStream = File.OpenRead("forumSystem.txt");
                    BinaryFormatter deserializer = new BinaryFormatter();
                    _controller = (ForumSystem)deserializer.Deserialize(fileStream);
                    fileStream.Close();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return false;
        }

    }
}
