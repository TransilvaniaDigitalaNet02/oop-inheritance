using OopInheritance.FilesLibrary;
using System;

namespace OopInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PdfFile pdfFile = new PdfFile("TestNonEditable", false);
            pdfFile.Open();
            pdfFile.AttemptEdit();

            ExcelFile excelFile = new ExcelFile("TestExcel2023", "Excel2023");
            excelFile.Open();
            excelFile.PerformCalculation("a = b + c");

            Console.WriteLine("---------------");

            File[] filesArray = new File[] { pdfFile, excelFile };
            foreach(File file in filesArray)
            {
                file.Open();
            }

            Console.WriteLine("---------------");

            OpenFile(pdfFile);
            OpenFile(excelFile);
        }

        private static void OpenFile(File file)
        {
            if (file is null)
            {
                Console.WriteLine("Cannot open a null file");
                return;
            }

            file.Open();
        }
    }
}