using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LanguageTeacher
{
    class DataAccess
    {
        private static DataSet1 dataSet = null;
        public static DataSet1 DataSet {
            get
            {
                if (dataSet == null)
                {
                    dataSet = new DataSet1();
                }
                return dataSet;
            } 
            set { } 
        }

        public static void ReadFromFile(string fileName)
        {
            int i = 1;
            foreach (string line in File.ReadAllLines(fileName, Encoding.UTF8))
            {
                string[] elements = line.Split(new char[] { ',' });
                if (elements.Length > 1)
                {
                    DataSet1.WordsRow row = DataSet.Words.NewWordsRow();
                    row.Foreign = elements[0].Trim();
                    row.Native = elements[1].Trim();
                    row.ID = i++;
                    row.Difficulty = elements.Length > 2 ? decimal.Parse(elements[2].ToString()) : 0;
                    row.Class = elements.Length > 3 ? elements[3].Trim() : string.Empty;
                    row.Guessed = false;
                    DataSet.Words.AddWordsRow(row);
                }
            }
        }


        internal static void WriteToFile(string path, string content)
        {
            File.WriteAllText(path,content, Encoding.UTF8);
        }
    }
}
