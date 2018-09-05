using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.FileAccess
{
    public class FileOpener
    {
        public void OpenFile(string path)
        {
            try
            {
                TryOpenFile(path);
            } catch (FileNotFoundException ex)
            {
                throw new FileOpenerFailedException(ex);
            }
        }

        private void TryOpenFile(string path)
        {
            StreamReader reader = new StreamReader(path);
        }
    }
}
