using System.IO;

namespace OpenClosedPrinciple
{
    public class FileManager
    {
        public void SaveToFile(JurnalAfter j, string fileName, bool overwride = false)
        {
            if (overwride || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, j.ToString());
            }
        }


    }
}
