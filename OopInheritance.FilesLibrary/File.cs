using System;

namespace OopInheritance.FilesLibrary
{
    public abstract class File
    {
        protected File(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string Extension { get; }

        public abstract void Open();
    }
}