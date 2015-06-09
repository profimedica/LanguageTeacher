using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageTeacher
{
    class Business
    {
        public DataSet1 DataSet = DataAccess.DataSet;
        public void Load()
        {
            DataAccess.ReadFromFile("DE.txt");
        }

        internal void Save(string content)
        {
            DataAccess.WriteToFile("DE.txt", content);
        }
    }
}
