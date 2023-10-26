using System;

namespace OopInheritance.FilesLibrary
{
    public class ExcelFile : File
    {
        public ExcelFile(string name, string excelVersion)
            : base(name)
        {
            ExcelVersion = excelVersion;
        }

        public string ExcelVersion
        {
            get;
        }

        public override string Extension
        {
            get
            {
                return "xslx";
            }
        }

        public override void Open()
        {
            Console.WriteLine($"Opening Excel file {Name}.{Extension}");
        }

        public void PerformCalculation(string formula)
        {
            Console.WriteLine($"Calculating formula '{formula}' on file '{this.Name}.{this.Extension}' open in {this.ExcelVersion}");
        }
    }
}
