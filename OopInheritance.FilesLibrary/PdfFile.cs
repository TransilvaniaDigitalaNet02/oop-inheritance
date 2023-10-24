using System;

namespace OopInheritance.FilesLibrary
{
    public class PdfFile : File
    {
        public PdfFile(string name, bool isEditable) 
            : base(name, "pdf")
        {
            IsEditable = isEditable;
        }

        public bool IsEditable
        {
            get;
        }

        public void AttemptEdit()
        {
            if (IsEditable)
            {
                Console.WriteLine($"Editing file '{Name}.{Extension}'");
            }
            else
            {
                Console.WriteLine($"File '{Name}.{Extension}' doesn't support editing");
            }
        }
    }
}
