using OopInheritance.AbstractMembers;
using OopInheritance.FilesLibrary;
using System;

namespace OopInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File pdfFile = new PdfFile("TestNonEditable", false);
            pdfFile.Open();

            File excelFile = new ExcelFile("TestExcel2023", "Excel2023");
            excelFile.Open();
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

        private static void PrintArea(Shape shape)
        {
            /*
            Class obiect = new Class();
            obiect.Method()
                1) static dispatch (default)
                2) dynamic dispatch (abstract/virtual - pe membrii!)
            */

            Console.WriteLine(shape.CalculateArea());
        }

        
    }
}