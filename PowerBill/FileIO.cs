using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBill
{
    public class FileIO
    {

        public static string filePath()
        {
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);
            path = path + @"\Customers.txt";

            return path;
        }

        public static string[] getTxtLines()
        {

            string path = filePath();

            if (!File.Exists(path))
            {
                var custFile = File.Create(path);
                custFile.Close();
                //System.IO.FileNotFoundException
            }

            return File.ReadAllLines(path);

        }

        public static void saveListBox(System.Windows.Forms.ListBox L)
        {
            string path = filePath();
            string[] contents = L.Items.OfType<string>().ToArray();

            File.WriteAllLines(path, contents);

        }
    }
}
