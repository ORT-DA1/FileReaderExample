using System;
using System.IO;
using System.Runtime.Serialization;

namespace FileReader.FileAccess
{
    public class FileOpenerFailedException : Exception
    {
        private const string MESSAGE = "ERROR AL ABRIR EL ARCHIVO";
        public FileOpenerFailedException() : base(MESSAGE)
        {
        }
        
        public FileOpenerFailedException(Exception innerException) : base(MESSAGE, innerException)
        {
        }

    }
}