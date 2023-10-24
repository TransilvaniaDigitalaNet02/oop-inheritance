using System;

namespace OopInheritance.FilesLibrary
{
    public class ExcelFile : File
    {
        public ExcelFile(string name, string excelVersion)
            : base(name, "xslx")
        {
            ExcelVersion = excelVersion;
        }

        public string ExcelVersion
        {
            get;
        }

        public void PerformCalculation(string formula)
        {
            Console.WriteLine($"Calculating formula '{formula}' on file '{this.Name}.{this.Extension}' open in {this.ExcelVersion}");
        }
    }
}
