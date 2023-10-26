using System;

namespace OopInheritance.FilesLibrary
{
    public class PdfFile : File
    {
        public PdfFile(string name, bool isEditable) 
            : base(name)
        {
            IsEditable = isEditable;
        }

        public bool IsEditable
        {
            get;
        }

        public override string Extension
        {
            get
            {
                return "pdf";
            }
        }

        public override void Open()
        {
            Console.WriteLine($"Opening PDF file {Name}.{Extension}");
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
