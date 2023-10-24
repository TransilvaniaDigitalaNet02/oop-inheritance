using System;

namespace OopInheritance.FilesLibrary
{
    public class File
    {
        protected File(string name, string extension)
        {
            Name = name;
            Extension = extension;
        }

        public string Name
        {
            get;
        }

        public string Extension
        {
            get;
        }

        public void Open()
        {
            Console.WriteLine($"Opening file '{Name}.{Extension}'");
        }
    }
}