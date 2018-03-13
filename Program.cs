using System;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Program program = new Program();

            String path = "C:\\Users\\rosty\\Downloads\\Telegram Desktop\\asd.xlsx";
            ExcelParser parser = new ExcelParser(path);

            String accessPath = "C:\\Users\\rosty\\Downloads\\Telegram Desktop\\db.accdb";
            Access access = new Access(accessPath);

            //access.deleteTables();
            access.insertTeachers(parser.getTeachers());
            access.insertWeeks(parser.getWeeks());
            access.insertSchedule(parser.getYear(), parser.getSpeciality(), parser.getEntities());
        }
    }
}
