using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexyboxTestTask
{
    public class WriteToDiskService
    {
        public void Write(IEnumerable<Vehicle> instances)
        {
            if (instances != null)
            {
                var list = instances.Select(x => x.GetType().ToString());
                string mydocpath =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\Types.txt"))
                {
                    foreach (string item in list)
                        outputFile.WriteLine(item);
                }
            }
        }
    }
}
