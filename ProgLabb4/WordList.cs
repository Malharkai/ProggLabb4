using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLabb4
{
    public class WordList
    {
        public static DirectoryInfo d = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory + @"\Lists");
        public string Name { get; }
        public string[] Languages { get; }

        public WordList(string name, params string[] languages)
        {
            name = Name;
            languages = Languages;
        }

        public static string[] GetLists()
        {
            
            FileInfo[] Files = d.GetFiles("*.dat"); 
            List<string> list = new List<string>();

            foreach (FileInfo file in Files)
            {              
                list.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
            return list.ToArray();
        }

        public static WordList LoadList(string name)
        {
            name += ".dat";
            FileInfo[] List = d.GetFiles(name);
            List.

        }
    }
}
